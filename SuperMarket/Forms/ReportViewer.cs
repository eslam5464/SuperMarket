using Microsoft.Reporting.WinForms;
using SuperMarket.Classes;
using System;
using System.Collections.Generic;
using System.Data;
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
        public static ShownReport SelectedReport;

        public enum ShownReport { Customers, Products, Orders, Users }

        private void Customers_Load(object sender, EventArgs e)
        {
            if (SelectedReport == ShownReport.Customers)
            {
                Methods methods = new Methods();
                DataTable dtp = methods.DataGridToDataTable(DGVtoPrint);
                dtp.TableName = "العملاء";

                ReportDataSource datasource = new ReportDataSource("Customers", dtp);

                rv_customers.LocalReport.DataSources.Clear();
                rv_customers.LocalReport.DataSources.Add(datasource);
                rv_customers.RefreshReport();

                rv_customers.Visible = true;
                rv_customers.Dock = DockStyle.Fill;
            }
            else if (SelectedReport == ShownReport.Products)
            {
                List<Classes.Models.ProductModel> AllProducts = Classes.DataAccess.Products.LoadProducts(false);

                DataTable dtp = new Methods().ListToDataTable(AllProducts);

                dtp.TableName = "Products";

                ReportDataSource datasource = new ReportDataSource("Products", dtp);

                rv_products.LocalReport.DataSources.Clear();
                rv_products.LocalReport.DataSources.Add(datasource);
                var p = new ReportParameter("RenderDateTime", DateTime.Now.ToString());
                rv_products.LocalReport.SetParameters(p);
                rv_products.RefreshReport();

                rv_products.Visible = true;
                rv_products.Dock = DockStyle.Fill;
            }

        }
    }
}
