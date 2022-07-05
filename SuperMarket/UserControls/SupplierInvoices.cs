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
            SupplierSearchType = new Dictionary<int, string>();
        private readonly string[] ALlSearchTypes = { "الإسم", "التواصل" };

        public SupplierInvoices()
        {
            InitializeComponent();
        }

        private void SupplierInvoices_Load(object sender, EventArgs e)
        {
            SetColors(Properties.Settings.Default.AppColor);

            ResetAll();

            SetComboBoxs();

            SetDataGrid();

            //LoadDataGrid(Classes.DataAccess.Suppliers.LoadSuppliers(true));

            //contextMenu = Methods.SetupContextMenuCopy(contextMenu, MenuItemCopyOption_Click);
        }

        private void SetDataGrid()
        {
            db_productDataGridView.Columns["ProductId"].HeaderText = "الرقم التعريفي";
            db_productDataGridView.Columns["Quantity"].HeaderText = "كميه المنتج";
            db_productDataGridView.Columns["ProductName"].HeaderText = "اسم المنتج";
            db_productDataGridView.Columns["CreationDate"].HeaderText = "يوم الاضافه";

            db_productDataGridView.Columns["Id"].Visible = false;

            db_productDataGridView.AutoResizeColumns();
            db_productDataGridView.Columns["CreationDate"].Width += 5;
        }

        private void ResetAll()
        {
            pan_searchResults.Enabled = false;
            pan_product.Enabled = false;
            pan_payment.Enabled = false;
        }

        private void SetComboBoxs()
        {
            for (int i = 0; i < GlobalVars.PaymentMethod.Length; i++)
                PaymentMethodDict.Add(i, GlobalVars.PaymentMethod[i]);

            txt_paymentMethod.DataSource = new BindingSource(PaymentMethodDict, null);
            txt_paymentMethod.DisplayMember = "Value";
            txt_paymentMethod.ValueMember = "Key";
            txt_paymentMethod.SelectedIndex = -1;



            for (int i = 0; i < ALlSearchTypes.Length; i++)
                SupplierSearchType.Add(i, ALlSearchTypes[i]);

            txt_searchType.DataSource = new BindingSource(SupplierSearchType, null);
            txt_searchType.DisplayMember = "Value";
            txt_searchType.ValueMember = "Key";
            txt_searchType.SelectedIndex = -1;
        }

        private void pcb_supplier_MouseEnter(object sender, EventArgs e)
        {

        }

        private void pcb_supplier_MouseLeave(object sender, EventArgs e)
        {

        }

        private void pcb_searchSupplier_Click(object sender, EventArgs e)
        {
            if (txt_searchType.SelectedIndex != -1)
            {
                if (txt_searchType.Text == SupplierSearchType[0].ToString())
                {
                    List<SupplierModel> SearchecSuppliers = Classes.DataAccess.Suppliers.GetSupplierParameterLike("Name", txt_search.Text);

                    if (SearchecSuppliers.Count > 0)
                    {
                        txt_searchedSupplierName.DataSource = null;
                        txt_searchedSupplierName.Items.Clear();

                        DataTable DataSupplierSearch = new Methods().ListToDataTable(SearchecSuppliers);
                        txt_searchedSupplierName.DataSource = DataSupplierSearch;
                        txt_searchedSupplierName.ValueMember = "Id";
                        txt_searchedSupplierName.DisplayMember = "Name";

                        pan_searchResults.Enabled = true;
                    }
                    else
                        MessageBox.Show("لا يوجد مورد بهذه البيانات", "لا يوجد",
                            MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }

                else if (txt_searchType.Text == SupplierSearchType[1].ToString())
                {
                    List<SupplierModel> SearchecSuppliers = Classes.DataAccess.Suppliers.GetSupplierParameterLike("Contact", txt_search.Text);

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
