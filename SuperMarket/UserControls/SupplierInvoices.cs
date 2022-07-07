using SuperMarket.Classes;
using SuperMarket.Classes.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
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
            db_productDataGridView.Columns["ProductId"].HeaderText = "الرقم التعريفي للمنتج";
            db_productDataGridView.Columns["Quantity"].HeaderText = "كميه المنتج";
            db_productDataGridView.Columns["ProductName"].HeaderText = "اسم المنتج";

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

            txt_searchedProductName.SelectedIndex = -1;
            txt_searchedProductName.DataSource = null;

            txt_searchProductType.SelectedIndex = -1;

            txt_searchedSupplierName.SelectedIndex = -1;
            txt_searchedSupplierName.DataSource = null;

            txt_searchSupplierType.SelectedIndex = -1;

            txt_paymentMethod.SelectedIndex = -1;

            num_paymentAmoutLeft.Value = 0;
            num_paymentAmoutPaid.Value = 0;
            num_paymentAmoutRequired.Value = 0;
        }

        private void SetComboBoxs()
        {
            SetEachComboBos(GlobalVars.PaymentMethod, PaymentMethodDict, txt_paymentMethod);
            SetEachComboBos(SupplierSearchString, SupplierSearchType, txt_searchSupplierType);
            SetEachComboBos(ProductSearchString, ProductSearchType, txt_searchProductType);
        }

        private void SetEachComboBos(string[] SearchString, IDictionary<int, string> SearchType, ComboBox SearchComboBox)
        {
            for (int i = 0; i < SearchString.Length; i++)
                SearchType.Add(i, SearchString[i]);
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

                else if (txt_searchSupplierType.Text == SupplierSearchType[1].ToString())
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

                else if (txt_searchSupplierType.Text == SupplierSearchType[2].ToString())
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

        private void FillProductComboBox(ComboBox comboBox, List<ProductModel> searchedProducts, string Value, string Display)
        {
            comboBox.DataSource = null;
            comboBox.Items.Clear();

            DataTable DataProductSearch = new Methods().ListToDataTable(searchedProducts);
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
                    if (txt_productQuantity.Text.Trim() != "")
                    {
                        if (float.Parse(txt_productQuantity.Text) != 0)
                        {
                            supplierProduct = new SupplierInvoiceProductModel()
                            {
                                ProductId = long.Parse(txt_searchedProductName.SelectedValue.ToString()),
                                ProductName = txt_searchedProductName.Text,
                                Quantity = float.Parse(txt_productQuantity.Text)
                            };

                            UpdateProductsDataGrid(supplierProduct);

                            pan_payment.Enabled = true;
                            pan_save.Enabled = true;

                        }
                        else
                        {
                            MessageBox.Show("لا يمكن اضافه منتج والكمية تساوي صفر", "خطأ",
                                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        }
                    }
                    else
                    {
                        MessageBox.Show("برجاء تحديد الكمية", "خطأ",
                            MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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
            decimal AmoutRequired = num_paymentAmoutRequired.Value,
                    AmoutPaid = num_paymentAmoutPaid.Value,
                    AmoutLeft = AmoutRequired - AmoutPaid;

            num_paymentAmoutLeft.Value = AmoutLeft;
        }

        private void txt_productQuantity_TextChanged(object sender, EventArgs e)
        {
            if (txt_productQuantity.Text == ".")
            {
                txt_productQuantity.Text = "0.";
                txt_productQuantity.SelectionStart = txt_productQuantity.Text.Length;
            }
        }

        private void pcb_searchSupplier_Click(object sender, EventArgs e)
        {
            if (txt_searchSupplierType.SelectedIndex != -1)
            {
                if (txt_searchSupplierType.Text == SupplierSearchType[0].ToString())
                {
                    List<SupplierModel> SearchecSuppliers = Classes.DataAccess.Suppliers.GetSupplierParameterLike("Name", txt_searchSupplier.Text);

                    if (SearchecSuppliers.Count > 0)
                    {
                        FillSupplierComboBox(txt_searchedSupplierName, SearchecSuppliers, "Id", "Name");
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
                        FillSupplierComboBox(txt_searchedSupplierName, SearchecSuppliers, "Id", "Name");
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
                        FillSupplierComboBox(txt_searchedSupplierName, SearchecSuppliers, "Id", "Name");
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

        private void btn_saveInovice_Click(object sender, EventArgs e)
        {
            if (txt_paymentMethod.SelectedIndex != -1)
            {
                List<SupplierInvoiceProductModel> AllSupplierProducts = (List<SupplierInvoiceProductModel>)db_productDataGridView.DataSource;

                foreach (SupplierInvoiceProductModel SupplierProduct in AllSupplierProducts)
                {
                    Classes.DataAccess.SupplierInvoiceProduct.SaveSupplierInvoiceProduct(SupplierProduct);

                    List<SupplierInvoiceProductModel> SearchedSupplierProducts =
                        Classes.DataAccess.SupplierInvoiceProduct.LoadSupplierInvoiceProduct();

                    SupplierInvoiceProductModel lastSupplierProduct = SearchedSupplierProducts[SearchedSupplierProducts.Count - 1];

                    int PaymentFinished = 0;
                    if (num_paymentAmoutPaid.Value == 0)
                        PaymentFinished = 1;

                    SupplierInvoiceModel supplierInvoice = new SupplierInvoiceModel()
                    {
                        AmountLeft = num_paymentAmoutLeft.Value,
                        AmountTotal = num_paymentAmoutRequired.Value,
                        AmountPaid = num_paymentAmoutPaid.Value,
                        PaymentMethod = (int)txt_paymentMethod.SelectedValue,
                        PaymentStatus = PaymentFinished,
                        SupplierId = (int)txt_searchedSupplierName.SelectedValue,
                        SupplierInvoiceProductId = lastSupplierProduct.Id
                    };

                    Classes.DataAccess.SupplierInvoice.SaveSupplierInvoice(supplierInvoice);
                }
                ResetAll();

                MessageBox.Show("تمت الإضافه", "نجحت العملية",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void FillSupplierComboBox(ComboBox comboBox, List<SupplierModel> searchecSuppliers, string Value, string Display)
        {
            comboBox.DataSource = null;
            comboBox.Items.Clear();

            DataTable DataSupplierSearch = new Methods().ListToDataTable(searchecSuppliers);
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
                label6
            };

            foreach (Control control in AllControls)
            {
                if (control.GetType() == typeof(Button))
                    control.BackColor = appColor;

                else if (control.GetType() == typeof(Label))
                    control.ForeColor = appColor;
            }

            //suppliersDataGridView.ColumnHeadersDefaultCellStyle.BackColor = appColor;
        }
    }
}
