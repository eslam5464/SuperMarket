using SuperMarket.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
    }
}
