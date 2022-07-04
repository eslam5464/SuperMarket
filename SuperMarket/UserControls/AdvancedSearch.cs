using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace SuperMarket.UserControls
{
    public partial class AdvancedSearch : UserControl
    {
        public AdvancedSearch()
        {
            InitializeComponent();
        }
        private static Dictionary<string, string> AllTables;

        private void AdvancedSearch_Load(object sender, EventArgs e)
        {
            SetColors(Properties.Settings.Default.AppColor);
            ResetAll();
        }

        private void ResetAll()
        {
            AllTables = new Dictionary<string, string>
            {
                { "Categories", "الاصناف"},
                { "Customers", "العملاء"},
                { "Invoices", "الفواتير"},
                { "Orders", "الطلبات"},
                { "Products", "المنتجات"},
                { "Users", "المستخدمين"},
            };

            Control[] AllControls =
            {
                cb_branch1,
                cb_branch2,
                cb_branch3,
                cb_branch4,
                cb_branch5,
                cb_branch6,
                cb_branch7,
                cb_branch8,
            };

            cb_type.DataSource = null;

            cb_type.DataSource = new BindingSource(AllTables, null);
            cb_type.DisplayMember = "Value";
            cb_type.ValueMember = "Key";
            //cb_type.DataSource =;

            foreach (Control control in AllControls)
            {
                if (control.GetType() == typeof(ComboBox))
                {
                    ComboBox cb = (ComboBox)control;
                    cb.DataSource = null;
                }
            }
        }

        private void SetColors(Color appColor)
        {
            Control[] AllControls =
            {

            };

            foreach (Control control in AllControls)
            {
                if (control.GetType() == typeof(Button))
                    control.BackColor = appColor;

                else if (control.GetType() == typeof(Label))
                    control.ForeColor = appColor;
            }

            //db_procardsDataGridView.ColumnHeadersDefaultCellStyle.BackColor = appColor;
        }
    }
}
