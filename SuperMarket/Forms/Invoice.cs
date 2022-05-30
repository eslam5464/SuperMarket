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
    public partial class Invoice : Form
    {
        public Invoice()
        {
            InitializeComponent();
        }

        private void Invoice_Load(object sender, EventArgs e)
        {
            SetColor(Properties.Settings.Default.AppColor);
        }

        private void SetColor(Color appColor)
        {
            panel1.BackColor = appColor;
            panel2.BackColor = appColor;
            panel3.BackColor = appColor;
            panel4.BackColor = appColor;
        }
    }
}
