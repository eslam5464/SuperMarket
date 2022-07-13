using SuperMarket.Classes;
using SuperMarket.Classes.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace SuperMarket.UserControls
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
            ordersDataGridView.Columns["InvoiceDate"].HeaderText = "تاريخ الطلب";
            ordersDataGridView.Columns["InvoiceDate"].DefaultCellStyle.Format = "yyyy/MM/dd tt HH:mm:ss";
            ordersDataGridView.Columns["InvoiceId"].HeaderText = "رقم الفاتورة";
            ordersDataGridView.Columns["CustomerId"].HeaderText = "الرقم التعريفي للعميل";
            ordersDataGridView.Columns["CustomerName"].HeaderText = "اسم العميل";
            ordersDataGridView.Columns["ContactNumber"].HeaderText = "رقم الإتصال";
            ordersDataGridView.Columns["Address"].HeaderText = "العنوان";
            ordersDataGridView.Columns["GrandTotal"].HeaderText = "المجموع الكلي للفاتورة";
            ordersDataGridView.Columns["CreatedByUserFullName"].HeaderText = "اسم الموظف";

            ordersDataGridView.Columns["Id"].Visible = false;
            ordersDataGridView.Columns["CreatedByUserId"].Visible = false;

            ordersDataGridView.AutoResizeColumns();
            ordersDataGridView.Columns["InvoiceDate"].Width += 5;
        }

        private void SetColors(Color appColor)
        {
            label1.ForeColor = appColor;
            label2.ForeColor = appColor;
            btn_refresh.BackColor = appColor;
            ordersDataGridView.ColumnHeadersDefaultCellStyle.BackColor = appColor;
        }

        private void db_ordersDataGridView_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            ordersDataGridView.DataSource = new Methods().DataGridToDataTable(ordersDataGridView);

            ordersDataGridView.Sort(ordersDataGridView.Columns[e.ColumnIndex], ListSortDirection.Ascending);
        }

        private void db_ordersDataGridView_ColumnHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            ordersDataGridView.DataSource = new Methods().DataGridToDataTable(ordersDataGridView);

            ordersDataGridView.Sort(ordersDataGridView.Columns[e.ColumnIndex], ListSortDirection.Descending);
        }

        private void ordersBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.ordersBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.superMarketDataSet);

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

        private async void btn_exportPDF_Click(object sender, EventArgs e)
        {
            await Methods.ExportDGVtoPDF(ordersDataGridView, "الطلبات");
        }
    }
}
