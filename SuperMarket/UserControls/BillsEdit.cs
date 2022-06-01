using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SuperMarket.UserControls
{
    public partial class BillsEdit : UserControl
    {
        public BillsEdit()
        {
            InitializeComponent();
        }

        private void pcb_search_MouseEnter(object sender, EventArgs e)
        {
            Control FocusedObject = (Control)sender;
            FocusedObject.BackColor = Properties.Settings.Default.AppColor;
        }

        private void pcb_search_MouseLeave(object sender, EventArgs e)
        {
            Control FocusedObject = (Control)sender;
            FocusedObject.BackColor = Color.Gainsboro;
        }

        private void BillsEdit_Load(object sender, EventArgs e)
        {
            SetColors(Properties.Settings.Default.AppColor);
            //dtp_invoicedate.Text = DateTime.Now.ToString("hh:mm:ss tt dd/MM/yyyy", new System.Globalization.CultureInfo("ar-AE"));
            //dtp_invoicedate.CustomFormat = DateTime.Now.ToString("dd/MM/yyyy hh:mm:ss tt", new System.Globalization.CultureInfo("ar-AE"));
        }

        private void SetColors(Color appColor)
        {
            Label[] AllLabels = {
                label1,
                label2,
                label3,
                label4,
                label5,
                label6,
                label7,
                label8,
                label9,
                label10,
                label12,
                label13,
            };

            Button[] AllButtons = {
                btn_addToBill,
                btn_removeFromBill
            };

            foreach (Label label in AllLabels)
                label.ForeColor = appColor;

            foreach (Button button in AllButtons)
                button.BackColor = appColor;

            db_probillsDataGridView.ColumnHeadersDefaultCellStyle.BackColor = appColor;
        }
    }
}
