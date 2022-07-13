using Microsoft.Reporting.WinForms;
using SuperMarket.Classes;
using System;
using System.Collections.Generic;
using System.Data;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SuperMarket.Forms
{
    public partial class ReportViewer : Form
    {
        public ReportViewer()
        {
            InitializeComponent();
        }
        public static DataGridView DGVtoPrint;
        public static AvailableReports SelectedReport;
        private DataTable dtp = null;

        public enum AvailableReports { Customers, Products, Orders, Users, Suppliers }

        private async void Customers_Load(object sender, EventArgs e)
        {
            await CheckReport(SelectedReport);
        }

        private async Task CheckReport(AvailableReports selectedReport)
        {
            if (selectedReport == AvailableReports.Customers)
            {
                Methods methods = new Methods();
                using (dtp = await Task.Run(() => methods.DataGridToDataTable(DGVtoPrint)))
                {
                    dtp.TableName = "العملاء";

                    ReportDataSource datasource = new ReportDataSource("Customers", dtp);

                    rv_customers.LocalReport.DataSources.Clear();
                    rv_customers.LocalReport.DataSources.Add(datasource);
                    rv_customers.RefreshReport();

                    rv_customers.Visible = true;
                    rv_customers.Dock = DockStyle.Fill;
                }
            }
            else if (selectedReport == AvailableReports.Products)
            {
                List<Classes.Models.Joins.Product_ProductPriceModel> AllProducts = Classes.DataAccess.Products.LoadProductsWithPrices(false);

                using (dtp = await new Methods().ListToDataTable(AllProducts))
                {
                    dtp.TableName = "المنتجات";

                    ReportDataSource datasource = new ReportDataSource("Products", dtp);

                    rv_products.LocalReport.DataSources.Clear();
                    rv_products.LocalReport.DataSources.Add(datasource);

                    var p = new ReportParameter("RenderDateTime", DateTime.Now.ToString());
                    rv_products.LocalReport.SetParameters(p);

                    rv_products.RefreshReport();

                    ShowReportViewer(rv_products);
                }
            }
        }

        private void ShowReportViewer(Microsoft.Reporting.WinForms.ReportViewer SelectedReportViewer)
        {
            SelectedReportViewer.Visible = true;
            SelectedReportViewer.Dock = DockStyle.Fill;
        }
    }
}
