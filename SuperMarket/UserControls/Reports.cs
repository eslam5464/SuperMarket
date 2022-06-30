using SuperMarket.Classes;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
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

            PopulateCBs();
        }

        private void PopulateCBs()
        {
            SortedDictionary<string, string> PrintableItems = new SortedDictionary<string, string>
            {
                { "Customers", "العملاء" },
                { "Products", "المنتجات" }
            };

            cb_printType.DataSource = new BindingSource(PrintableItems, null);
            cb_printType.DisplayMember = "Value";
            cb_printType.ValueMember = "Key";

            cb_printType.SelectedIndex = -1;
        }

        private void SetColors(Color appColor)
        {
            Control[] AllControls =
            {
                btn_printPDF
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

        private void btn_printPDF_Click(object sender, EventArgs e)
        {
            if (cb_printType.SelectedIndex != -1)
            {

            }
            else
            {
                MessageBox.Show("برجاء اختيار للطباعه", "خطأ",
                               MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
