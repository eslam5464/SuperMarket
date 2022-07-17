using SuperMarket.Classes;
using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace SuperMarket.UserControls
{
    public partial class AdminPanel : UserControl
    {
        public AdminPanel()
        {
            InitializeComponent();
        }

        private void btn_safeEdit_Click(object sender, EventArgs e)
        {
            Process.Start("explorer.exe", Security.GetDirecotryLocation() + @"\Backup");
        }

        private void btn_getSerial_Click(object sender, EventArgs e)
        {
            txt_serialKey.Text = Properties.Settings.Default.LicenseKey;
        }

        private void btn_restoreDatabase_Click(object sender, EventArgs e)
        {
            try
            {
                // TODO: finish restore database
                //using (var location = new SqlConnection(GlobalVars.LoadConnectionString("Default")))
                //{
                //    location.Execute($@"Restore database [SuperMarket] from disk = " +
                //                    $@"' C:\Users\Eslam\AppData\Local\Super Market System\Backup\DailyLocalBackup 2022-07-16.bak' " +
                //                    $@"with replace", new DynamicParameters());
                //}
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
