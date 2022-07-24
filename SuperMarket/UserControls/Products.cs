using POSWarehouse.Classes;
using POSWarehouse.Classes.Models;
using POSWarehouse.Classes.Models.Joins;
using POSWarehouse.Forms;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace POSWarehouse.UserControls
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
            LoadJoinedDataGrid(Classes.DataAccess.Products.LoadProductsWithPrices(true));

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
            label14.ForeColor = appColor;
            btn_edit.BackColor = appColor;
            btn_remove.BackColor = appColor;
            btn_save.BackColor = appColor;
            productsDataGridView.ColumnHeadersDefaultCellStyle.BackColor = appColor;
        }

        internal void LoadCategories()
        {
            txt_categoriename.DataSource = null;
            txt_categoriename.DataSource = Classes.DataAccess.Categories.LoadCategories();
            txt_categoriename.ValueMember = "Id";
            txt_categoriename.DisplayMember = "Name";
            txt_categoriename.SelectedIndex = -1;
        }

        private async void btn_save_Click(object sender, EventArgs e)
        {
            if (txt_productname.Text.Trim() != "" && txt_productPriceSell.Text.Trim() != "" &&
                txt_productBarCode.Text.Trim() != "" && txt_productPriceWholeSale.Text.Trim() != "")
            {
                if (!txt_productid.Enabled)
                {
                    if (txt_categoriename.SelectedIndex != -1)
                    {
                        if (decimal.Parse(txt_productPriceWholeSale.Text) > decimal.Parse(txt_productPriceSell.Text))
                        {
                            new Notification().ShowAlert($"سعر الجملة اكبر أو يساوي سعر البيع برجاء تعديل السعر",
                                Notification.EnmType.Error);
                        }
                        else
                        {
                            if (MessageBox.Show($"هل تريد ان تعدل {txt_productname.Text} ", "انتظر",
                                    MessageBoxButtons.YesNo,
                                    MessageBoxIcon.Information) == DialogResult.Yes)
                            {
                                long categoryId = long.Parse(txt_categoriename.SelectedValue.ToString());
                                string categoryName = Classes.DataAccess.Categories.GetCategoryParameter
                                        ("Id", "" + categoryId).FirstOrDefault().Name;
                                double MinQuantity = 0;

                                if (txt_productquantityMin.Text != "")
                                    MinQuantity = double.Parse(txt_productquantityMin.Text);

                                ProductPriceModel productPriceModel = new ProductPriceModel
                                {
                                    PriceWholesale = decimal.Parse(txt_productPriceWholeSale.Text),
                                    PriceSell = decimal.Parse(txt_productPriceSell.Text),
                                    ProductId = long.Parse(txt_productid.Text),
                                    ProductName = txt_productname.Text,
                                    CreationDate = DateTime.Now
                                };

                                ProductModel product = new ProductModel
                                {
                                    Id = long.Parse(txt_productid.Text),
                                    Name = txt_productname.Text,
                                    Quantity = double.Parse(txt_productquantity.Text),
                                    QuantityMinimum = MinQuantity,
                                    Description = txt_description.Text,
                                    BarCode = txt_productBarCode.Text,
                                    CategoryID = categoryId,
                                    CategoryName = categoryName,
                                    PriceModificationDate = productPriceModel.CreationDate
                                };

                                await Classes.DataAccess.Products.UpdateProduct(product);

                                await Classes.DataAccess.ProductPrice.SaveProductPrice(productPriceModel);

                                LoadJoinedDataGrid(Classes.DataAccess.Products.GetProductParameterWithPricee("Id", "" + product.Id));

                                Logger.Log($"user is editing product: {categoryName} with id: {categoryId}",
                                    System.Reflection.MethodInfo.GetCurrentMethod().Name, this.Name, Logger.INFO);
                            }
                            ResetTextBoxes();

                            SetEditMode(false);
                        }
                    }
                    else
                    {
                        new Notification().ShowAlert($"يجب أن تختار صنف لهذا المنتج", Notification.EnmType.Error);
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
                        if (decimal.Parse(txt_productPriceWholeSale.Text) >= decimal.Parse(txt_productPriceSell.Text))
                        {
                            new Notification().ShowAlert($"سعر الجملة اكبر أو يساوي سعر البيع برجاء تعديل السعر",
                                Notification.EnmType.Error);
                        }
                        else
                        {
                            if (MessageBox.Show(MsgResponse, "انتظر",
                                   MessageBoxButtons.YesNo,
                                   MessageBoxIcon.Information) == DialogResult.Yes)
                            {

                                long categoryId = long.Parse(txt_categoriename.SelectedValue.ToString());
                                CategoryModel SearchedCategoryName = Classes.DataAccess.Categories.GetCategoryParameter("Id", "" + categoryId)
                                    .FirstOrDefault();
                                double MinQuantity = 0;

                                if (txt_productquantityMin.Text != "")
                                    MinQuantity = double.Parse(txt_productquantityMin.Text);

                                if (SearchedCategoryName != null)
                                {
                                    string categoryName = SearchedCategoryName.Name;

                                    ProductModel product = new ProductModel
                                    {
                                        BarCode = txt_productBarCode.Text,
                                        Name = txt_productname.Text,
                                        //PriceSell = decimal.Parse(txt_productPriceSell.Text),
                                        Description = txt_description.Text,
                                        Quantity = 0,
                                        QuantityMinimum = MinQuantity,
                                        CategoryID = categoryId,
                                        CategoryName = categoryName,
                                        CreationDate = DateTime.Now
                                        //PriceWholesale = decimal.Parse(txt_productPriceWholeSale.Text),
                                    };
                                    await Classes.DataAccess.Products.SaveProduct(product);

                                    ProductModel LastProduct = Classes.DataAccess.Products.GetLastAddedProduct();

                                    ProductPriceModel ProductPrice = new ProductPriceModel
                                    {
                                        ProductId = LastProduct.Id,
                                        ProductName = LastProduct.Name,
                                        PriceSell = decimal.Parse(txt_productPriceSell.Text),
                                        PriceWholesale = decimal.Parse(txt_productPriceWholeSale.Text),
                                        CreationDate = LastProduct.CreationDate
                                    };

                                    await Classes.DataAccess.ProductPrice.SaveProductPrice(ProductPrice);

                                    LoadJoinedDataGrid(Classes.DataAccess.Products.LoadProductsWithPrices(true));

                                    ResetTextBoxes();

                                    Logger.Log($"user added product: {product.Name}",
                                        System.Reflection.MethodInfo.GetCurrentMethod().Name, this.Name, Logger.INFO);
                                }
                                else
                                {
                                    new Notification().ShowAlert($"لا يوجد تصنيف بهذا الاسم", Notification.EnmType.Error);

                                    Logger.Log($"while adding product {txt_productname.Text} category is null with id = {categoryId}",
                                        System.Reflection.MethodInfo.GetCurrentMethod().Name, this.Name, Logger.ERROR);
                                }
                            }
                        }
                    }
                    else
                    {
                        new Notification().ShowAlert($"يجب أن تختار صنف لهذا المنتج", Notification.EnmType.Error);
                    }
                }
            }
            else
                new Notification().ShowAlert($"برجاء ادخال بيانات المنتج من الاسم والكمية والسعر والباركود", Notification.EnmType.Error);
        }

        private void ResetTextBoxes()
        {
            txt_categoriename.Text = "";
            txt_description.Text = "";
            txt_productname.Text = "";
            txt_productPriceSell.Text = "";
            txt_productPriceWholeSale.Text = "";
            txt_productquantity.Text = "";
            txt_productid.Text = "";
            txt_productBarCode.Text = "";
            txt_productquantityMin.Text = "";

            chk_generateBarCode.Checked = false;

            txt_categoriename.SelectedIndex = -1;
        }

        private void LoadJoinedDataGrid(List<Product_ProductPriceModel> Products)
        {
            productsDataGridView.DataSource = null;
            productsDataGridView.DataSource = Products;

            productsDataGridView.Columns["IdDataGridViewTextBoxColumn_"].HeaderText = "رقم المنتج";
            productsDataGridView.Columns["BarCodeDataGridViewTextBoxColumn_"].HeaderText = "باركود";
            productsDataGridView.Columns["NameDataGridViewTextBoxColumn_"].HeaderText = "اسم المنتج";
            productsDataGridView.Columns["PriceWholesaleDataGridViewTextBoxColumn_"].HeaderText = "سعر جمله المنتج";
            productsDataGridView.Columns["PriceSellDataGridViewTextBoxColumn_"].HeaderText = "سعر بيع المنتج";
            productsDataGridView.Columns["DescriptionDataGridViewTextBoxColumn_"].HeaderText = "وصف المنتج";
            productsDataGridView.Columns["QuantityDataGridViewTextBoxColumn_"].HeaderText = "كميه المنتج";
            productsDataGridView.Columns["QuantityMinimumDataGridViewTextBoxColumn_"].HeaderText = "حد ادنى للمنتج";
            productsDataGridView.Columns["CategoryIDDataGridViewTextBoxColumn_"].HeaderText = "رقم الصنف";
            productsDataGridView.Columns["CategoryNameDataGridViewTextBoxColumn_"].HeaderText = "اسم الصنف";
            productsDataGridView.Columns["CreationDateDataGridViewTextBoxColumn_"].HeaderText = "يوم اضافه المنتج";
            productsDataGridView.Columns["PriceModificationDateDataGridViewTextBoxColumn_"].HeaderText = "يوم تعديل السعر";
            productsDataGridView.Columns["PriceModificationDateDataGridViewTextBoxColumn_"].DefaultCellStyle.Format = "yyyy/MM/dd tt HH:mm:ss";
            productsDataGridView.Columns["CreationDateDataGridViewTextBoxColumn_"].DefaultCellStyle.Format = "yyyy/MM/dd tt HH:mm:ss";

            productsDataGridView.AutoResizeColumns();
            productsDataGridView.Columns["CreationDateDataGridViewTextBoxColumn_"].Width += 5;
            productsDataGridView.Columns["PriceModificationDateDataGridViewTextBoxColumn_"].Width += 5;
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

                    List<Product_ProductPriceModel> productSearch = Classes.DataAccess.Products.GetProductParameterWithPricee("BarCode", txt_productBarCode.Text);
                    LoadJoinedDataGrid(productSearch);
                }
            }
        }

        private void pcb_searchName_Click(object sender, EventArgs e)
        {
            if (txt_productname.Text.Trim() == "")
                LoadJoinedDataGrid(Classes.DataAccess.Products.LoadProductsWithPrices(true));

            else
            {
                Logger.Log($"user is searching by name for product: {txt_productname.Text}",
                    System.Reflection.MethodInfo.GetCurrentMethod().Name, this.Name, Logger.INFO);

                List<Product_ProductPriceModel> productSearch = Classes.DataAccess.Products.GetProductParameterWithPricee("Name", txt_productname.Text);
                LoadJoinedDataGrid(productSearch);
            }
        }

        private void pcb_searchID_Click(object sender, EventArgs e)
        {
            if (txt_productid.Text.Trim() == "")
                LoadJoinedDataGrid(Classes.DataAccess.Products.LoadProductsWithPrices(true));

            else
            {
                Logger.Log($"user is searching by id for product: {txt_productid.Text}",
                    System.Reflection.MethodInfo.GetCurrentMethod().Name, this.Name, Logger.INFO);

                List<Product_ProductPriceModel> productSearch = Classes.DataAccess.Products.GetProductParameterWithPricee("Id", txt_productid.Text);
                LoadJoinedDataGrid(productSearch);
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

                    string CategoryName = "";
                    if (productsDataGridView.Rows[RowIndex].Cells["CategoryName"].Value != null)
                        CategoryName = productsDataGridView.Rows[RowIndex].Cells["CategoryName"].Value.ToString();

                    string ProductName = productsDataGridView.Rows[RowIndex].Cells["ProductName_"].Value.ToString(),
                        ProductPriceWholesale = productsDataGridView.Rows[RowIndex].Cells["PriceWholesale"].Value.ToString(),
                        ProductPriceSell = productsDataGridView.Rows[RowIndex].Cells["PriceSell"].Value.ToString(),
                        ProductQuantity = productsDataGridView.Rows[RowIndex].Cells["Quantity"].Value.ToString(),
                        ProductDescription = productsDataGridView.Rows[RowIndex].Cells["Description"].Value.ToString(),
                        ProductBarcode = productsDataGridView.Rows[RowIndex].Cells["BarCode"].Value.ToString(),
                        ProductQuantityMin = productsDataGridView.Rows[RowIndex].Cells["QuantityMinimum"].Value.ToString();

                    Logger.Log($"user removed product: {ProductName} with id: {ProductID}",
                        System.Reflection.MethodInfo.GetCurrentMethod().Name, this.Name, Logger.INFO);

                    txt_productid.Text = "" + ProductID;
                    txt_productname.Text = ProductName;
                    txt_productPriceSell.Text = ProductPriceSell;
                    txt_productPriceWholeSale.Text = ProductPriceWholesale;
                    txt_productquantity.Text = ProductQuantity;
                    txt_description.Text = ProductDescription;
                    txt_productBarCode.Text = ProductBarcode;
                    txt_categoriename.Text = CategoryName;
                    txt_productquantityMin.Text = ProductQuantityMin;

                    SetEditMode(true);
                }
                else
                {
                    new Notification().ShowAlert($"يجب أن تختار منتج للتعديل", Notification.EnmType.Error);
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

        private async void btn_remove_Click(object sender, EventArgs e)
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
                        await Classes.DataAccess.Products.RemoveProduct(ProductID);
                        LoadJoinedDataGrid(Classes.DataAccess.Products.LoadProductsWithPrices(true));

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
            LoadJoinedDataGrid(Classes.DataAccess.Products.LoadProductsWithPrices(true));
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
                LoadJoinedDataGrid(Classes.DataAccess.Products.LoadProductsWithPrices(true));

            else
            {
                Logger.Log($"user is searching for product by barcode: {txt_productBarCode.Text}",
                    System.Reflection.MethodInfo.GetCurrentMethod().Name, this.Name, Logger.INFO);

                List<Product_ProductPriceModel> productSearch = Classes.DataAccess.Products.GetProductParameterWithPricee("BarCode", txt_productBarCode.Text);
                LoadJoinedDataGrid(productSearch);
            }
        }

        private async void db_productDataGridView_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            //productsDataGridView.DataSource = new Methods().DataGridToDataTable(productsDataGridView);

            System.Data.DataTable data = await new Methods().DataGridToDataTable(productsDataGridView);

            data.DefaultView.Sort = $"{productsDataGridView.Columns[e.ColumnIndex].Name} ASC";

            productsDataGridView.DataSource = data;


            //productsDataGridView.Sort(productsDataGridView.Columns[e.ColumnIndex], System.ComponentModel.ListSortDirection.Ascending);
        }



        private async void db_productDataGridView_ColumnHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            //productsDataGridView.DataSource = new Methods().DataGridToDataTable(productsDataGridView);

            System.Data.DataTable data = await new Methods().DataGridToDataTable(productsDataGridView);

            data.DefaultView.Sort = $"{productsDataGridView.Columns[e.ColumnIndex].Name} DESC";

            productsDataGridView.DataSource = data;

            //productsDataGridView.Sort(productsDataGridView.Columns[e.ColumnIndex], System.ComponentModel.ListSortDirection.Descending);

        }

        private void productsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            //this.Validate();
            //this.productsBindingSource.EndEdit();
            //this.tableAdapterManager.UpdateAll(this.superMarketDataSet);

        }

        private void productsBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            //this.Validate();
            //this.productsBindingSource.EndEdit();
            //this.tableAdapterManager.UpdateAll(this.superMarketDataSet);

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
            Forms.ReportViewer.SelectedReport = Forms.ReportViewer.AvailableReports.Products;

            using (Forms.ReportViewer reportViewer = new Forms.ReportViewer())
            {
                reportViewer.ShowDialog();
                reportViewer.Dispose();
                reportViewer.Close();
            }
        }

        private void chk_generateBarCode_CheckedChanged(object sender, EventArgs e)
        {
            if (chk_generateBarCode.Checked)
            {
                txt_productBarCode.Enabled = false;
                txt_productBarCode.Text = Methods.GetUniqueInvoiceID(6);
            }
            else
            {
                txt_productBarCode.Enabled = true;
                txt_productBarCode.Text = "";
            }
        }

        //private async void button1_Click(object sender, EventArgs e)
        //{
        //    Random r = new Random();
        //    int categoryId, barcode, quantity;
        //    decimal productPirce;

        //    for (int i = 0; i < 100; i++)
        //    {
        //        categoryId = r.Next(9, 15);
        //        barcode = r.Next(0, 999999);
        //        productPirce = (decimal)r.NextDouble() * 100;
        //        quantity = r.Next(20, 100);

        //        Math.Round(productPirce * 100, 2);
        //        ProductModel product = new ProductModel();

        //        product.BarCode = "" + barcode;
        //        product.Name = "random " + barcode;
        //        //product.PriceSell = productPirce;
        //        product.Description = "";
        //        product.Quantity = quantity;
        //        product.CategoryID = categoryId;
        //        product.CategoryName = "test " + categoryId;

        //        await Classes.DataAccess.Products.SaveProduct(product);
        //    }
        //}
    }
}
