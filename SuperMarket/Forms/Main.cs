using SuperMarket.Classes;
using SuperMarket.UserControls;
using System;
using System.Drawing;
using System.Windows.Forms;

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
        private readonly BillsEdit uc_billsEdit = new BillsEdit();
        private readonly UserControls.Settings uc_settings = new UserControls.Settings();

        public Main()
        {
            InitializeComponent();
        }

        internal static Classes.Models.UserModel LoggedUser;
        private int SessionTimer = 0;
        private bool SessionState = true;

        private void Main_Load(object sender, EventArgs e)
        {
            SetColors(Properties.Settings.Default.AppColor);

            if (LoggedUser == null)
                Close();
            else if (!Security.OpenFormMain || LoggedUser.Username == "")
                Close();
            else
                FormInitialSetup();
        }

        public void SetColors(Color color)
        {
            Panel[] AllPanels =
            {
                panel1,
                panel2,
                panel3,
                panel4,
                panel5,
                panel6,
                panel7,
            };

            foreach (Panel panel in AllPanels)
            {
                panel.BackColor = color;
            }
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

            UserControl[] AllUserControls = {
                uc_dashboard,
                uc_categories,
                uc_products,
                uc_customers,
                uc_orders,
                uc_billing,
                uc_sellers,
                uc_settings,
                uc_billsEdit
            };

            foreach (UserControl userControl in AllUserControls)
            {
                pan_controls.Controls.Add(userControl);
            }

            uc_dashboard.BringToFront();

            lbl_welcomeName.Text = LoggedUser.FullName;

            Classes.DataAccess.Backup.AllDaily();

            UserSession.Start();
        }

        private void btn_dashborad_Click(object sender, EventArgs e)
        {
            Logger.Log("user clicked on dashboard button",
                System.Reflection.MethodInfo.GetCurrentMethod().Name, this.Name, Logger.INFO);

            SidePanel.Height = btn_dashborad.Height;
            SidePanel.Top = btn_dashborad.Top;

            uc_dashboard.BringToFront();
        }

        private void btn_Categories_Click(object sender, EventArgs e)
        {
            Logger.Log("user clicked on categories button",
                System.Reflection.MethodInfo.GetCurrentMethod().Name, this.Name, Logger.INFO);

            SidePanel.Height = btn_Categories.Height;
            SidePanel.Top = btn_Categories.Top;

            uc_categories.BringToFront();
        }

        private void btn_Products_Click(object sender, EventArgs e)
        {
            Logger.Log("user clicked on products button",
                System.Reflection.MethodInfo.GetCurrentMethod().Name, this.Name, Logger.INFO);

            SidePanel.Height = btn_Products.Height;
            SidePanel.Top = btn_Products.Top;

            uc_products.BringToFront();
        }

        private void btn_Customers_Click(object sender, EventArgs e)
        {
            Logger.Log("user clicked on customers button",
                System.Reflection.MethodInfo.GetCurrentMethod().Name, this.Name, Logger.INFO);

            SidePanel.Height = btn_Customers.Height;
            SidePanel.Top = btn_Customers.Top;

            uc_customers.BringToFront();
        }

        private void btn_Orders_Click(object sender, EventArgs e)
        {
            Logger.Log("user clicked on orders button",
                System.Reflection.MethodInfo.GetCurrentMethod().Name, this.Name, Logger.INFO);

            SidePanel.Height = btn_Orders.Height;
            SidePanel.Top = btn_Orders.Top;

            uc_orders.BringToFront();
        }

        private void btn_billing_Click(object sender, EventArgs e)
        {
            Logger.Log("user clicked on billing button",
                System.Reflection.MethodInfo.GetCurrentMethod().Name, this.Name, Logger.INFO);

            SidePanel.Height = btn_billing.Height;
            SidePanel.Top = btn_billing.Top;

            uc_billing.BringToFront();
            uc_billing.setFocusForBarcode();
        }

        private void btn_sellers_Click(object sender, EventArgs e)
        {
            Logger.Log("user clicked on sellers button",
                System.Reflection.MethodInfo.GetCurrentMethod().Name, this.Name, Logger.INFO);

            SidePanel.Height = btn_sellers.Height;
            SidePanel.Top = btn_sellers.Top;

            uc_sellers.BringToFront();
        }

        private void btn_editBills_Click(object sender, EventArgs e)
        {
            Logger.Log("user clicked on edit bill button",
                System.Reflection.MethodInfo.GetCurrentMethod().Name, this.Name, Logger.INFO);

            SidePanel.Height = btn_editBills.Height;
            SidePanel.Top = btn_editBills.Top;

            uc_billsEdit.BringToFront();
            uc_billsEdit.SetFocusOnBarCode();
        }

        private void btn_settings_Click(object sender, EventArgs e)
        {
            Logger.Log("user clicked on settings button",
                System.Reflection.MethodInfo.GetCurrentMethod().Name, this.Name, Logger.INFO);

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
            if (LoggedUser != null)
            {
                if (LoggedUser.Username != "")
                {
                    Logger.Log("user is attempting to exit the application",
                        System.Reflection.MethodInfo.GetCurrentMethod().Name, this.Name, Logger.INFO);
                    if (!SessionState)
                        this.Close();
                    else
                    {
                        if (MessageBox.Show("هل تريد ان تغلق البرنامج؟", "انتظر",
                            MessageBoxButtons.YesNo,
                            MessageBoxIcon.Information) == DialogResult.No)
                        {
                            e.Cancel = true;

                            Logger.Log("user canceled the closing of the application",
                                System.Reflection.MethodInfo.GetCurrentMethod().Name, this.Name, Logger.INFO);
                        }
                        else
                        {
                            Logger.Log("user confirmed closing of the application",
                                System.Reflection.MethodInfo.GetCurrentMethod().Name, this.Name, Logger.INFO);

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
            else
                Logger.Log("no user has accessed the application.. closing now",
                           System.Reflection.MethodInfo.GetCurrentMethod().Name, this.Name, Logger.INFO);
        }

        private void UserSession_Tick(object sender, EventArgs e)
        {
            SessionTimer += 1;
            if (SessionTimer >= Properties.Settings.Default.SessionTime)
            {
                SessionState = false;
                UserSession.Stop();

                Logger.Log($"Session timeout user exceeded {Properties.Settings.Default.SessionTime} Seconds",
                    System.Reflection.MethodInfo.GetCurrentMethod().Name, this.Name, Logger.INFO);

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
            Logger.Log("user clicked on help button",
                System.Reflection.MethodInfo.GetCurrentMethod().Name, this.Name, Logger.INFO);

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
