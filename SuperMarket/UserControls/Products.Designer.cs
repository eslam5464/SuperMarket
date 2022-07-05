
namespace SuperMarket.UserControls
{
    partial class Products
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
            this.txt_categoriename = new System.Windows.Forms.ComboBox();
            this.btn_remove = new System.Windows.Forms.Button();
            this.btn_edit = new System.Windows.Forms.Button();
            this.btn_save = new System.Windows.Forms.Button();
            this.txt_description = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_productquantity = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_productprice = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_productname = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_productid = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.productsDataGridView = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BarCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductName_ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CategoryID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CategoryName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CreationDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.superMarketDataSet = new SuperMarket.SuperMarketDataSet();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.pcb_refresh = new System.Windows.Forms.PictureBox();
            this.pcb_searchID = new System.Windows.Forms.PictureBox();
            this.pcb_searchName = new System.Windows.Forms.PictureBox();
            this.txt_productBarCode = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.pcb_searchBarCode = new System.Windows.Forms.PictureBox();
            this.productsTableAdapter = new SuperMarket.SuperMarketDataSetTableAdapters.ProductsTableAdapter();
            this.tableAdapterManager = new SuperMarket.SuperMarketDataSetTableAdapters.TableAdapterManager();
            this.btn_exportPDF = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productsDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.superMarketDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcb_refresh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcb_searchID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcb_searchName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcb_searchBarCode)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_categoriename
            // 
            this.txt_categoriename.DropDownHeight = 200;
            this.txt_categoriename.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txt_categoriename.Font = new System.Drawing.Font("Palatino Linotype", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_categoriename.FormattingEnabled = true;
            this.txt_categoriename.IntegralHeight = false;
            this.txt_categoriename.Location = new System.Drawing.Point(482, 215);
            this.txt_categoriename.Name = "txt_categoriename";
            this.txt_categoriename.Size = new System.Drawing.Size(341, 40);
            this.txt_categoriename.TabIndex = 196;
            this.txt_categoriename.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_products_KeyDown);
            // 
            // btn_remove
            // 
            this.btn_remove.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_remove.BackColor = System.Drawing.Color.Purple;
            this.btn_remove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_remove.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_remove.ForeColor = System.Drawing.Color.White;
            this.btn_remove.Location = new System.Drawing.Point(843, 178);
            this.btn_remove.Name = "btn_remove";
            this.btn_remove.Size = new System.Drawing.Size(167, 50);
            this.btn_remove.TabIndex = 195;
            this.btn_remove.Text = "مسح";
            this.btn_remove.UseVisualStyleBackColor = false;
            this.btn_remove.Click += new System.EventHandler(this.btn_remove_Click);
            // 
            // btn_edit
            // 
            this.btn_edit.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_edit.BackColor = System.Drawing.Color.Purple;
            this.btn_edit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_edit.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_edit.ForeColor = System.Drawing.Color.White;
            this.btn_edit.Location = new System.Drawing.Point(843, 97);
            this.btn_edit.Name = "btn_edit";
            this.btn_edit.Size = new System.Drawing.Size(167, 50);
            this.btn_edit.TabIndex = 194;
            this.btn_edit.Text = "تعديل";
            this.btn_edit.UseVisualStyleBackColor = false;
            this.btn_edit.Click += new System.EventHandler(this.btn_edit_Click);
            // 
            // btn_save
            // 
            this.btn_save.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_save.BackColor = System.Drawing.Color.Purple;
            this.btn_save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_save.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_save.ForeColor = System.Drawing.Color.White;
            this.btn_save.Location = new System.Drawing.Point(843, 16);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(167, 50);
            this.btn_save.TabIndex = 193;
            this.btn_save.Text = "حفظ";
            this.btn_save.UseVisualStyleBackColor = false;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // txt_description
            // 
            this.txt_description.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_description.BackColor = System.Drawing.Color.White;
            this.txt_description.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.txt_description.Font = new System.Drawing.Font("Palatino Linotype", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_description.ForeColor = System.Drawing.Color.Black;
            this.txt_description.Location = new System.Drawing.Point(474, 119);
            this.txt_description.Multiline = true;
            this.txt_description.Name = "txt_description";
            this.txt_description.Size = new System.Drawing.Size(341, 45);
            this.txt_description.TabIndex = 190;
            this.txt_description.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_products_KeyDown);
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Purple;
            this.label5.Location = new System.Drawing.Point(691, 167);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 23);
            this.label5.TabIndex = 188;
            this.label5.Text = ":اسم الصنف";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Purple;
            this.label6.Location = new System.Drawing.Point(715, 88);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 23);
            this.label6.TabIndex = 189;
            this.label6.Text = ":الوصف";
            // 
            // txt_productquantity
            // 
            this.txt_productquantity.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_productquantity.BackColor = System.Drawing.Color.White;
            this.txt_productquantity.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.txt_productquantity.Font = new System.Drawing.Font("Palatino Linotype", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_productquantity.ForeColor = System.Drawing.Color.Black;
            this.txt_productquantity.Location = new System.Drawing.Point(48, 198);
            this.txt_productquantity.Multiline = true;
            this.txt_productquantity.Name = "txt_productquantity";
            this.txt_productquantity.Size = new System.Drawing.Size(341, 45);
            this.txt_productquantity.TabIndex = 187;
            this.txt_productquantity.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_products_KeyDown);
            this.txt_productquantity.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_products_KeyPress);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Purple;
            this.label1.Location = new System.Drawing.Point(691, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 23);
            this.label1.TabIndex = 184;
            this.label1.Text = ":سعر المنتج";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Purple;
            this.label4.Location = new System.Drawing.Point(290, 167);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 23);
            this.label4.TabIndex = 185;
            this.label4.Text = ":كميه المنتج";
            // 
            // txt_productprice
            // 
            this.txt_productprice.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_productprice.BackColor = System.Drawing.Color.White;
            this.txt_productprice.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.txt_productprice.Font = new System.Drawing.Font("Palatino Linotype", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_productprice.ForeColor = System.Drawing.Color.Black;
            this.txt_productprice.Location = new System.Drawing.Point(474, 40);
            this.txt_productprice.Multiline = true;
            this.txt_productprice.Name = "txt_productprice";
            this.txt_productprice.Size = new System.Drawing.Size(341, 45);
            this.txt_productprice.TabIndex = 186;
            this.txt_productprice.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_products_KeyDown);
            this.txt_productprice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_products_KeyPress);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Purple;
            this.label3.Location = new System.Drawing.Point(296, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 23);
            this.label3.TabIndex = 180;
            this.label3.Text = ":اسم المنتج";
            // 
            // txt_productname
            // 
            this.txt_productname.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_productname.BackColor = System.Drawing.Color.White;
            this.txt_productname.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.txt_productname.Font = new System.Drawing.Font("Palatino Linotype", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_productname.ForeColor = System.Drawing.Color.Black;
            this.txt_productname.Location = new System.Drawing.Point(48, 119);
            this.txt_productname.Multiline = true;
            this.txt_productname.Name = "txt_productname";
            this.txt_productname.Size = new System.Drawing.Size(341, 45);
            this.txt_productname.TabIndex = 182;
            this.txt_productname.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_products_KeyDown);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Purple;
            this.label2.Location = new System.Drawing.Point(296, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 23);
            this.label2.TabIndex = 181;
            this.label2.Text = ":رقم المنتج";
            // 
            // txt_productid
            // 
            this.txt_productid.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_productid.BackColor = System.Drawing.Color.White;
            this.txt_productid.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.txt_productid.Font = new System.Drawing.Font("Palatino Linotype", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_productid.ForeColor = System.Drawing.Color.Black;
            this.txt_productid.Location = new System.Drawing.Point(48, 40);
            this.txt_productid.Multiline = true;
            this.txt_productid.Name = "txt_productid";
            this.txt_productid.Size = new System.Drawing.Size(341, 45);
            this.txt_productid.TabIndex = 183;
            this.txt_productid.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_products_KeyDown);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gray;
            this.panel1.Controls.Add(this.productsDataGridView);
            this.panel1.Location = new System.Drawing.Point(3, 326);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1032, 331);
            this.panel1.TabIndex = 179;
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
            this.BarCode,
            this.ProductName_,
            this.Quantity,
            this.Price,
            this.Description,
            this.CategoryID,
            this.CategoryName,
            this.CreationDate});
            this.productsDataGridView.DataSource = this.productsBindingSource;
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
            this.productsDataGridView.Size = new System.Drawing.Size(1032, 331);
            this.productsDataGridView.TabIndex = 1;
            this.productsDataGridView.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.productsDataGridView_CellMouseClick);
            this.productsDataGridView.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.db_productDataGridView_ColumnHeaderMouseClick);
            this.productsDataGridView.ColumnHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.db_productDataGridView_ColumnHeaderMouseDoubleClick);
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            // 
            // BarCode
            // 
            this.BarCode.DataPropertyName = "BarCode";
            this.BarCode.HeaderText = "BarCode";
            this.BarCode.Name = "BarCode";
            this.BarCode.ReadOnly = true;
            // 
            // ProductName_
            // 
            this.ProductName_.DataPropertyName = "Name";
            this.ProductName_.HeaderText = "Name";
            this.ProductName_.Name = "ProductName_";
            this.ProductName_.ReadOnly = true;
            // 
            // Quantity
            // 
            this.Quantity.DataPropertyName = "Quantity";
            this.Quantity.HeaderText = "Quantity";
            this.Quantity.Name = "Quantity";
            this.Quantity.ReadOnly = true;
            // 
            // Price
            // 
            this.Price.DataPropertyName = "Price";
            this.Price.HeaderText = "Price";
            this.Price.Name = "Price";
            this.Price.ReadOnly = true;
            // 
            // Description
            // 
            this.Description.DataPropertyName = "Description";
            this.Description.HeaderText = "Description";
            this.Description.Name = "Description";
            this.Description.ReadOnly = true;
            // 
            // CategoryID
            // 
            this.CategoryID.DataPropertyName = "CategoryID";
            this.CategoryID.HeaderText = "CategoryID";
            this.CategoryID.Name = "CategoryID";
            this.CategoryID.ReadOnly = true;
            // 
            // CategoryName
            // 
            this.CategoryName.DataPropertyName = "CategoryName";
            this.CategoryName.HeaderText = "CategoryName";
            this.CategoryName.Name = "CategoryName";
            this.CategoryName.ReadOnly = true;
            // 
            // CreationDate
            // 
            this.CreationDate.DataPropertyName = "CreationDate";
            this.CreationDate.HeaderText = "CreationDate";
            this.CreationDate.Name = "CreationDate";
            this.CreationDate.ReadOnly = true;
            // 
            // productsBindingSource
            // 
            this.productsBindingSource.DataMember = "Products";
            this.productsBindingSource.DataSource = this.superMarketDataSet;
            // 
            // superMarketDataSet
            // 
            this.superMarketDataSet.DataSetName = "SuperMarketDataSet";
            this.superMarketDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Red;
            this.label7.Location = new System.Drawing.Point(28, 178);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(29, 37);
            this.label7.TabIndex = 198;
            this.label7.Text = "*";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Red;
            this.label8.Location = new System.Drawing.Point(28, 98);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(29, 37);
            this.label8.TabIndex = 199;
            this.label8.Text = "*";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Red;
            this.label9.Location = new System.Drawing.Point(462, 20);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(29, 37);
            this.label9.TabIndex = 200;
            this.label9.Text = "*";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Red;
            this.label10.Location = new System.Drawing.Point(466, 191);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(29, 37);
            this.label10.TabIndex = 201;
            this.label10.Text = "*";
            // 
            // pcb_refresh
            // 
            this.pcb_refresh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pcb_refresh.Image = global::SuperMarket.Properties.Resources.icons8_synchronize_48;
            this.pcb_refresh.Location = new System.Drawing.Point(431, 213);
            this.pcb_refresh.Name = "pcb_refresh";
            this.pcb_refresh.Size = new System.Drawing.Size(45, 45);
            this.pcb_refresh.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcb_refresh.TabIndex = 197;
            this.pcb_refresh.TabStop = false;
            this.pcb_refresh.Click += new System.EventHandler(this.pcb_refresh_Click);
            this.pcb_refresh.MouseEnter += new System.EventHandler(this.pcb_refresh_MouseEnter);
            this.pcb_refresh.MouseLeave += new System.EventHandler(this.pcb_refresh_MouseLeave);
            // 
            // pcb_searchID
            // 
            this.pcb_searchID.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pcb_searchID.Image = global::SuperMarket.Properties.Resources.icons8_search_48px_1;
            this.pcb_searchID.Location = new System.Drawing.Point(395, 40);
            this.pcb_searchID.Name = "pcb_searchID";
            this.pcb_searchID.Size = new System.Drawing.Size(45, 45);
            this.pcb_searchID.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcb_searchID.TabIndex = 192;
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
            this.pcb_searchName.Location = new System.Drawing.Point(395, 119);
            this.pcb_searchName.Name = "pcb_searchName";
            this.pcb_searchName.Size = new System.Drawing.Size(45, 45);
            this.pcb_searchName.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcb_searchName.TabIndex = 191;
            this.pcb_searchName.TabStop = false;
            this.pcb_searchName.Click += new System.EventHandler(this.pcb_searchName_Click);
            this.pcb_searchName.DoubleClick += new System.EventHandler(this.pcb_search_DoubleClick);
            this.pcb_searchName.MouseEnter += new System.EventHandler(this.pcb_search_MouseEnter);
            this.pcb_searchName.MouseLeave += new System.EventHandler(this.pcb_search_MouseLeave);
            // 
            // txt_productBarCode
            // 
            this.txt_productBarCode.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_productBarCode.BackColor = System.Drawing.Color.White;
            this.txt_productBarCode.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.txt_productBarCode.Font = new System.Drawing.Font("Palatino Linotype", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_productBarCode.ForeColor = System.Drawing.Color.Black;
            this.txt_productBarCode.Location = new System.Drawing.Point(48, 275);
            this.txt_productBarCode.MaxLength = 18;
            this.txt_productBarCode.Multiline = true;
            this.txt_productBarCode.Name = "txt_productBarCode";
            this.txt_productBarCode.Size = new System.Drawing.Size(341, 45);
            this.txt_productBarCode.TabIndex = 202;
            this.txt_productBarCode.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_products_KeyDown);
            // 
            // label11
            // 
            this.label11.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Purple;
            this.label11.Location = new System.Drawing.Point(320, 249);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(57, 23);
            this.label11.TabIndex = 203;
            this.label11.Text = ":باركود";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Red;
            this.label12.Location = new System.Drawing.Point(25, 256);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(29, 37);
            this.label12.TabIndex = 204;
            this.label12.Text = "*";
            // 
            // pcb_searchBarCode
            // 
            this.pcb_searchBarCode.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pcb_searchBarCode.Image = global::SuperMarket.Properties.Resources.icons8_search_48px_1;
            this.pcb_searchBarCode.Location = new System.Drawing.Point(395, 275);
            this.pcb_searchBarCode.Name = "pcb_searchBarCode";
            this.pcb_searchBarCode.Size = new System.Drawing.Size(45, 45);
            this.pcb_searchBarCode.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcb_searchBarCode.TabIndex = 205;
            this.pcb_searchBarCode.TabStop = false;
            this.pcb_searchBarCode.Click += new System.EventHandler(this.pcb_searchBarCode_Click);
            this.pcb_searchBarCode.DoubleClick += new System.EventHandler(this.pcb_search_DoubleClick);
            this.pcb_searchBarCode.MouseEnter += new System.EventHandler(this.pcb_search_MouseEnter);
            this.pcb_searchBarCode.MouseLeave += new System.EventHandler(this.pcb_search_MouseLeave);
            // 
            // productsTableAdapter
            // 
            this.productsTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CategoriesTableAdapter = null;
            this.tableAdapterManager.CustomersTableAdapter = null;
            this.tableAdapterManager.InvoicesTableAdapter = null;
            this.tableAdapterManager.OrdersTableAdapter = null;
            this.tableAdapterManager.ProductsTableAdapter = this.productsTableAdapter;
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
            this.btn_exportPDF.Location = new System.Drawing.Point(843, 259);
            this.btn_exportPDF.Name = "btn_exportPDF";
            this.btn_exportPDF.Size = new System.Drawing.Size(167, 50);
            this.btn_exportPDF.TabIndex = 206;
            this.btn_exportPDF.Text = "طباعه الجدول";
            this.btn_exportPDF.UseVisualStyleBackColor = false;
            this.btn_exportPDF.Click += new System.EventHandler(this.btn_exportPDF_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(575, 288);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 207;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(707, 293);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 208;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Products
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn_exportPDF);
            this.Controls.Add(this.pcb_searchBarCode);
            this.Controls.Add(this.txt_productBarCode);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.pcb_refresh);
            this.Controls.Add(this.txt_categoriename);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txt_productquantity);
            this.Controls.Add(this.txt_productprice);
            this.Controls.Add(this.txt_productname);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btn_remove);
            this.Controls.Add(this.btn_edit);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.pcb_searchID);
            this.Controls.Add(this.pcb_searchName);
            this.Controls.Add(this.txt_description);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_productid);
            this.Controls.Add(this.panel1);
            this.MinimumSize = new System.Drawing.Size(1038, 660);
            this.Name = "Products";
            this.Size = new System.Drawing.Size(1038, 660);
            this.Load += new System.EventHandler(this.Products_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.productsDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.superMarketDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcb_refresh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcb_searchID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcb_searchName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcb_searchBarCode)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox txt_categoriename;
        private System.Windows.Forms.Button btn_remove;
        private System.Windows.Forms.Button btn_edit;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.PictureBox pcb_searchID;
        private System.Windows.Forms.PictureBox pcb_searchName;
        private System.Windows.Forms.TextBox txt_description;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_productquantity;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_productprice;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_productname;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_productid;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pcb_refresh;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txt_productBarCode;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.PictureBox pcb_searchBarCode;
        private SuperMarketDataSet superMarketDataSet;
        private System.Windows.Forms.BindingSource productsBindingSource;
        private SuperMarketDataSetTableAdapters.ProductsTableAdapter productsTableAdapter;
        private SuperMarketDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView productsDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn BarCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductName_;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn Description;
        private System.Windows.Forms.DataGridViewTextBoxColumn CategoryID;
        private System.Windows.Forms.DataGridViewTextBoxColumn CategoryName;
        private System.Windows.Forms.DataGridViewTextBoxColumn CreationDate;
        private System.Windows.Forms.Button btn_exportPDF;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}
