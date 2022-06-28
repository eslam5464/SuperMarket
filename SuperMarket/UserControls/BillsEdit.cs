using SuperMarket.Classes;
using System;
using System.ComponentModel;
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

        private ContextMenu contextMenu = new ContextMenu();
        private DataGridViewCell ContextMenuSelectedCell;

        private void MenuItemCopyOption_Click(Object sender, EventArgs e)
        {
            string CellText = db_probillsDataGridView.Rows[ContextMenuSelectedCell.RowIndex].
                Cells[ContextMenuSelectedCell.ColumnIndex].Value.ToString();
            Clipboard.SetText(CellText);
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

            contextMenu = Methods.SetupContextMenuCopy(contextMenu, MenuItemCopyOption_Click);
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

        private void db_probillsDataGridView_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            db_probillsDataGridView.DataSource = new Methods().DataGridToDataTable(db_probillsDataGridView);

            db_probillsDataGridView.Sort(db_probillsDataGridView.Columns[e.ColumnIndex], ListSortDirection.Ascending);
        }

        private void db_probillsDataGridView_ColumnHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            db_probillsDataGridView.DataSource = new Methods().DataGridToDataTable(db_probillsDataGridView);

            db_probillsDataGridView.Sort(db_probillsDataGridView.Columns[e.ColumnIndex], ListSortDirection.Descending);
        }

        private void db_probillsDataGridView_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                int cellColumnIndex = db_probillsDataGridView.CurrentCell.ColumnIndex;
                int cellRowIndex = db_probillsDataGridView.CurrentCell.RowIndex;

                int CellX = db_probillsDataGridView.GetCellDisplayRectangle(cellColumnIndex, cellRowIndex, false).Left;
                int CellY = db_probillsDataGridView.GetCellDisplayRectangle(cellColumnIndex, cellRowIndex, false).Top;

                ContextMenuSelectedCell = (sender as DataGridView).Rows[cellRowIndex].Cells[cellColumnIndex];

                if (ContextMenuSelectedCell != null)
                {
                    contextMenu.Show(db_probillsDataGridView, new Point(CellX, CellY));
                }
            }
        }
    }
}
