using SuperMarket.Classes;
using System;
using System.Drawing;
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
            About.AdditionalInfo = "هذا البرنامج غير مفعل برجاء ادخال مفتاح الترخيص";
            frm_about.TopMost = true;
            frm_about.ShowDialog();
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            Close();
        }

        private async void btn_checkKey_Click(object sender, EventArgs e)
        {
            Logger.Log("Entered the serial & checked it", System.Reflection.MethodInfo.GetCurrentMethod().Name,
               this.Name, Logger.INFO);
            string SerialKey = $"{tb_serial1.Text.ToUpper()}-{tb_serial2.Text.ToUpper()}-{tb_serial3.Text.ToUpper()}-" +
                $"{tb_serial4.Text.ToUpper()}-{tb_serial5.Text.ToUpper()}-{tb_serial6.Text.ToUpper()}-{tb_serial7.Text.ToUpper()}";

            Security.SaveLicenseKeyInAppAsync(SerialKey);

            string output = await Security.CheckLicenseKeyOnAppAsync();

            if (output == "200")
            {
                Logger.Log("serial key is correct closing the form SerialKeyCheck", System.Reflection.MethodInfo.GetCurrentMethod().Name, this.Name, Logger.INFO);

                MessageBox.Show("مفتاح الترخيص صحيح.. سوف يتم بدا البرنامج", "عملية ناجحه");

                Close();
            }
            else
            {
                Logger.Log("serial key is not correct", System.Reflection.MethodInfo.GetCurrentMethod().Name, this.Name, Logger.INFO);

                MessageBox.Show("الرقم السري غير صحيح");
            }
        }
    }
}
