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

        private void btn_trialDaysLeft_Click(object sender, EventArgs e)
        {
            //Console.WriteLine(await Classes.DataAccess.DataInit.GetDatabaseCreationDate("SuperMarket"));
            //Console.WriteLine("trial: "+Security.GetTrialDays());

            //Console.WriteLine("trial: " + await Security.GetTrialDaysLeft());
            int TrialDays = Security.GetTrialDays();
            if (TrialDays == -1)
                MessageBox.Show($"This is a full version");

            else if (TrialDays >= 0)
            {
                int TrialDaysLeft = Security.GetTrialDaysLeft();
                MessageBox.Show($"Trial Days left: {TrialDaysLeft}");
            }
        }
    }
}
