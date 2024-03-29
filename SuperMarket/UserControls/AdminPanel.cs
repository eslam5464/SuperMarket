﻿using POSWarehouse.Classes;
using POSWarehouse.Forms;
using System;
using System.Diagnostics;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POSWarehouse.UserControls
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

        private async void btn_restoreDatabase_Click(object sender, EventArgs e)
        {
            string FileLocation = Methods.PromptOpenFileDialog("bak", "Backup");

            if (FileLocation != "")
            {
                await Task.Run(() => Classes.DataAccess.DataRestore.All(FileLocation));
            }
        }

        private async void btn_trialDaysLeft_Click(object sender, EventArgs e)
        {
            //Console.WriteLine(await Classes.DataAccess.DataInit.GetDatabaseCreationDate("SuperMarket"));
            //Console.WriteLine("trial: "+Security.GetTrialDays());

            //Console.WriteLine("trial: " + await Security.GetTrialDaysLeft());
            btn_trialDaysLeft.Enabled = false;
            int TrialDays = Security.GetTrialDays();
            if (TrialDays == -1)
                new Notification().ShowAlert("This is a full version", Notification.EnmType.Info);

            else if (TrialDays >= 0)
            {
                await Security.CalculateTrialDaysLeft();
                double TrialDaysLeft = Security.GetTrialDaysLeft();
                new Notification().ShowAlert($"Trial Time left: {TimeSpan.FromDays(TrialDaysLeft)}", Notification.EnmType.Info);
            }
            btn_trialDaysLeft.Enabled = true;
        }

        private void AdminPanel_Load(object sender, EventArgs e)
        {

        }
    }
}
