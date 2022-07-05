
namespace SuperMarket.UserControls
{
    partial class SupplierInvoices
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
            this.txt_paymentMethod = new System.Windows.Forms.ComboBox();
            this.txt_search = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_searchedSupplierContact = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_searchedSupplierAddress = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.pan_searchResults = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_searchType = new System.Windows.Forms.ComboBox();
            this.pcb_searchSupplier = new System.Windows.Forms.PictureBox();
            this.pan_payment = new System.Windows.Forms.Panel();
            this.txt_searchedSupplierName = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.pan_product = new System.Windows.Forms.Panel();
            this.pan_productDataGrid = new System.Windows.Forms.Panel();
            this.db_productDataGridView = new System.Windows.Forms.DataGridView();
            this.superMarketDataSet = new SuperMarket.SuperMarketDataSet();
            this.supplierInvoiceProductBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.supplierInvoiceProductTableAdapter = new SuperMarket.SuperMarketDataSetTableAdapters.SupplierInvoiceProductTableAdapter();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CreationDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pan_searchResults.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcb_searchSupplier)).BeginInit();
            this.pan_payment.SuspendLayout();
            this.pan_product.SuspendLayout();
            this.pan_productDataGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.db_productDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.superMarketDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.supplierInvoiceProductBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_paymentMethod
            // 
            this.txt_paymentMethod.DropDownHeight = 200;
            this.txt_paymentMethod.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txt_paymentMethod.Font = new System.Drawing.Font("Palatino Linotype", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_paymentMethod.FormattingEnabled = true;
            this.txt_paymentMethod.IntegralHeight = false;
            this.txt_paymentMethod.Location = new System.Drawing.Point(28, 33);
            this.txt_paymentMethod.Name = "txt_paymentMethod";
            this.txt_paymentMethod.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txt_paymentMethod.Size = new System.Drawing.Size(175, 40);
            this.txt_paymentMethod.TabIndex = 200;
            // 
            // txt_search
            // 
            this.txt_search.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_search.BackColor = System.Drawing.Color.White;
            this.txt_search.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.txt_search.Font = new System.Drawing.Font("Palatino Linotype", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_search.ForeColor = System.Drawing.Color.Black;
            this.txt_search.Location = new System.Drawing.Point(638, 17);
            this.txt_search.Multiline = true;
            this.txt_search.Name = "txt_search";
            this.txt_search.Size = new System.Drawing.Size(208, 45);
            this.txt_search.TabIndex = 199;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Purple;
            this.label5.Location = new System.Drawing.Point(234, 33);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 23);
            this.label5.TabIndex = 197;
            this.label5.Text = ":نوع الدفع";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Purple;
            this.label6.Location = new System.Drawing.Point(951, 27);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 23);
            this.label6.TabIndex = 198;
            this.label6.Text = ": البحث بـ";
            // 
            // txt_searchedSupplierContact
            // 
            this.txt_searchedSupplierContact.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_searchedSupplierContact.BackColor = System.Drawing.Color.White;
            this.txt_searchedSupplierContact.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.txt_searchedSupplierContact.Font = new System.Drawing.Font("Palatino Linotype", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_searchedSupplierContact.ForeColor = System.Drawing.Color.Black;
            this.txt_searchedSupplierContact.Location = new System.Drawing.Point(9, 97);
            this.txt_searchedSupplierContact.Multiline = true;
            this.txt_searchedSupplierContact.Name = "txt_searchedSupplierContact";
            this.txt_searchedSupplierContact.ReadOnly = true;
            this.txt_searchedSupplierContact.Size = new System.Drawing.Size(332, 45);
            this.txt_searchedSupplierContact.TabIndex = 202;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Purple;
            this.label1.Location = new System.Drawing.Point(357, 107);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 23);
            this.label1.TabIndex = 201;
            this.label1.Text = ":التواصل";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Purple;
            this.label2.Location = new System.Drawing.Point(378, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 23);
            this.label2.TabIndex = 203;
            this.label2.Text = ":الاسم";
            // 
            // txt_searchedSupplierAddress
            // 
            this.txt_searchedSupplierAddress.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_searchedSupplierAddress.BackColor = System.Drawing.Color.White;
            this.txt_searchedSupplierAddress.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.txt_searchedSupplierAddress.Font = new System.Drawing.Font("Palatino Linotype", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_searchedSupplierAddress.ForeColor = System.Drawing.Color.Black;
            this.txt_searchedSupplierAddress.Location = new System.Drawing.Point(9, 159);
            this.txt_searchedSupplierAddress.Multiline = true;
            this.txt_searchedSupplierAddress.Name = "txt_searchedSupplierAddress";
            this.txt_searchedSupplierAddress.ReadOnly = true;
            this.txt_searchedSupplierAddress.Size = new System.Drawing.Size(332, 45);
            this.txt_searchedSupplierAddress.TabIndex = 206;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Purple;
            this.label3.Location = new System.Drawing.Point(364, 170);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 23);
            this.label3.TabIndex = 205;
            this.label3.Text = ":العنوان";
            // 
            // pan_searchResults
            // 
            this.pan_searchResults.BackColor = System.Drawing.Color.Gainsboro;
            this.pan_searchResults.Controls.Add(this.txt_searchedSupplierName);
            this.pan_searchResults.Controls.Add(this.label4);
            this.pan_searchResults.Controls.Add(this.label2);
            this.pan_searchResults.Controls.Add(this.label3);
            this.pan_searchResults.Controls.Add(this.label1);
            this.pan_searchResults.Controls.Add(this.txt_searchedSupplierAddress);
            this.pan_searchResults.Controls.Add(this.txt_searchedSupplierContact);
            this.pan_searchResults.Enabled = false;
            this.pan_searchResults.Location = new System.Drawing.Point(587, 80);
            this.pan_searchResults.Name = "pan_searchResults";
            this.pan_searchResults.Size = new System.Drawing.Size(438, 219);
            this.pan_searchResults.TabIndex = 207;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Purple;
            this.label4.Location = new System.Drawing.Point(180, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 23);
            this.label4.TabIndex = 207;
            this.label4.Text = "نتاج البحث";
            // 
            // txt_searchType
            // 
            this.txt_searchType.DropDownHeight = 200;
            this.txt_searchType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txt_searchType.Font = new System.Drawing.Font("Palatino Linotype", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_searchType.FormattingEnabled = true;
            this.txt_searchType.IntegralHeight = false;
            this.txt_searchType.Location = new System.Drawing.Point(852, 17);
            this.txt_searchType.Name = "txt_searchType";
            this.txt_searchType.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txt_searchType.Size = new System.Drawing.Size(93, 40);
            this.txt_searchType.TabIndex = 208;
            // 
            // pcb_searchSupplier
            // 
            this.pcb_searchSupplier.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pcb_searchSupplier.Image = global::SuperMarket.Properties.Resources.icons8_search_48px_1;
            this.pcb_searchSupplier.Location = new System.Drawing.Point(587, 17);
            this.pcb_searchSupplier.Name = "pcb_searchSupplier";
            this.pcb_searchSupplier.Size = new System.Drawing.Size(45, 45);
            this.pcb_searchSupplier.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcb_searchSupplier.TabIndex = 209;
            this.pcb_searchSupplier.TabStop = false;
            this.pcb_searchSupplier.Click += new System.EventHandler(this.pcb_searchSupplier_Click);
            this.pcb_searchSupplier.MouseEnter += new System.EventHandler(this.pcb_supplier_MouseEnter);
            this.pcb_searchSupplier.MouseLeave += new System.EventHandler(this.pcb_supplier_MouseLeave);
            // 
            // pan_payment
            // 
            this.pan_payment.BackColor = System.Drawing.Color.Gainsboro;
            this.pan_payment.Controls.Add(this.txt_paymentMethod);
            this.pan_payment.Controls.Add(this.label5);
            this.pan_payment.Location = new System.Drawing.Point(65, 27);
            this.pan_payment.Name = "pan_payment";
            this.pan_payment.Size = new System.Drawing.Size(374, 241);
            this.pan_payment.TabIndex = 210;
            // 
            // txt_searchedSupplierName
            // 
            this.txt_searchedSupplierName.BackColor = System.Drawing.Color.White;
            this.txt_searchedSupplierName.DropDownHeight = 200;
            this.txt_searchedSupplierName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txt_searchedSupplierName.Font = new System.Drawing.Font("Palatino Linotype", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_searchedSupplierName.FormattingEnabled = true;
            this.txt_searchedSupplierName.IntegralHeight = false;
            this.txt_searchedSupplierName.Location = new System.Drawing.Point(9, 40);
            this.txt_searchedSupplierName.Name = "txt_searchedSupplierName";
            this.txt_searchedSupplierName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txt_searchedSupplierName.Size = new System.Drawing.Size(332, 40);
            this.txt_searchedSupplierName.TabIndex = 209;
            this.txt_searchedSupplierName.SelectedIndexChanged += new System.EventHandler(this.text_searchedSupplierName_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Purple;
            this.label7.Location = new System.Drawing.Point(465, 16);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(48, 23);
            this.label7.TabIndex = 208;
            this.label7.Text = "المنتج";
            // 
            // pan_product
            // 
            this.pan_product.BackColor = System.Drawing.Color.Gainsboro;
            this.pan_product.Controls.Add(this.pan_productDataGrid);
            this.pan_product.Controls.Add(this.label7);
            this.pan_product.Location = new System.Drawing.Point(10, 305);
            this.pan_product.Name = "pan_product";
            this.pan_product.Size = new System.Drawing.Size(1015, 352);
            this.pan_product.TabIndex = 211;
            // 
            // pan_productDataGrid
            // 
            this.pan_productDataGrid.BackColor = System.Drawing.Color.Gray;
            this.pan_productDataGrid.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pan_productDataGrid.Controls.Add(this.db_productDataGridView);
            this.pan_productDataGrid.Location = new System.Drawing.Point(3, 121);
            this.pan_productDataGrid.Name = "pan_productDataGrid";
            this.pan_productDataGrid.Size = new System.Drawing.Size(1009, 228);
            this.pan_productDataGrid.TabIndex = 208;
            // 
            // db_productDataGridView
            // 
            this.db_productDataGridView.AllowUserToAddRows = false;
            this.db_productDataGridView.AllowUserToDeleteRows = false;
            this.db_productDataGridView.AllowUserToResizeColumns = false;
            this.db_productDataGridView.AllowUserToResizeRows = false;
            this.db_productDataGridView.AutoGenerateColumns = false;
            this.db_productDataGridView.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Purple;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.db_productDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.db_productDataGridView.ColumnHeadersHeight = 40;
            this.db_productDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.ProductId,
            this.ProductName,
            this.Quantity,
            this.CreationDate});
            this.db_productDataGridView.DataSource = this.supplierInvoiceProductBindingSource;
            this.db_productDataGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.db_productDataGridView.EnableHeadersVisualStyles = false;
            this.db_productDataGridView.GridColor = System.Drawing.Color.Silver;
            this.db_productDataGridView.Location = new System.Drawing.Point(3, 3);
            this.db_productDataGridView.MultiSelect = false;
            this.db_productDataGridView.Name = "db_productDataGridView";
            this.db_productDataGridView.ReadOnly = true;
            this.db_productDataGridView.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.db_productDataGridView.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.db_productDataGridView.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Palatino Linotype", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.db_productDataGridView.RowTemplate.Height = 24;
            this.db_productDataGridView.Size = new System.Drawing.Size(1001, 220);
            this.db_productDataGridView.TabIndex = 1;
            // 
            // superMarketDataSet
            // 
            this.superMarketDataSet.DataSetName = "SuperMarketDataSet";
            this.superMarketDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // supplierInvoiceProductBindingSource
            // 
            this.supplierInvoiceProductBindingSource.DataMember = "SupplierInvoiceProduct";
            this.supplierInvoiceProductBindingSource.DataSource = this.superMarketDataSet;
            // 
            // supplierInvoiceProductTableAdapter
            // 
            this.supplierInvoiceProductTableAdapter.ClearBeforeFill = true;
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            // 
            // ProductId
            // 
            this.ProductId.DataPropertyName = "ProductId";
            this.ProductId.HeaderText = "ProductId";
            this.ProductId.Name = "ProductId";
            this.ProductId.ReadOnly = true;
            // 
            // ProductName
            // 
            this.ProductName.DataPropertyName = "ProductName";
            this.ProductName.HeaderText = "ProductName";
            this.ProductName.Name = "ProductName";
            this.ProductName.ReadOnly = true;
            // 
            // Quantity
            // 
            this.Quantity.DataPropertyName = "Quantity";
            this.Quantity.HeaderText = "Quantity";
            this.Quantity.Name = "Quantity";
            this.Quantity.ReadOnly = true;
            // 
            // CreationDate
            // 
            this.CreationDate.DataPropertyName = "CreationDate";
            this.CreationDate.HeaderText = "CreationDate";
            this.CreationDate.Name = "CreationDate";
            this.CreationDate.ReadOnly = true;
            // 
            // SupplierInvoices
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pan_payment);
            this.Controls.Add(this.pan_product);
            this.Controls.Add(this.pcb_searchSupplier);
            this.Controls.Add(this.txt_searchType);
            this.Controls.Add(this.pan_searchResults);
            this.Controls.Add(this.txt_search);
            this.Controls.Add(this.label6);
            this.MaximumSize = new System.Drawing.Size(1038, 660);
            this.MinimumSize = new System.Drawing.Size(1038, 660);
            this.Name = "SupplierInvoices";
            this.Size = new System.Drawing.Size(1038, 660);
            this.Load += new System.EventHandler(this.SupplierInvoices_Load);
            this.pan_searchResults.ResumeLayout(false);
            this.pan_searchResults.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcb_searchSupplier)).EndInit();
            this.pan_payment.ResumeLayout(false);
            this.pan_payment.PerformLayout();
            this.pan_product.ResumeLayout(false);
            this.pan_product.PerformLayout();
            this.pan_productDataGrid.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.db_productDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.superMarketDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.supplierInvoiceProductBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox txt_paymentMethod;
        private System.Windows.Forms.TextBox txt_search;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_searchedSupplierContact;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_searchedSupplierAddress;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel pan_searchResults;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox txt_searchType;
        private System.Windows.Forms.PictureBox pcb_searchSupplier;
        private System.Windows.Forms.Panel pan_payment;
        private System.Windows.Forms.ComboBox txt_searchedSupplierName;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel pan_product;
        private System.Windows.Forms.Panel pan_productDataGrid;
        private System.Windows.Forms.DataGridView db_productDataGridView;
        private System.Windows.Forms.BindingSource supplierInvoiceProductBindingSource;
        private SuperMarketDataSet superMarketDataSet;
        private SuperMarketDataSetTableAdapters.SupplierInvoiceProductTableAdapter supplierInvoiceProductTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn CreationDate;
    }
}
