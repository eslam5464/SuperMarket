using SuperMarket.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

        private void LicenseKeyValidator_Load(object sender, EventArgs e)
        {
            this.TopMost = false;

            SetColors(Properties.Settings.Default.AppColor);

            tb_serial1.Focus();
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
            new About().ShowDialog();
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_checkKey_Click(object sender, EventArgs e)
        {
            Logger.Log("Entered the serial & checked it", "btn_checkKey_Click", "LicenseKeyValidator", Logger.INFO);
            string SerialKey = $"{tb_serial1.Text}-{tb_serial2.Text}-{tb_serial3.Text}-{tb_serial4.Text}-{tb_serial5.Text}-{tb_serial6.Text}-{tb_serial7.Text}";

            Security.SaveLicenseKeyInApp(SerialKey);

            string output = Security.CheckLicenseKeyOnApp();

            if (output == "200")
            {
                Logger.Log("serial key is correct closing the form SerialKeyCheck", "btn_checkKey_Click", "LicenseKeyValidator", Logger.INFO);

                MessageBox.Show("الرقم السري صحيح. البرنامج سوف يغلق الأن بـرجاء فتحه مره أخرى");

                Close();
            }
            else
            {
                Logger.Log("serial key is not correct", "btn_checkKey_Click", "LicenseKeyValidator", Logger.INFO);

                MessageBox.Show("الرقم السري غير صحيح");
            }
        }
    }
}
