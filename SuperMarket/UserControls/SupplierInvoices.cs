using SuperMarket.Classes;
using SuperMarket.Classes.Models;
using SuperMarket.Classes.Models.Joins;
using SuperMarket.Forms;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SuperMarket.UserControls
{
    public partial class SupplierInvoices : UserControl
    {
        private readonly IDictionary<int, string> PaymentMethodDict = new Dictionary<int, string>(),
            SupplierSearchType = new Dictionary<int, string>(), ProductSearchType = new Dictionary<int, string>();
        private readonly string[] SupplierSearchString = { "اسم المورد", "التواصل", "الرقم التعريفي" },
            ProductSearchString = { "اسم المنتج", "الباركود", "الرقم التعريفي" };

        private SupplierInvoiceProductModel supplierProduct;

        public SupplierInvoices()
        {
            InitializeComponent();
        }

        private void SupplierInvoices_Load(object sender, EventArgs e)
        {
            SetColors(Properties.Settings.Default.AppColor);

            ResetAll();

            SetComboBoxs();

            //SetDataGrid();

            //LoadDataGrid(Classes.DataAccess.Suppliers.LoadSuppliers(true));

            //contextMenu = Methods.SetupContextMenuCopy(contextMenu, MenuItemCopyOption_Click);
        }

        private void ResizeAndRenameCoulmns()
        {
            db_productDataGridView.Columns["ProductId"].HeaderText = "الرقم التعريفي";
            db_productDataGridView.Columns["Quantity"].HeaderText = "كميه المنتج";
            db_productDataGridView.Columns["ProductName"].HeaderText = "اسم المنتج";
            db_productDataGridView.Columns["ProductPriceWholesale"].HeaderText = "سعر الجملة";
            db_productDataGridView.Columns["ProductPriceSell"].HeaderText = "سعر البيع";

            db_productDataGridView.Columns["CreationDate"].Visible = false;
            db_productDataGridView.Columns["Id"].Visible = false;

            db_productDataGridView.AutoResizeColumns();
            db_productDataGridView.Columns["Quantity"].Width += 20;
        }

        private void ResetAll()
        {
            pan_supplierResults.Enabled = false;
            pan_productResults.Enabled = false;
            pan_payment.Enabled = false;
            pan_save.Enabled = false;

            db_productDataGridView.DataSource = null;
            db_productDataGridView.Refresh();

            txt_searchProduct.Text = "";
            txt_searchSupplier.Text = "";
            txt_searchedProductBarCode.Text = "";
            txt_productQuantity.Text = "";
            txt_productPriceSell.Text = "";
            txt_productPriceWholeSale.Text = "";

            txt_searchedProductName.SelectedIndex = -1;
            txt_searchedProductName.DataSource = null;

            txt_searchProductType.SelectedIndex = -1;

            txt_searchedSupplierName.SelectedIndex = -1;
            txt_searchedSupplierName.DataSource = null;

            txt_searchSupplierType.SelectedIndex = -1;

            txt_withdrawFromSafe.SelectedIndex = -1;

            txt_paymentMethod.SelectedIndex = -1;

            num_paymentAmoutLeft.Value = 0;
            num_paymentAmoutPaid.Value = 0;
            num_paymentAmoutRequired.Value = 0;
        }

        public void SetComboBoxs()
        {
            SetEachComboBos(GlobalVars.PaymentMethod, PaymentMethodDict, txt_paymentMethod);
            SetEachComboBos(SupplierSearchString, SupplierSearchType, txt_searchSupplierType);
            SetEachComboBos(ProductSearchString, ProductSearchType, txt_searchProductType);
        }

        public void GetSafeNames()
        {
            txt_withdrawFromSafe.DataSource = null;
            txt_withdrawFromSafe.DataSource = new BindingSource(Classes.DataAccess.Safe.LoadSafe(), null);
            txt_withdrawFromSafe.DisplayMember = "Name";
            txt_withdrawFromSafe.ValueMember = "Id";
            txt_withdrawFromSafe.SelectedIndex = -1;
        }

        private void SetEachComboBos(string[] SearchString, IDictionary<int, string> SearchType, ComboBox SearchComboBox)
        {
            for (int i = 0; i < SearchString.Length; i++)
                SearchType.Add(i, SearchString[i]);

            SearchComboBox.DataSource = null;
            SearchComboBox.DataSource = new BindingSource(SearchType, null);
            SearchComboBox.DisplayMember = "Value";
            SearchComboBox.ValueMember = "Key";
            SearchComboBox.SelectedIndex = -1;
        }

        private void pcb_supplier_MouseEnter(object sender, EventArgs e)
        {
            Control FocusedObject = (Control)sender;
            FocusedObject.BackColor = Properties.Settings.Default.AppColor;
        }

        private void pcb_supplier_MouseLeave(object sender, EventArgs e)
        {
            Control FocusedObject = (Control)sender;
            FocusedObject.BackColor = Color.Transparent;
        }

        private void pcb_searchProduct_Click(object sender, EventArgs e)
        {
            if (txt_searchProductType.SelectedIndex != -1)
            {
                if (txt_searchProductType.Text == ProductSearchType[0].ToString())
                {
                    List<ProductModel> SearchedProducts = Classes.DataAccess.Products.GetProductLikeParameter("Name",
                        txt_searchProduct.Text);

                    if (SearchedProducts.Count > 0)
                    {
                        FillProductComboBox(txt_searchedProductName, SearchedProducts, "Id", "Name");
                    }
                    else
                        MessageBox.Show("لا يوجد منتج بهذه البيانات", "لا يوجد",
                            MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }

                else if (txt_searchProductType.Text == ProductSearchType[1].ToString())
                {
                    List<ProductModel> SearchedProducts = Classes.DataAccess.Products.GetProductParameter("BarCode",
                        txt_searchProduct.Text);

                    if (SearchedProducts.Count > 0)
                    {
                        FillProductComboBox(txt_searchedProductName, SearchedProducts, "Id", "Name");
                    }
                    else
                        MessageBox.Show("لا يوجد منتج بهذه البيانات", "لا يوجد",
                            MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }

                else if (txt_searchProductType.Text == ProductSearchType[2].ToString())
                {
                    List<ProductModel> SearchedProducts = Classes.DataAccess.Products.GetProductParameter("Id",
                        txt_searchProduct.Text);

                    if (SearchedProducts.Count > 0)
                    {
                        FillProductComboBox(txt_searchedProductName, SearchedProducts, "Id", "Name");
                    }
                    else
                        MessageBox.Show("لا يوجد منتج بهذه البيانات", "لا يوجد",
                            MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            else
                MessageBox.Show("برجاء اختيار نوع البحث اولا", "خطأ",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private async void FillProductComboBox(ComboBox comboBox, List<ProductModel> searchedProducts, string Value, string Display)
        {
            comboBox.DataSource = null;
            comboBox.Items.Clear();

            DataTable DataProductSearch = await new Methods().ListToDataTable(searchedProducts);
            comboBox.DataSource = DataProductSearch;
            comboBox.ValueMember = Value;
            comboBox.DisplayMember = Display;
        }

        private void txt_searchedProductName_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (txt_searchedProductName.SelectedIndex != -1 && txt_searchedProductName.DataSource != null &&
                txt_searchedProductName.SelectedValue.GetType() == typeof(Int64))
            {
                List<ProductModel> SearchedProducts = Classes.DataAccess.Products.GetProductLikeParameter("Id",
                        txt_searchedProductName.SelectedValue.ToString());

                if (SearchedProducts.Count != 0)
                {
                    txt_searchedProductBarCode.Text = "" + SearchedProducts[0].BarCode;
                }
            }
        }

        private void txt_supplierInvoices_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Return)
            {
                e.SuppressKeyPress = true;
            }
        }

        private void txt_productQuantity_KeyPress(object sender, KeyPressEventArgs e)
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

        private void btn_addProduct_Click(object sender, EventArgs e)
        {
            if (txt_searchedProductName.DataSource != null)
            {
                if (txt_searchedProductName.SelectedIndex != -1)
                {
                    if (txt_productQuantity.Text.Trim() != "" && txt_productPriceSell.Text.Trim() != ""
                        && txt_productPriceWholeSale.Text.Trim() != "")
                    {
                        if (float.Parse(txt_productQuantity.Text) != 0)
                        {
                            supplierProduct = new SupplierInvoiceProductModel()
                            {
                                ProductId = long.Parse(txt_searchedProductName.SelectedValue.ToString()),
                                ProductName = txt_searchedProductName.Text,
                                Quantity = float.Parse(txt_productQuantity.Text),
                                ProductPriceSell = decimal.Parse(txt_productPriceSell.Text),
                                ProductPriceWholesale = decimal.Parse(txt_productPriceWholeSale.Text),
                            };

                            if (supplierProduct.ProductPriceSell < supplierProduct.ProductPriceWholesale)
                            {
                                MessageBox.Show("لا يمكن اضافه منتج وسعر البيع اصغر من سعر الجملة", "خطأ",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            else
                            {
                                if (!CheckProductInDataGrid(supplierProduct.ProductId))
                                {
                                    UpdateProductsDataGrid(supplierProduct);

                                    pan_payment.Enabled = true;
                                    pan_save.Enabled = false;
                                }
                                else
                                {
                                    MessageBox.Show("لا يمكن اضافه هذا المنتج لانه موجود في الفاتورة", "خطأ",
                                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                            }
                        }
                        else
                        {
                            MessageBox.Show("لا يمكن اضافه منتج والكمية تساوي صفر", "خطأ",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("برجاء ادخال بيانات المنتج كامله من الكمية وسعر البيع وسعر الجملة", "خطأ",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                    ////Classes.DataAccess.SupplierInvoice.SaveSupplierInvoice()

                    //if (SearchedProducts.Count > 0)
                    //{
                    //    UpdateProductsDataGrid(SearchedProducts);
                    //    //List<ProductModel> datasource = (List<ProductModel>)db_productDataGridView.DataSource;
                    //    //db_productDataGridView.DataSource = null;
                    //    //datasource.Add(SearchedProducts[0]);
                    //    //db_productDataGridView.DataSource = datasource;
                    //    //SetDataGrid();
                    //}
                }
                else
                {
                    MessageBox.Show("يجب اختيار منتج للاضافه", "خطأ",
                                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            else
            {
                MessageBox.Show("يجب اختيار منتج للاضافه", "خطأ",
                            MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private bool CheckProductInDataGrid(long ProductId)
        {
            if (db_productDataGridView.DataSource != null)
            {
                List<SupplierInvoiceProductModel> datasource = (List<SupplierInvoiceProductModel>)db_productDataGridView.DataSource;

                foreach (SupplierInvoiceProductModel supplierInvoice in datasource)
                {
                    if (supplierInvoice.ProductId == ProductId)
                        return true;
                }
            }
            return false;
        }

        private void UpdateProductsDataGrid(SupplierInvoiceProductModel Product)
        {
            if (db_productDataGridView.DataSource != null)
            {
                List<SupplierInvoiceProductModel> datasource = (List<SupplierInvoiceProductModel>)db_productDataGridView.DataSource;
                db_productDataGridView.DataSource = null;
                datasource.Add(Product);
                db_productDataGridView.DataSource = datasource;
                ResizeAndRenameCoulmns();
            }
            else
            {
                List<SupplierInvoiceProductModel> ProductList = new List<SupplierInvoiceProductModel>
                {
                    Product
                };

                db_productDataGridView.DataSource = ProductList;
                ResizeAndRenameCoulmns();
            }
        }

        private void num_payment_ValueChanged(object sender, EventArgs e)
        {
            if ((NumericUpDown)sender == num_paymentAmoutRequired && num_paymentAmoutPaid.Enabled == false)
            {
                if (txt_paymentMethod.SelectedIndex == Methods.FindIndexFromArray(GlobalVars.PaymentMethod, "نقدي"))
                {
                    num_paymentAmoutPaid.Value = num_paymentAmoutRequired.Value;

                    num_paymentAmoutLeft.Value = 0;
                }
                else if (txt_paymentMethod.SelectedIndex == Methods.FindIndexFromArray(GlobalVars.PaymentMethod, "آجل"))
                {
                    num_paymentAmoutLeft.Value = num_paymentAmoutRequired.Value;
                }
            }
            else
            {
                decimal AmoutRequired = num_paymentAmoutRequired.Value,
                AmoutPaid = num_paymentAmoutPaid.Value,
                AmoutLeft = AmoutRequired - AmoutPaid;

                num_paymentAmoutLeft.Value = AmoutLeft;
            }
        }

        private void txt_productQuantity_TextChanged(object sender, EventArgs e)
        {
            if (txt_productQuantity.Text == ".")
            {
                txt_productQuantity.Text = "0.";
                txt_productQuantity.SelectionStart = txt_productQuantity.Text.Length;
            }
        }

        private async void pcb_searchSupplier_Click(object sender, EventArgs e)
        {
            if (txt_searchSupplierType.SelectedIndex != -1)
            {
                if (txt_searchSupplierType.Text == SupplierSearchType[0].ToString())
                {
                    List<SupplierModel> SearchecSuppliers = Classes.DataAccess.Suppliers.GetSupplierParameterLike("Name", txt_searchSupplier.Text);

                    if (SearchecSuppliers.Count > 0)
                    {
                        await FillSupplierComboBox(txt_searchedSupplierName, SearchecSuppliers, "Id", "Name");
                    }
                    else
                        MessageBox.Show("لا يوجد مورد بهذه البيانات", "لا يوجد",
                            MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }

                else if (txt_searchSupplierType.Text == SupplierSearchType[1].ToString())
                {
                    List<SupplierModel> SearchecSuppliers = Classes.DataAccess.Suppliers.GetSupplierParameterLike("Contact", txt_searchSupplier.Text);

                    if (SearchecSuppliers.Count > 0)
                    {
                        await FillSupplierComboBox(txt_searchedSupplierName, SearchecSuppliers, "Id", "Name");
                    }
                    else
                        MessageBox.Show("لا يوجد مورد بهذه البيانات", "لا يوجد",
                            MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else if (txt_searchSupplierType.Text == SupplierSearchType[2].ToString())
                {
                    List<SupplierModel> SearchecSuppliers = Classes.DataAccess.Suppliers.GetSupplierParameter("Id", txt_searchSupplier.Text);

                    if (SearchecSuppliers.Count > 0)
                    {
                        await FillSupplierComboBox(txt_searchedSupplierName, SearchecSuppliers, "Id", "Name");
                    }
                    else
                        MessageBox.Show("لا يوجد مورد بهذه البيانات", "لا يوجد",
                            MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            else
                MessageBox.Show("برجاء اختيار نوع البحث", "خطأ",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private async void AddSupplierProduct()
        {
            List<SupplierInvoiceProductModel> AllSupplierProducts = (List<SupplierInvoiceProductModel>)db_productDataGridView.DataSource;

            foreach (SupplierInvoiceProductModel SupplierProduct in AllSupplierProducts)
            {
                Classes.DataAccess.SupplierInvoiceProduct.SaveSupplierInvoiceProduct(SupplierProduct);

                List<SupplierInvoiceProductModel> SearchedSupplierProducts =
                    Classes.DataAccess.SupplierInvoiceProduct.LoadSupplierInvoiceProduct();

                SupplierInvoiceProductModel lastSupplierProduct = SearchedSupplierProducts[SearchedSupplierProducts.Count - 1];

                bool PaymentFinished = false;
                if (num_paymentAmoutLeft.Value == 0)
                    PaymentFinished = true;

                SupplierInvoiceModel supplierInvoice = new SupplierInvoiceModel
                {
                    AmountLeft = num_paymentAmoutLeft.Value,
                    AmountTotal = num_paymentAmoutRequired.Value,
                    AmountPaid = num_paymentAmoutPaid.Value,
                    PaymentMethod = (int)txt_paymentMethod.SelectedValue,
                    PaymentStatus = PaymentFinished,
                    SupplierId = (int)txt_searchedSupplierName.SelectedValue,
                    SupplierName = txt_searchedSupplierName.Text,
                    SupplierInvoiceProductId = lastSupplierProduct.Id
                };

                Classes.DataAccess.SupplierInvoices.SaveSupplierInvoice(supplierInvoice);

                List<ProductModel> AdjustedProuduct = Classes.DataAccess.Products
                      .GetProductParameter("Id", lastSupplierProduct.ProductId.ToString());

                AdjustedProuduct[0].Quantity += lastSupplierProduct.Quantity;

                await Classes.DataAccess.Products.UpdateProduct(AdjustedProuduct[0]);

                ProductPriceModel productPrice = new ProductPriceModel()
                {
                    ProductId = lastSupplierProduct.ProductId,
                    PriceSell = lastSupplierProduct.ProductPriceSell,
                    PriceWholesale = lastSupplierProduct.ProductPriceWholesale,
                    ProductName = lastSupplierProduct.ProductName,
                    CreationDate = DateTime.Now
                };

                await Classes.DataAccess.ProductPrice.SaveProductPrice(productPrice);

                List<ProductModel> SearchedProduct = Classes.DataAccess.Products.GetProductParameter("Id", "" + productPrice.ProductId);
                SearchedProduct[0].PriceModificationDate = productPrice.CreationDate;

                await Classes.DataAccess.Products.UpdateProduct(SearchedProduct[0]);

            }
            ResetAll();
        }

        private void btn_saveInovice_Click(object sender, EventArgs e)
        {
            if (txt_paymentMethod.SelectedIndex != -1)
            {
                if (chk_withdrawFromSafe.Checked)
                {
                    if (txt_withdrawFromSafe.SelectedIndex != -1)
                    {
                        AddSupplierProduct();

                        List<SafeTransactionModel> AllSafeTransactions =
                        Classes.DataAccess.SafeTransactions.GetSafeTransactionParameter("SafeName", txt_withdrawFromSafe.Text, "ASC");

                        if (AllSafeTransactions.Count == 0)
                        {
                            SafeTransactionModel safeTransactionModel = new SafeTransactionModel
                            {
                                AdjustedByUserId = Main.LoggedUser.Id,
                                AdjustedByUserFullName = Main.LoggedUserEnc.FullName,
                                AmountAdded = -1 * num_paymentAmoutPaid.Value,
                                AmountTotal = -1 * num_paymentAmoutPaid.Value,
                                Notes = $"حساب فاتورة المورد {txt_searchedSupplierName.Text}",
                                SafeId = int.Parse(txt_withdrawFromSafe.SelectedValue.ToString()),
                                SafeName = txt_withdrawFromSafe.Text
                            };
                            Classes.DataAccess.SafeTransactions.SaveSafeTransaction(safeTransactionModel);
                        }

                        else
                        {
                            SafeTransactionModel safeTransactionModel = new SafeTransactionModel
                            {
                                AdjustedByUserId = Main.LoggedUser.Id,
                                AdjustedByUserFullName = Main.LoggedUserEnc.FullName,
                                AmountAdded = -1 * num_paymentAmoutPaid.Value,
                                AmountTotal = AllSafeTransactions[AllSafeTransactions.Count - 1].AmountTotal + (-1 * num_paymentAmoutPaid.Value),
                                Notes = $"حساب فاتورة المورد {txt_searchedSupplierName.Text}",
                                SafeId = int.Parse(txt_withdrawFromSafe.SelectedValue.ToString()),
                                SafeName = txt_withdrawFromSafe.Text
                            };
                            Classes.DataAccess.SafeTransactions.SaveSafeTransaction(safeTransactionModel);
                        }

                        MessageBox.Show("تمت اضافه الفاتورة", "عملية ناجحه", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("برجاء اختيار الخزنة", "خطأ",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    AddSupplierProduct();
                }
            }
            else
            {
                MessageBox.Show("برجاء اختيار طريقه الدفع", "خطأ",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_resetAll_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show($"هل انت متأكد من مسح جميع الخانات", "انتظر",
                                MessageBoxButtons.YesNo,
                                MessageBoxIcon.Information) == DialogResult.Yes)
            {
                ResetAll();
            }
        }

        private void btn_removeProduct_Click(object sender, EventArgs e)
        {
            if (db_productDataGridView.DataSource != null && db_productDataGridView.CurrentCell != null)
            {
                int rowindex = db_productDataGridView.CurrentCell.RowIndex;
                long SupplierID = int.Parse(db_productDataGridView.Rows[rowindex].Cells["Id"].Value.ToString());
                string ProductName = db_productDataGridView.Rows[rowindex].Cells["ProductName"].Value.ToString();

                if (MessageBox.Show($"هل تريد ان تحذف من السله {ProductName}", "انتظر",
                           MessageBoxButtons.YesNo,
                           MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    List<SupplierInvoiceProductModel> datasource = (List<SupplierInvoiceProductModel>)db_productDataGridView.DataSource;
                    db_productDataGridView.DataSource = null;
                    datasource.Remove(datasource.Find(product => product.Id == SupplierID));
                    db_productDataGridView.DataSource = datasource;
                    ResizeAndRenameCoulmns();
                }
            }
            else
                MessageBox.Show("رجاء اختيار منتج أولا قبل الحذف", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);

            if (db_productDataGridView.Rows.Count == 0)
            {
                pan_payment.Enabled = false;
            }
        }

        private void txt_paymentMethod_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (txt_paymentMethod.SelectedIndex == Methods.FindIndexFromArray(GlobalVars.PaymentMethod, "نقدي"))
            {
                num_paymentAmoutPaid.Value = num_paymentAmoutRequired.Value;
                num_paymentAmoutPaid.Enabled = false;
            }
            else if (txt_paymentMethod.SelectedIndex == Methods.FindIndexFromArray(GlobalVars.PaymentMethod, "آجل"))
            {
                num_paymentAmoutPaid.Enabled = false;
            }
            else
            {
                num_paymentAmoutPaid.Enabled = true;
            }
        }

        private void db_productDataGridView_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (db_productDataGridView.DataSource != null && db_productDataGridView.CurrentCell != null)
            {
                int rowindex = db_productDataGridView.CurrentCell.RowIndex;
                long ProdcutID = int.Parse(db_productDataGridView.Rows[rowindex].Cells["ProductId"].Value.ToString());
                //string ProductName = db_productDataGridView.Rows[rowindex].Cells["ProductName"].Value.ToString();

                List<Product_ProductPriceModel> ProductData =
                     Classes.DataAccess.Products.GetProductParameterWithPricee("Id", "" + ProdcutID);

                if (ProductData.Count > 0)
                    MessageBox.Show($"اسم المنتج: {ProductData[0].Name}\n" +
                        $"باركود المنتج: {ProductData[0].BarCode}\n" +
                        $"التصنيف: {ProductData[0].CategoryName}\n" +
                        $"وصف المنتج: {ProductData[0].Description}\n" +
                        $"سعر البيع: {ProductData[0].PriceSell}\n" +
                        $"سعر الجملة: {ProductData[0].PriceWholesale}\n" +
                        $"الكمية: {ProductData[0].Quantity}\n" +
                        $"اقل كميه مسموحة: {ProductData[0].QuantityMinimum}\n",
                        "بيانات المنتج", MessageBoxButtons.OK, MessageBoxIcon.Question);
                else
                    MessageBox.Show("لا يوجد بيانات لهذا المنتج", "خطأ",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void chk_withdrawFromSafe_CheckedChanged(object sender, EventArgs e)
        {
            if (chk_withdrawFromSafe.Checked)
            {
                txt_withdrawFromSafe.Enabled = true;

                pan_save.Enabled = false;
            }
            else
            {
                txt_withdrawFromSafe.Enabled = false;

                pan_save.Enabled = true;
            }
        }

        private void txt_withdrawFromSafe_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (txt_withdrawFromSafe.SelectedIndex != -1)
            {
                pan_save.Enabled = true;
            }
        }

        private async void db_productDataGridView_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            System.Data.DataTable data = await new Methods().DataGridToDataTable(db_productDataGridView);

            data.DefaultView.Sort = $"{db_productDataGridView.Columns[e.ColumnIndex].Name} DESC";

            db_productDataGridView.DataSource = data;
        }

        private async void db_productDataGridView_ColumnHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            System.Data.DataTable data = await new Methods().DataGridToDataTable(db_productDataGridView);

            data.DefaultView.Sort = $"{db_productDataGridView.Columns[e.ColumnIndex].Name} ASC";

            db_productDataGridView.DataSource = data;
        }

        private async Task FillSupplierComboBox(ComboBox comboBox, List<SupplierModel> searchecSuppliers, string Value, string Display)
        {
            comboBox.DataSource = null;
            comboBox.Items.Clear();

            DataTable DataSupplierSearch = await new Methods().ListToDataTable(searchecSuppliers);
            comboBox.DataSource = DataSupplierSearch;
            comboBox.ValueMember = Value;
            comboBox.DisplayMember = Display;

            comboBox.SelectedIndex = -1;

            pan_supplierResults.Enabled = true;
        }

        private void text_searchedSupplierName_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (txt_searchedSupplierName.SelectedIndex != -1 && txt_searchedSupplierName.DataSource != null &&
                txt_searchedSupplierName.SelectedValue.GetType() == typeof(int))
            {
                List<SupplierModel> SearchecSuppliers =
                    Classes.DataAccess.Suppliers.GetSupplierParameter("Id", txt_searchedSupplierName.SelectedValue.ToString());

                if (SearchecSuppliers.Count != 0)
                {
                    txt_searchedSupplierContact.Text = "" + SearchecSuppliers[0].Contact;
                    txt_searchedSupplierName.Text = "" + SearchecSuppliers[0].Name;
                    txt_searchedSupplierAddress.Text = SearchecSuppliers[0].Address;
                    pan_productResults.Enabled = true;
                }
            }

            if (txt_searchedSupplierName.SelectedIndex == -1)
            {
                txt_searchedSupplierAddress.Text = "";
                txt_searchedSupplierContact.Text = "";
                pan_productResults.Enabled = false;
            }
        }

        private void SetColors(Color appColor)
        {
            Control[] AllControls =
            {
                label1,
                label2,
                label3,
                label4,
                label5,
                label6,
                label7,
                label8,
                label9,
                label10,
                label11,
                label12,
                label13,
                label14,
                label15,
                label16,
                btn_addProduct,
                btn_removeProduct,
                btn_resetAll,
                btn_saveInovice,
            };

            foreach (Control control in AllControls)
            {
                if (control.GetType() == typeof(Button))
                    control.BackColor = appColor;

                else if (control.GetType() == typeof(Label))
                    control.ForeColor = appColor;
            }

            db_productDataGridView.ColumnHeadersDefaultCellStyle.BackColor = appColor;
        }
    }
}
