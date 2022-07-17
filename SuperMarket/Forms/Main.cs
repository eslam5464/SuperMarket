using SuperMarket.Classes;
using System;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SuperMarket.Forms
{
    public partial class Main : Form
    {
        private readonly UserControls.Dashboard uc_dashboard = new UserControls.Dashboard();
        private readonly UserControls.Categories uc_categories = new UserControls.Categories();
        private readonly UserControls.Products uc_products = new UserControls.Products();
        private readonly UserControls.Customers uc_customers = new UserControls.Customers();
        private readonly UserControls.Orders uc_orders = new UserControls.Orders();
        private readonly UserControls.Billing uc_billing = new UserControls.Billing();
        private readonly UserControls.Users uc_sellers = new UserControls.Users();
        private readonly UserControls.BillsEdit uc_billsEdit = new UserControls.BillsEdit();
        private readonly UserControls.AdvancedSearch uc_advancedSearch = new UserControls.AdvancedSearch();
        private readonly UserControls.Suppliers uc_suppliers = new UserControls.Suppliers();
        private readonly UserControls.SupplierInvoices uc_supplierInvoices = new UserControls.SupplierInvoices();
        private readonly UserControls.Reports uc_reports = new UserControls.Reports();
        private readonly UserControls.Safe uc_safe = new UserControls.Safe();
        private readonly UserControls.Blank uc_blank = new UserControls.Blank();
        private readonly UserControls.AdminPanel uc_adminPanel = new UserControls.AdminPanel();
        private readonly UserControls.Settings uc_settings = new UserControls.Settings();

        public Main()
        {
            InitializeComponent();
        }

        internal static Classes.Models.UserModel LoggedUser, LoggedUserEnc;
        private int SessionTimer = 0, HourlyTimer = 0, FourHoursTimer = 0;
        private bool SessionState = true;

        private async void Main_Load(object sender, EventArgs e)
        {
            SetColors(Properties.Settings.Default.AppColor);

            if (LoggedUser == null)
                Close();
            else if (!Security.OpenFormMain || LoggedUser.Username == "")
                Close();
            else
                await FormInitialSetup();
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

        private async Task FormInitialSetup()
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
                uc_billsEdit,
                uc_reports,
                uc_advancedSearch,
                uc_suppliers,
                uc_supplierInvoices,
                uc_safe,
                uc_blank,
                uc_adminPanel,
            };

            foreach (UserControl userControl in AllUserControls)
            {
                pan_controls.Controls.Add(userControl);
            }

            uc_dashboard.BringToFront();

            lbl_welcomeName.Text = LoggedUser.FullName;

            await Classes.DataAccess.Backup.AllDaily();

            UserSession.Start();
            HourlyChecker.Start();

            HideSubMenu();

            CheckUserLevelAccess();
        }

        private void btn_dashborad_Click(object sender, EventArgs e)
        {
            SelectButton(btn_dashborad, true);
            uc_dashboard.BringToFront();
        }

        private void btn_Categories_Click(object sender, EventArgs e)
        {
            SelectButton(btn_Categories, true);
            uc_categories.BringToFront();
            uc_categories.RefreshComboBoxes();
        }

        private void btn_Products_Click(object sender, EventArgs e)
        {
            SelectButton(btn_Products, true);
            uc_products.BringToFront();
            uc_products.LoadCategories();
        }

        private void btn_Customers_Click(object sender, EventArgs e)
        {
            SelectButton(btn_Customers, true);
            uc_customers.BringToFront();
        }

        private void btn_Orders_Click(object sender, EventArgs e)
        {
            SelectButton(btn_Orders, true);
            uc_orders.BringToFront();
        }

        private void btn_billing_Click(object sender, EventArgs e)
        {
            SelectButton(btn_billing, false);
            ShowSubMenu(pan_billing);
            ShowBlankUC();
        }

        private void btn_billingAdd_Click(object sender, EventArgs e)
        {
            SelectSideMenuButton(btn_billing, btn_billing, false, 1);
            uc_billing.BringToFront();
            uc_billing.setFocusForBarcode();
        }

        private void btn_editBills_Click(object sender, EventArgs e)
        {
            SelectSideMenuButton(btn_billingEdit, btn_billing, false, 2);
            uc_billsEdit.BringToFront();
            uc_billsEdit.SetFocusOnBarCode();
        }

        private void btn_sellers_Click(object sender, EventArgs e)
        {
            SelectButton(btn_users, true);
            uc_sellers.BringToFront();
        }

        private void btn_settings_Click(object sender, EventArgs e)
        {
            SelectButton(btn_settings, true);

            uc_settings.BringToFront();
        }

        private void btn_reports_Click(object sender, EventArgs e)
        {
            SelectButton(btn_reports, true);

            uc_reports.BringToFront();
        }

        private void btn_advancedSearch_Click(object sender, EventArgs e)
        {
            SelectButton(btn_advancedSearch, true);

            uc_advancedSearch.BringToFront();
        }

        private void btn_suppliers_Click(object sender, EventArgs e)
        {
            SelectButton(btn_suppliers, false);

            ShowSubMenu(pan_suppliers);

            ShowBlankUC();
        }

        private void btn_supplierInvoices_Click(object sender, EventArgs e)
        {
            SelectSideMenuButton(btn_suppliers, btn_suppliers, false, 1);

            uc_supplierInvoices.BringToFront();
            uc_supplierInvoices.GetSafeNames();
        }

        private void btn_suppliersEdit_Click(object sender, EventArgs e)
        {
            SelectSideMenuButton(btn_suppliers, btn_suppliers, false, 2);
            uc_suppliers.BringToFront();
        }

        private void btn_safe_Click(object sender, EventArgs e)
        {
            SelectButton(btn_safe, false);
            uc_safe.BringToFront();
        }

        private void btn_adminPanel_Click(object sender, EventArgs e)
        {
            SelectButton(btn_adminPanel, true);
            uc_adminPanel.BringToFront();
        }

        private void ShowBlankUC()
        {
            uc_blank.BringToFront();
        }

        private void CheckUserLevelAccess()
        {
            // TODO: finish level access
            if (LoggedUser.UserLevel == "admin")
            {
                btn_adminPanel.Visible = true;
            }
        }

        private void SelectButton(Button SelectedButton, bool HideAllSubMenus)
        {
            Logger.Log($"user clicked on {SelectedButton.Name} button",
                System.Reflection.MethodInfo.GetCurrentMethod().Name, this.Name, Logger.INFO);

            if (HideAllSubMenus)
                HideSubMenu();

            SidePanel.Height = SelectedButton.Height;
            SidePanel.Top = SelectedButton.Top;
        }

        private void SelectSideMenuButton(Button SelectedButton, Button MainButton, bool HideAllSubMenus, int location)
        {
            Logger.Log($"user clicked on {SelectedButton.Name} button",
                System.Reflection.MethodInfo.GetCurrentMethod().Name, this.Name, Logger.INFO);

            if (HideAllSubMenus)
                HideSubMenu();

            SidePanel.Height = MainButton.Height;
            SidePanel.Top = MainButton.Top + (location * MainButton.Height);
        }

        private void ShowSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                HideSubMenu();
                subMenu.Visible = true;
            }
            else
                subMenu.Visible = false;
        }

        private void HideSubMenu()
        {
            Panel[] AllPanels =
            {
                pan_suppliers,
                pan_billing
            };

            foreach (Panel panel in AllPanels)
            {
                panel.Visible = false;
            }
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

        private void HourlyChecker_Tick(object sender, EventArgs e)
        {
            HourlyTimer += 1;
            FourHoursTimer += 1;
            if (HourlyTimer >= 3600)
            {
                Task.Run(() => Classes.DataAccess.Backup.AllDaily());
                HourlyTimer = 0;
            }

            if (FourHoursTimer >= 14400)
            {
                Console.WriteLine(Methods.GetTimeOnline());// TODO: finish checking online
                FourHoursTimer = 0;
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

        private async void button1_Click(object sender, EventArgs e)
        {
            await Methods.SendEmail("eslam5464@hotmail.com", "Eslam Mohamed", "Test subkect", "idk body");
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
