using POSWarehouse.Classes.Models;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace POSWarehouse.Forms
{
    public partial class UserAccess : Form
    {
        public UserAccess()
        {
            InitializeComponent();
        }

        private static UserLevelAccessModel SelectedUser;

        private void UserAccess_Load(object sender, EventArgs e)
        {
            if (SelectedUser != null)
            {
                ResetCheckBoxes();
                SetAllCheckBoxes(SelectedUser);
                lbl_userId.Text = "" + SelectedUser.UserId;
                lbl_userName.Text = "" + SelectedUser.UserFullName;
            }
            else
            {
                new Notification().ShowAlert("حدث خطأ أثناء تحميل  بيانات المستخدم", Notification.EnmType.Error);
            }
        }

        private void ResetCheckBoxes()
        {
            chk_billing.BackColor = Color.IndianRed;
            chk_billingEdit.BackColor = Color.IndianRed;
            chk_categories.BackColor = Color.IndianRed;
            chk_customers.BackColor = Color.IndianRed;
            chk_dashboard.BackColor = Color.IndianRed;
            chk_products.BackColor = Color.IndianRed;
            chk_reports.BackColor = Color.IndianRed;
            chk_settings.BackColor = Color.IndianRed;
            chk_users.BackColor = Color.IndianRed;
            chk_safe.BackColor = Color.IndianRed;
            chk_orders.BackColor = Color.IndianRed;
            chk_supplierInvoices.BackColor = Color.IndianRed;
            chk_suppliersEdit.BackColor = Color.IndianRed;
        }

        private void SetAllCheckBoxes(UserLevelAccessModel selectedUser)
        {
            chk_billing.Checked = selectedUser.Billing;
            chk_billingEdit.Checked = selectedUser.BillsEdit;
            chk_categories.Checked = selectedUser.Categories;
            chk_customers.Checked = selectedUser.Customers;
            chk_dashboard.Checked = selectedUser.Dashboard;
            chk_products.Checked = selectedUser.Products;
            chk_reports.Checked = selectedUser.Reports;
            chk_settings.Checked = selectedUser.Settings;
            chk_users.Checked = selectedUser.Users;
            chk_safe.Checked = selectedUser.Safe;
            chk_orders.Checked = selectedUser.Orders;
            chk_supplierInvoices.Checked = selectedUser.SupplierInvoices;
            chk_suppliersEdit.Checked = selectedUser.SuppliersEdit;
        }

        internal static void SetSelectedUser(UserLevelAccessModel userLevelAccess)
        {
            SelectedUser = userLevelAccess;
        }

        private async void btn_save_Click(object sender, EventArgs e)
        {
            UserLevelAccessModel AdjustedUserAccess = new UserLevelAccessModel
            {
                UserId = SelectedUser.UserId,
                UserFullName = SelectedUser.UserFullName,
                UserLevel = SelectedUser.UserFullName,
                Billing = chk_billing.Checked,
                BillsEdit = chk_billingEdit.Checked,
                Categories = chk_categories.Checked,
                Customers = chk_customers.Checked,
                Dashboard = chk_dashboard.Checked,
                Products = chk_products.Checked,
                Reports = chk_reports.Checked,
                Settings = chk_settings.Checked,
                Users = chk_users.Checked,
                Orders = chk_orders.Checked,
                SuppliersEdit = chk_suppliersEdit.Checked,
                SupplierInvoices = chk_supplierInvoices.Checked,
                Safe = chk_safe.Checked,
            };
            await Classes.DataAccess.UserLevelAccess.UpdateUserLevelAccess(AdjustedUserAccess);
        }

        private void chk_userAccess_MouseLeave(object sender, EventArgs e)
        {
            //Control FocusedObject = (Control)sender;
            //FocusedObject.BackColor = Color.Transparent;
            //FocusedObject.ForeColor = Color.Black;
        }

        private void chk_userAccess_MouseEnter(object sender, EventArgs e)
        {
            //Control FocusedObject = (Control)sender;
            //FocusedObject.BackColor = Properties.Settings.Default.AppColor;
            //FocusedObject.ForeColor = Color.White;
        }

        private void chk_userAccess_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox FocusedObject = (CheckBox)sender;

            if (FocusedObject.Checked)
                FocusedObject.BackColor = Color.LightGreen;
            else
                FocusedObject.BackColor = Color.IndianRed;
        }
    }
}
