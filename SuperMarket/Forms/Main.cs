using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Cache;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using SuperMarket.Classes;
using SuperMarket.UserControls;

namespace SuperMarket.Forms
{
    public partial class Main : Form
    {
        private readonly Dashboard uc_dashboard = new Dashboard();
        private readonly Categories uc_categories = new Categories();
        private readonly Products uc_products = new Products();
        private readonly Customers uc_customers = new Customers();
        private readonly Orders uc_orders = new Orders();
        private readonly Billing uc_billing = new Billing();
        private readonly Sellers uc_sellers = new Sellers();
        private readonly UserControls.Settings uc_settings = new UserControls.Settings();

        public Main()
        {
            InitializeComponent();
        }

        public static string LoggedUser = "", UserLevel = "";
        private int SessionTimer = 0;
        private bool SessionState = true;

        private void Main_Load(object sender, EventArgs e)
        {
            SetColors(Properties.Settings.Default.AppColor);

            if (!Security.OpenFormMain || LoggedUser == "")
                Close();

            FormInitialSetup();

            //string LicenseKey = Properties.Settings.Default.LicenseKey;

            //if (LicenseKey != "")
            //{
            //    string SerialKeyCheckOutput = Security.CheckLicenseKeyValidity(LicenseKey);

            //    if (SerialKeyCheckOutput == "404")
            //    {
            //        Logger.Log("cant find serial key file", "Dashboard_Load", "Dashboard", Logger.CRITICAL);
            //        Close();
            //    }
            //    else if (SerialKeyCheckOutput == "200")
            //    {
            //        Logger.Log("serial key validated", "Dashboard_Load", "Dashboard", Logger.INFO);

            //        Login login = new Login();
            //        login.TopMost = true;
            //        login.ShowDialog();

            //        if (LoggedUser == "")
            //            Close();

            //        FormInitialSetup();
            //    }
            //    else if (SerialKeyCheckOutput == "400")
            //    {
            //        Logger.Log("wrong serial key in the system", "Dashboard_Load", "Dashboard", Logger.ERROR);

            //        LicenseKeyValidator frm_license = new LicenseKeyValidator();
            //        frm_license.TopMost = true;
            //        frm_license.ShowDialog();
            //        Close();
            //    }
            //    else
            //    {
            //        Logger.Log("unknown error", "Dashboard_Load", "Dashboard", Logger.CRITICAL);
            //        Close();
            //    }
            //}

            //else
            //{
            //    Logger.Log("serial key isnt available prompting the user to add it", "Dashboard_Load", "Dashboard", Logger.INFO);
            //    new LicenseKeyValidator().ShowDialog();
            //    Close();
            //}
        }

        public void SetColors(Color color)
        {
            panel1.BackColor = color;
            panel2.BackColor = color;
            panel3.BackColor = color;
            panel4.BackColor = color;
            panel5.BackColor = color;
            panel6.BackColor = color;
            panel7.BackColor = color;
            //panel8.BackColor = Classes.Settings.AppColor;
            //panel9.BackColor = Classes.Settings.AppColor;
        }

        private void FormInitialSetup()
        {
            this.WindowState = Properties.Settings.Default.WindowState;

            if (this.WindowState == FormWindowState.Minimized)
                this.WindowState = FormWindowState.Normal;

            this.Size = Properties.Settings.Default.WindowSize;


            if ((Location.X < Screen.PrimaryScreen.Bounds.Width - 50 && Location.X > 0) ||
                (Location.Y < Screen.PrimaryScreen.Bounds.Height - 50 && Location.Y > 0))
            {
                this.Location = Properties.Settings.Default.WindowLocation;
            }
            else
            {
                this.Location = new Point(10, 10);
            }

            pan_controls.Controls.Add(uc_dashboard);
            pan_controls.Controls.Add(uc_categories);
            pan_controls.Controls.Add(uc_products);
            pan_controls.Controls.Add(uc_customers);
            pan_controls.Controls.Add(uc_orders);
            pan_controls.Controls.Add(uc_billing);
            pan_controls.Controls.Add(uc_sellers);
            pan_controls.Controls.Add(uc_settings);

            uc_dashboard.BringToFront();

            lbl_welcomeName.Text = LoggedUser;

            Classes.DataAccess.Backup.AllDaily();

            UserSession.Start();
        }

