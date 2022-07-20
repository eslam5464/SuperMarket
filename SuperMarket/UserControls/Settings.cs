﻿using SuperMarket.Classes;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SuperMarket.UserControls
{
    public partial class Settings : UserControl
    {
        public Settings()
        {
            InitializeComponent();
        }

        private readonly IDictionary<int, Color> ColorsDict = new Dictionary<int, Color>();

        private async void Settings_Load(object sender, EventArgs e)
        {
            await SetupColorsDict();
            SetupVars();
            // TODO: finish get backup folder
        }

        private void SetupVars()
        {
            tb_backupLocation.Text = Properties.Settings.Default.BackupLocation;
        }

        private async Task SetupColorsDict()
        {
            for (int i = 0; i < GlobalVars.AvailableColors.Length; i++)
                await Task.Run(() => ColorsDict.Add(i, GlobalVars.AvailableColors[i]));

            for (int i = 0; i < ColorsDict.Count; i++)
                cb_color.Items.Add(ColorsDict[i].Name);
        }

        private void txt_color_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cb_color.SelectedIndex != -1)
                pan_color_sample.BackColor = ColorsDict[cb_color.SelectedIndex];
        }

        private void btn_saveChanges_Click(object sender, EventArgs e)
        {
            if (cb_color.SelectedIndex != -1)
                Properties.Settings.Default.AppColor = ColorsDict[cb_color.SelectedIndex];
        }

        private void btn_saveSettings_Click(object sender, EventArgs e)
        {
            if (cb_color.SelectedIndex != -1)
                Properties.Settings.Default.AppColor = ColorsDict[cb_color.SelectedIndex];

            if (tb_backupLocation.Text != "")
                Properties.Settings.Default.Save();

            MessageBox.Show("تم حفظ جميع الاعدادات", "عملية ناجحه", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btn_resetDefault_Click(object sender, EventArgs e)
        {
            cb_color.SelectedIndex = -1;
            Properties.Settings.Default.AppColor = Color.Purple;

            MessageBox.Show("تم اعاده ضبط الاعدادات", "عملية ناجحه", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private async void btn_backupLocation_Click(object sender, EventArgs e)
        {
            string BackupLocation = await Methods.PromptFolderBrowserDialog();

            if (BackupLocation != "")
            {
                Properties.Settings.Default.BackupLocation = BackupLocation;
                tb_backupLocation.Text = Properties.Settings.Default.BackupLocation;
            }
        }

        private void btn_restoreDatabase_Click(object sender, EventArgs e)
        {
            btn_restoreDatabase.Enabled = false;

            string FileLocation = Methods.PromptOpenFileDialog("bak", "Backup");

            if (FileLocation != "")
            {
                Classes.DataAccess.DataRestore.All(FileLocation, "Default");
            }

            btn_restoreDatabase.Enabled = true;
        }

        private async void btn_createBackup_Click(object sender, EventArgs e)
        {
            btn_createBackup.Enabled = false;

            string Date = DateTime.Now.ToString("yyyy-MM-dd"),
                FileName = $"LocalBackup {Date}.bak";

            string BackupLocation = await Methods.PromptSaveFileDialog(FileName);

            if (BackupLocation != "")
            {
                string[] saveFileDialogSplit = BackupLocation.Split('\\');
                string DirectoryName = "";
                for (int i = 0; i < saveFileDialogSplit.Length - 1; i++)
                {
                    DirectoryName += saveFileDialogSplit[i] + "\\";
                }

                bool output = await Classes.DataAccess.DataBackup.
                    AllOnce(DirectoryName, BackupLocation.Split('\\')[saveFileDialogSplit.Length - 1], true);

                if (output)
                    MessageBox.Show("تم حفظ النسخة الاحتياطية", "عملية ناجحه", MessageBoxButtons.OK, MessageBoxIcon.Information);

                else
                    MessageBox.Show("حدث خطأ أثناء حفظ النسخة الاحتياطية", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            btn_createBackup.Enabled = true;
        }
    }
}
