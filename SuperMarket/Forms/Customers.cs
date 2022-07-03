using Microsoft.Reporting.WinForms;
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
    public partial class Customers : Form
    {
        public Customers()
        {
            InitializeComponent();
        }
        public static DataGridView DGVtoPrint;

        private void Customers_Load(object sender, EventArgs e)
        {
            Methods methods = new Methods();
            DataTable dtp = methods.DataGridToDataTable(DGVtoPrint);
            dtp.TableName = "Customers";

            ReportDataSource datasource = new ReportDataSource("Customers", dtp);

            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(datasource);
            reportViewer1.RefreshReport();
        }
    }
}
