using SuperMarket.Classes;
using SuperMarket.Classes.Models;
using SuperMarket.Forms;
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

            LoadDataGrid(Classes.DataAccess.SafeTransactions.LoadSafeTransactions(true, "DESC"));

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
            db_safeTransactionDataGridView.DataSource = null;
            db_safeTransactionDataGridView.DataSource = safeTransactionModels;

            db_safeTransactionDataGridView.Columns["Id"].HeaderText = "رقم التصنيف";
            db_safeTransactionDataGridView.Columns["SafeName"].HeaderText = "اسم الخزنة";
            db_safeTransactionDataGridView.Columns["AmountAdded"].HeaderText = "المبلغ المضاف";
            db_safeTransactionDataGridView.Columns["AmountTotal"].HeaderText = "المبلغ الكلي بعد الاضافه";
            db_safeTransactionDataGridView.Columns["AdjustedByUserFullName"].HeaderText = "منفذ المعامله";
            db_safeTransactionDataGridView.Columns["Notes"].HeaderText = "الملاحظات";
            db_safeTransactionDataGridView.Columns["CreationDate"].HeaderText = "يوم اضافه المعامله";
            db_safeTransactionDataGridView.Columns["CreationDate"].DefaultCellStyle.Format = "yyyy/MM/dd tt HH:mm:ss";

            db_safeTransactionDataGridView.Columns["SafeId"].Visible = false;
            db_safeTransactionDataGridView.Columns["AdjustedByUserId"].Visible = false;

            db_safeTransactionDataGridView.AutoResizeColumns();
            db_safeTransactionDataGridView.Columns["CreationDate"].Width += 5;
        }

        private void SetColors(Color appColor)
        {
            Control[] AllControls =
            {
                label2,
                label4,
                label5,
                label6,
                label7,
                label8,
                label9,
                btn_safeTransactionRemove,
                btn_exportPDF,
                btn_safeDelete,
                btn_safeEdit,
                btn_safeSave,
                btn_safeTransactionSave
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

            List<SafeModel> SearchedSafe = await Classes.DataAccess.Safe.GetSafeParameter("Name", safeModel.Name);

            if (SearchedSafe.Count == 0)
            {
                await Classes.DataAccess.Safe.SaveSafe(safeModel);

                RefreshComboBoxes();
            }
            else
            {
                MessageBox.Show($"لا يمكنك الحفظ لانه يوجد خزنه بهذا الاسم", "خطأ",
                         MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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

        private void btn_safeTransactionSave_Click(object sender, EventArgs e)
        {
            if (txt_safeTransactionNameSearch.SelectedIndex != -1)
            {
                if (num_safeTransactionAmount.Value != 0 && txt_safeTransactionNotes.Text.Trim() != "")
                {
                    List<SafeTransactionModel> AllSafeTransactions =
                        Classes.DataAccess.SafeTransactions.GetSafeTransactionParameter("SafeName", txt_safeTransactionNameSearch.Text, "ASC");

                    if (AllSafeTransactions.Count == 0)
                    {
                        SafeTransactionModel safeTransactionModel = new SafeTransactionModel()
                        {
                            AdjustedByUserId = Main.LoggedUser.Id,
                            AdjustedByUserFullName = Main.LoggedUserEnc.FullName,
                            AmountAdded = num_safeTransactionAmount.Value,
                            AmountTotal = num_safeTransactionAmount.Value,
                            Notes = txt_safeTransactionNotes.Text,
                            SafeId = int.Parse(txt_safeTransactionNameSearch.SelectedValue.ToString()),
                            SafeName = txt_safeTransactionNameSearch.Text
                        };
                        Classes.DataAccess.SafeTransactions.SaveSafeTransaction(safeTransactionModel);
                    }
                    else
                    {
                        SafeTransactionModel safeTransactionModel = new SafeTransactionModel()
                        {
                            AdjustedByUserId = Main.LoggedUser.Id,
                            AdjustedByUserFullName = Main.LoggedUserEnc.FullName,
                            AmountAdded = num_safeTransactionAmount.Value,
                            AmountTotal = AllSafeTransactions[AllSafeTransactions.Count - 1].AmountTotal + num_safeTransactionAmount.Value,
                            Notes = txt_safeTransactionNotes.Text,
                            SafeId = int.Parse(txt_safeTransactionNameSearch.SelectedValue.ToString()),
                            SafeName = txt_safeTransactionNameSearch.Text
                        };
                        Classes.DataAccess.SafeTransactions.SaveSafeTransaction(safeTransactionModel);
                    }

                    LoadDataGrid(Classes.DataAccess.SafeTransactions.LoadSafeTransactions(true, "DESC"));

                    ResetTransactionTextBoxes();
                }
                else
                {
                    MessageBox.Show($"برجاء اكمل بيانات المعامله من المال الذي لا يساوي صفر والملاحظات", "خطأ",
                         MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show($"برجاء اختيار الخزنة", "خطأ",
                         MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ResetTransactionTextBoxes()
        {
            txt_safeTransactionId.Text = "";
            txt_safeTransactionNotes.Text = "";
            num_safeTransactionAmount.Value = 0;
            txt_safeTransactionNameSearch.SelectedIndex = -1;
        }

        private void pcb_searchSafeName_Click(object sender, EventArgs e)
        {
            if (txt_safeTransactionNameSearch.SelectedIndex != -1)
            {
                List<SafeTransactionModel> SearchedSafe =
                    Classes.DataAccess.SafeTransactions.GetSafeTransactionParameter("SafeName", txt_safeTransactionNameSearch.Text, "DESC");

                if (SearchedSafe.Count != 0)
                {
                    LoadDataGrid(SearchedSafe);
                }
                else
                {
                    MessageBox.Show($"لا يوجد معاملات لهذه الخزنه", "خطأ",
                         MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show($"برجاء اختيار اسم الخزنه قبل البحث", "خطأ",
                         MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void pcb_searchID_Click(object sender, EventArgs e)
        {
            if (txt_safeTransactionId.Text.Trim() != "")
            {
                List<SafeTransactionModel> SearchedSafe =
                    Classes.DataAccess.SafeTransactions.GetSafeTransactionParameter("Id", txt_safeTransactionId.Text, "DESC");

                if (SearchedSafe.Count != 0)
                {
                    LoadDataGrid(SearchedSafe);
                }
                else
                {
                    MessageBox.Show($"لا يوجد بيانات لرقم التصنيف هذا", "خطأ",
                         MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void pcb_search_DoubleClick(object sender, EventArgs e)
        {
            LoadDataGrid(Classes.DataAccess.SafeTransactions.LoadSafeTransactions(true, "DESC"));
        }

        private void btn_safeTransactionRemove_Click(object sender, EventArgs e)
        {
            if (db_safeTransactionDataGridView.DataSource != null && db_safeTransactionDataGridView.CurrentCell != null)
            {
                int rowindex = db_safeTransactionDataGridView.CurrentCell.RowIndex;
                int SafeTransactionId = int.Parse(db_safeTransactionDataGridView.Rows[rowindex].Cells["Id"].Value.ToString());

                if (MessageBox.Show($"هل تريد ان تحذف المعامله رقم {SafeTransactionId}", "انتظر",
                           MessageBoxButtons.YesNo,
                           MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    List<SafeTransactionModel> datasource = (List<SafeTransactionModel>)db_safeTransactionDataGridView.DataSource;
                    //db_safeTransactionDataGridView.DataSource = null;
                    //datasource.Remove(datasource.Find(SafeTransaction => SafeTransaction.Id == SafeTransactionId));
                    //db_safeTransactionDataGridView.DataSource = datasource;
                    Classes.DataAccess.SafeTransactions.RemoveSafeTransaction(SafeTransactionId);
                    LoadDataGrid(Classes.DataAccess.SafeTransactions.LoadSafeTransactions(true, "DESC"));
                }
            }
            else
                MessageBox.Show("رجاء اختيار منتج أولا قبل الحذف", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btn_exportPDF_Click(object sender, EventArgs e)
        {
            Forms.ReportViewer.SelectedReport = Forms.ReportViewer.AvailableReports.Safe;

            using (Forms.ReportViewer reportViewer = new Forms.ReportViewer())
            {
                reportViewer.ShowDialog();
                reportViewer.Dispose();
                reportViewer.Close();
            }
        }

        private async void db_safeTransactionDataGridView_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            System.Data.DataTable data = await new Methods().DataGridToDataTable(db_safeTransactionDataGridView);

            data.DefaultView.Sort = $"{db_safeTransactionDataGridView.Columns[e.ColumnIndex].Name} ASC";

            db_safeTransactionDataGridView.DataSource = data;
        }

        private async void db_safeTransactionDataGridView_ColumnHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            System.Data.DataTable data = await new Methods().DataGridToDataTable(db_safeTransactionDataGridView);

            data.DefaultView.Sort = $"{db_safeTransactionDataGridView.Columns[e.ColumnIndex].Name} DESC";

            db_safeTransactionDataGridView.DataSource = data;
        }

        private async void btn_safeDelete_Click(object sender, EventArgs e)
        {
            if (txt_safeNameEdit.SelectedIndex != -1)
            {
                if (MessageBox.Show($"هل انت متأكد من مسح < {txt_safeNameEdit.Text} >", "انتظر",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    await Classes.DataAccess.Safe.RemoveSafe(int.Parse(txt_safeNameEdit.SelectedValue.ToString()));
                    RefreshComboBoxes();
                }
            }
            else
                MessageBox.Show("برجاءاختيار خزنه للحذف", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private async void btn_safeEdit_Click(object sender, EventArgs e)
        {
            if (txt_safeNameEdit.SelectedIndex != -1)
            {
                string SafeNameEditResult = Microsoft.VisualBasic.Interaction.InputBox("",
                    $"تعديل اسم الخزنه {txt_safeNameEdit.Text}", txt_safeNameEdit.Text);

                if (SafeNameEditResult != "")
                {
                    List<SafeModel> SafeSearch = await
                        Classes.DataAccess.Safe.GetSafeParameter("Id", txt_safeNameEdit.SelectedValue.ToString());

                    if (SafeSearch.Count > 0)
                    {
                        SafeSearch[0].Name = SafeNameEditResult;
                        await Classes.DataAccess.Safe.UpdateSafe(SafeSearch[0]);
                        RefreshComboBoxes();
                        MessageBox.Show("تم التعديل", "عمليه ناجحه", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("لا يمكن تعديل اسم الخزنة لانه غير موجود", "حدث خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
                MessageBox.Show("برجاءاختيار خزنه للتعديل", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
