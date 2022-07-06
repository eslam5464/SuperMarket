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
        private IDictionary<int, string> PaymentMethodDict = new Dictionary<int, string>(),
            SupplierSearchType = new Dictionary<int, string>(), ProductSearchType = new Dictionary<int, string>();
        private string[] SupplierSearchString = { "اسم المورد", "التواصل" },
            ProductSearchString = { "اسم المنتج", "الباركود" };

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

        private void SetDataGrid()
        {
            db_productDataGridView.Columns["ProductId"].HeaderText = "الرقم التعريفي";
            db_productDataGridView.Columns["Quantity"].HeaderText = "كميه المنتج";
            db_productDataGridView.Columns["ProductName_"].HeaderText = "اسم المنتج";
            db_productDataGridView.Columns["CreationDate"].HeaderText = "يوم الاضافه";

            db_productDataGridView.Columns["Id"].Visible = false;

            db_productDataGridView.AutoResizeColumns();
            db_productDataGridView.Columns["CreationDate"].Width += 5;
        }

        private void ResetAll()
        {
            pan_supplierResults.Enabled = false;
            pan_productResults.Enabled = false;
            pan_payment.Enabled = false;
        }

        private void SetComboBoxs()
        {
            SetEachComboBos(GlobalVars.PaymentMethod, PaymentMethodDict, txt_paymentMethod);
            SetEachComboBos(SupplierSearchString, SupplierSearchType, txt_searchSupplierType);
            SetEachComboBos(ProductSearchString, ProductSearchType, txt_searchProductType);

            //for (int i = 0; i < GlobalVars.PaymentMethod.Length; i++)
            //    PaymentMethodDict.Add(i, GlobalVars.PaymentMethod[i]);
            //txt_paymentMethod.DataSource = new BindingSource(PaymentMethodDict, null);
            //txt_paymentMethod.DisplayMember = "Value";
            //txt_paymentMethod.ValueMember = "Key";
            //txt_paymentMethod.SelectedIndex = -1;

            //for (int i = 0; i < SupplierSearchString.Length; i++)
            //    SupplierSearchType.Add(i, SupplierSearchString[i]);
            //txt_searchSupplierType.DataSource = new BindingSource(SupplierSearchType, null);
            //txt_searchSupplierType.DisplayMember = "Value";
            //txt_searchSupplierType.ValueMember = "Key";
            //txt_searchSupplierType.SelectedIndex = -1;

            //for (int i = 0; i < ProductSearchString.Length; i++)
            //    ProductSearchType.Add(i, ProductSearchString[i]);
            //txt_searchProductType.DataSource = new BindingSource(ProductSearchType, null);
            //txt_searchProductType.DisplayMember = "Value";
            //txt_searchProductType.ValueMember = "Key";
            //txt_searchProductType.SelectedIndex = -1;
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
                        txt_searchedProductName.DataSource = null;
                        txt_searchedProductName.Items.Clear();

                        DataTable DataProductSearch = new Methods().ListToDataTable(SearchedProducts);
                        txt_searchedProductName.DataSource = DataProductSearch;
                        txt_searchedProductName.ValueMember = "Id";
                        txt_searchedProductName.DisplayMember = "Name";

                        pan_payment.Enabled = true;
                    }
                    else
                        MessageBox.Show("لا يوجد منتج بهذه البيانات", "لا يوجد",
                            MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }

                else if (txt_searchSupplierType.Text == SupplierSearchType[1].ToString())
                {
                    List<ProductModel> SearchedProducts = Classes.DataAccess.Products.GetProductLikeParameter("Name",
                        txt_searchProduct.Text);

                    if (SearchedProducts.Count > 0)
                    {

                    }
                    else
                        MessageBox.Show("لا يوجد منتج بهذه البيانات", "لا يوجد",
                            MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            else
                MessageBox.Show("برجاء اختيار نوع البحث", "خطأ",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void pcb_searchSupplier_Click(object sender, EventArgs e)
        {
            if (txt_searchSupplierType.SelectedIndex != -1)
            {
                if (txt_searchSupplierType.Text == SupplierSearchType[0].ToString())
                {
                    List<SupplierModel> SearchecSuppliers = Classes.DataAccess.Suppliers.GetSupplierParameterLike("Name", txt_searchSupplier.Text);

                    if (SearchecSuppliers.Count > 0)
                    {
                        txt_searchedSupplierName.DataSource = null;
                        txt_searchedSupplierName.Items.Clear();

                        DataTable DataSupplierSearch = new Methods().ListToDataTable(SearchecSuppliers);
                        txt_searchedSupplierName.DataSource = DataSupplierSearch;
                        txt_searchedSupplierName.ValueMember = "Id";
                        txt_searchedSupplierName.DisplayMember = "Name";

                        pan_supplierResults.Enabled = true;
                        pan_productResults.Enabled = true;
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
                        foreach (SupplierModel supplier in SearchecSuppliers)
                        {

                        }
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
                }
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
