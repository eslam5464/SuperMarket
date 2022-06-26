using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace SuperMarket.UserControls
{
    public partial class BillsEdit : UserControl
    {
        public BillsEdit()
        {
            InitializeComponent();
        }

        public void SetFocusOnBarCode()
        {
            txt_productBarCode.Focus();
        }

        private void pcb_search_MouseEnter(object sender, EventArgs e)
        {
            Control FocusedObject = (Control)sender;
            FocusedObject.BackColor = Properties.Settings.Default.AppColor;
        }

        private void pcb_search_MouseLeave(object sender, EventArgs e)
        {
            Control FocusedObject = (Control)sender;
            FocusedObject.BackColor = Color.Gainsboro;
        }

        private void BillsEdit_Load(object sender, EventArgs e)
        {
            SetColors(Properties.Settings.Default.AppColor);
            //dtp_invoicedate.Text = DateTime.Now.ToString();
            //dtp_invoicedate.CustomFormat = DateTime.Now.ToString("dd/MM/yyyy hh:mm:ss tt", new System.Globalization.CultureInfo("ar-AE"));
        }

        private void SetColors(Color appColor)
        {
            Label[] AllLabels = {
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
                label12,
                label13,
            };

            Button[] AllButtons = {
                btn_addToBill,
                btn_removeFromBill
            };

            foreach (Label label in AllLabels)
                label.ForeColor = appColor;

            foreach (Button button in AllButtons)
                button.BackColor = appColor;

            db_probillsDataGridView.ColumnHeadersDefaultCellStyle.BackColor = appColor;
        }

        private void btn_removeFromBill_Click(object sender, EventArgs e)
        {

        }

        private void btn_addToBill_Click(object sender, EventArgs e)
        {

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

        private void db_probillsDataGridView_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            db_probillsDataGridView.DataSource = TransformDataToDataTable(db_probillsDataGridView);

            db_probillsDataGridView.Sort(db_probillsDataGridView.Columns[e.ColumnIndex], ListSortDirection.Ascending);
        }

        private void db_probillsDataGridView_ColumnHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            db_probillsDataGridView.DataSource = TransformDataToDataTable(db_probillsDataGridView);

            db_probillsDataGridView.Sort(db_probillsDataGridView.Columns[e.ColumnIndex], ListSortDirection.Descending);
        }
    }
}
