using System;
using System.Drawing;
using System.Windows.Forms;

namespace SuperMarket.UserControls
{
    public partial class Reports : UserControl
    {
        public Reports()
        {
            InitializeComponent();
        }

        private void Reports_Load(object sender, EventArgs e)
        {
            SetColors(Properties.Settings.Default.AppColor);
        }

        private void SetColors(Color appColor)
        {
            Control[] AllControls =
            {
                btn_save
            };

            foreach (Control control in AllControls)
            {
                if (control.GetType() == typeof(Button))
                    control.BackColor = appColor;

                if (control.GetType() == typeof(Label))
                    control.ForeColor = appColor;
            }
            //db_procardsDataGridView.ColumnHeadersDefaultCellStyle.BackColor = appColor;
        }
    }
}
