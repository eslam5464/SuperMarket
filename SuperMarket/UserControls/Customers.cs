using POSWarehouse.Classes;
using POSWarehouse.Classes.Models;
using POSWarehouse.Forms;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace POSWarehouse.UserControls
{
    public partial class Customers : UserControl
    {
        public Customers()
        {
            InitializeComponent();
        }

        private ContextMenu contextMenu = new ContextMenu();
        private DataGridViewCell ContextMenuSelectedCell;

        internal void LoadDataGrid(List<CustomerModel> Customers, DataGridView dataGridView)
        {
            dataGridView.DataSource = null;
            dataGridView.DataSource = Customers;

            dataGridView.Columns["IdDataGridViewTextBoxColumn_"].HeaderText = "الرقم التعريفي للعميل";
            dataGridView.Columns["NameDataGridViewTextBoxColumn_"].HeaderText = "اسم العميل";
            dataGridView.Columns["ContactNoDataGridViewTextBoxColumn_"].HeaderText = "رقم الاتصال";
            dataGridView.Columns["AddressDataGridViewTextBoxColumn_"].HeaderText = "العنوان";
            dataGridView.Columns["CreationDateDataGridViewTextBoxColumn_"].HeaderText = "يوم اضافه العميل";
            dataGridView.Columns["CreationDateDataGridViewTextBoxColumn_"].DefaultCellStyle.Format = "yyyy/MM/dd tt HH:mm:ss";

            dataGridView.AutoResizeColumns();
            dataGridView.Columns["CreationDateDataGridViewTextBoxColumn_"].Width += 5;
        }

        private async void btn_save_Click(object sender, EventArgs e)
        {
            try
            {
                if (txt_customername.Text.Trim() == "" && txt_contact.Text.Trim() == "" && txt_address.Text.Trim() == "")
                {
                    new Notification().ShowAlert($"برجاء ادخال جميع بيانات العميل من الاسم ورقم التواصل والعنوان",
                        Notification.EnmType.Error);
                }
                else
                {

                    if (!txt_customerid.Enabled)
                    {
                        Logger.Log($"user is trying to edit {txt_customername.Text}",
                            System.Reflection.MethodInfo.GetCurrentMethod().Name, this.Name, Logger.INFO);

                        if (MessageBox.Show($"هل تريد ان تعدل {txt_customername.Text} ", "انتظر",
                            MessageBoxButtons.YesNo,
                            MessageBoxIcon.Information) == DialogResult.Yes)
                        {
                            CustomerModel customer = new CustomerModel
                            {
                                Id = long.Parse(txt_customerid.Text),
                                Name = txt_customername.Text,
                                Address = txt_address.Text,
                                ContactNo = txt_contact.Text
                            };
                            await Classes.DataAccess.Customers.UpdateCustomer(customer);

                            LoadDataGrid(Classes.DataAccess.Customers.GetCustomerParameter("Id", "" + customer.Id), customersDataGridView);

                            Logger.Log($"user has edited customer with id: {customer.Id}",
                                System.Reflection.MethodInfo.GetCurrentMethod().Name, this.Name, Logger.INFO);
                        }

                        ResetTextBoxes();

                        SetEditMode(false);
                    }
                    else
                    {
                        string MsgResponse = $"هل تريد اضافه هذا العميل {txt_customername.Text} ";

                        var CustomerResult = Classes.DataAccess.Customers.GetCustomerParameter("Name", txt_customername.Text);

                        if (CustomerResult.Count > 0)
                            MsgResponse += "لانه يوجد عميل بهذا الاسم";

                        if (MessageBox.Show(MsgResponse, "انتظر",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Information) == DialogResult.Yes)
                        {
                            CustomerModel customer = new CustomerModel
                            {
                                Name = txt_customername.Text,
                                Address = txt_address.Text,
                                ContactNo = txt_contact.Text
                            };
                            await Classes.DataAccess.Customers.SaveCustomer(customer);

                            LoadDataGrid(Classes.DataAccess.Customers.LoadCustomers(true), customersDataGridView);

                            ResetTextBoxes();

                            Logger.Log($"user has added customer: {customer.Name}",
                                System.Reflection.MethodInfo.GetCurrentMethod().Name, this.Name, Logger.INFO);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Logger.Log($"while saving customer & error: {ex.Message}",
                                System.Reflection.MethodInfo.GetCurrentMethod().Name, this.Name, Logger.INFO);

                MessageBox.Show(ex.Message);
            }
        }

        private void ResetTextBoxes()
        {
            txt_address.Text = "";
            txt_contact.Text = "";
            txt_customername.Text = "";
        }

        private void pcb_searchName_Click(object sender, EventArgs e)
        {
            if (txt_customername.Text.Trim() == "")
                LoadDataGrid(Classes.DataAccess.Customers.LoadCustomers(true), customersDataGridView);

            else
            {
                Logger.Log($"user is trying to search for customer with name {txt_contact.Text}",
                    System.Reflection.MethodInfo.GetCurrentMethod().Name, this.Name, Logger.INFO);

                List<CustomerModel> customerSearch = Classes.DataAccess.Customers.GetCustomerParameter("Name", txt_customername.Text);
                LoadDataGrid(customerSearch, customersDataGridView);
            }
        }

        private void pcb_searchPhone_Click(object sender, EventArgs e)
        {
            if (txt_contact.Text.Trim() == "")
                LoadDataGrid(Classes.DataAccess.Customers.LoadCustomers(true), customersDataGridView);

            else
            {
                Logger.Log($"user is trying to search for customer with phone {txt_contact.Text}",
                    System.Reflection.MethodInfo.GetCurrentMethod().Name, this.Name, Logger.INFO);

                List<CustomerModel> customerSearch = Classes.DataAccess.Customers.GetCustomerParameterLike("ContactNo", txt_contact.Text);
                LoadDataGrid(customerSearch, customersDataGridView);
            }
        }

        internal void CheckUserAccess()
        {
            if (!Main.LoggedUserAccess.Reports)
            {
                btn_exportPDF.Enabled = false;
            }
        }

        private void Customers_Load(object sender, EventArgs e)
        {
            SetColors(Properties.Settings.Default.AppColor);

            LoadDataGrid(Classes.DataAccess.Customers.LoadCustomers(true), customersDataGridView);

            contextMenu = Methods.SetupContextMenuCopy(contextMenu, MenuItemCopyOption_Click);
        }

        private void MenuItemCopyOption_Click(Object sender, EventArgs e)
        {
            string CellText = customersDataGridView.Rows[ContextMenuSelectedCell.RowIndex].
                Cells[ContextMenuSelectedCell.ColumnIndex].Value.ToString();
            Clipboard.SetText(CellText);
        }

        private void SetColors(Color appColor)
        {
            label1.ForeColor = appColor;
            label2.ForeColor = appColor;
            label3.ForeColor = appColor;
            label4.ForeColor = appColor;
            btn_save.BackColor = appColor;
            btn_remove.BackColor = appColor;
            btn_edit.BackColor = appColor;
            customersDataGridView.ColumnHeadersDefaultCellStyle.BackColor = appColor;
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            if (customersDataGridView != null)
            {
                if (customersDataGridView.CurrentCell != null)
                {
                    int rowindex = customersDataGridView.CurrentCell.RowIndex;

                    long CustomerID = long.Parse(customersDataGridView.Rows[rowindex].Cells["IdDataGridViewTextBoxColumn_"].Value.ToString());
                    string CustomerName = customersDataGridView.Rows[rowindex].Cells["NameDataGridViewTextBoxColumn_"].Value.ToString(),
                     CustomerAddress = customersDataGridView.Rows[rowindex].Cells["AddressDataGridViewTextBoxColumn_"].Value.ToString(),
                     CustomerContactNo = customersDataGridView.Rows[rowindex].Cells["ContactNoDataGridViewTextBoxColumn_"].Value.ToString();

                    txt_customerid.Text = "" + CustomerID;
                    txt_customername.Text = CustomerName;
                    txt_contact.Text = CustomerContactNo;
                    txt_address.Text = CustomerAddress;

                    SetEditMode(true);
                }
            }
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
            }

            txt_customerid.Enabled = !State;
            btn_edit.Enabled = !State;
            btn_remove.Enabled = !State;
        }

        private async void btn_remove_Click(object sender, EventArgs e)
        {

            if (customersDataGridView != null)
            {
                if (customersDataGridView.CurrentCell != null)
                {
                    int rowindex = customersDataGridView.CurrentCell.RowIndex;
                    long CustomerID = long.Parse(customersDataGridView.Rows[rowindex].Cells["IdDataGridViewTextBoxColumn_"].Value.ToString());
                    string CustomerName = customersDataGridView.Rows[rowindex].Cells["NameDataGridViewTextBoxColumn_"].Value.ToString();

                    Logger.Log($"user is trying to remove {CustomerName}",
                        System.Reflection.MethodInfo.GetCurrentMethod().Name, this.Name, Logger.INFO);

                    if (MessageBox.Show($"هل تريد ان تمسح {CustomerName}", "انتظر",
                                MessageBoxButtons.YesNo,
                                MessageBoxIcon.Information) == DialogResult.Yes)
                    {
                        await Classes.DataAccess.Customers.RemoveCustomer(CustomerID);
                        LoadDataGrid(Classes.DataAccess.Customers.LoadCustomers(true), customersDataGridView);

                        Logger.Log($"user removed {CustomerName} with id: {CustomerID}",
                            System.Reflection.MethodInfo.GetCurrentMethod().Name, this.Name, Logger.INFO);
                    }
                    else
                        Logger.Log($"user didnt remove {CustomerName}",
                            System.Reflection.MethodInfo.GetCurrentMethod().Name, this.Name, Logger.INFO);
                }
            }

        }

        private void pcb_search_DoubleClick(object sender, EventArgs e)
        {
            LoadDataGrid(Classes.DataAccess.Customers.LoadCustomers(true), customersDataGridView);
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

        private void txt_customers_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                btn_save.PerformClick();
            }
        }

        private async void customersDataGridView_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            //customersDataGridView.DataSource = new Methods().DataGridToDataTable(customersDataGridView);

            //customersDataGridView.Sort(customersDataGridView.Columns[e.ColumnIndex], ListSortDirection.Ascending);

            System.Data.DataTable data = await new Methods().DataGridToDataTable(customersDataGridView);

            data.DefaultView.Sort = $"{customersDataGridView.Columns[e.ColumnIndex].Name} ASC";

            customersDataGridView.DataSource = data;
        }

        private async void customersDataGridView_ColumnHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            //customersDataGridView.DataSource = new Methods().DataGridToDataTable(customersDataGridView);

            //customersDataGridView.Sort(customersDataGridView.Columns[e.ColumnIndex], ListSortDirection.Descending);

            System.Data.DataTable data = await new Methods().DataGridToDataTable(customersDataGridView);

            data.DefaultView.Sort = $"{customersDataGridView.Columns[e.ColumnIndex].Name} DESC";

            customersDataGridView.DataSource = data;
        }

        private void customersBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            //this.Validate();
            //this.customersBindingSource.EndEdit();
            //this.tableAdapterManager.UpdateAll(this.superMarketDataSet);

        }

        private void customersDataGridView_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                int cellColumnIndex = customersDataGridView.CurrentCell.ColumnIndex;
                int cellRowIndex = customersDataGridView.CurrentCell.RowIndex;

                int CellX = customersDataGridView.GetCellDisplayRectangle(cellColumnIndex, cellRowIndex, false).Left;
                int CellY = customersDataGridView.GetCellDisplayRectangle(cellColumnIndex, cellRowIndex, false).Top;

                ContextMenuSelectedCell = (sender as DataGridView).Rows[cellRowIndex].Cells[cellColumnIndex];

                if (ContextMenuSelectedCell != null)
                {
                    contextMenu.Show(customersDataGridView, new Point(CellX, CellY));
                }
            }
        }

        private void btn_exportPDF_Click(object sender, EventArgs e)
        {
            //Methods.ExportDGVtoPDF(customersDataGridView, "العملاء");
            using (Forms.ReportViewer reportViewer = new Forms.ReportViewer())
            {
                Forms.ReportViewer.DGVtoPrint = customersDataGridView;
                Forms.ReportViewer.SelectedReport = Forms.ReportViewer.AvailableReports.Customers;
                reportViewer.ShowDialog();
                reportViewer.Dispose();
                reportViewer.Close();
            }
        }
    }
}
