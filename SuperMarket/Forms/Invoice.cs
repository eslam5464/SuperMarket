using Microsoft.Reporting.WinForms;
using SuperMarket.Classes;
using System;
using System.Data;
using System.Drawing;
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
        public string invoiceID = "";
        public DataGridView DGVtoPrint = null;

        private void Invoice_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'superMarketDataSet.Invoices' table. You can move, or remove it, as needed.
            //this.invoicesTableAdapter.Fill(this.superMarketDataSet.Invoices);
            SetColor(Properties.Settings.Default.AppColor);

            txt_invoiceid.Text = invoiceID;
            //this.reportViewer1.RefreshReport();
        }

        private void SetColor(Color appColor)
        {
            panel1.BackColor = appColor;
            panel2.BackColor = appColor;
            panel3.BackColor = appColor;
            panel4.BackColor = appColor;
        }

        private async void txt_invoiceid_TextChanged(object sender, EventArgs e)
        {
            Methods methods = new Methods();
            DataTable dtp = await Task.Run(() => methods.DataGridToDataTable(DGVtoPrint));
            dtp.TableName = "Invoice";

            ReportDataSource datasource = new ReportDataSource("Invoice", dtp);

            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(datasource);
            reportViewer1.RefreshReport();
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
