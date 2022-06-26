﻿using SuperMarket.Classes.Models;
using System;
using System.Drawing;
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
            pan_orders_count.BackColor = appColor;
            pan_product_count.BackColor = appColor;
            pan_orders_sum.BackColor = appColor;
            pan_customer_count.BackColor = appColor;
            pan_user_count.BackColor = appColor;
            btn_refresh.BackColor = appColor;
        }

        private void CalculateAll()
        {
            decimal OrderSum = 0;
            foreach (OrderModel order in Classes.DataAccess.Orders.GetAllOrders())
            {
                OrderSum += order.GrandTotal;
            }

            lbl_orders_sum.Text = "" + OrderSum;
            lbl_orders_count.Text = "" + Classes.DataAccess.Orders.GetAllOrders().Count;
            lbl_product_count.Text = "" + Classes.DataAccess.Products.LoadProducts().Count;
            lbl_customer_count.Text = "" + Classes.DataAccess.Customers.LoadCustomers().Count;
            lbl_user_count.Text = "" + Classes.DataAccess.Users.LoadAtiveUsersNonAdmin().Count;

            CenterLabels();
        }

        private void CenterLabels()
        {
            int startX = (pan_orders_sum.Size.Width - lbl_orders_sum.Width) / 2;
            lbl_orders_sum.Location = new Point(startX, lbl_orders_sum.Location.Y);

            startX = (pan_orders_count.Size.Width - lbl_orders_count.Width) / 2;
            lbl_orders_count.Location = new Point(startX, lbl_orders_count.Location.Y);

            startX = (pan_product_count.Size.Width - lbl_product_count.Width) / 2;
            lbl_product_count.Location = new Point(startX, lbl_product_count.Location.Y);

            startX = (pan_customer_count.Size.Width - lbl_customer_count.Width) / 2;
            lbl_customer_count.Location = new Point(startX, lbl_customer_count.Location.Y);

            startX = (pan_user_count.Size.Width - lbl_user_count.Width) / 2;
            lbl_user_count.Location = new Point(startX, lbl_user_count.Location.Y);
        }
    }
}
