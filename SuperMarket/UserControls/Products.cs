using SuperMarket.Classes;
using SuperMarket.Classes.Models;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace SuperMarket.UserControls
{
    public partial class Products : UserControl
    {
        public Products()
        {
            InitializeComponent();
        }

        private void Products_Load(object sender, EventArgs e)
        {
            SetColors(Properties.Settings.Default.AppColor);
            LoadCategories();
            LoadDataGrid(Classes.DataAccess.Products.LoadProducts());
        }

        private void SetColors(Color appColor)
        {
            label1.ForeColor = appColor;
            label2.ForeColor = appColor;
            label3.ForeColor = appColor;
            label4.ForeColor = appColor;
            label5.ForeColor = appColor;
            label6.ForeColor = appColor;
            label11.ForeColor = appColor;
            btn_edit.BackColor = appColor;
            btn_remove.BackColor = appColor;
            btn_save.BackColor = appColor;
            db_productDataGridView.ColumnHeadersDefaultCellStyle.BackColor = appColor;
        }

        public void LoadCategories()
        {
            txt_categoriename.DataSource = null;
            txt_categoriename.DataSource = Classes.DataAccess.Categories.LoadCategories();
            txt_categoriename.ValueMember = "Id";
            txt_categoriename.DisplayMember = "Name";
            txt_categoriename.SelectedIndex = -1;
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            if (txt_productname.Text != "" && txt_productprice.Text != "" && txt_productquantity.Text != "" && txt_productBarCode.Text != "")
            {
                if (!txt_productid.Enabled)
                {
                    if (txt_categoriename.SelectedIndex != -1)
                    {
                        if (MessageBox.Show($"هل تريد ان تعدل {txt_productname.Text} ", "انتظر",
                            MessageBoxButtons.YesNo,
                            MessageBoxIcon.Information) == DialogResult.Yes)
                        {
                            int categoryId = int.Parse(txt_categoriename.SelectedValue.ToString());
                            string categoryName = Classes.DataAccess.Categories.GetCategoryParameter
                                    ("Id", "" + categoryId).FirstOrDefault().Name;
                            ProductModel product = new ProductModel
                            {
                                Id = int.Parse(txt_productid.Text),
                                Name = txt_productname.Text,
                                Quantity = txt_productquantity.Text,
                                Price = txt_productprice.Text,
                                Description = txt_description.Text,
                                BarCode = txt_productBarCode.Text,
                                CategoryID = categoryId,
                                CategoryName = categoryName
                            };
                            Classes.DataAccess.Products.UpdateProduct(product);

                            LoadDataGrid(Classes.DataAccess.Products.GetProductParameter("Id", "" + product.Id));

                            ResetTextBoxes();

                            Logger.Log($"user is editing product: {categoryName} with id: {categoryId}",
                                System.Reflection.MethodInfo.GetCurrentMethod().Name, this.Name, Logger.INFO);
                        }
                        SetEditMode(false);
                    }
                    else
                    {
                        MessageBox.Show("يجب أن تختار صنف لهذا المنتج", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
                else
                {
                    string MsgResponse = $"هل تريد ان تحفظ {txt_productname.Text} ";

                    var ProductResult = Classes.DataAccess.Products.GetProductParameter("Name", txt_productname.Text);

                    if (ProductResult.Count > 0)
                        MsgResponse += "لانه يوجد منتج بهذا الاسم";

                    if (txt_categoriename.SelectedValue != null && txt_categoriename.SelectedIndex != -1)
                    {
                        if (MessageBox.Show(MsgResponse, "انتظر",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Information) == DialogResult.Yes)
                        {

                            int categoryId = int.Parse(txt_categoriename.SelectedValue.ToString());
                            string categoryName = Classes.DataAccess.Categories.GetCategoryParameter
                                ("Id", "" + categoryId).FirstOrDefault().Name;
                            ProductModel product = new ProductModel
                            {
                                BarCode = txt_productBarCode.Text,
                                Name = txt_productname.Text,
                                Price = txt_productprice.Text,
                                Description = txt_description.Text,
                                Quantity = txt_productquantity.Text,
                                CategoryID = categoryId,
                                CategoryName = categoryName
                            };
                            Classes.DataAccess.Products.SaveProduct(product);
                            LoadDataGrid(Classes.DataAccess.Products.LoadProducts());

                            ResetTextBoxes();

                            Logger.Log($"user added product: {product.Name}",
                                System.Reflection.MethodInfo.GetCurrentMethod().Name, this.Name, Logger.INFO);
                        }
                    }
                    else
                    {
                        MessageBox.Show("يجب أن تختار صنف لهذا المنتج", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
                MessageBox.Show("برجاء ادخال بيانات المنتج من الاسم والكمية والسعر والباركود", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void ResetTextBoxes()
        {
            txt_categoriename.Text = "";
            txt_description.Text = "";
            txt_productname.Text = "";
            txt_productprice.Text = "";
            txt_productquantity.Text = "";
            txt_productid.Text = "";
            txt_productBarCode.Text = "";

            txt_categoriename.SelectedIndex = -1;
        }

        private void LoadDataGrid(List<ProductModel> Products)
        {
            db_productDataGridView.DataSource = null;
            db_productDataGridView.DataSource = Products;

            db_productDataGridView.Columns["Id"].HeaderText = "رقم المنتج";
            db_productDataGridView.Columns["BarCode"].HeaderText = "باركود";
            db_productDataGridView.Columns["Name"].HeaderText = "اسم المنتج";
            db_productDataGridView.Columns["Price"].HeaderText = "سعر المنتج";
            db_productDataGridView.Columns["Description"].HeaderText = "وصف المتج";
            db_productDataGridView.Columns["Quantity"].HeaderText = "كميه المنتج";
            db_productDataGridView.Columns["CategoryID"].HeaderText = "رقم الصنف";
            db_productDataGridView.Columns["CategoryName"].HeaderText = "اسم الصنف";
            db_productDataGridView.Columns["CreationDate"].HeaderText = "يوم اضافه المنتج";

            db_productDataGridView.AutoResizeColumns();
            db_productDataGridView.Columns["CreationDate"].Width += 5;
        }

        private void txt_products_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                btn_save.PerformClick();
            }
        }

        private void pcb_refresh_MouseEnter(object sender, EventArgs e)
        {
            pcb_refresh.BackColor = Properties.Settings.Default.AppColor;
        }

        private void pcb_refresh_MouseLeave(object sender, EventArgs e)
        {
            pcb_refresh.BackColor = Color.Transparent;
        }

        private void pcb_refresh_Click(object sender, EventArgs e)
        {
            LoadCategories();
        }

        private void pcb_searchName_Click(object sender, EventArgs e)
        {
            if (txt_productname.Text == "")
                LoadDataGrid(Classes.DataAccess.Products.LoadProducts());

            else
            {
                Logger.Log($"user is searching by name for product: {txt_productname.Text}",
                    System.Reflection.MethodInfo.GetCurrentMethod().Name, this.Name, Logger.INFO);

                List<ProductModel> productSearch = Classes.DataAccess.Products.GetProductParameter("Name", txt_productname.Text);
                LoadDataGrid(productSearch);
            }
        }

        private void pcb_searchID_Click(object sender, EventArgs e)
        {
            if (txt_productid.Text == "")
                LoadDataGrid(Classes.DataAccess.Products.LoadProducts());

            else
            {
                Logger.Log($"user is searching by id for product: {txt_productid.Text}",
                    System.Reflection.MethodInfo.GetCurrentMethod().Name, this.Name, Logger.INFO);

                List<ProductModel> productSearch = Classes.DataAccess.Products.GetProductParameter("Id", txt_productid.Text);
                LoadDataGrid(productSearch);
            }
        }

        private void txt_products_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            if (db_productDataGridView != null)
            {
                if (db_productDataGridView.CurrentCell != null)
                {
                    int RowIndex = db_productDataGridView.CurrentCell.RowIndex;

                    int ProductID = int.Parse(db_productDataGridView.Rows[RowIndex].Cells["Id"].Value.ToString()),
                        CategoryID = int.Parse(db_productDataGridView.Rows[RowIndex].Cells["CategoryId"].Value.ToString());

                    string ProductName = db_productDataGridView.Rows[RowIndex].Cells["Name"].Value.ToString(),
                        ProductPrice = db_productDataGridView.Rows[RowIndex].Cells["Price"].Value.ToString(),
                        ProductQuantity = db_productDataGridView.Rows[RowIndex].Cells["Quantity"].Value.ToString(),
                        ProductDescription = db_productDataGridView.Rows[RowIndex].Cells["Description"].Value.ToString(),
                        ProductBarcode = db_productDataGridView.Rows[RowIndex].Cells["BarCode"].Value.ToString(),
                        CategoryName = db_productDataGridView.Rows[RowIndex].Cells["CategoryName"].Value.ToString();

                    Logger.Log($"user removed product: {ProductName} with id: {ProductID}",
                        System.Reflection.MethodInfo.GetCurrentMethod().Name, this.Name, Logger.INFO);

                    txt_productid.Text = "" + ProductID;
                    txt_productname.Text = ProductName;
                    txt_productprice.Text = ProductPrice;
                    txt_productquantity.Text = ProductQuantity;
                    txt_description.Text = ProductDescription;
                    txt_productBarCode.Text = ProductBarcode;
                    txt_categoriename.Text = CategoryName;

                    SetEditMode(true);
                }
                else
                {
                    MessageBox.Show("يجب أن تختار منتج للتعديل", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void SetEditMode(bool State)
        {
            if (State)
            {
                btn_edit.BackColor = Color.Silver;
                btn_remove.BackColor = Color.Silver;
            }
            else
            {
                btn_edit.BackColor = Properties.Settings.Default.AppColor;
                btn_remove.BackColor = Properties.Settings.Default.AppColor;
            }

            txt_productid.Enabled = !State;
            btn_edit.Enabled = !State;
            btn_remove.Enabled = !State;
            pcb_searchID.Enabled = !State;
            pcb_searchName.Enabled = !State;
        }

        private void btn_remove_Click(object sender, EventArgs e)
        {
            if (db_productDataGridView != null)
            {
                if (db_productDataGridView.CurrentCell != null)
                {
                    int rowindex = db_productDataGridView.CurrentCell.RowIndex;
                    int ProductID = int.Parse(db_productDataGridView.Rows[rowindex].Cells["Id"].Value.ToString());
                    string ProductName = db_productDataGridView.Rows[rowindex].Cells["Name"].Value.ToString();

                    Logger.Log($"user is trying to remove product: {ProductName}",
                        System.Reflection.MethodInfo.GetCurrentMethod().Name, this.Name, Logger.INFO);

                    if (MessageBox.Show($"هل تريد ان تمسح {ProductName}", "انتظر",
                                MessageBoxButtons.YesNo,
                                MessageBoxIcon.Information) == DialogResult.Yes)
                    {
                        Classes.DataAccess.Products.RemoveProduct(ProductID);
                        LoadDataGrid(Classes.DataAccess.Products.LoadProducts());

                        Logger.Log($"user removed product: {ProductName} with id: {ProductID}",
                            System.Reflection.MethodInfo.GetCurrentMethod().Name, this.Name, Logger.INFO);
                    }
                    else
                        Logger.Log($"user didnt remove product: {ProductName}",
                            System.Reflection.MethodInfo.GetCurrentMethod().Name, this.Name, Logger.INFO);
                }
            }
        }

        private void pcb_search_DoubleClick(object sender, EventArgs e)
        {
            LoadDataGrid(Classes.DataAccess.Products.LoadProducts());
        }

        private void pcb_search_MouseEnter(object sender, EventArgs e)
        {
            Control FocusedObject = (Control)sender;
            FocusedObject.BackColor = Properties.Settings.Default.AppColor;
        }

        private void pcb_search_MouseLeave(object sender, EventArgs e)
        {
            Control FocusedObject = (Control)sender;
            FocusedObject.BackColor = Color.Transparent;
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }
    }
}
