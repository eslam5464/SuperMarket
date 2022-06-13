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
    public partial class Customers : UserControl
    {
        public Customers()
        {
            InitializeComponent();
        }

        private void LoadDataGrid(List<CustomerModel> Customers)
        {
            db_customersDataGridView.DataSource = null;
            db_customersDataGridView.DataSource = Customers;

            db_customersDataGridView.Columns["Id"].HeaderText = "الرقم التعريفي للعميل";
            db_customersDataGridView.Columns["Name"].HeaderText = "اسم العميل";
            db_customersDataGridView.Columns["ContactNo"].HeaderText = "رقم الاتصال";
            db_customersDataGridView.Columns["Address"].HeaderText = "العنوان";
            db_customersDataGridView.Columns["CreationDate"].HeaderText = "يوم اضافه العميل";

            db_customersDataGridView.AutoResizeColumns();
            db_customersDataGridView.Columns["CreationDate"].Width += 5;
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            try
            {
                if (txt_customername.Text == "" && txt_contact.Text == "" && txt_address.Text == "")
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
                                Id = int.Parse(txt_customerid.Text),
                                Name = txt_customername.Text,
                                Address = txt_address.Text,
                                ContactNo = txt_contact.Text
                            };
                            Classes.DataAccess.Customers.UpdateCustomer(customer);

                            LoadDataGrid(Classes.DataAccess.Customers.GetCustomerParameter("Id", "" + customer.Id));

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

                            LoadDataGrid(Classes.DataAccess.Customers.LoadCustomers());

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
            if (txt_customername.Text == "")
                LoadDataGrid(Classes.DataAccess.Customers.LoadCustomers());

            else
            {
                Logger.Log($"user is trying to search for customer with name {txt_contact.Text}",
                    System.Reflection.MethodInfo.GetCurrentMethod().Name, this.Name, Logger.INFO);

                List<CustomerModel> customerSearch = Classes.DataAccess.Customers.GetCustomerParameter("Name", txt_customername.Text);
                LoadDataGrid(customerSearch);
            }
        }

        private void pcb_searchPhone_Click(object sender, EventArgs e)
        {
            if (txt_contact.Text == "")
                LoadDataGrid(Classes.DataAccess.Customers.LoadCustomers());

            else
            {
                Logger.Log($"user is trying to search for customer with phone {txt_contact.Text}",
                    System.Reflection.MethodInfo.GetCurrentMethod().Name, this.Name, Logger.INFO);

                List<CustomerModel> customerSearch = Classes.DataAccess.Customers.GetCustomerParameter("ContactNo", txt_contact.Text);
                LoadDataGrid(customerSearch);
            }
        }

        private void Customers_Load(object sender, EventArgs e)
        {
            SetColors(Properties.Settings.Default.AppColor);

            LoadDataGrid(Classes.DataAccess.Customers.LoadCustomers());
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
            db_customersDataGridView.ColumnHeadersDefaultCellStyle.BackColor = appColor;
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            if (db_customersDataGridView != null)
            {
                if (db_customersDataGridView.CurrentCell != null)
                {
                    int rowindex = db_customersDataGridView.CurrentCell.RowIndex;

                    int CustomerID = int.Parse(db_customersDataGridView.Rows[rowindex].Cells["Id"].Value.ToString());
                    string CustomerName = db_customersDataGridView.Rows[rowindex].Cells["Name"].Value.ToString(),
                     CustomerAddress = db_customersDataGridView.Rows[rowindex].Cells["Address"].Value.ToString(),
                     CustomerContactNo = db_customersDataGridView.Rows[rowindex].Cells["ContactNo"].Value.ToString();

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

            if (db_customersDataGridView != null)
            {
                if (db_customersDataGridView.CurrentCell != null)
                {
                    int rowindex = db_customersDataGridView.CurrentCell.RowIndex;
                    int CustomerID = int.Parse(db_customersDataGridView.Rows[rowindex].Cells["Id"].Value.ToString());
                    string CustomerName = db_customersDataGridView.Rows[rowindex].Cells["Name"].Value.ToString();

                    Logger.Log($"user is trying to remove {CustomerName}",
                        System.Reflection.MethodInfo.GetCurrentMethod().Name, this.Name, Logger.INFO);

                    if (MessageBox.Show($"هل تريد ان تمسح {CustomerName}", "انتظر",
                                MessageBoxButtons.YesNo,
                                MessageBoxIcon.Information) == DialogResult.Yes)
                    {
                        Classes.DataAccess.Customers.RemoveCustomer(CustomerID);
                        LoadDataGrid(Classes.DataAccess.Customers.LoadCustomers());

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
            LoadDataGrid(Classes.DataAccess.Customers.LoadCustomers());
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
    }
}
