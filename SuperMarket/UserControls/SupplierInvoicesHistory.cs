using POSWarehouse.Classes.Models;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace POSWarehouse.UserControls
{
    public partial class SupplierInvoicesHistory : UserControl
    {
        public SupplierInvoicesHistory()
        {
            InitializeComponent();
        }

        private async void SupplierInvoicesHistory_Load(object sender, EventArgs e)
        {
            //SetColors(Properties.Settings.Default.AppColor);

            LoadDataGrid(await Classes.DataAccess.SupplierInvoices.LoadSupplierInvoices(true));
        }

        private void LoadDataGrid(List<SupplierInvoiceModel> supplierInvoice)
        {
            db_supplierInvoicesDataGridView.DataSource = null;
            db_supplierInvoicesDataGridView.DataSource = supplierInvoice;

            db_supplierInvoicesDataGridView.Columns["Id"].HeaderText = "رقم التصنيف";
            db_supplierInvoicesDataGridView.Columns["SupplierId"].HeaderText = "رقم التعريفي للمورد";
            db_supplierInvoicesDataGridView.Columns["SupplierName"].HeaderText = "اسم المورد";
            db_supplierInvoicesDataGridView.Columns["PaymentMethod"].HeaderText = "طريقه الدفع";
            db_supplierInvoicesDataGridView.Columns["AmountPaid"].HeaderText = "المبلغ المدفوع";
            db_supplierInvoicesDataGridView.Columns["AmountLeft"].HeaderText = "المبلغ المتبقي";
            db_supplierInvoicesDataGridView.Columns["AmountTotal"].HeaderText = "المبلغ المطلوب";
            db_supplierInvoicesDataGridView.Columns["PaymentStatus"].HeaderText = "حاله الدفع";
            db_supplierInvoicesDataGridView.Columns["CreationDate"].HeaderText = "تاريخ الانشاء";
            db_supplierInvoicesDataGridView.Columns["CreationDate"].DefaultCellStyle.Format = "yyyy/MM/dd tt HH:mm:ss";

            db_supplierInvoicesDataGridView.Columns["SupplierInvoiceProductId"].Visible = false;

            db_supplierInvoicesDataGridView.AutoResizeColumns();
            db_supplierInvoicesDataGridView.Columns["CreationDate"].Width += 5;
        }

        private void SetColors(Color appColor)
        {
            throw new NotImplementedException();
        }

        private async void btn_refresh_Click(object sender, EventArgs e)
        {
            LoadDataGrid(await Classes.DataAccess.SupplierInvoices.LoadSupplierInvoices(true));
        }

        private void pcb_supplierInvoicesHistory_MouseEnter(object sender, EventArgs e)
        {
            Control FocusedObject = (Control)sender;
            FocusedObject.BackColor = Properties.Settings.Default.AppColor;
        }

        private void pcb_supplierInvoicesHistory_MouseLeave(object sender, EventArgs e)
        {
            Control FocusedObject = (Control)sender;
            FocusedObject.BackColor = Color.Transparent;
        }
        //MessageBox.Show("برجاء اختيار المخزن", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);

        private async void pcb_search_by_supplier_name_Click(object sender, EventArgs e)
        {
            if (txt_supplierName.Text.Trim() == "")
            {
                LoadDataGrid(await Classes.DataAccess.SupplierInvoices.LoadSupplierInvoices(true));
            }
            else
            {
                List<SupplierInvoiceModel> SearchedSupplierInvoices =
                  await Classes.DataAccess.SupplierInvoices.GetSupplierInvoiceParameterLike("SupplierName", txt_supplierName.Text.Trim());

                LoadDataGrid(SearchedSupplierInvoices);
            }
        }
    }
}
