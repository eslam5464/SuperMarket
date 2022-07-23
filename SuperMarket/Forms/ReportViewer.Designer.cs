
namespace POSWarehouse.Forms
{
    partial class ReportViewer
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReportViewer));
            this.rv_customers = new Microsoft.Reporting.WinForms.ReportViewer();
            this.rv_orders = new Microsoft.Reporting.WinForms.ReportViewer();
            this.rv_products = new Microsoft.Reporting.WinForms.ReportViewer();
            this.rv_users = new Microsoft.Reporting.WinForms.ReportViewer();
            this.rv_categories = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SuspendLayout();
            // 
            // rv_customers
            // 
            this.rv_customers.LocalReport.ReportEmbeddedResource = "SuperMarket.Reports.Customers.rdlc";
            this.rv_customers.Location = new System.Drawing.Point(12, 12);
            this.rv_customers.Name = "rv_customers";
            this.rv_customers.ServerReport.BearerToken = null;
            this.rv_customers.Size = new System.Drawing.Size(125, 174);
            this.rv_customers.TabIndex = 0;
            this.rv_customers.Visible = false;
            // 
            // rv_orders
            // 
            this.rv_orders.Location = new System.Drawing.Point(143, 12);
            this.rv_orders.Name = "rv_orders";
            this.rv_orders.ProcessingMode = Microsoft.Reporting.WinForms.ProcessingMode.Remote;
            this.rv_orders.ServerReport.BearerToken = null;
            this.rv_orders.Size = new System.Drawing.Size(125, 174);
            this.rv_orders.TabIndex = 1;
            this.rv_orders.Visible = false;
            // 
            // rv_products
            // 
            this.rv_products.LocalReport.ReportEmbeddedResource = "SuperMarket.Reports.Products.rdlc";
            this.rv_products.Location = new System.Drawing.Point(274, 12);
            this.rv_products.Name = "rv_products";
            this.rv_products.ServerReport.BearerToken = null;
            this.rv_products.Size = new System.Drawing.Size(125, 174);
            this.rv_products.TabIndex = 2;
            this.rv_products.Visible = false;
            // 
            // rv_users
            // 
            this.rv_users.LocalReport.ReportEmbeddedResource = "SuperMarket.Reports.Customers.rdlc";
            this.rv_users.Location = new System.Drawing.Point(405, 12);
            this.rv_users.Name = "rv_users";
            this.rv_users.ServerReport.BearerToken = null;
            this.rv_users.Size = new System.Drawing.Size(125, 174);
            this.rv_users.TabIndex = 3;
            this.rv_users.Visible = false;
            // 
            // rv_categories
            // 
            this.rv_categories.LocalReport.ReportEmbeddedResource = "SuperMarket.Reports.Categories.rdlc";
            this.rv_categories.Location = new System.Drawing.Point(536, 12);
            this.rv_categories.Name = "rv_categories";
            this.rv_categories.ServerReport.BearerToken = null;
            this.rv_categories.Size = new System.Drawing.Size(125, 174);
            this.rv_categories.TabIndex = 4;
            this.rv_categories.Visible = false;
            // 
            // ReportViewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.rv_categories);
            this.Controls.Add(this.rv_users);
            this.Controls.Add(this.rv_products);
            this.Controls.Add(this.rv_orders);
            this.Controls.Add(this.rv_customers);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimizeBox = false;
            this.Name = "ReportViewer";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Customers_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rv_customers;
        private Microsoft.Reporting.WinForms.ReportViewer rv_orders;
        private Microsoft.Reporting.WinForms.ReportViewer rv_products;
        private Microsoft.Reporting.WinForms.ReportViewer rv_users;
        private Microsoft.Reporting.WinForms.ReportViewer rv_categories;
    }
}