using SuperMarket.Classes;
using SuperMarket.Classes.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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

        private void btn_refresh_Click(object sender, EventArgs e)
        {
            LoadDataGrid(Classes.DataAccess.Orders.GetAllOrders());

            Logger.Log($"user clicked on refresh",
                System.Reflection.MethodInfo.GetCurrentMethod().Name, this.Name, Logger.INFO);
        }

        private void pcb_search_by_customer_name_Click(object sender, EventArgs e)
        {
            //if (txt_customername.Text.Trim() == "")
            //    LoadDataGrid(Classes.DataAccess.Customers.LoadCustomers());

            //else
            //{
            //    List<CustomerModel> customerSearch = Classes.DataAccess.Customers.GetCustomerParameter("Name", txt_customername.Text);
            //    LoadDataGrid(customerSearch);
            //}
        }

        private void pcb_search_by_invoiceno_Click(object sender, EventArgs e)
        {
            //if (txt_customername.Text.Trim() == "")
            //    LoadDataGrid(Classes.DataAccess.Customers.LoadCustomers());

            //else
            //{
            //    List<CustomerModel> customerSearch = Classes.DataAccess.Customers.GetCustomerParameter("Name", txt_customername.Text);
            //    LoadDataGrid(customerSearch);
            //}
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
            LoadDataGrid(Classes.DataAccess.Orders.GetAllOrders());
        }

        private void LoadDataGrid(List<OrderModel> Orders)
        {
            db_ordersDataGridView.DataSource = null;
            db_ordersDataGridView.DataSource = Orders;

            db_ordersDataGridView.Columns["InvoiceDate"].HeaderText = "تاريخ الطلب";
            db_ordersDataGridView.Columns["InvoiceId"].HeaderText = "رقم الفاتورة";
            db_ordersDataGridView.Columns["CustomerId"].HeaderText = "الرقم التعريفي للعميل";
            db_ordersDataGridView.Columns["CustomerName"].HeaderText = "اسم العميل";
            db_ordersDataGridView.Columns["ContactNumber"].HeaderText = "رقم الإتصال";
            db_ordersDataGridView.Columns["Address"].HeaderText = "العنوان";
            db_ordersDataGridView.Columns["GrandTotal"].HeaderText = "المجموع الكلي للفاتورة";

            db_ordersDataGridView.Columns["Id"].Visible = false;

            db_ordersDataGridView.AutoResizeColumns();
            db_ordersDataGridView.Columns["InvoiceDate"].Width += 5;
        }

        private void SetColors(Color appColor)
        {
            label1.ForeColor = appColor;
            label2.ForeColor = appColor;
            btn_refresh.BackColor = appColor;
            db_ordersDataGridView.ColumnHeadersDefaultCellStyle.BackColor = appColor;
        }

        private DataTable TransformDataToDataTable(DataGridView dataGridView)
        {
            DataTable dataTable = new DataTable();

            foreach (DataGridViewColumn column in dataGridView.Columns)
            {
                dataTable.Columns.Add(column.Name, column.ValueType);
            }

            foreach (DataGridViewRow row in dataGridView.Rows)
            {
                dataTable.Rows.Add();
                foreach (DataGridViewCell cell in row.Cells)
                {
                    dataTable.Rows[dataTable.Rows.Count - 1][cell.ColumnIndex] = cell.Value.ToString();
                }
            }
            return dataTable;
        }

        private void db_ordersDataGridView_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            db_ordersDataGridView.DataSource = TransformDataToDataTable(db_ordersDataGridView);

            db_ordersDataGridView.Sort(db_ordersDataGridView.Columns[e.ColumnIndex], ListSortDirection.Ascending);
        }

        private void db_ordersDataGridView_ColumnHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            db_ordersDataGridView.DataSource = TransformDataToDataTable(db_ordersDataGridView);

            db_ordersDataGridView.Sort(db_ordersDataGridView.Columns[e.ColumnIndex], ListSortDirection.Descending);
        }
    }
}
