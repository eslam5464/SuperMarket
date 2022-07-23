
namespace POSWarehouse.UserControls
{
    partial class BillsEdit
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
            this.txt_invoiceno = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.db_probillsDataGridView = new System.Windows.Forms.DataGridView();
            this.invoicesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.superMarketDataSet = new POSWarehouse.SuperMarketDataSet();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pcb_searchInvoiceNo = new System.Windows.Forms.PictureBox();
            this.txt_grandtotal = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_removeFromBill = new System.Windows.Forms.Button();
            this.btn_addToBill = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.txt_totalprice = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_productprice = new System.Windows.Forms.TextBox();
            this.txt_productquantity = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.txt_searchProduct = new System.Windows.Forms.TextBox();
            this.txt_searchedProductBarCode = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_searchedProductName = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.pcb_searchProduct = new System.Windows.Forms.PictureBox();
            this.txt_searchProductType = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_save = new System.Windows.Forms.Button();
            this.invoicesTableAdapter = new POSWarehouse.SuperMarketDataSetTableAdapters.InvoicesTableAdapter();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.InvoiceNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CreationDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CustomerID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CustomerName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CustomerContact = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CustomerAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductName_ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductBarCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PriceTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.db_probillsDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.invoicesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.superMarketDataSet)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcb_searchInvoiceNo)).BeginInit();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcb_searchProduct)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_invoiceno
            // 
            this.txt_invoiceno.BackColor = System.Drawing.Color.White;
            this.txt_invoiceno.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.txt_invoiceno.Font = new System.Drawing.Font("Palatino Linotype", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_invoiceno.ForeColor = System.Drawing.Color.Black;
            this.txt_invoiceno.Location = new System.Drawing.Point(30, 8);
            this.txt_invoiceno.Multiline = true;
            this.txt_invoiceno.Name = "txt_invoiceno";
            this.txt_invoiceno.Size = new System.Drawing.Size(263, 45);
            this.txt_invoiceno.TabIndex = 197;
            this.txt_invoiceno.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Gainsboro;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Purple;
            this.label9.Location = new System.Drawing.Point(367, 16);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(111, 25);
            this.label9.TabIndex = 195;
            this.label9.Text = ":رقم الفاتورة";
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.BackColor = System.Drawing.Color.Gray;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.db_probillsDataGridView);
            this.panel3.Location = new System.Drawing.Point(3, 7);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1016, 476);
            this.panel3.TabIndex = 227;
            // 
            // db_probillsDataGridView
            // 
            this.db_probillsDataGridView.AllowUserToAddRows = false;
            this.db_probillsDataGridView.AllowUserToDeleteRows = false;
            this.db_probillsDataGridView.AllowUserToResizeColumns = false;
            this.db_probillsDataGridView.AllowUserToResizeRows = false;
            this.db_probillsDataGridView.AutoGenerateColumns = false;
            this.db_probillsDataGridView.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Purple;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.db_probillsDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.db_probillsDataGridView.ColumnHeadersHeight = 40;
            this.db_probillsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.InvoiceNumber,
            this.CreationDate,
            this.CustomerID,
            this.CustomerName,
            this.CustomerContact,
            this.CustomerAddress,
            this.ProductID,
            this.ProductName_,
            this.ProductBarCode,
            this.ProductQuantity,
            this.ProductPrice,
            this.PriceTotal});
            this.db_probillsDataGridView.DataSource = this.invoicesBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.db_probillsDataGridView.DefaultCellStyle = dataGridViewCellStyle2;
            this.db_probillsDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.db_probillsDataGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.db_probillsDataGridView.EnableHeadersVisualStyles = false;
            this.db_probillsDataGridView.GridColor = System.Drawing.Color.Silver;
            this.db_probillsDataGridView.Location = new System.Drawing.Point(0, 0);
            this.db_probillsDataGridView.MultiSelect = false;
            this.db_probillsDataGridView.Name = "db_probillsDataGridView";
            this.db_probillsDataGridView.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.db_probillsDataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.db_probillsDataGridView.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.db_probillsDataGridView.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Palatino Linotype", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.db_probillsDataGridView.RowTemplate.Height = 24;
            this.db_probillsDataGridView.Size = new System.Drawing.Size(1014, 474);
            this.db_probillsDataGridView.TabIndex = 1;
            this.db_probillsDataGridView.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.db_probillsDataGridView_CellMouseClick);
            this.db_probillsDataGridView.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.db_probillsDataGridView_ColumnHeaderMouseClick);
            this.db_probillsDataGridView.ColumnHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.db_probillsDataGridView_ColumnHeaderMouseDoubleClick);
            // 
            // invoicesBindingSource
            // 
            this.invoicesBindingSource.DataMember = "Invoices";
            this.invoicesBindingSource.DataSource = this.superMarketDataSet;
            // 
            // superMarketDataSet
            // 
            this.superMarketDataSet.DataSetName = "SuperMarketDataSet";
            this.superMarketDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Location = new System.Drawing.Point(7, 166);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1024, 488);
            this.panel1.TabIndex = 235;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Gainsboro;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.txt_invoiceno);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.pcb_searchInvoiceNo);
            this.panel2.Controls.Add(this.txt_grandtotal);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Location = new System.Drawing.Point(11, 6);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(484, 154);
            this.panel2.TabIndex = 236;
            // 
            // pcb_searchInvoiceNo
            // 
            this.pcb_searchInvoiceNo.BackColor = System.Drawing.Color.Gainsboro;
            this.pcb_searchInvoiceNo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pcb_searchInvoiceNo.Image = global::POSWarehouse.Properties.Resources.icons8_search_48px_1;
            this.pcb_searchInvoiceNo.Location = new System.Drawing.Point(306, 8);
            this.pcb_searchInvoiceNo.Name = "pcb_searchInvoiceNo";
            this.pcb_searchInvoiceNo.Size = new System.Drawing.Size(45, 45);
            this.pcb_searchInvoiceNo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcb_searchInvoiceNo.TabIndex = 199;
            this.pcb_searchInvoiceNo.TabStop = false;
            this.pcb_searchInvoiceNo.Click += new System.EventHandler(this.pcb_searchInvoiceNo_Click);
            this.pcb_searchInvoiceNo.MouseEnter += new System.EventHandler(this.pcb_search_MouseEnter);
            this.pcb_searchInvoiceNo.MouseLeave += new System.EventHandler(this.pcb_search_MouseLeave);
            // 
            // txt_grandtotal
            // 
            this.txt_grandtotal.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_grandtotal.BackColor = System.Drawing.Color.White;
            this.txt_grandtotal.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.txt_grandtotal.Font = new System.Drawing.Font("Palatino Linotype", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_grandtotal.ForeColor = System.Drawing.Color.Black;
            this.txt_grandtotal.Location = new System.Drawing.Point(103, 89);
            this.txt_grandtotal.Multiline = true;
            this.txt_grandtotal.Name = "txt_grandtotal";
            this.txt_grandtotal.ReadOnly = true;
            this.txt_grandtotal.Size = new System.Drawing.Size(257, 45);
            this.txt_grandtotal.TabIndex = 232;
            this.txt_grandtotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Purple;
            this.label4.Location = new System.Drawing.Point(161, 61);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(133, 25);
            this.label4.TabIndex = 231;
            this.label4.Text = ":المبلغ الإجمالي";
            // 
            // btn_removeFromBill
            // 
            this.btn_removeFromBill.BackColor = System.Drawing.Color.Purple;
            this.btn_removeFromBill.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_removeFromBill.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_removeFromBill.ForeColor = System.Drawing.Color.White;
            this.btn_removeFromBill.Location = new System.Drawing.Point(551, 43);
            this.btn_removeFromBill.Name = "btn_removeFromBill";
            this.btn_removeFromBill.Size = new System.Drawing.Size(187, 50);
            this.btn_removeFromBill.TabIndex = 230;
            this.btn_removeFromBill.Text = "حذف من الفاتورة";
            this.btn_removeFromBill.UseVisualStyleBackColor = false;
            this.btn_removeFromBill.Click += new System.EventHandler(this.btn_removeFromBill_Click);
            // 
            // btn_addToBill
            // 
            this.btn_addToBill.BackColor = System.Drawing.Color.Purple;
            this.btn_addToBill.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_addToBill.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold);
            this.btn_addToBill.ForeColor = System.Drawing.Color.White;
            this.btn_addToBill.Location = new System.Drawing.Point(30, 201);
            this.btn_addToBill.Name = "btn_addToBill";
            this.btn_addToBill.Size = new System.Drawing.Size(187, 50);
            this.btn_addToBill.TabIndex = 229;
            this.btn_addToBill.Text = "أضف إلى الفاتورة";
            this.btn_addToBill.UseVisualStyleBackColor = false;
            this.btn_addToBill.Click += new System.EventHandler(this.btn_addToBill_Click);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Gainsboro;
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Controls.Add(this.txt_totalprice);
            this.panel5.Controls.Add(this.label2);
            this.panel5.Controls.Add(this.txt_productprice);
            this.panel5.Controls.Add(this.txt_productquantity);
            this.panel5.Controls.Add(this.label12);
            this.panel5.Controls.Add(this.label13);
            this.panel5.Controls.Add(this.txt_searchProduct);
            this.panel5.Controls.Add(this.txt_searchedProductBarCode);
            this.panel5.Controls.Add(this.label11);
            this.panel5.Controls.Add(this.label1);
            this.panel5.Controls.Add(this.txt_searchedProductName);
            this.panel5.Controls.Add(this.label3);
            this.panel5.Controls.Add(this.pcb_searchProduct);
            this.panel5.Controls.Add(this.txt_searchProductType);
            this.panel5.Controls.Add(this.label5);
            this.panel5.Controls.Add(this.btn_addToBill);
            this.panel5.Location = new System.Drawing.Point(529, 119);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(497, 307);
            this.panel5.TabIndex = 238;
            this.panel5.Visible = false;
            // 
            // txt_totalprice
            // 
            this.txt_totalprice.BackColor = System.Drawing.Color.White;
            this.txt_totalprice.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.txt_totalprice.Font = new System.Drawing.Font("Palatino Linotype", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_totalprice.ForeColor = System.Drawing.Color.Black;
            this.txt_totalprice.Location = new System.Drawing.Point(249, 244);
            this.txt_totalprice.Multiline = true;
            this.txt_totalprice.Name = "txt_totalprice";
            this.txt_totalprice.ShortcutsEnabled = false;
            this.txt_totalprice.Size = new System.Drawing.Size(237, 45);
            this.txt_totalprice.TabIndex = 247;
            this.txt_totalprice.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Purple;
            this.label2.Location = new System.Drawing.Point(291, 216);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(163, 25);
            this.label2.TabIndex = 246;
            this.label2.Text = ":السعر الكلي للمنتج";
            // 
            // txt_productprice
            // 
            this.txt_productprice.BackColor = System.Drawing.Color.White;
            this.txt_productprice.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.txt_productprice.Font = new System.Drawing.Font("Palatino Linotype", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_productprice.ForeColor = System.Drawing.Color.Black;
            this.txt_productprice.Location = new System.Drawing.Point(30, 151);
            this.txt_productprice.Multiline = true;
            this.txt_productprice.Name = "txt_productprice";
            this.txt_productprice.ShortcutsEnabled = false;
            this.txt_productprice.Size = new System.Drawing.Size(120, 45);
            this.txt_productprice.TabIndex = 244;
            this.txt_productprice.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_productquantity
            // 
            this.txt_productquantity.BackColor = System.Drawing.Color.White;
            this.txt_productquantity.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.txt_productquantity.Font = new System.Drawing.Font("Palatino Linotype", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_productquantity.ForeColor = System.Drawing.Color.Black;
            this.txt_productquantity.Location = new System.Drawing.Point(157, 151);
            this.txt_productquantity.Multiline = true;
            this.txt_productquantity.Name = "txt_productquantity";
            this.txt_productquantity.ShortcutsEnabled = false;
            this.txt_productquantity.Size = new System.Drawing.Size(120, 45);
            this.txt_productquantity.TabIndex = 245;
            this.txt_productquantity.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Gainsboro;
            this.label12.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Purple;
            this.label12.Location = new System.Drawing.Point(168, 118);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(103, 25);
            this.label12.TabIndex = 243;
            this.label12.Text = ":كمية المنتج";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Gainsboro;
            this.label13.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.Purple;
            this.label13.Location = new System.Drawing.Point(46, 117);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(104, 25);
            this.label13.TabIndex = 242;
            this.label13.Text = ":سعر المنتج";
            // 
            // txt_searchProduct
            // 
            this.txt_searchProduct.BackColor = System.Drawing.Color.White;
            this.txt_searchProduct.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.txt_searchProduct.Font = new System.Drawing.Font("Palatino Linotype", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_searchProduct.ForeColor = System.Drawing.Color.Black;
            this.txt_searchProduct.Location = new System.Drawing.Point(133, 57);
            this.txt_searchProduct.Multiline = true;
            this.txt_searchProduct.Name = "txt_searchProduct";
            this.txt_searchProduct.Size = new System.Drawing.Size(255, 45);
            this.txt_searchProduct.TabIndex = 241;
            // 
            // txt_searchedProductBarCode
            // 
            this.txt_searchedProductBarCode.BackColor = System.Drawing.Color.White;
            this.txt_searchedProductBarCode.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.txt_searchedProductBarCode.Font = new System.Drawing.Font("Palatino Linotype", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_searchedProductBarCode.ForeColor = System.Drawing.Color.Black;
            this.txt_searchedProductBarCode.Location = new System.Drawing.Point(306, 158);
            this.txt_searchedProductBarCode.Multiline = true;
            this.txt_searchedProductBarCode.Name = "txt_searchedProductBarCode";
            this.txt_searchedProductBarCode.ReadOnly = true;
            this.txt_searchedProductBarCode.Size = new System.Drawing.Size(86, 45);
            this.txt_searchedProductBarCode.TabIndex = 240;
            this.txt_searchedProductBarCode.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Purple;
            this.label11.Location = new System.Drawing.Point(424, 168);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(67, 23);
            this.label11.TabIndex = 239;
            this.label11.Text = ":الباركود";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Purple;
            this.label1.Location = new System.Drawing.Point(405, 116);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 23);
            this.label1.TabIndex = 238;
            this.label1.Text = ":اسم المنتج";
            // 
            // txt_searchedProductName
            // 
            this.txt_searchedProductName.DropDownHeight = 200;
            this.txt_searchedProductName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txt_searchedProductName.Font = new System.Drawing.Font("Palatino Linotype", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_searchedProductName.FormattingEnabled = true;
            this.txt_searchedProductName.IntegralHeight = false;
            this.txt_searchedProductName.Location = new System.Drawing.Point(296, 111);
            this.txt_searchedProductName.Name = "txt_searchedProductName";
            this.txt_searchedProductName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txt_searchedProductName.Size = new System.Drawing.Size(103, 40);
            this.txt_searchedProductName.TabIndex = 237;
            this.txt_searchedProductName.SelectedIndexChanged += new System.EventHandler(this.txt_searchedProductName_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Purple;
            this.label3.Location = new System.Drawing.Point(413, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 23);
            this.label3.TabIndex = 235;
            this.label3.Text = ": البحث بـ";
            // 
            // pcb_searchProduct
            // 
            this.pcb_searchProduct.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pcb_searchProduct.Image = global::POSWarehouse.Properties.Resources.icons8_search_48px_1;
            this.pcb_searchProduct.Location = new System.Drawing.Point(82, 57);
            this.pcb_searchProduct.Name = "pcb_searchProduct";
            this.pcb_searchProduct.Size = new System.Drawing.Size(45, 45);
            this.pcb_searchProduct.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcb_searchProduct.TabIndex = 234;
            this.pcb_searchProduct.TabStop = false;
            this.pcb_searchProduct.Click += new System.EventHandler(this.pcb_searchProduct_Click);
            // 
            // txt_searchProductType
            // 
            this.txt_searchProductType.DropDownHeight = 200;
            this.txt_searchProductType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txt_searchProductType.Font = new System.Drawing.Font("Palatino Linotype", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_searchProductType.FormattingEnabled = true;
            this.txt_searchProductType.IntegralHeight = false;
            this.txt_searchProductType.Location = new System.Drawing.Point(82, 10);
            this.txt_searchProductType.Name = "txt_searchProductType";
            this.txt_searchProductType.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txt_searchProductType.Size = new System.Drawing.Size(306, 40);
            this.txt_searchProductType.TabIndex = 233;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Purple;
            this.label5.Location = new System.Drawing.Point(366, 79);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(113, 23);
            this.label5.TabIndex = 231;
            this.label5.Text = "نتاج بحث المنتج";
            // 
            // btn_save
            // 
            this.btn_save.BackColor = System.Drawing.Color.Purple;
            this.btn_save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_save.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_save.ForeColor = System.Drawing.Color.White;
            this.btn_save.Location = new System.Drawing.Point(766, 43);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(187, 50);
            this.btn_save.TabIndex = 239;
            this.btn_save.Text = "حفظ";
            this.btn_save.UseVisualStyleBackColor = false;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // invoicesTableAdapter
            // 
            this.invoicesTableAdapter.ClearBeforeFill = true;
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            // 
            // InvoiceNumber
            // 
            this.InvoiceNumber.DataPropertyName = "InvoiceNumber";
            this.InvoiceNumber.HeaderText = "InvoiceNumber";
            this.InvoiceNumber.Name = "InvoiceNumber";
            this.InvoiceNumber.ReadOnly = true;
            // 
            // CreationDate
            // 
            this.CreationDate.DataPropertyName = "CreationDate";
            this.CreationDate.HeaderText = "CreationDate";
            this.CreationDate.Name = "CreationDate";
            this.CreationDate.ReadOnly = true;
            // 
            // CustomerID
            // 
            this.CustomerID.DataPropertyName = "CustomerID";
            this.CustomerID.HeaderText = "CustomerID";
            this.CustomerID.Name = "CustomerID";
            this.CustomerID.ReadOnly = true;
            // 
            // CustomerName
            // 
            this.CustomerName.DataPropertyName = "CustomerName";
            this.CustomerName.HeaderText = "CustomerName";
            this.CustomerName.Name = "CustomerName";
            this.CustomerName.ReadOnly = true;
            // 
            // CustomerContact
            // 
            this.CustomerContact.DataPropertyName = "CustomerContact";
            this.CustomerContact.HeaderText = "CustomerContact";
            this.CustomerContact.Name = "CustomerContact";
            this.CustomerContact.ReadOnly = true;
            // 
            // CustomerAddress
            // 
            this.CustomerAddress.DataPropertyName = "CustomerAddress";
            this.CustomerAddress.HeaderText = "CustomerAddress";
            this.CustomerAddress.Name = "CustomerAddress";
            this.CustomerAddress.ReadOnly = true;
            // 
            // ProductID
            // 
            this.ProductID.DataPropertyName = "ProductID";
            this.ProductID.HeaderText = "ProductID";
            this.ProductID.Name = "ProductID";
            this.ProductID.ReadOnly = true;
            // 
            // ProductName_
            // 
            this.ProductName_.DataPropertyName = "ProductName";
            this.ProductName_.HeaderText = "ProductName";
            this.ProductName_.Name = "ProductName_";
            this.ProductName_.ReadOnly = true;
            // 
            // ProductBarCode
            // 
            this.ProductBarCode.DataPropertyName = "ProductBarCode";
            this.ProductBarCode.HeaderText = "ProductBarCode";
            this.ProductBarCode.Name = "ProductBarCode";
            this.ProductBarCode.ReadOnly = true;
            // 
            // ProductQuantity
            // 
            this.ProductQuantity.DataPropertyName = "ProductQuantity";
            this.ProductQuantity.HeaderText = "ProductQuantity";
            this.ProductQuantity.Name = "ProductQuantity";
            this.ProductQuantity.ReadOnly = true;
            // 
            // ProductPrice
            // 
            this.ProductPrice.DataPropertyName = "ProductPrice";
            this.ProductPrice.HeaderText = "ProductPrice";
            this.ProductPrice.Name = "ProductPrice";
            this.ProductPrice.ReadOnly = true;
            // 
            // PriceTotal
            // 
            this.PriceTotal.DataPropertyName = "PriceTotal";
            this.PriceTotal.HeaderText = "PriceTotal";
            this.PriceTotal.Name = "PriceTotal";
            this.PriceTotal.ReadOnly = true;
            // 
            // BillsEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.btn_removeFromBill);
            this.Controls.Add(this.panel5);
            this.MinimumSize = new System.Drawing.Size(1038, 660);
            this.Name = "BillsEdit";
            this.Size = new System.Drawing.Size(1038, 660);
            this.Load += new System.EventHandler(this.BillsEdit_Load);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.db_probillsDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.invoicesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.superMarketDataSet)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcb_searchInvoiceNo)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcb_searchProduct)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txt_invoiceno;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView db_probillsDataGridView;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pcb_searchInvoiceNo;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.TextBox txt_grandtotal;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_removeFromBill;
        private System.Windows.Forms.Button btn_addToBill;
        private System.Windows.Forms.TextBox txt_searchedProductBarCode;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox txt_searchedProductName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pcb_searchProduct;
        private System.Windows.Forms.ComboBox txt_searchProductType;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_searchProduct;
        private System.Windows.Forms.TextBox txt_totalprice;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_productprice;
        private System.Windows.Forms.TextBox txt_productquantity;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.BindingSource invoicesBindingSource;
        private SuperMarketDataSet superMarketDataSet;
        private SuperMarketDataSetTableAdapters.InvoicesTableAdapter invoicesTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn InvoiceNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn CreationDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn CustomerID;
        private System.Windows.Forms.DataGridViewTextBoxColumn CustomerName;
        private System.Windows.Forms.DataGridViewTextBoxColumn CustomerContact;
        private System.Windows.Forms.DataGridViewTextBoxColumn CustomerAddress;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductName_;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductBarCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductQuantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn PriceTotal;
    }
}
