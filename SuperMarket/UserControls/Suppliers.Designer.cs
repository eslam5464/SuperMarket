
namespace SuperMarket.UserControls
{
    partial class Suppliers
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
            this.btn_edit = new System.Windows.Forms.Button();
            this.txt_description = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btn_exportPDF = new System.Windows.Forms.Button();
            this.btn_remove = new System.Windows.Forms.Button();
            this.btn_save = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_mobailno = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_fullname = new System.Windows.Forms.TextBox();
            this.superMarketDataSet = new SuperMarket.SuperMarketDataSet();
            this.suppliersTableAdapter = new SuperMarket.SuperMarketDataSetTableAdapters.SuppliersTableAdapter();
            this.tableAdapterManager = new SuperMarket.SuperMarketDataSetTableAdapters.TableAdapterManager();
            this.suppliersDataGridView = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.productsDataGridView = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Contact = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CreationDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.suppliersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pcb_searchName = new System.Windows.Forms.PictureBox();
            this.pcb_serchbyPhone = new System.Windows.Forms.PictureBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.superMarketDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.suppliersDataGridView)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productsDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.suppliersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcb_searchName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcb_serchbyPhone)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_edit
            // 
            this.btn_edit.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_edit.BackColor = System.Drawing.Color.Purple;
            this.btn_edit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_edit.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_edit.ForeColor = System.Drawing.Color.White;
            this.btn_edit.Location = new System.Drawing.Point(850, 135);
            this.btn_edit.Name = "btn_edit";
            this.btn_edit.Size = new System.Drawing.Size(163, 50);
            this.btn_edit.TabIndex = 197;
            this.btn_edit.Text = "تعديل";
            this.btn_edit.UseVisualStyleBackColor = false;
            this.btn_edit.Click += new System.EventHandler(this.btn_edit_Click);
            // 
            // txt_description
            // 
            this.txt_description.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_description.BackColor = System.Drawing.Color.White;
            this.txt_description.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.txt_description.Font = new System.Drawing.Font("Palatino Linotype", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_description.ForeColor = System.Drawing.Color.Black;
            this.txt_description.Location = new System.Drawing.Point(18, 49);
            this.txt_description.Multiline = true;
            this.txt_description.Name = "txt_description";
            this.txt_description.Size = new System.Drawing.Size(341, 45);
            this.txt_description.TabIndex = 196;
            this.txt_description.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_suppliers_KeyDown);
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Purple;
            this.label6.Location = new System.Drawing.Point(259, 18);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 23);
            this.label6.TabIndex = 195;
            this.label6.Text = ":العنوان";
            // 
            // btn_exportPDF
            // 
            this.btn_exportPDF.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_exportPDF.BackColor = System.Drawing.Color.Purple;
            this.btn_exportPDF.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_exportPDF.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_exportPDF.ForeColor = System.Drawing.Color.White;
            this.btn_exportPDF.Location = new System.Drawing.Point(420, 135);
            this.btn_exportPDF.Name = "btn_exportPDF";
            this.btn_exportPDF.Size = new System.Drawing.Size(163, 50);
            this.btn_exportPDF.TabIndex = 210;
            this.btn_exportPDF.Text = "طباعه الجدول";
            this.btn_exportPDF.UseVisualStyleBackColor = false;
            this.btn_exportPDF.Click += new System.EventHandler(this.btn_exportPDF_Click);
            // 
            // btn_remove
            // 
            this.btn_remove.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_remove.BackColor = System.Drawing.Color.Purple;
            this.btn_remove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_remove.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_remove.ForeColor = System.Drawing.Color.White;
            this.btn_remove.Location = new System.Drawing.Point(635, 135);
            this.btn_remove.Name = "btn_remove";
            this.btn_remove.Size = new System.Drawing.Size(163, 50);
            this.btn_remove.TabIndex = 209;
            this.btn_remove.Text = "مسح";
            this.btn_remove.UseVisualStyleBackColor = false;
            this.btn_remove.Click += new System.EventHandler(this.btn_remove_Click);
            // 
            // btn_save
            // 
            this.btn_save.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_save.BackColor = System.Drawing.Color.Purple;
            this.btn_save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_save.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_save.ForeColor = System.Drawing.Color.White;
            this.btn_save.Location = new System.Drawing.Point(850, 49);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(163, 50);
            this.btn_save.TabIndex = 207;
            this.btn_save.Text = "حفظ";
            this.btn_save.UseVisualStyleBackColor = false;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Purple;
            this.label1.Location = new System.Drawing.Point(227, 109);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 23);
            this.label1.TabIndex = 213;
            this.label1.Text = ":رقم الهاتف";
            // 
            // txt_mobailno
            // 
            this.txt_mobailno.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_mobailno.BackColor = System.Drawing.Color.White;
            this.txt_mobailno.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.txt_mobailno.Font = new System.Drawing.Font("Palatino Linotype", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_mobailno.ForeColor = System.Drawing.Color.Black;
            this.txt_mobailno.Location = new System.Drawing.Point(18, 140);
            this.txt_mobailno.Multiline = true;
            this.txt_mobailno.Name = "txt_mobailno";
            this.txt_mobailno.Size = new System.Drawing.Size(341, 45);
            this.txt_mobailno.TabIndex = 214;
            this.txt_mobailno.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_suppliers_KeyDown);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Purple;
            this.label3.Location = new System.Drawing.Point(627, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 23);
            this.label3.TabIndex = 211;
            this.label3.Text = ":الاسم بـالكامل";
            // 
            // txt_fullname
            // 
            this.txt_fullname.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_fullname.BackColor = System.Drawing.Color.White;
            this.txt_fullname.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.txt_fullname.Font = new System.Drawing.Font("Palatino Linotype", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_fullname.ForeColor = System.Drawing.Color.Black;
            this.txt_fullname.Location = new System.Drawing.Point(420, 49);
            this.txt_fullname.Multiline = true;
            this.txt_fullname.Name = "txt_fullname";
            this.txt_fullname.Size = new System.Drawing.Size(341, 45);
            this.txt_fullname.TabIndex = 212;
            this.txt_fullname.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_suppliers_KeyDown);
            // 
            // superMarketDataSet
            // 
            this.superMarketDataSet.DataSetName = "SuperMarketDataSet";
            this.superMarketDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // suppliersTableAdapter
            // 
            this.suppliersTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CategoriesTableAdapter = null;
            this.tableAdapterManager.CustomersTableAdapter = null;
            this.tableAdapterManager.InvoicesTableAdapter = null;
            this.tableAdapterManager.OrdersTableAdapter = null;
            this.tableAdapterManager.ProductsTableAdapter = null;
            this.tableAdapterManager.SupplierInvoiceProductTableAdapter = null;
            this.tableAdapterManager.SupplierInvoicesTableAdapter = null;
            this.tableAdapterManager.SuppliersTableAdapter = this.suppliersTableAdapter;
            this.tableAdapterManager.UpdateOrder = SuperMarket.SuperMarketDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UserLevelAccessTableAdapter = null;
            this.tableAdapterManager.UsersTableAdapter = null;
            // 
            // suppliersDataGridView
            // 
            this.suppliersDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.suppliersDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.suppliersDataGridView.Location = new System.Drawing.Point(0, 0);
            this.suppliersDataGridView.Name = "suppliersDataGridView";
            this.suppliersDataGridView.Size = new System.Drawing.Size(1032, 445);
            this.suppliersDataGridView.TabIndex = 215;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gray;
            this.panel1.Controls.Add(this.productsDataGridView);
            this.panel1.Controls.Add(this.suppliersDataGridView);
            this.panel1.Location = new System.Drawing.Point(3, 213);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1032, 445);
            this.panel1.TabIndex = 216;
            // 
            // productsDataGridView
            // 
            this.productsDataGridView.AllowUserToAddRows = false;
            this.productsDataGridView.AllowUserToDeleteRows = false;
            this.productsDataGridView.AllowUserToResizeColumns = false;
            this.productsDataGridView.AllowUserToResizeRows = false;
            this.productsDataGridView.AutoGenerateColumns = false;
            this.productsDataGridView.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Purple;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.productsDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.productsDataGridView.ColumnHeadersHeight = 40;
            this.productsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.ProductName,
            this.Contact,
            this.Address,
            this.CreationDate});
            this.productsDataGridView.DataSource = this.suppliersBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.productsDataGridView.DefaultCellStyle = dataGridViewCellStyle2;
            this.productsDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.productsDataGridView.EnableHeadersVisualStyles = false;
            this.productsDataGridView.GridColor = System.Drawing.Color.Silver;
            this.productsDataGridView.Location = new System.Drawing.Point(0, 0);
            this.productsDataGridView.MultiSelect = false;
            this.productsDataGridView.Name = "productsDataGridView";
            this.productsDataGridView.ReadOnly = true;
            this.productsDataGridView.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.productsDataGridView.RowHeadersVisible = false;
            this.productsDataGridView.Size = new System.Drawing.Size(1032, 445);
            this.productsDataGridView.TabIndex = 1;
            this.productsDataGridView.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.productsDataGridView_CellMouseClick);
            this.productsDataGridView.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.productsDataGridView_ColumnHeaderMouseClick);
            this.productsDataGridView.ColumnHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.productsDataGridView_ColumnHeaderMouseDoubleClick);
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            // 
            // ProductName
            // 
            this.ProductName.DataPropertyName = "Name";
            this.ProductName.HeaderText = "Name";
            this.ProductName.Name = "ProductName";
            this.ProductName.ReadOnly = true;
            // 
            // Contact
            // 
            this.Contact.DataPropertyName = "Contact";
            this.Contact.HeaderText = "Contact";
            this.Contact.Name = "Contact";
            this.Contact.ReadOnly = true;
            // 
            // Address
            // 
            this.Address.DataPropertyName = "Address";
            this.Address.HeaderText = "Address";
            this.Address.Name = "Address";
            this.Address.ReadOnly = true;
            // 
            // CreationDate
            // 
            this.CreationDate.DataPropertyName = "CreationDate";
            this.CreationDate.HeaderText = "CreationDate";
            this.CreationDate.Name = "CreationDate";
            this.CreationDate.ReadOnly = true;
            // 
            // suppliersBindingSource
            // 
            this.suppliersBindingSource.DataMember = "Suppliers";
            this.suppliersBindingSource.DataSource = this.superMarketDataSet;
            // 
            // pcb_searchName
            // 
            this.pcb_searchName.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pcb_searchName.Image = global::SuperMarket.Properties.Resources.icons8_search_48px_1;
            this.pcb_searchName.Location = new System.Drawing.Point(767, 49);
            this.pcb_searchName.Name = "pcb_searchName";
            this.pcb_searchName.Size = new System.Drawing.Size(45, 45);
            this.pcb_searchName.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcb_searchName.TabIndex = 217;
            this.pcb_searchName.TabStop = false;
            this.pcb_searchName.Click += new System.EventHandler(this.pcb_searchName_Click);
            this.pcb_searchName.DoubleClick += new System.EventHandler(this.pcb_searchName_DoubleClick);
            // 
            // pcb_serchbyPhone
            // 
            this.pcb_serchbyPhone.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pcb_serchbyPhone.Image = global::SuperMarket.Properties.Resources.icons8_search_48px_1;
            this.pcb_serchbyPhone.Location = new System.Drawing.Point(365, 140);
            this.pcb_serchbyPhone.Name = "pcb_serchbyPhone";
            this.pcb_serchbyPhone.Size = new System.Drawing.Size(45, 45);
            this.pcb_serchbyPhone.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcb_serchbyPhone.TabIndex = 218;
            this.pcb_serchbyPhone.TabStop = false;
            this.pcb_serchbyPhone.Click += new System.EventHandler(this.pcb_serchbyPhone_Click);
            this.pcb_serchbyPhone.DoubleClick += new System.EventHandler(this.pcb_serchbyPhone_DoubleClick);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Red;
            this.label9.Location = new System.Drawing.Point(404, 29);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(29, 37);
            this.label9.TabIndex = 219;
            this.label9.Text = "*";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(8, 124);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 37);
            this.label2.TabIndex = 220;
            this.label2.Text = "*";
            // 
            // Suppliers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pcb_serchbyPhone);
            this.Controls.Add(this.pcb_searchName);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_mobailno);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_fullname);
            this.Controls.Add(this.btn_exportPDF);
            this.Controls.Add(this.btn_remove);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.btn_edit);
            this.Controls.Add(this.txt_description);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label2);
            this.MinimumSize = new System.Drawing.Size(1038, 660);
            this.Name = "Suppliers";
            this.Size = new System.Drawing.Size(1038, 660);
            this.Load += new System.EventHandler(this.Suppliers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.superMarketDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.suppliersDataGridView)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.productsDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.suppliersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcb_searchName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcb_serchbyPhone)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_edit;
        private System.Windows.Forms.TextBox txt_description;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btn_exportPDF;
        private System.Windows.Forms.Button btn_remove;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_mobailno;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_fullname;
        private SuperMarketDataSet superMarketDataSet;
        private SuperMarketDataSetTableAdapters.SuppliersTableAdapter suppliersTableAdapter;
        private SuperMarketDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView suppliersDataGridView;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView productsDataGridView;
        private System.Windows.Forms.PictureBox pcb_searchName;
        private System.Windows.Forms.PictureBox pcb_serchbyPhone;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.BindingSource suppliersBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Contact;
        private System.Windows.Forms.DataGridViewTextBoxColumn Address;
        private System.Windows.Forms.DataGridViewTextBoxColumn CreationDate;
    }
}
