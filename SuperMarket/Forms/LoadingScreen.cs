using SuperMarket.Classes;
using System;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SuperMarket.Forms
{
    public partial class LoadingScreen : Form
    {
        public LoadingScreen()
        {
            InitializeComponent();
        }

        private Login login = new Login();

        private void LoadingScreen_Load(object sender, EventArgs e)
        {
            timer_loading.Start();

            SetColors(Properties.Settings.Default.AppColor);
        }

        private async Task IncrementProgressBar(ProgressBar SelectedProgressBar, int value)
        {
            SelectedProgressBar.Increment(value);
            SelectedProgressBar.Update();
            await Task.Run(() => System.Threading.Thread.Sleep(1000));
        }

        private void SetColors(Color appColor)
        {
            panel1.BackColor = appColor;
            panel2.BackColor = appColor;
            panel3.BackColor = appColor;
            panel4.BackColor = appColor;
            pic_loading.BackColor = appColor;
            pic_logo.BackColor = appColor;
        }

        private async Task MoveProgressBar()
        {
            if (progressBar.Value < 75)
            {
                await IncrementProgressBar(progressBar, 25);
            }
            else
            {
                timer_loading.Stop();

                await Security.GetComputerInfo();

                await Security.SetupTrialDays();

                string LicenseKey = Properties.Settings.Default.LicenseKey;

                if (LicenseKey != "")
                {
                    string SerialKeyCheckOutput = await Security.CheckLicenseKeyValidity(LicenseKey);

                    if (SerialKeyCheckOutput == "404")
                    {
                        Logger.Log("cant find serial key file",
                                System.Reflection.MethodInfo.GetCurrentMethod().Name, this.Name, Logger.CRITICAL);
                        Security.OpenFormMain = false;

                        await Methods.SendComputerInfo();

                        await IncrementProgressBar(progressBar, 25);

                        new Notification().ShowAlert("ملف فتح البرنامج غير موجود برجاء ايجاد مكان الملف", Notification.EnmType.Error);

                        string SerialFIleLocation = Methods.PromptOpenFileDialog("enc", "Serial");

                        await Security.MoveSerialKeyFile(SerialFIleLocation);

                        if (Methods.CheckFileExists(Security.GetSerialKeyDateTimeFileLocation()) &&
                           Methods.CheckFileExists(Security.GetSerialKeyFileLocation()))
                        {
                            progressBar.Value = 0;
                            timer_loading.Start();
                        }
                    }
                    else if (SerialKeyCheckOutput == "200")
                    {
                        if (Security.GetTrialDays() != -1)
                        {
                            if (await Methods.GetTimeOnline() != DateTime.MinValue)
                            {
                                if (await Security.CalculateTrialDaysLeft() <= 0)
                                {
                                    this.TopMost = false;

                                    await IncrementProgressBar(progressBar, 25);

                                    MessageBox.Show("لقد انتهت المده المسموحة لاستخدام البرنامج", "انتبه",
                                        MessageBoxButtons.OK, MessageBoxIcon.Warning);

                                    Logger.Log("time used to open the application finished",
                                             System.Reflection.MethodInfo.GetCurrentMethod().Name, this.Name, Logger.CRITICAL);

                                    this.Close();
                                }
                                else
                                {
                                    Logger.Log("serial key validated",
                                             System.Reflection.MethodInfo.GetCurrentMethod().Name, this.Name, Logger.CRITICAL);

                                    await IncrementProgressBar(progressBar, 25);

                                    this.TopMost = false;
                                    this.Hide();

                                    login.TopMost = true;
                                    login.ShowDialog();

                                    Security.OpenFormMain = true;

                                    if (Main.LoggedUser != null)
                                        if (Main.LoggedUser.Username == "")
                                            Security.OpenFormMain = false;

                                    this.Close();
                                }
                            }
                            else
                            {
                                this.TopMost = false;

                                await IncrementProgressBar(progressBar, 25);

                                MessageBox.Show("لا يمكن الاتصال بالإنترنت برجاء استخدام البرنامج عندما يكون الجهاز متصل بال انترنت",
                                    "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                                Logger.Log("time used to open the application finished",
                                         System.Reflection.MethodInfo.GetCurrentMethod().Name, this.Name, Logger.INFO);

                                System.Threading.Thread.Sleep(1000);

                                this.Close();
                            }
                        }
                        else
                        {
                            Logger.Log("serial key validated",
                                             System.Reflection.MethodInfo.GetCurrentMethod().Name, this.Name, Logger.CRITICAL);

                            await IncrementProgressBar(progressBar, 25);

                            this.TopMost = false;
                            this.Hide();

                            login.TopMost = true;
                            login.ShowDialog();

                            Security.OpenFormMain = true;

                            if (Main.LoggedUser != null)
                                if (Main.LoggedUser.Username == "")
                                    Security.OpenFormMain = false;

                            this.Close();
                        }
                    }
                    else if (SerialKeyCheckOutput == "400")
                    {
                        Logger.Log("wrong serial key in the system",
                                System.Reflection.MethodInfo.GetCurrentMethod().Name, this.Name, Logger.ERROR);

                        await IncrementProgressBar(progressBar, 25);

                        this.Hide();

                        LicenseKeyValidator frm_license = new LicenseKeyValidator
                        {
                            TopMost = true
                        };

                        frm_license.ShowDialog();

                        this.Show();

                        LicenseKey = Properties.Settings.Default.LicenseKey;

                        SerialKeyCheckOutput = await Security.CheckLicenseKeyValidity(LicenseKey);

                        if (SerialKeyCheckOutput == "200")
                        {
                            progressBar.Value = 0;
                            timer_loading.Start();
                        }
                        else
                        {
                            Close();
                        }
                    }
                    else
                    {
                        Logger.Log("unknown error",
                                 System.Reflection.MethodInfo.GetCurrentMethod().Name, this.Name, Logger.CRITICAL);
                        Security.OpenFormMain = false;

                        await IncrementProgressBar(progressBar, 25);

                        this.Close();
                    }
                }

                else
                {
                    Logger.Log("serial key isnt available prompting the user to add it",
                                 System.Reflection.MethodInfo.GetCurrentMethod().Name, this.Name, Logger.INFO);

                    if (await Security.SerialKeyFileExists())
                    {
                        this.Hide();
                        LicenseKeyValidator licenseKeyValidator = new LicenseKeyValidator();
                        licenseKeyValidator.TopMost = true;
                        licenseKeyValidator.ShowDialog();
                        licenseKeyValidator.Close();
                        this.Show();

                        progressBar.Value = 0;
                        timer_loading.Start();

                        Security.OpenFormMain = true;

                        this.Close();
                    }
                    else
                    {
                        this.TopMost = false;

                        About frm_about = new About();
                        About.AdditionalInfo = "هذا البرنامج غير قابل للعمل على هذا الجهاز";

                        await IncrementProgressBar(progressBar, 25);

                        frm_about.TopMost = true;
                        frm_about.ShowDialog();

                        this.Close();
                    }
                }
            }
        }

        private async void timer_loading_Tick(object sender, EventArgs e)
        {
            await MoveProgressBar();
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
