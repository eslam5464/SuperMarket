using POSWarehouse.Classes;
using POSWarehouse.Classes.Models;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace POSWarehouse.UserControls
{
    public partial class Orders : UserControl
    {
        public Orders()
        {
            InitializeComponent();
        }

        private ContextMenu contextMenu = new ContextMenu();
        private DataGridViewCell ContextMenuSelectedCell;

        private void btn_refresh_Click(object sender, EventArgs e)
        {
            LoadDataGrid(Classes.DataAccess.Orders.GetAllOrders(true));

            Logger.Log($"user clicked on refresh",
                System.Reflection.MethodInfo.GetCurrentMethod().Name, this.Name, Logger.INFO);
        }

        private void pcb_search_by_MouseEnter(object sender, EventArgs e)
        {
            Control FocusedObject = (Control)sender;
            FocusedObject.BackColor = Properties.Settings.Default.AppColor;
        }

        private void pcb_search_by_MouseLeave(object sender, EventArgs e)
        {
            Control FocusedObject = (Control)sender;
            FocusedObject.BackColor = Color.Transparent;
        }

        private void Orders_Load(object sender, EventArgs e)
        {
            SetColors(Properties.Settings.Default.AppColor);
            LoadDataGrid(Classes.DataAccess.Orders.GetAllOrders(true));

            contextMenu = Methods.SetupContextMenuCopy(contextMenu, MenuItemCopyOption_Click);
        }

        private void MenuItemCopyOption_Click(Object sender, EventArgs e)
        {
            string CellText = ordersDataGridView.Rows[ContextMenuSelectedCell.RowIndex].
                Cells[ContextMenuSelectedCell.ColumnIndex].Value.ToString();
            Clipboard.SetText(CellText);
        }

        private void LoadDataGrid(List<OrderModel> Orders)
        {
            ordersDataGridView.DataSource = null;
            ordersDataGridView.DataSource = Orders;

            HideAndTranslateColums();
        }

        private void HideAndTranslateColums()
        {
            ordersDataGridView.Columns["InvoiceDateDataGridViewTextBoxColumn_"].HeaderText = "تاريخ الطلب";
            ordersDataGridView.Columns["InvoiceDateDataGridViewTextBoxColumn_"].DefaultCellStyle.Format = "yyyy/MM/dd tt HH:mm:ss";
            ordersDataGridView.Columns["InvoiceIdDataGridViewTextBoxColumn_"].HeaderText = "رقم الفاتورة";
            ordersDataGridView.Columns["CustomerIdDataGridViewTextBoxColumn_"].HeaderText = "الرقم التعريفي للعميل";
            ordersDataGridView.Columns["CustomerNameDataGridViewTextBoxColumn_"].HeaderText = "اسم العميل";
            ordersDataGridView.Columns["ContactNumberDataGridViewTextBoxColumn_"].HeaderText = "رقم الإتصال";
            ordersDataGridView.Columns["AddressDataGridViewTextBoxColumn_"].HeaderText = "العنوان";
            ordersDataGridView.Columns["GrandTotalDataGridViewTextBoxColumn_"].HeaderText = "المجموع الكلي للفاتورة";
            ordersDataGridView.Columns["CreatedByUserFullNameDataGridViewTextBoxColumn_"].HeaderText = "اسم الموظف";

            ordersDataGridView.Columns["IdDataGridViewTextBoxColumn_"].Visible = false;
            ordersDataGridView.Columns["CreatedByUserIdDataGridViewTextBoxColumn_"].Visible = false;

            ordersDataGridView.AutoResizeColumns();
            ordersDataGridView.Columns["InvoiceDateDataGridViewTextBoxColumn_"].Width += 5;
        }

        private void SetColors(Color appColor)
        {
            label1.ForeColor = appColor;
            label2.ForeColor = appColor;
            btn_refresh.BackColor = appColor;
            ordersDataGridView.ColumnHeadersDefaultCellStyle.BackColor = appColor;
        }

        private async void db_ordersDataGridView_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            //ordersDataGridView.DataSource = new Methods().DataGridToDataTable(ordersDataGridView);

            //ordersDataGridView.Sort(ordersDataGridView.Columns[e.ColumnIndex], ListSortDirection.Ascending);

            System.Data.DataTable data = await new Methods().DataGridToDataTable(ordersDataGridView);

            data.DefaultView.Sort = $"{ordersDataGridView.Columns[e.ColumnIndex].Name} ASC";

            ordersDataGridView.DataSource = data;
        }

        private async void db_ordersDataGridView_ColumnHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            //ordersDataGridView.DataSource = new Methods().DataGridToDataTable(ordersDataGridView);

            //ordersDataGridView.Sort(ordersDataGridView.Columns[e.ColumnIndex], ListSortDirection.Descending);

            System.Data.DataTable data = await new Methods().DataGridToDataTable(ordersDataGridView);

            data.DefaultView.Sort = $"{ordersDataGridView.Columns[e.ColumnIndex].Name} DESC";

            ordersDataGridView.DataSource = data;
        }

        private void ordersBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            //this.Validate();
            //this.ordersBindingSource.EndEdit();
            //this.tableAdapterManager.UpdateAll(this.superMarketDataSet);

        }

        private void txt_order_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
            }
        }

        private void pcb_search_by_customer_name_DoubleClick(object sender, EventArgs e)
        {
            LoadDataGrid(Classes.DataAccess.Orders.GetAllOrders(true));
        }

        private void pcb_search_by_invoiceno_DoubleClick(object sender, EventArgs e)
        {
            LoadDataGrid(Classes.DataAccess.Orders.GetAllOrders(true));
        }

        private void pcb_search_by_customer_name_Click(object sender, EventArgs e)
        {
            if (txt_customername.Text.Trim() != "")
            {
                Logger.Log($"user is trying to search by customer name for order: {txt_customername.Text}",
                               System.Reflection.MethodInfo.GetCurrentMethod().Name, this.Name, Logger.INFO);

                List<OrderModel> productSearch = Classes.DataAccess.Orders.GetOrderParameter("CustomerName", txt_customername.Text);

                LoadDataGrid(productSearch);

                HideAndTranslateColums();
            }
        }

        private void pcb_search_by_invoiceno_Click(object sender, EventArgs e)
        {
            if (txt_invoiceno.Text.Trim() != "")
            {
                Logger.Log($"user is trying to search by invoice number for order: {txt_invoiceno.Text}",
                               System.Reflection.MethodInfo.GetCurrentMethod().Name, this.Name, Logger.INFO);

                List<OrderModel> productSearch = Classes.DataAccess.Orders.GetOrderParameter("InvoiceId", txt_invoiceno.Text);

                LoadDataGrid(productSearch);

                HideAndTranslateColums();
            }
        }

        private void txt_invoiceno_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void ordersDataGridView_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                int cellColumnIndex = ordersDataGridView.CurrentCell.ColumnIndex;
                int cellRowIndex = ordersDataGridView.CurrentCell.RowIndex;

                int CellX = ordersDataGridView.GetCellDisplayRectangle(cellColumnIndex, cellRowIndex, false).Left;
                int CellY = ordersDataGridView.GetCellDisplayRectangle(cellColumnIndex, cellRowIndex, false).Top;

                ContextMenuSelectedCell = (sender as DataGridView).Rows[cellRowIndex].Cells[cellColumnIndex];

                if (ContextMenuSelectedCell != null)
                {
                    contextMenu.Show(ordersDataGridView, new Point(CellX, CellY));
                }
            }
        }

        private void btn_exportPDF_Click(object sender, EventArgs e)
        {
            //await Methods.ExportDGVtoPDF(ordersDataGridView, "الطلبات");
            Forms.ReportViewer.SelectedReport = Forms.ReportViewer.AvailableReports.Users;

            using (Forms.ReportViewer reportViewer = new Forms.ReportViewer())
            {
                reportViewer.ShowDialog();
                reportViewer.Dispose();
                reportViewer.Close();
            }
        }
    }
}
