using SuperMarket.Classes;
using SuperMarket.Classes.Models;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
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
        private int EditedSupplierId = -1;

        private void Suppliers_Load(object sender, EventArgs e)
        {
            SetColors(Properties.Settings.Default.AppColor);
            LoadDataGrid(Classes.DataAccess.Suppliers.LoadSuppliers(true));

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
                label6,
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

        private void LoadDataGrid(List<SupplierModel> supplierModels)
        {
            suppliersDataGridView.DataSource = null;
            suppliersDataGridView.DataSource = supplierModels;

            suppliersDataGridView.Columns["Id"].HeaderText = "رقم التعريفي للمورد";
            suppliersDataGridView.Columns["SupplierName"].HeaderText = "اسم المورد";
            suppliersDataGridView.Columns["Contact"].HeaderText = "الاتصال";
            suppliersDataGridView.Columns["CreationDate"].HeaderText = "يوم اضافه المورد";
            suppliersDataGridView.Columns["Address"].HeaderText = "العنوان";
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
            if (txt_fullname.Text.Trim() != "" && txt_phone.Text.Trim() != "")
            {
                if (!btn_edit.Enabled)
                {
                    if (MessageBox.Show($"هل تريد ان تعدل {txt_fullname.Text} ", "انتظر",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Information) == DialogResult.Yes)
                    {
                        int supplierId = EditedSupplierId;
                        string SupplierName = Classes.DataAccess.Suppliers.GetSupplierParameter
                                ("Id", "" + supplierId).FirstOrDefault().Name;
                        SupplierModel supplier = new SupplierModel
                        {
                            Id = supplierId,
                            Name = txt_fullname.Text,
                            Address = txt_address.Text,
                            Contact = txt_phone.Text
                        };
                        Classes.DataAccess.Suppliers.UpdateSupplier(supplier);

                        LoadDataGrid(Classes.DataAccess.Suppliers.GetSupplierParameter("Id", "" + supplier.Id));

                        Logger.Log($"user has edited product: {SupplierName} with id: {supplierId}",
                            System.Reflection.MethodInfo.GetCurrentMethod().Name, this.Name, Logger.INFO);
                    }

                    ResetTextBoxes();
                    SetEditMode(false);
                }
                else
                {
                    string MsgResponse = $"هل تريد ان تحفظ {txt_fullname.Text} ";

                    var SupplierResult = Classes.DataAccess.Suppliers.GetSupplierParameter("Name", txt_fullname.Text);

                    if (SupplierResult.Count > 0)
                        MsgResponse += "لانه يوجد مورد بهذا الاسم";

                    if (MessageBox.Show(MsgResponse, "انتظر",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Information) == DialogResult.Yes)
                    {
                        SupplierModel supplier = new SupplierModel
                        {
                            Name = "" + txt_fullname.Text,
                            Address = "" + txt_address.Text,
                            Contact = "" + txt_phone.Text
                        };
                        Classes.DataAccess.Suppliers.SaveSupplier(supplier);

                        LoadDataGrid(Classes.DataAccess.Suppliers.LoadSuppliers(true));

                        ResetTextBoxes();

                        Logger.Log($"user added supplier: {supplier.Name}",
                            System.Reflection.MethodInfo.GetCurrentMethod().Name, this.Name, Logger.INFO);
                    }
                }
            }
            else
                MessageBox.Show("برجاء ادخال بيانات المورد من الاسم والعنوان وبيانات الاتصال", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void SetEditMode(bool State)
        {
            if (State)
            {
                btn_edit.BackColor = Color.Silver;
                btn_remove.BackColor = Color.Silver;
            }
            else
            {
                btn_edit.BackColor = Properties.Settings.Default.AppColor;
                btn_remove.BackColor = Properties.Settings.Default.AppColor;
                EditedSupplierId = -1;
            }

            btn_edit.Enabled = !State;
            btn_remove.Enabled = !State;
            pcb_searchName.Enabled = !State;
        }

        private void ResetTextBoxes()
        {
            txt_phone.Text = "";
            txt_address.Text = "";
            txt_fullname.Text = "";
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            if (suppliersDataGridView != null)
            {
                if (suppliersDataGridView.CurrentCell != null)
                {
                    int RowIndex = suppliersDataGridView.CurrentCell.RowIndex;

                    EditedSupplierId = int.Parse(suppliersDataGridView.Rows[RowIndex].Cells["Id"].Value.ToString());

                    string SupplierName = suppliersDataGridView.Rows[RowIndex].Cells["SupplierName"].Value.ToString(),
                        SupplierAddress = suppliersDataGridView.Rows[RowIndex].Cells["Address"].Value.ToString(),
                        SupplierContact = suppliersDataGridView.Rows[RowIndex].Cells["Contact"].Value.ToString();

                    Logger.Log($"user is editing supplier: {SupplierName} with id: {EditedSupplierId}",
                        System.Reflection.MethodInfo.GetCurrentMethod().Name, this.Name, Logger.INFO);

                    txt_fullname.Text = SupplierName;
                    txt_address.Text = SupplierAddress;
                    txt_phone.Text = SupplierContact;

                    SetEditMode(true);
                }
                else
                {
                    MessageBox.Show("يجب أن تختار منتج للتعديل", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btn_remove_Click(object sender, EventArgs e)
        {
            if (suppliersDataGridView != null)
            {
                if (suppliersDataGridView.CurrentCell != null)
                {
                    int rowindex = suppliersDataGridView.CurrentCell.RowIndex;
                    int SupplierId = int.Parse(suppliersDataGridView.Rows[rowindex].Cells["Id"].Value.ToString());
                    string SupplierName = suppliersDataGridView.Rows[rowindex].Cells["SupplierName"].Value.ToString();

                    Logger.Log($"user is trying to remove supplier: {SupplierName}",
                            System.Reflection.MethodInfo.GetCurrentMethod().Name, this.Name, Logger.INFO);

                    if (MessageBox.Show($"هل تريد ان تمسح {SupplierName}", "انتظر",
                                MessageBoxButtons.YesNo,
                                MessageBoxIcon.Information) == DialogResult.Yes)
                    {
                        Logger.Log($"user has removed supplier: {SupplierName} with id: {SupplierId}",
                               System.Reflection.MethodInfo.GetCurrentMethod().Name, this.Name, Logger.INFO);

                        Classes.DataAccess.Suppliers.RemoveSupplier(SupplierId);

                        LoadDataGrid(Classes.DataAccess.Suppliers.LoadSuppliers(true));
                    }
                }
            }
        }

        private void btn_exportPDF_Click(object sender, EventArgs e)
        {
            Forms.ReportViewer.SelectedReport = Forms.ReportViewer.AvailableReports.Suppliers;

            using (Forms.ReportViewer reportViewer = new Forms.ReportViewer())
            {
                reportViewer.ShowDialog();
                reportViewer.Dispose();
                reportViewer.Close();
            }
        }

        private void txt_suppliers_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                btn_save.PerformClick();
            }
        }

        private void pcb_searchName_Click(object sender, EventArgs e)
        {
            if (txt_fullname.Text.Trim() == "")
                LoadDataGrid(Classes.DataAccess.Suppliers.LoadSuppliers(true));

            else
            {
                Logger.Log($"user is searching for supplier name: {txt_fullname.Text}",
                    System.Reflection.MethodInfo.GetCurrentMethod().Name, this.Name, Logger.INFO);

                List<SupplierModel> supplierSearch =
                    Classes.DataAccess.Suppliers.GetSupplierParameter("Name", txt_fullname.Text);
                LoadDataGrid(supplierSearch);
            }
        }

        private void pcb_serchbyPhone_Click(object sender, EventArgs e)
        {
            if (txt_phone.Text.Trim() == "")
                LoadDataGrid(Classes.DataAccess.Suppliers.LoadSuppliers(true));

            else
            {
                Logger.Log($"user is searching for supplier contact: {txt_phone.Text}",
                    System.Reflection.MethodInfo.GetCurrentMethod().Name, this.Name, Logger.INFO);

                List<SupplierModel> supplierSearch =
                    Classes.DataAccess.Suppliers.GetSupplierParameter("Contact", txt_phone.Text);
                LoadDataGrid(supplierSearch);
            }
        }

        private void pcb_suppliers_DoubleClick(object sender, EventArgs e)
        {
            LoadDataGrid(Classes.DataAccess.Suppliers.LoadSuppliers(true));
        }

        private void suppliersDataGridView_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
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

        private async void suppliersDataGridView_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            //suppliersDataGridView.DataSource = new Methods().DataGridToDataTable(suppliersDataGridView);

            //suppliersDataGridView.Columns[e.ColumnIndex]

            //suppliersDataGridView.Sort(suppliersDataGridView.Columns[e.ColumnIndex], ListSortDirection.Ascending);
            //suppliersDataGridView.DataSource = Classes.DataAccess.Suppliers.LoadSuppliers(true).OrderBy(o => o.Address).ToList();


            //suppliersDataGridView.DataSource =
            //    Classes.DataAccess.Suppliers.LoadSuppliers(true).OrderBy(o => suppliersDataGridView.Columns[e.ColumnIndex].Name).ToList();

            System.Data.DataTable data = await new Methods().DataGridToDataTable(suppliersDataGridView);

            data.DefaultView.Sort = $"{suppliersDataGridView.Columns[e.ColumnIndex].Name} ASC";

            suppliersDataGridView.DataSource = data;
        }

        private async void suppliersDataGridView_ColumnHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            //suppliersDataGridView.DataSource = new Methods().DataGridToDataTable(suppliersDataGridView);

            ////suppliersDataGridView.Sort(suppliersDataGridView.Columns[e.ColumnIndex], ListSortDirection.Descending);


            //suppliersDataGridView.DataSource =
            //    Classes.DataAccess.Suppliers.LoadSuppliers(true).OrderBy(o => (suppliersDataGridView.Columns[e.ColumnIndex].Name)).ToList();

            System.Data.DataTable data = await new Methods().DataGridToDataTable(suppliersDataGridView);

            data.DefaultView.Sort = $"{suppliersDataGridView.Columns[e.ColumnIndex].Name} DESC";

            suppliersDataGridView.DataSource = data;
        }

        private void pcb_suppliers_MouseEnter(object sender, EventArgs e)
        {
            Control FocusedObject = (Control)sender;
            FocusedObject.BackColor = Properties.Settings.Default.AppColor;
        }

        private void pcb_suppliers_MouseLeave(object sender, EventArgs e)
        {
            Control FocusedObject = (Control)sender;
            FocusedObject.BackColor = Color.Transparent;
        }
    }
}
