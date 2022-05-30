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
    public partial class Dashboard : UserControl
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void btn_refresh_Click(object sender, EventArgs e)
        {
            CalculateAll();
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            SetColors(Properties.Settings.Default.AppColor);

            CalculateAll();
        }

        private void SetColors(Color appColor)
        {
            panel1.BackColor = appColor;
            panel9.BackColor = appColor;
            panel3.BackColor = appColor;
            panel7.BackColor = appColor;
            panel5.BackColor = appColor;
            btn_refresh.BackColor = appColor;
        }

        private void CalculateAll()
        {
            lbl_product_count.Text = "" + Classes.DataAccess.Products.LoadProducts().Count;
            lbl_customer_count.Text = "" + Classes.DataAccess.Customers.LoadCustomers().Count;
            lbl_user_count.Text = "" + Classes.DataAccess.Users.LoadAtiveUsers().Count;
        }
    }
}