        private void btn_dashborad_Click(object sender, EventArgs e)
        {
            SidePanel.Height = btn_dashborad.Height;
            SidePanel.Top = btn_dashborad.Top;

            uc_dashboard.BringToFront();
        }

        private void btn_Categories_Click(object sender, EventArgs e)
        {
            SidePanel.Height = btn_Categories.Height;
            SidePanel.Top = btn_Categories.Top;

            uc_categories.BringToFront();
        }

        private void btn_Products_Click(object sender, EventArgs e)
        {
            SidePanel.Height = btn_Products.Height;
            SidePanel.Top = btn_Products.Top;

            uc_products.BringToFront();
        }

        private void btn_Customers_Click(object sender, EventArgs e)
        {
            SidePanel.Height = btn_Customers.Height;
            SidePanel.Top = btn_Customers.Top;

            uc_customers.BringToFront();
        }

        private void btn_Orders_Click(object sender, EventArgs e)
        {
            SidePanel.Height = btn_Orders.Height;
            SidePanel.Top = btn_Orders.Top;

            uc_orders.BringToFront();
        }

        private void btn_billing_Click(object sender, EventArgs e)
        {
            SidePanel.Height = btn_billing.Height;
            SidePanel.Top = btn_billing.Top;

            uc_billing.BringToFront();
        }

        private void btn_sellers_Click(object sender, EventArgs e)
        {
            SidePanel.Height = btn_sellers.Height;
            SidePanel.Top = btn_sellers.Top;

            uc_sellers.BringToFront();
        }

        private void btn_settings_Click(object sender, EventArgs e)
        {
            SidePanel.Height = btn_settings.Height;
            SidePanel.Top = btn_settings.Top;

            uc_settings.BringToFront();
        }

        private void btn_logout_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (LoggedUser != "")
            {
                if (!SessionState)
                    this.Close();
                else
                {
                    if (MessageBox.Show("هل تريد ان تغلق البرنامج؟", "انتظر",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Information) == DialogResult.No)
                    {
                        e.Cancel = true;
                    }
                    else
                    {
                        if (this.WindowState == FormWindowState.Normal)
                        {
                            Properties.Settings.Default.WindowSize = this.Size;
                            Properties.Settings.Default.WindowLocation = this.Location;
                        }
                        else
                        {
                            Properties.Settings.Default.WindowLocation = this.RestoreBounds.Location;
                            this.WindowState = FormWindowState.Normal;
                        }
                        Properties.Settings.Default.WindowSize = this.Size;
                        Properties.Settings.Default.WindowLocation = this.Location;
                        Properties.Settings.Default.WindowState = this.WindowState;
                        Properties.Settings.Default.Save();
                    }
                }
            }
        }

        private void UserSession_Tick(object sender, EventArgs e)
        {
            SessionTimer += 1;
            if (SessionTimer >= Properties.Settings.Default.SessionTime)
            {
                SessionState = false;
                UserSession.Stop();
                MessageBox.Show("لقد تم انتهاء المده المسموحه لفتح البرنامج بدون حركه برجاء فتح البرنامج مره أخرى!",
                    "انتبه", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.Dispose();
                this.Close();
            }
        }

        private void panels_MouseMove(object sender, MouseEventArgs e)
        {
            SessionTimer = 0;
        }

        private void pic_help_Click(object sender, EventArgs e)
        {
            new About().ShowDialog();
        }

        private void pic_help_MouseEnter(object sender, EventArgs e)
        {
            pic_help.BackColor = Color.Goldenrod;
        }

        private void pic_help_MouseLeave(object sender, EventArgs e)
        {
            pic_help.BackColor = Properties.Settings.Default.AppColor;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
        }
    }
}
