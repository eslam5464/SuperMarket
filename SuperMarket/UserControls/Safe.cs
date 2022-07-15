using SuperMarket.Classes;
using SuperMarket.Classes.Models;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace SuperMarket.UserControls
{
    public partial class Safe : UserControl
    {
        private ContextMenu contextMenu = new ContextMenu();
        private DataGridViewCell ContextMenuSelectedCell;

        public Safe()
        {
            InitializeComponent();
        }

        private void Safe_Load(object sender, System.EventArgs e)
        {
            SetColors(Properties.Settings.Default.AppColor);

            LoadDataGrid(Classes.DataAccess.SafeTransactions.LoadSafeTransactions(true));

            RefreshComboBoxes();

            contextMenu = Methods.SetupContextMenuCopy(contextMenu, MenuItemCopyOption_Click);
        }

        private void MenuItemCopyOption_Click(Object sender, EventArgs e)
        {
            string CellText = db_safeTransactionDataGridView.Rows[ContextMenuSelectedCell.RowIndex].
                Cells[ContextMenuSelectedCell.ColumnIndex].Value.ToString();
            Clipboard.SetText(CellText);
        }

        private void RefreshComboBoxes()
        {
            ComboBox[] AllComboBoxes =
             {
                txt_safeTransactionNameSearch,
                txt_safeNameEdit,
            };

            List<SafeModel> AllStoragesData;

            foreach (ComboBox comboBox in AllComboBoxes)
            {
                AllStoragesData = Classes.DataAccess.Safe.LoadSafe();
                comboBox.DataSource = null;
                comboBox.DataSource = AllStoragesData;
                comboBox.ValueMember = "Id";
                comboBox.DisplayMember = "Name";
                comboBox.SelectedIndex = -1;
            }
        }

        private void LoadDataGrid(List<SafeTransactionModel> safeTransactionModels)
        {
            //throw new NotImplementedException();
        }

        private void SetColors(Color appColor)
        {
            Control[] AllControls =
            {
                label2,
                label3,
                label4,
                label5,
                label6,
                label7,
                label8,
                label9,
                btn_categoryEdit,
                btn_CategoryRemove,
                btn_exportPDF,
                btn_safeDelete,
                btn_safeEdit,
                btn_safeSave,
                btn_saveCategory
            };

            foreach (Control control in AllControls)
            {
                if (control.GetType() == typeof(Button))
                    control.BackColor = appColor;

                else if (control.GetType() == typeof(Label))
                    control.ForeColor = appColor;
            }

            db_safeTransactionDataGridView.ColumnHeadersDefaultCellStyle.BackColor = appColor;
        }

        private void pcb_search_MouseEnter(object sender, EventArgs e)
        {
            Control FocusedObject = (Control)sender;
            FocusedObject.BackColor = Properties.Settings.Default.AppColor;

        }

        private void pcb_search_MouseLeave(object sender, EventArgs e)
        {
            Control FocusedObject = (Control)sender;
            FocusedObject.BackColor = Color.Transparent;
        }

        private async void btn_safeSave_Click(object sender, EventArgs e)
        {
            SafeModel safeModel = new SafeModel()
            {
                Name = txt_safeName.Text
            };

            await Classes.DataAccess.Safe.SaveSafe(safeModel);
        }

        private void db_safeTransactionDataGridView_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                int cellColumnIndex = db_safeTransactionDataGridView.CurrentCell.ColumnIndex;
                int cellRowIndex = db_safeTransactionDataGridView.CurrentCell.RowIndex;

                int CellX = db_safeTransactionDataGridView.GetCellDisplayRectangle(cellColumnIndex, cellRowIndex, false).Left;
                int CellY = db_safeTransactionDataGridView.GetCellDisplayRectangle(cellColumnIndex, cellRowIndex, false).Top;

                ContextMenuSelectedCell = (sender as DataGridView).Rows[cellRowIndex].Cells[cellColumnIndex];

                if (ContextMenuSelectedCell != null)
                {
                    contextMenu.Show(db_safeTransactionDataGridView, new Point(CellX, CellY));
                }
            }
        }

        private void txt_safeTransaction_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Return)
            {
                e.SuppressKeyPress = true;
            }
        }

        private void txt_safeTransactionAmount_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.') && (e.KeyChar != '-'))
            {
                e.Handled = true;
            }

            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }
    }
}
