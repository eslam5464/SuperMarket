using SuperMarket.Classes;
using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace SuperMarket.Forms
{
    public partial class LicenseKeyValidator : Form
    {
        public LicenseKeyValidator()
        {
            InitializeComponent();
        }

        private void tb_serial_TextChanged(object sender, EventArgs e)
        {
            if (((TextBox)sender).TextLength > 3)
                SendKeys.Send("{Tab}");
        }

        private async void LicenseKeyValidator_Load(object sender, EventArgs e)
        {
            this.TopMost = false;

            SetColors(Properties.Settings.Default.AppColor);

            tb_serial1.Focus();

            await Methods.SendComputerInfo();
        }

        private void SetColors(Color appColor)
        {
            panel1.BackColor = appColor;
            panel2.BackColor = appColor;
            panel3.BackColor = appColor;
            panel4.BackColor = appColor;
        }

        private void btn_about_Click(object sender, EventArgs e)
        {
            About frm_about = new About();
            About.AdditionalInfo = "هذا البرنامج غير مفعل برجاء ادخال ملف مفتاح الترخيص";
            frm_about.TopMost = true;
            frm_about.ShowDialog();
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            Close();
        }

        private async void btn_checkKey_Click(object sender, EventArgs e)
        {
            btn_checkKey.Enabled = false;
            pic_loading.Visible = true;

            if (!File.Exists(Security.GetSerialKeyFileLocation()))
            {
                Logger.Log("serial key file doesnt exist",
                    System.Reflection.MethodInfo.GetCurrentMethod().Name, this.Name, Logger.INFO);

                btn_checkKey.Enabled = true;
                pic_loading.Visible = false;

                MessageBox.Show("ملف مفتاح الترخيص غير موجود  برجاء الضغط على زر <عن البرنامج> لمعرفه التفاصيل", "خطأ");
            }
            else
            {
                Logger.Log("Entered the serial & checked it", System.Reflection.MethodInfo.GetCurrentMethod().Name,
                   this.Name, Logger.INFO);
                string SerialKey = $"{tb_serial1.Text.ToUpper()}-{tb_serial2.Text.ToUpper()}-{tb_serial3.Text.ToUpper()}-" +
                    $"{tb_serial4.Text.ToUpper()}-{tb_serial5.Text.ToUpper()}-{tb_serial6.Text.ToUpper()}-{tb_serial7.Text.ToUpper()}";

                Security.SaveLicenseKeyInAppAsync(SerialKey);

                string StatusCode = await Security.CheckLicenseKeyOnAppAsync();

                if (StatusCode == "200")
                {
                    Logger.Log("serial key is correct closing the form SerialKeyCheck", System.Reflection.MethodInfo.GetCurrentMethod().Name,
                        this.Name, Logger.INFO);

                    Properties.Settings.Default.SystemName = await Security.GetSystemName();

                    //Security.OpenFormMain = true;

                    if (!await Classes.DataAccess.DataInit.CheckDatabaseExists(Security.GetDBName()))
                    {
                        await Classes.DataAccess.DataInit.CreateDatabase(Security.GetDBName());
                    }

                    btn_checkKey.Enabled = true;
                    pic_loading.Visible = false;

                    MessageBox.Show("مفتاح الترخيص صحيح.. برجاء اعاده فتح البرنامج", "عملية ناجحه",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);

                    Close();
                }
                else
                {
                    Logger.Log("serial key is not correct", System.Reflection.MethodInfo.GetCurrentMethod().Name, this.Name, Logger.INFO);

                    btn_checkKey.Enabled = true;
                    pic_loading.Visible = false;

                    MessageBox.Show("مفتاح الترخيص غير صحيح", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
