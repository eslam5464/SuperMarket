using SuperMarket.Classes;
using SuperMarket.Classes.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace SuperMarket.UserControls
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

            dataGridView.Columns["Id"].HeaderText = "الرقم التعريفي للعميل";
            dataGridView.Columns["CustomerName"].HeaderText = "اسم العميل";
            dataGridView.Columns["ContactNo"].HeaderText = "رقم الاتصال";
            dataGridView.Columns["Address"].HeaderText = "العنوان";
            dataGridView.Columns["CreationDate"].HeaderText = "يوم اضافه العميل";
            dataGridView.Columns["CreationDate"].DefaultCellStyle.Format = "yyyy/MM/dd tt HH:mm:ss";

            dataGridView.AutoResizeColumns();
            dataGridView.Columns["CreationDate"].Width += 5;
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            try
            {
                if (txt_customername.Text.Trim() == "" && txt_contact.Text.Trim() == "" && txt_address.Text.Trim() == "")
                {
                    MessageBox.Show("برجاء ادخال جميع بيانات العميل من الاسم ورقم التواصل والعنوان", "حاو مره أخرى", MessageBoxButtons.OK, MessageBoxIcon.Error);

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
                            Classes.DataAccess.Customers.UpdateCustomer(customer);

                            LoadDataGrid(Classes.DataAccess.Customers.GetCustomerParameter("Id", "" + customer.Id), customersDataGridView);

                            ResetTextBoxes();

                            Logger.Log($"user has edited customer with id: {customer.Id}",
                                System.Reflection.MethodInfo.GetCurrentMethod().Name, this.Name, Logger.INFO);
                        }

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
                            Classes.DataAccess.Customers.SaveCustomer(customer);

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

                List<CustomerModel> customerSearch = Classes.DataAccess.Customers.GetCustomerParameter("ContactNo", txt_contact.Text);
                LoadDataGrid(customerSearch, customersDataGridView);
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

                    long CustomerID = long.Parse(customersDataGridView.Rows[rowindex].Cells["Id"].Value.ToString());
                    string CustomerName = customersDataGridView.Rows[rowindex].Cells["CustomerName"].Value.ToString(),
                     CustomerAddress = customersDataGridView.Rows[rowindex].Cells["Address"].Value.ToString(),
                     CustomerContactNo = customersDataGridView.Rows[rowindex].Cells["ContactNo"].Value.ToString();

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

        private void btn_remove_Click(object sender, EventArgs e)
        {

            if (customersDataGridView != null)
            {
                if (customersDataGridView.CurrentCell != null)
                {
                    int rowindex = customersDataGridView.CurrentCell.RowIndex;
                    long CustomerID = long.Parse(customersDataGridView.Rows[rowindex].Cells["Id"].Value.ToString());
                    string CustomerName = customersDataGridView.Rows[rowindex].Cells["CustomerName"].Value.ToString();

                    Logger.Log($"user is trying to remove {CustomerName}",
                        System.Reflection.MethodInfo.GetCurrentMethod().Name, this.Name, Logger.INFO);

                    if (MessageBox.Show($"هل تريد ان تمسح {CustomerName}", "انتظر",
                                MessageBoxButtons.YesNo,
                                MessageBoxIcon.Information) == DialogResult.Yes)
                    {
                        Classes.DataAccess.Customers.RemoveCustomer(CustomerID);
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

        private void customersDataGridView_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            customersDataGridView.DataSource = new Methods().DataGridToDataTable(customersDataGridView);

            customersDataGridView.Sort(customersDataGridView.Columns[e.ColumnIndex], ListSortDirection.Ascending);
        }

        private void customersDataGridView_ColumnHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            customersDataGridView.DataSource = new Methods().DataGridToDataTable(customersDataGridView);

            customersDataGridView.Sort(customersDataGridView.Columns[e.ColumnIndex], ListSortDirection.Descending);
        }

        private void customersBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.customersBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.superMarketDataSet);

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
                Forms.ReportViewer.SelectedReport = Forms.ReportViewer.ShownReport.Customers;
                reportViewer.ShowDialog();
                reportViewer.Dispose();
                reportViewer.Close();
            }
        }
    }
}
