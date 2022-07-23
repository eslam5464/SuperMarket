using Microsoft.Reporting.WinForms;
using POSWarehouse.Classes;
using System;
using System.Collections.Generic;
using System.Data;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POSWarehouse.Forms
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

        public enum AvailableReports { Customers, Products, Orders, Users, Suppliers, Safe, Categories }

        private async void Customers_Load(object sender, EventArgs e)
        {
            await CheckReport(SelectedReport);
            //this.rv_categories.RefreshReport();
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
            else if (selectedReport == AvailableReports.Categories)
            {
                List<Classes.Models.CategoryModel> AllCategories = Classes.DataAccess.Categories.LoadCategories();

                using (dtp = await new Methods().ListToDataTable(AllCategories))
                {
                    dtp.TableName = "التصنيفات والمخازن";

                    ReportDataSource datasource = new ReportDataSource("Categories", dtp);

                    rv_categories.LocalReport.DataSources.Clear();
                    rv_categories.LocalReport.DataSources.Add(datasource);

                    var p = new ReportParameter("RenderDateTime", DateTime.Now.ToString());
                    rv_categories.LocalReport.SetParameters(p);

                    rv_categories.RefreshReport();

                    ShowReportViewer(rv_categories);
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
