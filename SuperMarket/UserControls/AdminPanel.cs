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

        private void btn_getSerial_Click(object sender, EventArgs e)
        {
            txt_serialKey.Text = Properties.Settings.Default.LicenseKey;
        }

        private void btn_openBackupLocation_Click(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.BackupLocation != "")
                Process.Start("explorer.exe", Properties.Settings.Default.BackupLocation);

            else
                Process.Start("explorer.exe", Security.GetDirecotryLocation() + @"\Backup");
        }

        private void btn_restoreDatabase_Click(object sender, EventArgs e)
        {
            string FileLocation = Methods.PromptOpenFileDialog("bak", "Backup");

            if (FileLocation != "")
            {
                Classes.DataAccess.DataRestore.All(FileLocation, "Default");
            }
        }
    }
}
