using SuperMarket.Classes;
using System;
using System.Drawing;
using System.Net;
using System.Net.Cache;
using System.Threading;
using System.Windows.Forms;

namespace SuperMarket.Forms
{
    public partial class LoadingScreen : Form
    {
        public LoadingScreen()
        {
            InitializeComponent();
        }

        private bool FoundTimeOnline = false;
        private DateTime OnlineTimeNow;

        private void LoadingScreen_Load(object sender, EventArgs e)
        {
            timer_loading.Start();

            new Thread(new ThreadStart(GetTimeOnline)).Start();

            SetColors(Properties.Settings.Default.AppColor);
        }

        private void GetTimeOnline()
        {
            try
            {
                DateTime dateTime = DateTime.MinValue;
                HttpWebRequest request = (HttpWebRequest)WebRequest.Create("https://www.google.com.eg");
                request.Method = "GET";
                request.Accept = "text/html, application/xhtml+xml, */*";
                request.UserAgent = "Mozilla/5.0 (compatible; MSIE 10.0; Windows NT 6.1; Trident/6.0)";
                request.ContentType = "application/x-www-form-urlencoded";
                request.CachePolicy = new RequestCachePolicy(RequestCacheLevel.NoCacheNoStore);
                HttpWebResponse response = (HttpWebResponse)request.GetResponse();
                if (response.StatusCode == HttpStatusCode.OK)
                {
                    string todaysDates = response.Headers["date"];

                    dateTime = DateTime.ParseExact(todaysDates, "ddd, dd MMM yyyy HH:mm:ss 'GMT'",
                        System.Globalization.CultureInfo.InvariantCulture.DateTimeFormat, System.Globalization.DateTimeStyles.AssumeUniversal);
                }

                OnlineTimeNow = dateTime;
                FoundTimeOnline = true;
                Console.WriteLine(OnlineTimeNow);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                //MessageBox.Show(ex.Message);
            }

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

        private void MoveProgressBar()
        {
            if (progressBar.Value < 75)
            {
                progressBar.Value += 25;
            }
            else
            {
                if (progressBar.Value == 75 && FoundTimeOnline)
                    progressBar.Value += 25;// TO DO: finish fidning time online

                else
                {
                    timer_loading.Stop();

                    string LicenseKey = Properties.Settings.Default.LicenseKey;

                    if (LicenseKey != "")
                    {
                        string SerialKeyCheckOutput = Security.CheckLicenseKeyValidity(LicenseKey);

                        if (SerialKeyCheckOutput == "404")
                        {
                            Logger.Log("cant find serial key file",
                                    System.Reflection.MethodInfo.GetCurrentMethod().Name, this.Name, Logger.CRITICAL);
                            Security.OpenFormMain = false;
                        }
                        else if (SerialKeyCheckOutput == "200")
                        {
                            Logger.Log("serial key validated",
                                    System.Reflection.MethodInfo.GetCurrentMethod().Name, this.Name, Logger.INFO);

                            this.Hide();

                            Login login = new Login();
                            login.TopMost = true;
                            login.ShowDialog();

                            this.Show();

                            Security.OpenFormMain = true;

                            if (Main.LoggedUser == "")
                                Security.OpenFormMain = false;

                            this.Close();
                        }
                        else if (SerialKeyCheckOutput == "400")
                        {
                            Logger.Log("wrong serial key in the system",
                                    System.Reflection.MethodInfo.GetCurrentMethod().Name, this.Name, Logger.ERROR);

                            this.Hide();
                            LicenseKeyValidator frm_license = new LicenseKeyValidator();
                            frm_license.TopMost = true;
                            frm_license.ShowDialog();
                            this.Show();
                        }
                        else
                        {
                            Logger.Log("unknown error",
                                    System.Reflection.MethodInfo.GetCurrentMethod().Name, this.Name, Logger.CRITICAL);
                            Security.OpenFormMain = false;
                        }
                    }

                    else
                    {
                        Logger.Log("serial key isnt available prompting the user to add it",
                                    System.Reflection.MethodInfo.GetCurrentMethod().Name, this.Name, Logger.INFO);

                        if (Security.SerialKeyFileExists())
                        {
                            this.Hide();
                            LicenseKeyValidator licenseKeyValidator = new LicenseKeyValidator();
                            licenseKeyValidator.TopMost = true;
                            licenseKeyValidator.ShowDialog();
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
                            frm_about.TopMost = true;
                            frm_about.ShowDialog();

                            this.Close();
                        }
                    }
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            progressBar.Value += 10;
            //progressBar.
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void timer_loading_Tick(object sender, EventArgs e)
        {
            MoveProgressBar();
        }
    }
}
