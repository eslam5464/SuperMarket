
namespace POSWarehouse.UserControls
{
    partial class Orders
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel3 = new System.Windows.Forms.Panel();
            this.ordersDataGridView = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pcb_search_by_customer_name = new System.Windows.Forms.PictureBox();
            this.txt_customername = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_invoiceno = new System.Windows.Forms.TextBox();
            this.btn_refresh = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btn_exportPDF = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pcb_search_by_invoiceno = new System.Windows.Forms.PictureBox();
            this.tableAdapterManager = new POSWarehouse.SuperMarketDataSetTableAdapters.TableAdapterManager();
            this.pOSWarehouseDataSet = new POSWarehouse.Data.POSWarehouseDataSet();
            this.ordersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ordersTableAdapter = new POSWarehouse.Data.POSWarehouseDataSetTableAdapters.OrdersTableAdapter();
            this.IdDataGridViewTextBoxColumn_ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.InvoiceDateDataGridViewTextBoxColumn_ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.InvoiceIdDataGridViewTextBoxColumn_ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CustomerIdDataGridViewTextBoxColumn_ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CustomerNameDataGridViewTextBoxColumn_ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ContactNumberDataGridViewTextBoxColumn_ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AddressDataGridViewTextBoxColumn_ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GrandTotalDataGridViewTextBoxColumn_ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CreatedByUserIdDataGridViewTextBoxColumn_ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CreatedByUserFullNameDataGridViewTextBoxColumn_ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ordersDataGridView)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcb_search_by_customer_name)).BeginInit();
            this.panel4.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcb_search_by_invoiceno)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pOSWarehouseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Gray;
            this.panel3.Controls.Add(this.ordersDataGridView);
            this.panel3.Location = new System.Drawing.Point(3, 121);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1032, 536);
            this.panel3.TabIndex = 17;
            // 
            // ordersDataGridView
            // 
            this.ordersDataGridView.AllowUserToAddRows = false;
            this.ordersDataGridView.AllowUserToDeleteRows = false;
            this.ordersDataGridView.AllowUserToResizeColumns = false;
            this.ordersDataGridView.AllowUserToResizeRows = false;
            this.ordersDataGridView.AutoGenerateColumns = false;
            this.ordersDataGridView.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Purple;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ordersDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.ordersDataGridView.ColumnHeadersHeight = 40;
            this.ordersDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdDataGridViewTextBoxColumn_,
            this.InvoiceDateDataGridViewTextBoxColumn_,
            this.InvoiceIdDataGridViewTextBoxColumn_,
            this.CustomerIdDataGridViewTextBoxColumn_,
            this.CustomerNameDataGridViewTextBoxColumn_,
            this.ContactNumberDataGridViewTextBoxColumn_,
            this.AddressDataGridViewTextBoxColumn_,
            this.GrandTotalDataGridViewTextBoxColumn_,
            this.CreatedByUserIdDataGridViewTextBoxColumn_,
            this.CreatedByUserFullNameDataGridViewTextBoxColumn_});
            this.ordersDataGridView.DataSource = this.ordersBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.ordersDataGridView.DefaultCellStyle = dataGridViewCellStyle2;
            this.ordersDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ordersDataGridView.EnableHeadersVisualStyles = false;
            this.ordersDataGridView.GridColor = System.Drawing.Color.Silver;
            this.ordersDataGridView.Location = new System.Drawing.Point(0, 0);
            this.ordersDataGridView.MultiSelect = false;
            this.ordersDataGridView.Name = "ordersDataGridView";
            this.ordersDataGridView.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ordersDataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.ordersDataGridView.Size = new System.Drawing.Size(1032, 536);
            this.ordersDataGridView.TabIndex = 1;
            this.ordersDataGridView.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.ordersDataGridView_CellMouseClick);
            this.ordersDataGridView.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.db_ordersDataGridView_ColumnHeaderMouseClick);
            this.ordersDataGridView.ColumnHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.db_ordersDataGridView_ColumnHeaderMouseDoubleClick);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Purple;
            this.label2.Location = new System.Drawing.Point(163, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 23);
            this.label2.TabIndex = 46;
            this.label2.Text = ":رقم الفاتورة";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.pcb_search_by_customer_name);
            this.panel2.Controls.Add(this.txt_customername);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(343, 9);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(327, 100);
            this.panel2.TabIndex = 19;
            // 
            // pcb_search_by_customer_name
            // 
            this.pcb_search_by_customer_name.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pcb_search_by_customer_name.Image = global::POSWarehouse.Properties.Resources.icons8_search_48px_1;
            this.pcb_search_by_customer_name.Location = new System.Drawing.Point(270, 42);
            this.pcb_search_by_customer_name.Name = "pcb_search_by_customer_name";
            this.pcb_search_by_customer_name.Size = new System.Drawing.Size(45, 45);
            this.pcb_search_by_customer_name.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcb_search_by_customer_name.TabIndex = 138;
            this.pcb_search_by_customer_name.TabStop = false;
            this.pcb_search_by_customer_name.Click += new System.EventHandler(this.pcb_search_by_customer_name_Click);
            this.pcb_search_by_customer_name.DoubleClick += new System.EventHandler(this.pcb_search_by_customer_name_DoubleClick);
            this.pcb_search_by_customer_name.MouseEnter += new System.EventHandler(this.pcb_search_by_MouseEnter);
            this.pcb_search_by_customer_name.MouseLeave += new System.EventHandler(this.pcb_search_by_MouseLeave);
            // 
            // txt_customername
            // 
            this.txt_customername.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_customername.BackColor = System.Drawing.Color.White;
            this.txt_customername.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.txt_customername.Font = new System.Drawing.Font("Palatino Linotype", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_customername.ForeColor = System.Drawing.Color.Black;
            this.txt_customername.Location = new System.Drawing.Point(14, 42);
            this.txt_customername.Multiline = true;
            this.txt_customername.Name = "txt_customername";
            this.txt_customername.Size = new System.Drawing.Size(250, 45);
            this.txt_customername.TabIndex = 48;
            this.txt_customername.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_order_KeyDown);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Purple;
            this.label1.Location = new System.Drawing.Point(145, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 23);
            this.label1.TabIndex = 46;
            this.label1.Text = ":اسم العميل";
            // 
            // txt_invoiceno
            // 
            this.txt_invoiceno.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_invoiceno.BackColor = System.Drawing.Color.White;
            this.txt_invoiceno.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.txt_invoiceno.Font = new System.Drawing.Font("Palatino Linotype", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_invoiceno.ForeColor = System.Drawing.Color.Black;
            this.txt_invoiceno.Location = new System.Drawing.Point(17, 42);
            this.txt_invoiceno.Multiline = true;
            this.txt_invoiceno.Name = "txt_invoiceno";
            this.txt_invoiceno.Size = new System.Drawing.Size(250, 45);
            this.txt_invoiceno.TabIndex = 47;
            this.txt_invoiceno.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_order_KeyDown);
            this.txt_invoiceno.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_invoiceno_KeyPress);
            // 
            // btn_refresh
            // 
            this.btn_refresh.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_refresh.BackColor = System.Drawing.Color.Purple;
            this.btn_refresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_refresh.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold);
            this.btn_refresh.ForeColor = System.Drawing.Color.White;
            this.btn_refresh.Location = new System.Drawing.Point(182, 24);
            this.btn_refresh.Name = "btn_refresh";
            this.btn_refresh.Size = new System.Drawing.Size(162, 50);
            this.btn_refresh.TabIndex = 139;
            this.btn_refresh.Text = "تحديث البيانات";
            this.btn_refresh.UseVisualStyleBackColor = false;
            this.btn_refresh.Click += new System.EventHandler(this.btn_refresh_Click);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.btn_exportPDF);
            this.panel4.Controls.Add(this.btn_refresh);
            this.panel4.Location = new System.Drawing.Point(676, 9);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(359, 100);
            this.panel4.TabIndex = 20;
            // 
            // btn_exportPDF
            // 
            this.btn_exportPDF.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_exportPDF.BackColor = System.Drawing.Color.Purple;
            this.btn_exportPDF.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_exportPDF.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_exportPDF.ForeColor = System.Drawing.Color.White;
            this.btn_exportPDF.Location = new System.Drawing.Point(14, 24);
            this.btn_exportPDF.Name = "btn_exportPDF";
            this.btn_exportPDF.Size = new System.Drawing.Size(162, 50);
            this.btn_exportPDF.TabIndex = 168;
            this.btn_exportPDF.Text = "طباعه الجدول";
            this.btn_exportPDF.UseVisualStyleBackColor = false;
            this.btn_exportPDF.Click += new System.EventHandler(this.btn_exportPDF_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.pcb_search_by_invoiceno);
            this.panel1.Controls.Add(this.txt_invoiceno);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(3, 9);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(328, 100);
            this.panel1.TabIndex = 18;
            // 
            // pcb_search_by_invoiceno
            // 
            this.pcb_search_by_invoiceno.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pcb_search_by_invoiceno.Image = global::POSWarehouse.Properties.Resources.icons8_search_48px_1;
            this.pcb_search_by_invoiceno.Location = new System.Drawing.Point(273, 42);
            this.pcb_search_by_invoiceno.Name = "pcb_search_by_invoiceno";
            this.pcb_search_by_invoiceno.Size = new System.Drawing.Size(45, 45);
            this.pcb_search_by_invoiceno.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcb_search_by_invoiceno.TabIndex = 138;
            this.pcb_search_by_invoiceno.TabStop = false;
            this.pcb_search_by_invoiceno.Click += new System.EventHandler(this.pcb_search_by_invoiceno_Click);
            this.pcb_search_by_invoiceno.DoubleClick += new System.EventHandler(this.pcb_search_by_invoiceno_DoubleClick);
            this.pcb_search_by_invoiceno.MouseEnter += new System.EventHandler(this.pcb_search_by_MouseEnter);
            this.pcb_search_by_invoiceno.MouseLeave += new System.EventHandler(this.pcb_search_by_MouseLeave);
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CategoriesTableAdapter = null;
            this.tableAdapterManager.CustomersTableAdapter = null;
            this.tableAdapterManager.InvoicesTableAdapter = null;
            this.tableAdapterManager.ProductPriceTableAdapter = null;
            this.tableAdapterManager.ProductsTableAdapter = null;
            this.tableAdapterManager.SafeTableAdapter = null;
            this.tableAdapterManager.SafeTransactionTableAdapter = null;
            this.tableAdapterManager.StorageTableAdapter = null;
            this.tableAdapterManager.SupplierInvoiceProductTableAdapter = null;
            this.tableAdapterManager.SupplierInvoicesTableAdapter = null;
            this.tableAdapterManager.SuppliersTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = POSWarehouse.SuperMarketDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UserLevelAccessTableAdapter = null;
            this.tableAdapterManager.UsersTableAdapter = null;
            // 
            // pOSWarehouseDataSet
            // 
            this.pOSWarehouseDataSet.DataSetName = "POSWarehouseDataSet";
            this.pOSWarehouseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ordersBindingSource
            // 
            this.ordersBindingSource.DataMember = "Orders";
            this.ordersBindingSource.DataSource = this.pOSWarehouseDataSet;
            // 
            // ordersTableAdapter
            // 
            this.ordersTableAdapter.ClearBeforeFill = true;
            // 
            // IdDataGridViewTextBoxColumn_
            // 
            this.IdDataGridViewTextBoxColumn_.DataPropertyName = "Id";
            this.IdDataGridViewTextBoxColumn_.HeaderText = "Id";
            this.IdDataGridViewTextBoxColumn_.Name = "IdDataGridViewTextBoxColumn_";
            this.IdDataGridViewTextBoxColumn_.ReadOnly = true;
            // 
            // InvoiceDateDataGridViewTextBoxColumn_
            // 
            this.InvoiceDateDataGridViewTextBoxColumn_.DataPropertyName = "InvoiceDate";
            this.InvoiceDateDataGridViewTextBoxColumn_.HeaderText = "InvoiceDate";
            this.InvoiceDateDataGridViewTextBoxColumn_.Name = "InvoiceDateDataGridViewTextBoxColumn_";
            this.InvoiceDateDataGridViewTextBoxColumn_.ReadOnly = true;
            // 
            // InvoiceIdDataGridViewTextBoxColumn_
            // 
            this.InvoiceIdDataGridViewTextBoxColumn_.DataPropertyName = "InvoiceId";
            this.InvoiceIdDataGridViewTextBoxColumn_.HeaderText = "InvoiceId";
            this.InvoiceIdDataGridViewTextBoxColumn_.Name = "InvoiceIdDataGridViewTextBoxColumn_";
            this.InvoiceIdDataGridViewTextBoxColumn_.ReadOnly = true;
            // 
            // CustomerIdDataGridViewTextBoxColumn_
            // 
            this.CustomerIdDataGridViewTextBoxColumn_.DataPropertyName = "CustomerId";
            this.CustomerIdDataGridViewTextBoxColumn_.HeaderText = "CustomerId";
            this.CustomerIdDataGridViewTextBoxColumn_.Name = "CustomerIdDataGridViewTextBoxColumn_";
            this.CustomerIdDataGridViewTextBoxColumn_.ReadOnly = true;
            // 
            // CustomerNameDataGridViewTextBoxColumn_
            // 
            this.CustomerNameDataGridViewTextBoxColumn_.DataPropertyName = "CustomerName";
            this.CustomerNameDataGridViewTextBoxColumn_.HeaderText = "CustomerName";
            this.CustomerNameDataGridViewTextBoxColumn_.Name = "CustomerNameDataGridViewTextBoxColumn_";
            this.CustomerNameDataGridViewTextBoxColumn_.ReadOnly = true;
            // 
            // ContactNumberDataGridViewTextBoxColumn_
            // 
            this.ContactNumberDataGridViewTextBoxColumn_.DataPropertyName = "ContactNumber";
            this.ContactNumberDataGridViewTextBoxColumn_.HeaderText = "ContactNumber";
            this.ContactNumberDataGridViewTextBoxColumn_.Name = "ContactNumberDataGridViewTextBoxColumn_";
            this.ContactNumberDataGridViewTextBoxColumn_.ReadOnly = true;
            // 
            // AddressDataGridViewTextBoxColumn_
            // 
            this.AddressDataGridViewTextBoxColumn_.DataPropertyName = "Address";
            this.AddressDataGridViewTextBoxColumn_.HeaderText = "Address";
            this.AddressDataGridViewTextBoxColumn_.Name = "AddressDataGridViewTextBoxColumn_";
            this.AddressDataGridViewTextBoxColumn_.ReadOnly = true;
            // 
            // GrandTotalDataGridViewTextBoxColumn_
            // 
            this.GrandTotalDataGridViewTextBoxColumn_.DataPropertyName = "GrandTotal";
            this.GrandTotalDataGridViewTextBoxColumn_.HeaderText = "GrandTotal";
            this.GrandTotalDataGridViewTextBoxColumn_.Name = "GrandTotalDataGridViewTextBoxColumn_";
            this.GrandTotalDataGridViewTextBoxColumn_.ReadOnly = true;
            // 
            // CreatedByUserIdDataGridViewTextBoxColumn_
            // 
            this.CreatedByUserIdDataGridViewTextBoxColumn_.DataPropertyName = "CreatedByUserId";
            this.CreatedByUserIdDataGridViewTextBoxColumn_.HeaderText = "CreatedByUserId";
            this.CreatedByUserIdDataGridViewTextBoxColumn_.Name = "CreatedByUserIdDataGridViewTextBoxColumn_";
            this.CreatedByUserIdDataGridViewTextBoxColumn_.ReadOnly = true;
            // 
            // CreatedByUserFullNameDataGridViewTextBoxColumn_
            // 
            this.CreatedByUserFullNameDataGridViewTextBoxColumn_.DataPropertyName = "CreatedByUserFullName";
            this.CreatedByUserFullNameDataGridViewTextBoxColumn_.HeaderText = "CreatedByUserFullName";
            this.CreatedByUserFullNameDataGridViewTextBoxColumn_.Name = "CreatedByUserFullNameDataGridViewTextBoxColumn_";
            this.CreatedByUserFullNameDataGridViewTextBoxColumn_.ReadOnly = true;
            // 
            // Orders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel1);
            this.MinimumSize = new System.Drawing.Size(1038, 660);
            this.Name = "Orders";
            this.Size = new System.Drawing.Size(1038, 660);
            this.Load += new System.EventHandler(this.Orders_Load);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ordersDataGridView)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcb_search_by_customer_name)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcb_search_by_invoiceno)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pOSWarehouseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox pcb_search_by_invoiceno;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pcb_search_by_customer_name;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txt_customername;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_invoiceno;
        private System.Windows.Forms.Button btn_refresh;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel1;
        private SuperMarketDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView ordersDataGridView;
        private System.Windows.Forms.Button btn_exportPDF;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdDataGridViewTextBoxColumn_;
        private System.Windows.Forms.DataGridViewTextBoxColumn InvoiceDateDataGridViewTextBoxColumn_;
        private System.Windows.Forms.DataGridViewTextBoxColumn InvoiceIdDataGridViewTextBoxColumn_;
        private System.Windows.Forms.DataGridViewTextBoxColumn CustomerIdDataGridViewTextBoxColumn_;
        private System.Windows.Forms.DataGridViewTextBoxColumn CustomerNameDataGridViewTextBoxColumn_;
        private System.Windows.Forms.DataGridViewTextBoxColumn ContactNumberDataGridViewTextBoxColumn_;
        private System.Windows.Forms.DataGridViewTextBoxColumn AddressDataGridViewTextBoxColumn_;
        private System.Windows.Forms.DataGridViewTextBoxColumn GrandTotalDataGridViewTextBoxColumn_;
        private System.Windows.Forms.DataGridViewTextBoxColumn CreatedByUserIdDataGridViewTextBoxColumn_;
        private System.Windows.Forms.DataGridViewTextBoxColumn CreatedByUserFullNameDataGridViewTextBoxColumn_;
        private System.Windows.Forms.BindingSource ordersBindingSource;
        private Data.POSWarehouseDataSet pOSWarehouseDataSet;
        private Data.POSWarehouseDataSetTableAdapters.OrdersTableAdapter ordersTableAdapter;
    }
}
