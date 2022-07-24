
namespace POSWarehouse.UserControls
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
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
            this.txt_productPriceSell = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_productname = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_productid = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txt_productBarCode = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.btn_exportPDF = new System.Windows.Forms.Button();
            this.txt_productquantityMin = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txt_productPriceWholeSale = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.tableAdapterManager = new POSWarehouse.SuperMarketDataSetTableAdapters.TableAdapterManager();
            this.chk_generateBarCode = new System.Windows.Forms.CheckBox();
            this.pcb_searchName = new System.Windows.Forms.PictureBox();
            this.pcb_searchBarCode = new System.Windows.Forms.PictureBox();
            this.pcb_searchID = new System.Windows.Forms.PictureBox();
            this.pOSWarehouseDataSet = new POSWarehouse.Data.POSWarehouseDataSet();
            this.productsDataGridView = new System.Windows.Forms.DataGridView();
            this.spProductsGetFullDetailsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.spProducts_GetFullDetailsTableAdapter = new POSWarehouse.Data.POSWarehouseDataSetTableAdapters.spProducts_GetFullDetailsTableAdapter();
            this.IdDataGridViewTextBoxColumn_ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BarCodeDataGridViewTextBoxColumn_ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NameDataGridViewTextBoxColumn_ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QuantityDataGridViewTextBoxColumn_ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QuantityMinimumDataGridViewTextBoxColumn_ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PriceWholesaleDataGridViewTextBoxColumn_ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PriceSellDataGridViewTextBoxColumn_ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DescriptionDataGridViewTextBoxColumn_ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CategoryIDDataGridViewTextBoxColumn_ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CategoryNameDataGridViewTextBoxColumn_ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CreationDateDataGridViewTextBoxColumn_ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PriceModificationDateDataGridViewTextBoxColumn_ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcb_searchName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcb_searchBarCode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcb_searchID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pOSWarehouseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spProductsGetFullDetailsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_categoriename
            // 
            this.txt_categoriename.DropDownHeight = 200;
            this.txt_categoriename.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txt_categoriename.Font = new System.Drawing.Font("Palatino Linotype", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_categoriename.FormattingEnabled = true;
            this.txt_categoriename.IntegralHeight = false;
            this.txt_categoriename.Location = new System.Drawing.Point(48, 204);
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
            this.txt_description.Location = new System.Drawing.Point(48, 120);
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
            this.label5.Location = new System.Drawing.Point(255, 175);
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
            this.label6.Location = new System.Drawing.Point(289, 89);
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
            this.txt_productquantity.Enabled = false;
            this.txt_productquantity.Font = new System.Drawing.Font("Palatino Linotype", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_productquantity.ForeColor = System.Drawing.Color.Black;
            this.txt_productquantity.Location = new System.Drawing.Point(604, 199);
            this.txt_productquantity.Multiline = true;
            this.txt_productquantity.Name = "txt_productquantity";
            this.txt_productquantity.ShortcutsEnabled = false;
            this.txt_productquantity.Size = new System.Drawing.Size(165, 45);
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
            this.label1.Location = new System.Drawing.Point(255, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 23);
            this.label1.TabIndex = 184;
            this.label1.Text = ":سعر بيع المنتج";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Purple;
            this.label4.Location = new System.Drawing.Point(657, 172);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 23);
            this.label4.TabIndex = 185;
            this.label4.Text = ":كميه المنتج";
            // 
            // txt_productPriceSell
            // 
            this.txt_productPriceSell.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_productPriceSell.BackColor = System.Drawing.Color.White;
            this.txt_productPriceSell.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.txt_productPriceSell.Font = new System.Drawing.Font("Palatino Linotype", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_productPriceSell.ForeColor = System.Drawing.Color.Black;
            this.txt_productPriceSell.Location = new System.Drawing.Point(224, 41);
            this.txt_productPriceSell.Multiline = true;
            this.txt_productPriceSell.Name = "txt_productPriceSell";
            this.txt_productPriceSell.ShortcutsEnabled = false;
            this.txt_productPriceSell.Size = new System.Drawing.Size(165, 45);
            this.txt_productPriceSell.TabIndex = 186;
            this.txt_productPriceSell.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_products_KeyDown);
            this.txt_productPriceSell.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_products_KeyPress);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Purple;
            this.label3.Location = new System.Drawing.Point(662, 95);
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
            this.txt_productname.Location = new System.Drawing.Point(428, 120);
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
            this.label2.Location = new System.Drawing.Point(676, 10);
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
            this.txt_productid.Location = new System.Drawing.Point(428, 41);
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
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Red;
            this.label7.Location = new System.Drawing.Point(569, 164);
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
            this.label8.Location = new System.Drawing.Point(740, 89);
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
            this.label9.Location = new System.Drawing.Point(184, 10);
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
            this.label10.Location = new System.Drawing.Point(348, 167);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(29, 37);
            this.label10.TabIndex = 201;
            this.label10.Text = "*";
            // 
            // txt_productBarCode
            // 
            this.txt_productBarCode.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_productBarCode.BackColor = System.Drawing.Color.White;
            this.txt_productBarCode.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.txt_productBarCode.Font = new System.Drawing.Font("Palatino Linotype", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_productBarCode.ForeColor = System.Drawing.Color.Black;
            this.txt_productBarCode.Location = new System.Drawing.Point(428, 276);
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
            this.label11.Location = new System.Drawing.Point(700, 250);
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
            this.label12.Location = new System.Drawing.Point(405, 257);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(29, 37);
            this.label12.TabIndex = 204;
            this.label12.Text = "*";
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
            // txt_productquantityMin
            // 
            this.txt_productquantityMin.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_productquantityMin.BackColor = System.Drawing.Color.White;
            this.txt_productquantityMin.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.txt_productquantityMin.Font = new System.Drawing.Font("Palatino Linotype", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_productquantityMin.ForeColor = System.Drawing.Color.Black;
            this.txt_productquantityMin.Location = new System.Drawing.Point(428, 199);
            this.txt_productquantityMin.Multiline = true;
            this.txt_productquantityMin.Name = "txt_productquantityMin";
            this.txt_productquantityMin.ShortcutsEnabled = false;
            this.txt_productquantityMin.Size = new System.Drawing.Size(165, 45);
            this.txt_productquantityMin.TabIndex = 209;
            this.txt_productquantityMin.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_products_KeyDown);
            this.txt_productquantityMin.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_products_KeyPress);
            // 
            // label13
            // 
            this.label13.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.Purple;
            this.label13.Location = new System.Drawing.Point(464, 173);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(114, 23);
            this.label13.TabIndex = 210;
            this.label13.Text = ":اقل كمية للمنتج";
            // 
            // txt_productPriceWholeSale
            // 
            this.txt_productPriceWholeSale.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_productPriceWholeSale.BackColor = System.Drawing.Color.White;
            this.txt_productPriceWholeSale.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.txt_productPriceWholeSale.Font = new System.Drawing.Font("Palatino Linotype", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_productPriceWholeSale.ForeColor = System.Drawing.Color.Black;
            this.txt_productPriceWholeSale.Location = new System.Drawing.Point(48, 41);
            this.txt_productPriceWholeSale.Multiline = true;
            this.txt_productPriceWholeSale.Name = "txt_productPriceWholeSale";
            this.txt_productPriceWholeSale.ShortcutsEnabled = false;
            this.txt_productPriceWholeSale.Size = new System.Drawing.Size(165, 45);
            this.txt_productPriceWholeSale.TabIndex = 211;
            this.txt_productPriceWholeSale.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_products_KeyDown);
            this.txt_productPriceWholeSale.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_products_KeyPress);
            // 
            // label14
            // 
            this.label14.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.Purple;
            this.label14.Location = new System.Drawing.Point(71, 15);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(122, 23);
            this.label14.TabIndex = 212;
            this.label14.Text = ":سعر جمله المنتج";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.Transparent;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.Red;
            this.label15.Location = new System.Drawing.Point(360, 10);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(29, 37);
            this.label15.TabIndex = 213;
            this.label15.Text = "*";
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CategoriesTableAdapter = null;
            this.tableAdapterManager.Connection = null;
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
            this.tableAdapterManager.UpdateOrder = POSWarehouse.SuperMarketDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UserLevelAccessTableAdapter = null;
            this.tableAdapterManager.UsersTableAdapter = null;
            // 
            // chk_generateBarCode
            // 
            this.chk_generateBarCode.Font = new System.Drawing.Font("Palatino Linotype", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chk_generateBarCode.Location = new System.Drawing.Point(402, 289);
            this.chk_generateBarCode.Name = "chk_generateBarCode";
            this.chk_generateBarCode.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.chk_generateBarCode.Size = new System.Drawing.Size(20, 20);
            this.chk_generateBarCode.TabIndex = 214;
            this.chk_generateBarCode.UseVisualStyleBackColor = true;
            this.chk_generateBarCode.CheckedChanged += new System.EventHandler(this.chk_generateBarCode_CheckedChanged);
            // 
            // pcb_searchName
            // 
            this.pcb_searchName.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pcb_searchName.Image = global::POSWarehouse.Properties.Resources.icons8_search_48px_1;
            this.pcb_searchName.Location = new System.Drawing.Point(775, 120);
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
            // pcb_searchBarCode
            // 
            this.pcb_searchBarCode.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pcb_searchBarCode.Image = global::POSWarehouse.Properties.Resources.icons8_search_48px_1;
            this.pcb_searchBarCode.Location = new System.Drawing.Point(775, 276);
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
            // pcb_searchID
            // 
            this.pcb_searchID.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pcb_searchID.Image = global::POSWarehouse.Properties.Resources.icons8_search_48px_1;
            this.pcb_searchID.Location = new System.Drawing.Point(775, 41);
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
            // pOSWarehouseDataSet
            // 
            this.pOSWarehouseDataSet.DataSetName = "POSWarehouseDataSet";
            this.pOSWarehouseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // productsDataGridView
            // 
            this.productsDataGridView.AllowUserToAddRows = false;
            this.productsDataGridView.AllowUserToDeleteRows = false;
            this.productsDataGridView.AllowUserToResizeColumns = false;
            this.productsDataGridView.AllowUserToResizeRows = false;
            this.productsDataGridView.AutoGenerateColumns = false;
            this.productsDataGridView.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Purple;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.productsDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.productsDataGridView.ColumnHeadersHeight = 40;
            this.productsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdDataGridViewTextBoxColumn_,
            this.BarCodeDataGridViewTextBoxColumn_,
            this.NameDataGridViewTextBoxColumn_,
            this.QuantityDataGridViewTextBoxColumn_,
            this.QuantityMinimumDataGridViewTextBoxColumn_,
            this.PriceWholesaleDataGridViewTextBoxColumn_,
            this.PriceSellDataGridViewTextBoxColumn_,
            this.DescriptionDataGridViewTextBoxColumn_,
            this.CategoryIDDataGridViewTextBoxColumn_,
            this.CategoryNameDataGridViewTextBoxColumn_,
            this.CreationDateDataGridViewTextBoxColumn_,
            this.PriceModificationDateDataGridViewTextBoxColumn_});
            this.productsDataGridView.DataSource = this.spProductsGetFullDetailsBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
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
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.productsDataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.productsDataGridView.Size = new System.Drawing.Size(1032, 331);
            this.productsDataGridView.TabIndex = 1;
            this.productsDataGridView.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.productsDataGridView_CellMouseClick);
            this.productsDataGridView.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.db_productDataGridView_ColumnHeaderMouseClick);
            this.productsDataGridView.ColumnHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.db_productDataGridView_ColumnHeaderMouseDoubleClick);
            // 
            // spProductsGetFullDetailsBindingSource
            // 
            this.spProductsGetFullDetailsBindingSource.DataMember = "spProducts_GetFullDetails";
            this.spProductsGetFullDetailsBindingSource.DataSource = this.pOSWarehouseDataSet;
            // 
            // spProducts_GetFullDetailsTableAdapter
            // 
            this.spProducts_GetFullDetailsTableAdapter.ClearBeforeFill = true;
            // 
            // IdDataGridViewTextBoxColumn_
            // 
            this.IdDataGridViewTextBoxColumn_.DataPropertyName = "Id";
            this.IdDataGridViewTextBoxColumn_.HeaderText = "Id";
            this.IdDataGridViewTextBoxColumn_.Name = "IdDataGridViewTextBoxColumn_";
            this.IdDataGridViewTextBoxColumn_.ReadOnly = true;
            // 
            // BarCodeDataGridViewTextBoxColumn_
            // 
            this.BarCodeDataGridViewTextBoxColumn_.DataPropertyName = "BarCode";
            this.BarCodeDataGridViewTextBoxColumn_.HeaderText = "BarCode";
            this.BarCodeDataGridViewTextBoxColumn_.Name = "BarCodeDataGridViewTextBoxColumn_";
            this.BarCodeDataGridViewTextBoxColumn_.ReadOnly = true;
            // 
            // NameDataGridViewTextBoxColumn_
            // 
            this.NameDataGridViewTextBoxColumn_.DataPropertyName = "Name";
            this.NameDataGridViewTextBoxColumn_.HeaderText = "Name";
            this.NameDataGridViewTextBoxColumn_.Name = "NameDataGridViewTextBoxColumn_";
            this.NameDataGridViewTextBoxColumn_.ReadOnly = true;
            // 
            // QuantityDataGridViewTextBoxColumn_
            // 
            this.QuantityDataGridViewTextBoxColumn_.DataPropertyName = "Quantity";
            this.QuantityDataGridViewTextBoxColumn_.HeaderText = "Quantity";
            this.QuantityDataGridViewTextBoxColumn_.Name = "QuantityDataGridViewTextBoxColumn_";
            this.QuantityDataGridViewTextBoxColumn_.ReadOnly = true;
            // 
            // QuantityMinimumDataGridViewTextBoxColumn_
            // 
            this.QuantityMinimumDataGridViewTextBoxColumn_.DataPropertyName = "QuantityMinimum";
            this.QuantityMinimumDataGridViewTextBoxColumn_.HeaderText = "QuantityMinimum";
            this.QuantityMinimumDataGridViewTextBoxColumn_.Name = "QuantityMinimumDataGridViewTextBoxColumn_";
            this.QuantityMinimumDataGridViewTextBoxColumn_.ReadOnly = true;
            // 
            // PriceWholesaleDataGridViewTextBoxColumn_
            // 
            this.PriceWholesaleDataGridViewTextBoxColumn_.DataPropertyName = "PriceWholesale";
            this.PriceWholesaleDataGridViewTextBoxColumn_.HeaderText = "PriceWholesale";
            this.PriceWholesaleDataGridViewTextBoxColumn_.Name = "PriceWholesaleDataGridViewTextBoxColumn_";
            this.PriceWholesaleDataGridViewTextBoxColumn_.ReadOnly = true;
            // 
            // PriceSellDataGridViewTextBoxColumn_
            // 
            this.PriceSellDataGridViewTextBoxColumn_.DataPropertyName = "PriceSell";
            this.PriceSellDataGridViewTextBoxColumn_.HeaderText = "PriceSell";
            this.PriceSellDataGridViewTextBoxColumn_.Name = "PriceSellDataGridViewTextBoxColumn_";
            this.PriceSellDataGridViewTextBoxColumn_.ReadOnly = true;
            // 
            // DescriptionDataGridViewTextBoxColumn_
            // 
            this.DescriptionDataGridViewTextBoxColumn_.DataPropertyName = "Description";
            this.DescriptionDataGridViewTextBoxColumn_.HeaderText = "Description";
            this.DescriptionDataGridViewTextBoxColumn_.Name = "DescriptionDataGridViewTextBoxColumn_";
            this.DescriptionDataGridViewTextBoxColumn_.ReadOnly = true;
            // 
            // CategoryIDDataGridViewTextBoxColumn_
            // 
            this.CategoryIDDataGridViewTextBoxColumn_.DataPropertyName = "CategoryID";
            this.CategoryIDDataGridViewTextBoxColumn_.HeaderText = "CategoryID";
            this.CategoryIDDataGridViewTextBoxColumn_.Name = "CategoryIDDataGridViewTextBoxColumn_";
            this.CategoryIDDataGridViewTextBoxColumn_.ReadOnly = true;
            // 
            // CategoryNameDataGridViewTextBoxColumn_
            // 
            this.CategoryNameDataGridViewTextBoxColumn_.DataPropertyName = "CategoryName";
            this.CategoryNameDataGridViewTextBoxColumn_.HeaderText = "CategoryName";
            this.CategoryNameDataGridViewTextBoxColumn_.Name = "CategoryNameDataGridViewTextBoxColumn_";
            this.CategoryNameDataGridViewTextBoxColumn_.ReadOnly = true;
            // 
            // CreationDateDataGridViewTextBoxColumn_
            // 
            this.CreationDateDataGridViewTextBoxColumn_.DataPropertyName = "CreationDate";
            this.CreationDateDataGridViewTextBoxColumn_.HeaderText = "CreationDate";
            this.CreationDateDataGridViewTextBoxColumn_.Name = "CreationDateDataGridViewTextBoxColumn_";
            this.CreationDateDataGridViewTextBoxColumn_.ReadOnly = true;
            // 
            // PriceModificationDateDataGridViewTextBoxColumn_
            // 
            this.PriceModificationDateDataGridViewTextBoxColumn_.DataPropertyName = "PriceModificationDate";
            this.PriceModificationDateDataGridViewTextBoxColumn_.HeaderText = "PriceModificationDate";
            this.PriceModificationDateDataGridViewTextBoxColumn_.Name = "PriceModificationDateDataGridViewTextBoxColumn_";
            this.PriceModificationDateDataGridViewTextBoxColumn_.ReadOnly = true;
            // 
            // Products
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.chk_generateBarCode);
            this.Controls.Add(this.txt_productBarCode);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.txt_productid);
            this.Controls.Add(this.txt_productPriceWholeSale);
            this.Controls.Add(this.txt_productquantityMin);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btn_exportPDF);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_categoriename);
            this.Controls.Add(this.pcb_searchName);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.pcb_searchBarCode);
            this.Controls.Add(this.txt_productPriceSell);
            this.Controls.Add(this.pcb_searchID);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btn_remove);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.btn_edit);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txt_description);
            this.Controls.Add(this.txt_productname);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_productquantity);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label15);
            this.MinimumSize = new System.Drawing.Size(1038, 660);
            this.Name = "Products";
            this.Size = new System.Drawing.Size(1038, 660);
            this.Load += new System.EventHandler(this.Products_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pcb_searchName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcb_searchBarCode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcb_searchID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pOSWarehouseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spProductsGetFullDetailsBindingSource)).EndInit();
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
        private System.Windows.Forms.TextBox txt_productPriceSell;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_productname;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_productid;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txt_productBarCode;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.PictureBox pcb_searchBarCode;
        private System.Windows.Forms.Button btn_exportPDF;
        private System.Windows.Forms.TextBox txt_productquantityMin;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txt_productPriceWholeSale;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private SuperMarketDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.CheckBox chk_generateBarCode;
        private System.Windows.Forms.DataGridView productsDataGridView;
        private System.Windows.Forms.BindingSource spProductsGetFullDetailsBindingSource;
        private Data.POSWarehouseDataSet pOSWarehouseDataSet;
        private Data.POSWarehouseDataSetTableAdapters.spProducts_GetFullDetailsTableAdapter spProducts_GetFullDetailsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdDataGridViewTextBoxColumn_;
        private System.Windows.Forms.DataGridViewTextBoxColumn BarCodeDataGridViewTextBoxColumn_;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameDataGridViewTextBoxColumn_;
        private System.Windows.Forms.DataGridViewTextBoxColumn QuantityDataGridViewTextBoxColumn_;
        private System.Windows.Forms.DataGridViewTextBoxColumn QuantityMinimumDataGridViewTextBoxColumn_;
        private System.Windows.Forms.DataGridViewTextBoxColumn PriceWholesaleDataGridViewTextBoxColumn_;
        private System.Windows.Forms.DataGridViewTextBoxColumn PriceSellDataGridViewTextBoxColumn_;
        private System.Windows.Forms.DataGridViewTextBoxColumn DescriptionDataGridViewTextBoxColumn_;
        private System.Windows.Forms.DataGridViewTextBoxColumn CategoryIDDataGridViewTextBoxColumn_;
        private System.Windows.Forms.DataGridViewTextBoxColumn CategoryNameDataGridViewTextBoxColumn_;
        private System.Windows.Forms.DataGridViewTextBoxColumn CreationDateDataGridViewTextBoxColumn_;
        private System.Windows.Forms.DataGridViewTextBoxColumn PriceModificationDateDataGridViewTextBoxColumn_;
    }
}
