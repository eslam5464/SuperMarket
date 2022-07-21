﻿
namespace SuperMarket.UserControls
{
    partial class SupplierInvoicesHistory
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
            this.btn_exportPDF = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btn_refresh = new System.Windows.Forms.Button();
            this.pcb_search_by_supplier_name = new System.Windows.Forms.PictureBox();
            this.txt_supplierName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.db_supplierInvoicesDataGridView = new System.Windows.Forms.DataGridView();
            this.supplierInvoicesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.superMarketDataSet = new SuperMarket.SuperMarketDataSet();
            this.panel3 = new System.Windows.Forms.Panel();
            this.supplierInvoicesTableAdapter = new SuperMarket.SuperMarketDataSetTableAdapters.SupplierInvoicesTableAdapter();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SupplierId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SupplierName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PaymentMethod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AmountPaid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AmountLeft = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AmountTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PaymentStatus = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.SupplierInvoiceProductId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CreationDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcb_search_by_supplier_name)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.db_supplierInvoicesDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.supplierInvoicesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.superMarketDataSet)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
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
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.btn_exportPDF);
            this.panel4.Controls.Add(this.btn_refresh);
            this.panel4.Location = new System.Drawing.Point(676, 6);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(359, 100);
            this.panel4.TabIndex = 24;
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
            // pcb_search_by_supplier_name
            // 
            this.pcb_search_by_supplier_name.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pcb_search_by_supplier_name.Image = global::SuperMarket.Properties.Resources.icons8_search_48px_1;
            this.pcb_search_by_supplier_name.Location = new System.Drawing.Point(270, 42);
            this.pcb_search_by_supplier_name.Name = "pcb_search_by_supplier_name";
            this.pcb_search_by_supplier_name.Size = new System.Drawing.Size(45, 45);
            this.pcb_search_by_supplier_name.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcb_search_by_supplier_name.TabIndex = 138;
            this.pcb_search_by_supplier_name.TabStop = false;
            this.pcb_search_by_supplier_name.Click += new System.EventHandler(this.pcb_search_by_supplier_name_Click);
            this.pcb_search_by_supplier_name.MouseEnter += new System.EventHandler(this.pcb_supplierInvoicesHistory_MouseEnter);
            this.pcb_search_by_supplier_name.MouseLeave += new System.EventHandler(this.pcb_supplierInvoicesHistory_MouseLeave);
            // 
            // txt_supplierName
            // 
            this.txt_supplierName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_supplierName.BackColor = System.Drawing.Color.White;
            this.txt_supplierName.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.txt_supplierName.Font = new System.Drawing.Font("Palatino Linotype", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_supplierName.ForeColor = System.Drawing.Color.Black;
            this.txt_supplierName.Location = new System.Drawing.Point(14, 42);
            this.txt_supplierName.Multiline = true;
            this.txt_supplierName.Name = "txt_supplierName";
            this.txt_supplierName.Size = new System.Drawing.Size(250, 45);
            this.txt_supplierName.TabIndex = 48;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Purple;
            this.label1.Location = new System.Drawing.Point(145, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 23);
            this.label1.TabIndex = 46;
            this.label1.Text = ":اسم المورد";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.pcb_search_by_supplier_name);
            this.panel2.Controls.Add(this.txt_supplierName);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(14, 6);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(327, 100);
            this.panel2.TabIndex = 23;
            // 
            // db_supplierInvoicesDataGridView
            // 
            this.db_supplierInvoicesDataGridView.AllowUserToAddRows = false;
            this.db_supplierInvoicesDataGridView.AllowUserToDeleteRows = false;
            this.db_supplierInvoicesDataGridView.AllowUserToResizeColumns = false;
            this.db_supplierInvoicesDataGridView.AllowUserToResizeRows = false;
            this.db_supplierInvoicesDataGridView.AutoGenerateColumns = false;
            this.db_supplierInvoicesDataGridView.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Purple;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.db_supplierInvoicesDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.db_supplierInvoicesDataGridView.ColumnHeadersHeight = 40;
            this.db_supplierInvoicesDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.SupplierId,
            this.SupplierName,
            this.PaymentMethod,
            this.AmountPaid,
            this.AmountLeft,
            this.AmountTotal,
            this.PaymentStatus,
            this.SupplierInvoiceProductId,
            this.CreationDate});
            this.db_supplierInvoicesDataGridView.DataSource = this.supplierInvoicesBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.db_supplierInvoicesDataGridView.DefaultCellStyle = dataGridViewCellStyle2;
            this.db_supplierInvoicesDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.db_supplierInvoicesDataGridView.EnableHeadersVisualStyles = false;
            this.db_supplierInvoicesDataGridView.GridColor = System.Drawing.Color.Silver;
            this.db_supplierInvoicesDataGridView.Location = new System.Drawing.Point(0, 0);
            this.db_supplierInvoicesDataGridView.MultiSelect = false;
            this.db_supplierInvoicesDataGridView.Name = "db_supplierInvoicesDataGridView";
            this.db_supplierInvoicesDataGridView.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.db_supplierInvoicesDataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.db_supplierInvoicesDataGridView.Size = new System.Drawing.Size(1032, 536);
            this.db_supplierInvoicesDataGridView.TabIndex = 1;
            // 
            // supplierInvoicesBindingSource
            // 
            this.supplierInvoicesBindingSource.DataMember = "SupplierInvoices";
            this.supplierInvoicesBindingSource.DataSource = this.superMarketDataSet;
            // 
            // superMarketDataSet
            // 
            this.superMarketDataSet.DataSetName = "SuperMarketDataSet";
            this.superMarketDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Gray;
            this.panel3.Controls.Add(this.db_supplierInvoicesDataGridView);
            this.panel3.Location = new System.Drawing.Point(3, 118);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1032, 536);
            this.panel3.TabIndex = 21;
            // 
            // supplierInvoicesTableAdapter
            // 
            this.supplierInvoicesTableAdapter.ClearBeforeFill = true;
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            // 
            // SupplierId
            // 
            this.SupplierId.DataPropertyName = "SupplierId";
            this.SupplierId.HeaderText = "SupplierId";
            this.SupplierId.Name = "SupplierId";
            this.SupplierId.ReadOnly = true;
            // 
            // SupplierName
            // 
            this.SupplierName.DataPropertyName = "SupplierName";
            this.SupplierName.HeaderText = "SupplierName";
            this.SupplierName.Name = "SupplierName";
            this.SupplierName.ReadOnly = true;
            // 
            // PaymentMethod
            // 
            this.PaymentMethod.DataPropertyName = "PaymentMethod";
            this.PaymentMethod.HeaderText = "PaymentMethod";
            this.PaymentMethod.Name = "PaymentMethod";
            this.PaymentMethod.ReadOnly = true;
            // 
            // AmountPaid
            // 
            this.AmountPaid.DataPropertyName = "AmountPaid";
            this.AmountPaid.HeaderText = "AmountPaid";
            this.AmountPaid.Name = "AmountPaid";
            this.AmountPaid.ReadOnly = true;
            // 
            // AmountLeft
            // 
            this.AmountLeft.DataPropertyName = "AmountLeft";
            this.AmountLeft.HeaderText = "AmountLeft";
            this.AmountLeft.Name = "AmountLeft";
            this.AmountLeft.ReadOnly = true;
            // 
            // AmountTotal
            // 
            this.AmountTotal.DataPropertyName = "AmountTotal";
            this.AmountTotal.HeaderText = "AmountTotal";
            this.AmountTotal.Name = "AmountTotal";
            this.AmountTotal.ReadOnly = true;
            // 
            // PaymentStatus
            // 
            this.PaymentStatus.DataPropertyName = "PaymentStatus";
            this.PaymentStatus.HeaderText = "PaymentStatus";
            this.PaymentStatus.Name = "PaymentStatus";
            this.PaymentStatus.ReadOnly = true;
            this.PaymentStatus.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // SupplierInvoiceProductId
            // 
            this.SupplierInvoiceProductId.DataPropertyName = "SupplierInvoiceProductId";
            this.SupplierInvoiceProductId.HeaderText = "SupplierInvoiceProductId";
            this.SupplierInvoiceProductId.Name = "SupplierInvoiceProductId";
            this.SupplierInvoiceProductId.ReadOnly = true;
            // 
            // CreationDate
            // 
            this.CreationDate.DataPropertyName = "CreationDate";
            this.CreationDate.HeaderText = "CreationDate";
            this.CreationDate.Name = "CreationDate";
            this.CreationDate.ReadOnly = true;
            // 
            // SupplierInvoicesHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.MaximumSize = new System.Drawing.Size(1038, 660);
            this.MinimumSize = new System.Drawing.Size(1038, 660);
            this.Name = "SupplierInvoicesHistory";
            this.Size = new System.Drawing.Size(1038, 660);
            this.Load += new System.EventHandler(this.SupplierInvoicesHistory_Load);
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pcb_search_by_supplier_name)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.db_supplierInvoicesDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.supplierInvoicesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.superMarketDataSet)).EndInit();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btn_exportPDF;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btn_refresh;
        private System.Windows.Forms.PictureBox pcb_search_by_supplier_name;
        private System.Windows.Forms.TextBox txt_supplierName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView db_supplierInvoicesDataGridView;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.BindingSource supplierInvoicesBindingSource;
        private SuperMarketDataSet superMarketDataSet;
        private SuperMarketDataSetTableAdapters.SupplierInvoicesTableAdapter supplierInvoicesTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn SupplierId;
        private System.Windows.Forms.DataGridViewTextBoxColumn SupplierName;
        private System.Windows.Forms.DataGridViewTextBoxColumn PaymentMethod;
        private System.Windows.Forms.DataGridViewTextBoxColumn AmountPaid;
        private System.Windows.Forms.DataGridViewTextBoxColumn AmountLeft;
        private System.Windows.Forms.DataGridViewTextBoxColumn AmountTotal;
        private System.Windows.Forms.DataGridViewCheckBoxColumn PaymentStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn SupplierInvoiceProductId;
        private System.Windows.Forms.DataGridViewTextBoxColumn CreationDate;
    }
}