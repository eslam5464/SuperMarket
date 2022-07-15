namespace SuperMarket.UserControls
{
    partial class Categories
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
            this.btn_CategoryRemove = new System.Windows.Forms.Button();
            this.btn_categoryEdit = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.categoriesDataGridView = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CategoryName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StorageId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StorageName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CreationDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categoriesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.superMarketDataSet = new SuperMarket.SuperMarketDataSet();
            this.btn_saveCategory = new System.Windows.Forms.Button();
            this.txt_categorieid = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_categoriename = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pcb_searchID = new System.Windows.Forms.PictureBox();
            this.pcb_searchName = new System.Windows.Forms.PictureBox();
            this.categoriesTableAdapter = new SuperMarket.SuperMarketDataSetTableAdapters.CategoriesTableAdapter();
            this.tableAdapterManager = new SuperMarket.SuperMarketDataSetTableAdapters.TableAdapterManager();
            this.btn_exportPDF = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_storageNameSearch = new System.Windows.Forms.ComboBox();
            this.txt_storageName = new System.Windows.Forms.TextBox();
            this.btn_saveStorage = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btn_storageDelete = new System.Windows.Forms.Button();
            this.txt_storageNameEdit = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btn_storageEdit = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.pcb_searchStorage = new System.Windows.Forms.PictureBox();
            this.label9 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.categoriesDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoriesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.superMarketDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcb_searchID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcb_searchName)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcb_searchStorage)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_CategoryRemove
            // 
            this.btn_CategoryRemove.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_CategoryRemove.BackColor = System.Drawing.Color.Purple;
            this.btn_CategoryRemove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_CategoryRemove.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold);
            this.btn_CategoryRemove.ForeColor = System.Drawing.Color.White;
            this.btn_CategoryRemove.Location = new System.Drawing.Point(546, 136);
            this.btn_CategoryRemove.Name = "btn_CategoryRemove";
            this.btn_CategoryRemove.Size = new System.Drawing.Size(154, 50);
            this.btn_CategoryRemove.TabIndex = 137;
            this.btn_CategoryRemove.Text = "مسح";
            this.btn_CategoryRemove.UseVisualStyleBackColor = false;
            this.btn_CategoryRemove.Click += new System.EventHandler(this.btn_remove_Click);
            // 
            // btn_categoryEdit
            // 
            this.btn_categoryEdit.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_categoryEdit.BackColor = System.Drawing.Color.Purple;
            this.btn_categoryEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_categoryEdit.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold);
            this.btn_categoryEdit.ForeColor = System.Drawing.Color.White;
            this.btn_categoryEdit.Location = new System.Drawing.Point(330, 136);
            this.btn_categoryEdit.Name = "btn_categoryEdit";
            this.btn_categoryEdit.Size = new System.Drawing.Size(154, 50);
            this.btn_categoryEdit.TabIndex = 136;
            this.btn_categoryEdit.Text = "تعديل";
            this.btn_categoryEdit.UseVisualStyleBackColor = false;
            this.btn_categoryEdit.Click += new System.EventHandler(this.btn_edit_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gray;
            this.panel1.Controls.Add(this.categoriesDataGridView);
            this.panel1.Location = new System.Drawing.Point(3, 364);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1032, 293);
            this.panel1.TabIndex = 138;
            // 
            // categoriesDataGridView
            // 
            this.categoriesDataGridView.AllowUserToAddRows = false;
            this.categoriesDataGridView.AllowUserToDeleteRows = false;
            this.categoriesDataGridView.AllowUserToResizeColumns = false;
            this.categoriesDataGridView.AllowUserToResizeRows = false;
            this.categoriesDataGridView.AutoGenerateColumns = false;
            this.categoriesDataGridView.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Purple;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.categoriesDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.categoriesDataGridView.ColumnHeadersHeight = 40;
            this.categoriesDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.CategoryName,
            this.StorageId,
            this.StorageName,
            this.CreationDate});
            this.categoriesDataGridView.DataSource = this.categoriesBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.categoriesDataGridView.DefaultCellStyle = dataGridViewCellStyle2;
            this.categoriesDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.categoriesDataGridView.EnableHeadersVisualStyles = false;
            this.categoriesDataGridView.GridColor = System.Drawing.Color.Silver;
            this.categoriesDataGridView.Location = new System.Drawing.Point(0, 0);
            this.categoriesDataGridView.MultiSelect = false;
            this.categoriesDataGridView.Name = "categoriesDataGridView";
            this.categoriesDataGridView.ReadOnly = true;
            this.categoriesDataGridView.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.categoriesDataGridView.Size = new System.Drawing.Size(1032, 293);
            this.categoriesDataGridView.TabIndex = 0;
            this.categoriesDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.categoriesDataGridView_CellContentClick);
            this.categoriesDataGridView.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.categoriesDataGridView_CellMouseClick);
            this.categoriesDataGridView.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.db_categoriesDataGridView_ColumnHeaderMouseClick);
            this.categoriesDataGridView.ColumnHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.db_categoriesDataGridView_ColumnHeaderMouseDoubleClick);
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            // 
            // CategoryName
            // 
            this.CategoryName.DataPropertyName = "Name";
            this.CategoryName.HeaderText = "Name";
            this.CategoryName.Name = "CategoryName";
            this.CategoryName.ReadOnly = true;
            // 
            // StorageId
            // 
            this.StorageId.DataPropertyName = "StorageId";
            this.StorageId.HeaderText = "StorageId";
            this.StorageId.Name = "StorageId";
            this.StorageId.ReadOnly = true;
            // 
            // StorageName
            // 
            this.StorageName.DataPropertyName = "StorageName";
            this.StorageName.HeaderText = "StorageName";
            this.StorageName.Name = "StorageName";
            this.StorageName.ReadOnly = true;
            // 
            // CreationDate
            // 
            this.CreationDate.DataPropertyName = "CreationDate";
            this.CreationDate.HeaderText = "CreationDate";
            this.CreationDate.Name = "CreationDate";
            this.CreationDate.ReadOnly = true;
            // 
            // categoriesBindingSource
            // 
            this.categoriesBindingSource.DataMember = "Categories";
            this.categoriesBindingSource.DataSource = this.superMarketDataSet;
            this.categoriesBindingSource.CurrentChanged += new System.EventHandler(this.categoriesBindingSource_CurrentChanged);
            // 
            // superMarketDataSet
            // 
            this.superMarketDataSet.DataSetName = "SuperMarketDataSet";
            this.superMarketDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btn_saveCategory
            // 
            this.btn_saveCategory.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_saveCategory.BackColor = System.Drawing.Color.Purple;
            this.btn_saveCategory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_saveCategory.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_saveCategory.ForeColor = System.Drawing.Color.White;
            this.btn_saveCategory.Location = new System.Drawing.Point(114, 136);
            this.btn_saveCategory.Name = "btn_saveCategory";
            this.btn_saveCategory.Size = new System.Drawing.Size(154, 50);
            this.btn_saveCategory.TabIndex = 135;
            this.btn_saveCategory.Text = "حفظ";
            this.btn_saveCategory.UseVisualStyleBackColor = false;
            this.btn_saveCategory.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // txt_categorieid
            // 
            this.txt_categorieid.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_categorieid.BackColor = System.Drawing.Color.White;
            this.txt_categorieid.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.txt_categorieid.Font = new System.Drawing.Font("Palatino Linotype", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_categorieid.ForeColor = System.Drawing.Color.Black;
            this.txt_categorieid.Location = new System.Drawing.Point(384, 76);
            this.txt_categorieid.Multiline = true;
            this.txt_categorieid.Name = "txt_categorieid";
            this.txt_categorieid.ShortcutsEnabled = false;
            this.txt_categorieid.Size = new System.Drawing.Size(150, 45);
            this.txt_categorieid.TabIndex = 132;
            this.txt_categorieid.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_category_KeyDown);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Purple;
            this.label3.Location = new System.Drawing.Point(741, 45);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 28);
            this.label3.TabIndex = 129;
            this.label3.Text = ":اسم التصنيف";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Purple;
            this.label2.Location = new System.Drawing.Point(413, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 28);
            this.label2.TabIndex = 130;
            this.label2.Text = ":رقم التصنيف";
            // 
            // txt_categoriename
            // 
            this.txt_categoriename.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_categoriename.BackColor = System.Drawing.Color.White;
            this.txt_categoriename.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.txt_categoriename.Font = new System.Drawing.Font("Palatino Linotype", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_categoriename.ForeColor = System.Drawing.Color.Black;
            this.txt_categoriename.Location = new System.Drawing.Point(624, 76);
            this.txt_categoriename.Multiline = true;
            this.txt_categoriename.Name = "txt_categoriename";
            this.txt_categoriename.Size = new System.Drawing.Size(300, 45);
            this.txt_categoriename.TabIndex = 131;
            this.txt_categoriename.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_category_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(850, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 37);
            this.label1.TabIndex = 139;
            this.label1.Text = "*";
            // 
            // pcb_searchID
            // 
            this.pcb_searchID.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pcb_searchID.Image = global::SuperMarket.Properties.Resources.icons8_search_48px_1;
            this.pcb_searchID.Location = new System.Drawing.Point(542, 77);
            this.pcb_searchID.Name = "pcb_searchID";
            this.pcb_searchID.Size = new System.Drawing.Size(45, 45);
            this.pcb_searchID.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcb_searchID.TabIndex = 134;
            this.pcb_searchID.TabStop = false;
            this.pcb_searchID.Click += new System.EventHandler(this.pcb_searchID_Click);
            this.pcb_searchID.DoubleClick += new System.EventHandler(this.pcb_search_DoubleClick);
            this.pcb_searchID.MouseEnter += new System.EventHandler(this.pcb_search_MouseEnter);
            this.pcb_searchID.MouseLeave += new System.EventHandler(this.pcb_search_MouseLeave);
            // 
            // pcb_searchName
            // 
            this.pcb_searchName.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pcb_searchName.Image = global::SuperMarket.Properties.Resources.icons8_search_48px_1;
            this.pcb_searchName.Location = new System.Drawing.Point(932, 77);
            this.pcb_searchName.Name = "pcb_searchName";
            this.pcb_searchName.Size = new System.Drawing.Size(45, 45);
            this.pcb_searchName.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcb_searchName.TabIndex = 133;
            this.pcb_searchName.TabStop = false;
            this.pcb_searchName.Click += new System.EventHandler(this.pcb_searchName_Click);
            this.pcb_searchName.DoubleClick += new System.EventHandler(this.pcb_search_DoubleClick);
            this.pcb_searchName.MouseEnter += new System.EventHandler(this.pcb_search_MouseEnter);
            this.pcb_searchName.MouseLeave += new System.EventHandler(this.pcb_search_MouseLeave);
            // 
            // categoriesTableAdapter
            // 
            this.categoriesTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CategoriesTableAdapter = this.categoriesTableAdapter;
            this.tableAdapterManager.CustomersTableAdapter = null;
            this.tableAdapterManager.InvoicesTableAdapter = null;
            this.tableAdapterManager.OrdersTableAdapter = null;
            this.tableAdapterManager.ProductPriceTableAdapter = null;
            this.tableAdapterManager.ProductsTableAdapter = null;
            this.tableAdapterManager.SafeTableAdapter = null;
            this.tableAdapterManager.SafeTransactionTableAdapter = null;
            this.tableAdapterManager.StorageTableAdapter = null;
            this.tableAdapterManager.SupplierInvoiceProductTableAdapter = null;
            this.tableAdapterManager.SupplierInvoicesTableAdapter = null;
            this.tableAdapterManager.SuppliersTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = SuperMarket.SuperMarketDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UserLevelAccessTableAdapter = null;
            this.tableAdapterManager.UsersTableAdapter = null;
            // 
            // btn_exportPDF
            // 
            this.btn_exportPDF.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_exportPDF.BackColor = System.Drawing.Color.Purple;
            this.btn_exportPDF.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_exportPDF.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_exportPDF.ForeColor = System.Drawing.Color.White;
            this.btn_exportPDF.Location = new System.Drawing.Point(762, 136);
            this.btn_exportPDF.Name = "btn_exportPDF";
            this.btn_exportPDF.Size = new System.Drawing.Size(154, 50);
            this.btn_exportPDF.TabIndex = 168;
            this.btn_exportPDF.Text = "طباعه الجدول";
            this.btn_exportPDF.UseVisualStyleBackColor = false;
            this.btn_exportPDF.Click += new System.EventHandler(this.btn_exportPDF_Click);
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Purple;
            this.label4.Location = new System.Drawing.Point(191, 45);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(114, 28);
            this.label4.TabIndex = 170;
            this.label4.Text = ":اسم المخزن";
            // 
            // txt_storageNameSearch
            // 
            this.txt_storageNameSearch.DropDownHeight = 200;
            this.txt_storageNameSearch.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txt_storageNameSearch.Font = new System.Drawing.Font("Palatino Linotype", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_storageNameSearch.FormattingEnabled = true;
            this.txt_storageNameSearch.IntegralHeight = false;
            this.txt_storageNameSearch.Location = new System.Drawing.Point(52, 76);
            this.txt_storageNameSearch.Name = "txt_storageNameSearch";
            this.txt_storageNameSearch.Size = new System.Drawing.Size(265, 40);
            this.txt_storageNameSearch.TabIndex = 197;
            // 
            // txt_storageName
            // 
            this.txt_storageName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_storageName.BackColor = System.Drawing.Color.White;
            this.txt_storageName.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.txt_storageName.Font = new System.Drawing.Font("Palatino Linotype", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_storageName.ForeColor = System.Drawing.Color.Black;
            this.txt_storageName.Location = new System.Drawing.Point(9, 48);
            this.txt_storageName.Multiline = true;
            this.txt_storageName.Name = "txt_storageName";
            this.txt_storageName.Size = new System.Drawing.Size(300, 45);
            this.txt_storageName.TabIndex = 198;
            // 
            // btn_saveStorage
            // 
            this.btn_saveStorage.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_saveStorage.BackColor = System.Drawing.Color.Purple;
            this.btn_saveStorage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_saveStorage.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_saveStorage.ForeColor = System.Drawing.Color.White;
            this.btn_saveStorage.Location = new System.Drawing.Point(155, 99);
            this.btn_saveStorage.Name = "btn_saveStorage";
            this.btn_saveStorage.Size = new System.Drawing.Size(154, 50);
            this.btn_saveStorage.TabIndex = 199;
            this.btn_saveStorage.Text = "حفظ";
            this.btn_saveStorage.UseVisualStyleBackColor = false;
            this.btn_saveStorage.Click += new System.EventHandler(this.btn_saveStorage_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Gainsboro;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.btn_saveStorage);
            this.panel2.Controls.Add(this.txt_storageName);
            this.panel2.Location = new System.Drawing.Point(548, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(487, 156);
            this.panel2.TabIndex = 200;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Purple;
            this.label6.Location = new System.Drawing.Point(185, 6);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(115, 28);
            this.label6.TabIndex = 201;
            this.label6.Text = "اضافه مخزن";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Purple;
            this.label5.Location = new System.Drawing.Point(318, 53);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(168, 28);
            this.label5.TabIndex = 200;
            this.label5.Text = ":اسم المخزن الجديد";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Gainsboro;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.btn_storageDelete);
            this.panel3.Controls.Add(this.txt_storageNameEdit);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.label8);
            this.panel3.Controls.Add(this.btn_storageEdit);
            this.panel3.Location = new System.Drawing.Point(3, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(539, 156);
            this.panel3.TabIndex = 201;
            // 
            // btn_storageDelete
            // 
            this.btn_storageDelete.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_storageDelete.BackColor = System.Drawing.Color.Purple;
            this.btn_storageDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_storageDelete.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_storageDelete.ForeColor = System.Drawing.Color.White;
            this.btn_storageDelete.Location = new System.Drawing.Point(21, 99);
            this.btn_storageDelete.Name = "btn_storageDelete";
            this.btn_storageDelete.Size = new System.Drawing.Size(154, 50);
            this.btn_storageDelete.TabIndex = 203;
            this.btn_storageDelete.Text = "مسح";
            this.btn_storageDelete.UseVisualStyleBackColor = false;
            this.btn_storageDelete.Click += new System.EventHandler(this.btn_storageDelete_Click);
            // 
            // txt_storageNameEdit
            // 
            this.txt_storageNameEdit.DropDownHeight = 200;
            this.txt_storageNameEdit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txt_storageNameEdit.Font = new System.Drawing.Font("Palatino Linotype", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_storageNameEdit.FormattingEnabled = true;
            this.txt_storageNameEdit.IntegralHeight = false;
            this.txt_storageNameEdit.Location = new System.Drawing.Point(227, 95);
            this.txt_storageNameEdit.Name = "txt_storageNameEdit";
            this.txt_storageNameEdit.Size = new System.Drawing.Size(300, 40);
            this.txt_storageNameEdit.TabIndex = 202;
            this.txt_storageNameEdit.SelectedIndexChanged += new System.EventHandler(this.txt_storageNameEdit_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Purple;
            this.label7.Location = new System.Drawing.Point(205, 6);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(127, 28);
            this.label7.TabIndex = 201;
            this.label7.Text = "تعديل المخازن";
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Purple;
            this.label8.Location = new System.Drawing.Point(381, 53);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(120, 28);
            this.label8.TabIndex = 200;
            this.label8.Text = ":اسم المخازن";
            // 
            // btn_storageEdit
            // 
            this.btn_storageEdit.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_storageEdit.BackColor = System.Drawing.Color.Purple;
            this.btn_storageEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_storageEdit.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_storageEdit.ForeColor = System.Drawing.Color.White;
            this.btn_storageEdit.Location = new System.Drawing.Point(21, 43);
            this.btn_storageEdit.Name = "btn_storageEdit";
            this.btn_storageEdit.Size = new System.Drawing.Size(154, 50);
            this.btn_storageEdit.TabIndex = 199;
            this.btn_storageEdit.Text = "تعديل";
            this.btn_storageEdit.UseVisualStyleBackColor = false;
            this.btn_storageEdit.Click += new System.EventHandler(this.btn_storageEdit_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Gainsboro;
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.pcb_searchStorage);
            this.panel4.Controls.Add(this.label9);
            this.panel4.Controls.Add(this.txt_storageNameSearch);
            this.panel4.Controls.Add(this.label2);
            this.panel4.Controls.Add(this.label4);
            this.panel4.Controls.Add(this.label3);
            this.panel4.Controls.Add(this.btn_exportPDF);
            this.panel4.Controls.Add(this.txt_categorieid);
            this.panel4.Controls.Add(this.txt_categoriename);
            this.panel4.Controls.Add(this.pcb_searchName);
            this.panel4.Controls.Add(this.btn_CategoryRemove);
            this.panel4.Controls.Add(this.pcb_searchID);
            this.panel4.Controls.Add(this.btn_categoryEdit);
            this.panel4.Controls.Add(this.btn_saveCategory);
            this.panel4.Controls.Add(this.label1);
            this.panel4.Location = new System.Drawing.Point(3, 165);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1032, 193);
            this.panel4.TabIndex = 202;
            // 
            // pcb_searchStorage
            // 
            this.pcb_searchStorage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pcb_searchStorage.Image = global::SuperMarket.Properties.Resources.icons8_search_48px_1;
            this.pcb_searchStorage.Location = new System.Drawing.Point(323, 76);
            this.pcb_searchStorage.Name = "pcb_searchStorage";
            this.pcb_searchStorage.Size = new System.Drawing.Size(45, 45);
            this.pcb_searchStorage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcb_searchStorage.TabIndex = 203;
            this.pcb_searchStorage.TabStop = false;
            this.pcb_searchStorage.Click += new System.EventHandler(this.pcb_searchStorage_Click);
            this.pcb_searchStorage.DoubleClick += new System.EventHandler(this.pcb_search_DoubleClick);
            this.pcb_searchStorage.MouseEnter += new System.EventHandler(this.pcb_search_MouseEnter);
            this.pcb_searchStorage.MouseLeave += new System.EventHandler(this.pcb_search_MouseLeave);
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Purple;
            this.label9.Location = new System.Drawing.Point(469, 2);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(93, 28);
            this.label9.TabIndex = 202;
            this.label9.Text = "التصنيفات";
            // 
            // Categories
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel4);
            this.MinimumSize = new System.Drawing.Size(1038, 660);
            this.Name = "Categories";
            this.Size = new System.Drawing.Size(1038, 660);
            this.Load += new System.EventHandler(this.Categories_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.categoriesDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoriesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.superMarketDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcb_searchID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcb_searchName)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcb_searchStorage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_CategoryRemove;
        private System.Windows.Forms.Button btn_categoryEdit;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_saveCategory;
        private System.Windows.Forms.PictureBox pcb_searchID;
        private System.Windows.Forms.PictureBox pcb_searchName;
        private System.Windows.Forms.TextBox txt_categorieid;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_categoriename;
        private System.Windows.Forms.Label label1;
        private SuperMarketDataSet superMarketDataSet;
        private System.Windows.Forms.BindingSource categoriesBindingSource;
        private SuperMarketDataSetTableAdapters.CategoriesTableAdapter categoriesTableAdapter;
        private SuperMarketDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView categoriesDataGridView;
        private System.Windows.Forms.Button btn_exportPDF;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn CategoryName;
        private System.Windows.Forms.DataGridViewTextBoxColumn StorageId;
        private System.Windows.Forms.DataGridViewTextBoxColumn StorageName;
        private System.Windows.Forms.DataGridViewTextBoxColumn CreationDate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox txt_storageNameSearch;
        private System.Windows.Forms.TextBox txt_storageName;
        private System.Windows.Forms.Button btn_saveStorage;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btn_storageEdit;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btn_storageDelete;
        private System.Windows.Forms.ComboBox txt_storageNameEdit;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.PictureBox pcb_searchStorage;
    }
}
