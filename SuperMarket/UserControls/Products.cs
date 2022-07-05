using SuperMarket.Classes;
using SuperMarket.Classes.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
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

        private ContextMenu contextMenu = new ContextMenu();
        private DataGridViewCell ContextMenuSelectedCell;

        private void Products_Load(object sender, EventArgs e)
        {
            SetColors(Properties.Settings.Default.AppColor);
            LoadCategories();
            LoadDataGrid(Classes.DataAccess.Products.LoadProducts(true));

            contextMenu = Methods.SetupContextMenuCopy(contextMenu, MenuItemCopyOption_Click);
        }

        private void MenuItemCopyOption_Click(Object sender, EventArgs e)
        {
            string CellText = productsDataGridView.Rows[ContextMenuSelectedCell.RowIndex].
                Cells[ContextMenuSelectedCell.ColumnIndex].Value.ToString();
            Clipboard.SetText(CellText);
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
            productsDataGridView.ColumnHeadersDefaultCellStyle.BackColor = appColor;
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
            if (txt_productname.Text.Trim() != "" && txt_productprice.Text.Trim() != "" && txt_productquantity.Text.Trim() != "" && txt_productBarCode.Text.Trim() != "")
            {
                if (!txt_productid.Enabled)
                {
                    if (txt_categoriename.SelectedIndex != -1)
                    {
                        if (MessageBox.Show($"هل تريد ان تعدل {txt_productname.Text} ", "انتظر",
                            MessageBoxButtons.YesNo,
                            MessageBoxIcon.Information) == DialogResult.Yes)
                        {
                            long categoryId = long.Parse(txt_categoriename.SelectedValue.ToString());
                            string categoryName = Classes.DataAccess.Categories.GetCategoryParameter
                                    ("Id", "" + categoryId).FirstOrDefault().Name;
                            ProductModel product = new ProductModel
                            {
                                Id = long.Parse(txt_productid.Text),
                                Name = txt_productname.Text,
                                Quantity = double.Parse(txt_productquantity.Text),
                                Price = decimal.Parse(txt_productprice.Text),
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

                            long categoryId = long.Parse(txt_categoriename.SelectedValue.ToString());
                            string categoryName = Classes.DataAccess.Categories.GetCategoryParameter
                                ("Id", "" + categoryId).FirstOrDefault().Name;
                            ProductModel product = new ProductModel
                            {
                                BarCode = txt_productBarCode.Text,
                                Name = txt_productname.Text,
                                Price = decimal.Parse(txt_productprice.Text),
                                Description = txt_description.Text,
                                Quantity = double.Parse(txt_productquantity.Text),
                                CategoryID = categoryId,
                                CategoryName = categoryName
                            };
                            Classes.DataAccess.Products.SaveProduct(product);
                            LoadDataGrid(Classes.DataAccess.Products.LoadProducts(true));

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
            productsDataGridView.DataSource = null;
            productsDataGridView.DataSource = Products;

            productsDataGridView.Columns["Id"].HeaderText = "رقم المنتج";
            productsDataGridView.Columns["BarCode"].HeaderText = "باركود";
            productsDataGridView.Columns["ProductName_"].HeaderText = "اسم المنتج";
            productsDataGridView.Columns["Price"].HeaderText = "سعر المنتج";
            productsDataGridView.Columns["Description"].HeaderText = "وصف المتج";
            productsDataGridView.Columns["Quantity"].HeaderText = "كميه المنتج";
            productsDataGridView.Columns["CategoryID"].HeaderText = "رقم الصنف";
            productsDataGridView.Columns["CategoryName"].HeaderText = "اسم الصنف";
            productsDataGridView.Columns["CreationDate"].HeaderText = "يوم اضافه المنتج";
            productsDataGridView.Columns["CreationDate"].DefaultCellStyle.Format = "yyyy/MM/dd tt HH:mm:ss";

            productsDataGridView.AutoResizeColumns();
            productsDataGridView.Columns["CreationDate"].Width += 5;
        }

        private void txt_products_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;

                if (txt_productBarCode.Text.Trim() != "")
                {
                    Logger.Log($"user is searching for product by barcode: {txt_productBarCode.Text}",
                    System.Reflection.MethodInfo.GetCurrentMethod().Name, this.Name, Logger.INFO);

                    List<ProductModel> productSearch = Classes.DataAccess.Products.GetProductParameter("BarCode", txt_productBarCode.Text);
                    LoadDataGrid(productSearch);
                }
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
            if (txt_productname.Text.Trim() == "")
                LoadDataGrid(Classes.DataAccess.Products.LoadProducts(true));

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
            if (txt_productid.Text.Trim() == "")
                LoadDataGrid(Classes.DataAccess.Products.LoadProducts(true));

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
            if (productsDataGridView != null)
            {
                if (productsDataGridView.CurrentCell != null)
                {
                    int RowIndex = productsDataGridView.CurrentCell.RowIndex;

                    long ProductID = long.Parse(productsDataGridView.Rows[RowIndex].Cells["Id"].Value.ToString()),
                        CategoryID = long.Parse(productsDataGridView.Rows[RowIndex].Cells["CategoryId"].Value.ToString());

                    string ProductName = productsDataGridView.Rows[RowIndex].Cells["ProductName_"].Value.ToString(),
                        ProductPrice = productsDataGridView.Rows[RowIndex].Cells["Price"].Value.ToString(),
                        ProductQuantity = productsDataGridView.Rows[RowIndex].Cells["Quantity"].Value.ToString(),
                        ProductDescription = productsDataGridView.Rows[RowIndex].Cells["Description"].Value.ToString(),
                        ProductBarcode = productsDataGridView.Rows[RowIndex].Cells["BarCode"].Value.ToString(),
                        CategoryName = productsDataGridView.Rows[RowIndex].Cells["CategoryName"].Value.ToString();

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
            if (productsDataGridView != null)
            {
                if (productsDataGridView.CurrentCell != null)
                {
                    int rowindex = productsDataGridView.CurrentCell.RowIndex;
                    long ProductID = long.Parse(productsDataGridView.Rows[rowindex].Cells["Id"].Value.ToString());
                    string ProductName = productsDataGridView.Rows[rowindex].Cells["ProductName_"].Value.ToString();

                    Logger.Log($"user is trying to remove product: {ProductName}",
                        System.Reflection.MethodInfo.GetCurrentMethod().Name, this.Name, Logger.INFO);

                    if (MessageBox.Show($"هل تريد ان تمسح {ProductName}", "انتظر",
                                MessageBoxButtons.YesNo,
                                MessageBoxIcon.Information) == DialogResult.Yes)
                    {
                        Classes.DataAccess.Products.RemoveProduct(ProductID);
                        LoadDataGrid(Classes.DataAccess.Products.LoadProducts(true));

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
            LoadDataGrid(Classes.DataAccess.Products.LoadProducts(true));
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

        private void pcb_searchBarCode_Click(object sender, EventArgs e)
        {
            if (txt_productBarCode.Text.Trim() == "")
                LoadDataGrid(Classes.DataAccess.Products.LoadProducts(true));

            else
            {
                Logger.Log($"user is searching for product by barcode: {txt_productBarCode.Text}",
                    System.Reflection.MethodInfo.GetCurrentMethod().Name, this.Name, Logger.INFO);

                List<ProductModel> productSearch = Classes.DataAccess.Products.GetProductParameter("BarCode", txt_productBarCode.Text);
                LoadDataGrid(productSearch);
            }
        }

        private void db_productDataGridView_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            productsDataGridView.DataSource = new Methods().DataGridToDataTable(productsDataGridView);

            productsDataGridView.Sort(productsDataGridView.Columns[e.ColumnIndex], ListSortDirection.Ascending);
        }

        private void db_productDataGridView_ColumnHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            productsDataGridView.DataSource = new Methods().DataGridToDataTable(productsDataGridView);

            productsDataGridView.Sort(productsDataGridView.Columns[e.ColumnIndex], ListSortDirection.Descending);
        }

        private void productsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.productsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.superMarketDataSet);

        }

        private void productsBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.productsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.superMarketDataSet);

        }

        private void productsDataGridView_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                int cellColumnIndex = productsDataGridView.CurrentCell.ColumnIndex;
                int cellRowIndex = productsDataGridView.CurrentCell.RowIndex;

                int CellX = productsDataGridView.GetCellDisplayRectangle(cellColumnIndex, cellRowIndex, false).Left;
                int CellY = productsDataGridView.GetCellDisplayRectangle(cellColumnIndex, cellRowIndex, false).Top;

                ContextMenuSelectedCell = (sender as DataGridView).Rows[cellRowIndex].Cells[cellColumnIndex];

                if (ContextMenuSelectedCell != null)
                {
                    contextMenu.Show(productsDataGridView, new Point(CellX, CellY));
                }
            }
        }

        private void btn_exportPDF_Click(object sender, EventArgs e)
        {
            Forms.ReportViewer.SelectedReport = Forms.ReportViewer.ShownReport.Products;

            using (Forms.ReportViewer reportViewer = new Forms.ReportViewer())
            {
                reportViewer.ShowDialog();
                reportViewer.Dispose();
                reportViewer.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random r = new Random();
            int categoryId, barcode, quantity;
            decimal productPirce;

            for (int i = 0; i < 100; i++)
            {
                categoryId = r.Next(9, 15);
                barcode = r.Next(10000, 999999);
                productPirce = (decimal)r.NextDouble() * 100;
                quantity = r.Next(20, 100);

                Math.Round(productPirce * 100, 2);
                ProductModel product = new ProductModel();

                product.BarCode = "" + barcode;
                product.Name = "random " + categoryId;
                product.Price = productPirce;
                product.Description = "";
                product.Quantity = quantity;
                product.CategoryID = categoryId;
                product.CategoryName = "test " + categoryId;

                Classes.DataAccess.Products.SaveProduct(product);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            LoadDataGrid(Classes.DataAccess.Products.LoadProducts(true));
        }
    }
}
