using System;
using System.Windows.Forms;

namespace SuperMarket.Forms
{
    public partial class About : Form
    {
        public About()
        {
            InitializeComponent();
        }

        public static string AdditionalInfo = "";
        private void About_Load(object sender, EventArgs e)
        {
            BackColor = Properties.Settings.Default.AppColor;

            if (AdditionalInfo != "")
            {
                lbl_info.Visible = true;
                lbl_info.Text = AdditionalInfo;
            }
            else
                lbl_info.Visible = false;

        }
    }
}
