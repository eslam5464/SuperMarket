using SuperMarket.Classes;
using SuperMarket.Classes.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SuperMarket.UserControls
{
    public partial class Suppliers : UserControl
    {
        public Suppliers()
        {
            InitializeComponent();
        }

        private ContextMenu contextMenu = new ContextMenu();
        private DataGridViewCell ContextMenuSelectedCell;

        private void Suppliers_Load(object sender, EventArgs e)
        {
            SetColors(Properties.Settings.Default.AppColor);
            LoadDataGrid(Classes.DataAccess.Products.LoadProducts(true));

            contextMenu = Methods.SetupContextMenuCopy(contextMenu, MenuItemCopyOption_Click);
        }

        private void MenuItemCopyOption_Click(Object sender, EventArgs e)
        {
            string CellText = suppliersDataGridView.Rows[ContextMenuSelectedCell.RowIndex].
                Cells[ContextMenuSelectedCell.ColumnIndex].Value.ToString();
            Clipboard.SetText(CellText);
        }

        private void SetColors(Color appColor)
        {
            Control[] AllControls =
            {
                btn_edit,
                btn_exportPDF,
                btn_remove,
                btn_save,
                label1,
                label3,
                label6
            };

            foreach (Control control in AllControls)
            {
                if (control.GetType() == typeof(Button))
                    control.BackColor = appColor;

                else if (control.GetType() == typeof(Label))
                    control.ForeColor = appColor;
            }

            suppliersDataGridView.ColumnHeadersDefaultCellStyle.BackColor = appColor;
        }

        private void LoadDataGrid(List<ProductModel> productModels)
        {
            suppliersDataGridView.DataSource = null;
            suppliersDataGridView.DataSource = productModels;

            suppliersDataGridView.Columns["Id"].HeaderText = "رقم التعريفي للمورد";
            suppliersDataGridView.Columns["SupplierName"].HeaderText = "اسم المورد";
            suppliersDataGridView.Columns["CreationDate"].HeaderText = "يوم اضافه المورد";
            suppliersDataGridView.Columns["CreationDate"].DefaultCellStyle.Format = "yyyy/MM/dd tt HH:mm:ss";

            suppliersDataGridView.AutoResizeColumns();
            suppliersDataGridView.Columns["CreationDate"].Width += 5;
        }

        private void suppliersBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.suppliersBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.superMarketDataSet);

        }

        private void suppliersBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.suppliersBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.superMarketDataSet);

        }

        private void btn_save_Click(object sender, EventArgs e)
        {

        }

        private void btn_edit_Click(object sender, EventArgs e)
        {

        }

        private void btn_remove_Click(object sender, EventArgs e)
        {

        }

        private void btn_exportPDF_Click(object sender, EventArgs e)
        {
            Forms.ReportViewer.SelectedReport = Forms.ReportViewer.ShownReport.Suppliers;

            using (Forms.ReportViewer reportViewer = new Forms.ReportViewer())
            {
                reportViewer.ShowDialog();
                reportViewer.Dispose();
                reportViewer.Close();
            }
        }

        private void txt_suppliers_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void pcb_searchName_Click(object sender, EventArgs e)
        {

        }

        private void pcb_searchName_DoubleClick(object sender, EventArgs e)
        {

        }

        private void pcb_serchbyPhone_Click(object sender, EventArgs e)
        {

        }

        private void pcb_serchbyPhone_DoubleClick(object sender, EventArgs e)
        {

        }

        private void productsDataGridView_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                int cellColumnIndex = suppliersDataGridView.CurrentCell.ColumnIndex;
                int cellRowIndex = suppliersDataGridView.CurrentCell.RowIndex;

                int CellX = suppliersDataGridView.GetCellDisplayRectangle(cellColumnIndex, cellRowIndex, false).Left;
                int CellY = suppliersDataGridView.GetCellDisplayRectangle(cellColumnIndex, cellRowIndex, false).Top;

                ContextMenuSelectedCell = (sender as DataGridView).Rows[cellRowIndex].Cells[cellColumnIndex];

                if (ContextMenuSelectedCell != null)
                {
                    contextMenu.Show(suppliersDataGridView, new Point(CellX, CellY));
                }
            }
        }

        private void productsDataGridView_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            productsDataGridView.DataSource = new Methods().DataGridToDataTable(productsDataGridView);

            productsDataGridView.Sort(productsDataGridView.Columns[e.ColumnIndex], ListSortDirection.Ascending);
        }

        private void productsDataGridView_ColumnHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            productsDataGridView.DataSource = new Methods().DataGridToDataTable(productsDataGridView);

            productsDataGridView.Sort(productsDataGridView.Columns[e.ColumnIndex], ListSortDirection.Descending);
        }
    }
}
