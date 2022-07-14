
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.txt_paymentMethod = new System.Windows.Forms.ComboBox();
            this.txt_searchSupplier = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_searchedSupplierContact = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_searchedSupplierAddress = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.pan_supplierResults = new System.Windows.Forms.Panel();
            this.txt_searchedSupplierName = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_searchSupplierType = new System.Windows.Forms.ComboBox();
            this.pan_payment = new System.Windows.Forms.Panel();
            this.num_paymentAmoutLeft = new System.Windows.Forms.NumericUpDown();
            this.num_paymentAmoutRequired = new System.Windows.Forms.NumericUpDown();
            this.num_paymentAmoutPaid = new System.Windows.Forms.NumericUpDown();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.pan_productResults = new System.Windows.Forms.Panel();
            this.btn_removeProduct = new System.Windows.Forms.Button();
            this.btn_addProduct = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.txt_productQuantity = new System.Windows.Forms.TextBox();
            this.txt_searchedProductBarCode = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txt_searchedProductName = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_searchProductType = new System.Windows.Forms.ComboBox();
            this.txt_searchProduct = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.pan_productDataGrid = new System.Windows.Forms.Panel();
            this.db_productDataGridView = new System.Windows.Forms.DataGridView();
            this.pan_save = new System.Windows.Forms.Panel();
            this.btn_saveInovice = new System.Windows.Forms.Button();
            this.btn_resetAll = new System.Windows.Forms.Button();
            this.pcb_searchProduct = new System.Windows.Forms.PictureBox();
            this.pcb_searchSupplier = new System.Windows.Forms.PictureBox();
            this.label17 = new System.Windows.Forms.Label();
            this.txt_productPriceWholeSale = new System.Windows.Forms.TextBox();
            this.txt_productPriceSell = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.pan_supplierResults.SuspendLayout();
            this.pan_payment.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_paymentAmoutLeft)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_paymentAmoutRequired)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_paymentAmoutPaid)).BeginInit();
            this.pan_productResults.SuspendLayout();
            this.pan_productDataGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.db_productDataGridView)).BeginInit();
            this.pan_save.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcb_searchProduct)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcb_searchSupplier)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_paymentMethod
            // 
            this.txt_paymentMethod.DropDownHeight = 200;
            this.txt_paymentMethod.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txt_paymentMethod.Font = new System.Drawing.Font("Palatino Linotype", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_paymentMethod.FormattingEnabled = true;
            this.txt_paymentMethod.IntegralHeight = false;
            this.txt_paymentMethod.Location = new System.Drawing.Point(72, 37);
            this.txt_paymentMethod.Name = "txt_paymentMethod";
            this.txt_paymentMethod.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txt_paymentMethod.Size = new System.Drawing.Size(175, 40);
            this.txt_paymentMethod.TabIndex = 200;
            this.txt_paymentMethod.SelectedIndexChanged += new System.EventHandler(this.txt_paymentMethod_SelectedIndexChanged);
            // 
            // txt_searchSupplier
            // 
            this.txt_searchSupplier.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_searchSupplier.BackColor = System.Drawing.Color.White;
            this.txt_searchSupplier.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.txt_searchSupplier.Font = new System.Drawing.Font("Palatino Linotype", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_searchSupplier.ForeColor = System.Drawing.Color.Black;
            this.txt_searchSupplier.Location = new System.Drawing.Point(638, 17);
            this.txt_searchSupplier.Multiline = true;
            this.txt_searchSupplier.Name = "txt_searchSupplier";
            this.txt_searchSupplier.Size = new System.Drawing.Size(188, 45);
            this.txt_searchSupplier.TabIndex = 199;
            this.txt_searchSupplier.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_supplierInvoices_KeyDown);
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Purple;
            this.label5.Location = new System.Drawing.Point(305, 47);
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
            this.label6.Location = new System.Drawing.Point(957, 27);
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
            this.txt_searchedSupplierContact.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
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
            this.txt_searchedSupplierAddress.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
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
            // pan_supplierResults
            // 
            this.pan_supplierResults.BackColor = System.Drawing.Color.Gainsboro;
            this.pan_supplierResults.Controls.Add(this.txt_searchedSupplierName);
            this.pan_supplierResults.Controls.Add(this.label4);
            this.pan_supplierResults.Controls.Add(this.label2);
            this.pan_supplierResults.Controls.Add(this.label3);
            this.pan_supplierResults.Controls.Add(this.label1);
            this.pan_supplierResults.Controls.Add(this.txt_searchedSupplierAddress);
            this.pan_supplierResults.Controls.Add(this.txt_searchedSupplierContact);
            this.pan_supplierResults.Enabled = false;
            this.pan_supplierResults.Location = new System.Drawing.Point(587, 80);
            this.pan_supplierResults.Name = "pan_supplierResults";
            this.pan_supplierResults.Size = new System.Drawing.Size(438, 219);
            this.pan_supplierResults.TabIndex = 207;
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
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Purple;
            this.label4.Location = new System.Drawing.Point(161, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(117, 23);
            this.label4.TabIndex = 207;
            this.label4.Text = "نتاج بحث المورد";
            // 
            // txt_searchSupplierType
            // 
            this.txt_searchSupplierType.DropDownHeight = 200;
            this.txt_searchSupplierType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txt_searchSupplierType.Font = new System.Drawing.Font("Palatino Linotype", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_searchSupplierType.FormattingEnabled = true;
            this.txt_searchSupplierType.IntegralHeight = false;
            this.txt_searchSupplierType.Location = new System.Drawing.Point(832, 17);
            this.txt_searchSupplierType.Name = "txt_searchSupplierType";
            this.txt_searchSupplierType.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txt_searchSupplierType.Size = new System.Drawing.Size(123, 40);
            this.txt_searchSupplierType.TabIndex = 208;
            // 
            // pan_payment
            // 
            this.pan_payment.BackColor = System.Drawing.Color.Gainsboro;
            this.pan_payment.Controls.Add(this.num_paymentAmoutLeft);
            this.pan_payment.Controls.Add(this.num_paymentAmoutRequired);
            this.pan_payment.Controls.Add(this.num_paymentAmoutPaid);
            this.pan_payment.Controls.Add(this.label16);
            this.pan_payment.Controls.Add(this.label15);
            this.pan_payment.Controls.Add(this.label14);
            this.pan_payment.Controls.Add(this.label13);
            this.pan_payment.Controls.Add(this.txt_paymentMethod);
            this.pan_payment.Controls.Add(this.label5);
            this.pan_payment.Location = new System.Drawing.Point(587, 305);
            this.pan_payment.Name = "pan_payment";
            this.pan_payment.Size = new System.Drawing.Size(438, 241);
            this.pan_payment.TabIndex = 210;
            // 
            // num_paymentAmoutLeft
            // 
            this.num_paymentAmoutLeft.DecimalPlaces = 2;
            this.num_paymentAmoutLeft.Font = new System.Drawing.Font("Palatino Linotype", 18F, System.Drawing.FontStyle.Bold);
            this.num_paymentAmoutLeft.Location = new System.Drawing.Point(58, 186);
            this.num_paymentAmoutLeft.Maximum = new decimal(new int[] {
            900000000,
            0,
            0,
            0});
            this.num_paymentAmoutLeft.Minimum = new decimal(new int[] {
            410065408,
            2,
            0,
            -2147483648});
            this.num_paymentAmoutLeft.Name = "num_paymentAmoutLeft";
            this.num_paymentAmoutLeft.ReadOnly = true;
            this.num_paymentAmoutLeft.Size = new System.Drawing.Size(204, 40);
            this.num_paymentAmoutLeft.TabIndex = 228;
            this.num_paymentAmoutLeft.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.num_paymentAmoutLeft.ThousandsSeparator = true;
            // 
            // num_paymentAmoutRequired
            // 
            this.num_paymentAmoutRequired.DecimalPlaces = 2;
            this.num_paymentAmoutRequired.Font = new System.Drawing.Font("Palatino Linotype", 18F, System.Drawing.FontStyle.Bold);
            this.num_paymentAmoutRequired.Location = new System.Drawing.Point(58, 130);
            this.num_paymentAmoutRequired.Maximum = new decimal(new int[] {
            900000000,
            0,
            0,
            0});
            this.num_paymentAmoutRequired.Minimum = new decimal(new int[] {
            410065408,
            2,
            0,
            -2147483648});
            this.num_paymentAmoutRequired.Name = "num_paymentAmoutRequired";
            this.num_paymentAmoutRequired.Size = new System.Drawing.Size(204, 40);
            this.num_paymentAmoutRequired.TabIndex = 227;
            this.num_paymentAmoutRequired.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.num_paymentAmoutRequired.ThousandsSeparator = true;
            this.num_paymentAmoutRequired.ValueChanged += new System.EventHandler(this.num_payment_ValueChanged);
            // 
            // num_paymentAmoutPaid
            // 
            this.num_paymentAmoutPaid.DecimalPlaces = 2;
            this.num_paymentAmoutPaid.Font = new System.Drawing.Font("Palatino Linotype", 18F, System.Drawing.FontStyle.Bold);
            this.num_paymentAmoutPaid.Location = new System.Drawing.Point(58, 84);
            this.num_paymentAmoutPaid.Maximum = new decimal(new int[] {
            900000000,
            0,
            0,
            0});
            this.num_paymentAmoutPaid.Minimum = new decimal(new int[] {
            900000000,
            0,
            0,
            -2147483648});
            this.num_paymentAmoutPaid.Name = "num_paymentAmoutPaid";
            this.num_paymentAmoutPaid.Size = new System.Drawing.Size(204, 40);
            this.num_paymentAmoutPaid.TabIndex = 226;
            this.num_paymentAmoutPaid.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.num_paymentAmoutPaid.ThousandsSeparator = true;
            this.num_paymentAmoutPaid.ValueChanged += new System.EventHandler(this.num_payment_ValueChanged);
            // 
            // label16
            // 
            this.label16.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Century Gothic", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.Purple;
            this.label16.Location = new System.Drawing.Point(190, 5);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(58, 23);
            this.label16.TabIndex = 225;
            this.label16.Text = "الحساب";
            // 
            // label15
            // 
            this.label15.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.Purple;
            this.label15.Location = new System.Drawing.Point(322, 195);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(59, 23);
            this.label15.TabIndex = 223;
            this.label15.Text = ":المتبقي";
            // 
            // label14
            // 
            this.label14.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.Purple;
            this.label14.Location = new System.Drawing.Point(268, 139);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(113, 23);
            this.label14.TabIndex = 221;
            this.label14.Text = ":المبلغ المطلوب";
            // 
            // label13
            // 
            this.label13.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.Purple;
            this.label13.Location = new System.Drawing.Point(317, 93);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(64, 23);
            this.label13.TabIndex = 219;
            this.label13.Text = ":المدفوع";
            // 
            // pan_productResults
            // 
            this.pan_productResults.BackColor = System.Drawing.Color.Gainsboro;
            this.pan_productResults.Controls.Add(this.label17);
            this.pan_productResults.Controls.Add(this.txt_productPriceWholeSale);
            this.pan_productResults.Controls.Add(this.txt_productPriceSell);
            this.pan_productResults.Controls.Add(this.label19);
            this.pan_productResults.Controls.Add(this.btn_removeProduct);
            this.pan_productResults.Controls.Add(this.btn_addProduct);
            this.pan_productResults.Controls.Add(this.label12);
            this.pan_productResults.Controls.Add(this.txt_productQuantity);
            this.pan_productResults.Controls.Add(this.txt_searchedProductBarCode);
            this.pan_productResults.Controls.Add(this.label11);
            this.pan_productResults.Controls.Add(this.label10);
            this.pan_productResults.Controls.Add(this.txt_searchedProductName);
            this.pan_productResults.Controls.Add(this.label7);
            this.pan_productResults.Controls.Add(this.label9);
            this.pan_productResults.Controls.Add(this.pcb_searchProduct);
            this.pan_productResults.Controls.Add(this.txt_searchProductType);
            this.pan_productResults.Controls.Add(this.txt_searchProduct);
            this.pan_productResults.Controls.Add(this.label8);
            this.pan_productResults.Controls.Add(this.pan_productDataGrid);
            this.pan_productResults.Location = new System.Drawing.Point(10, 8);
            this.pan_productResults.Name = "pan_productResults";
            this.pan_productResults.Size = new System.Drawing.Size(571, 649);
            this.pan_productResults.TabIndex = 211;
            // 
            // btn_removeProduct
            // 
            this.btn_removeProduct.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_removeProduct.BackColor = System.Drawing.Color.Purple;
            this.btn_removeProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_removeProduct.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_removeProduct.ForeColor = System.Drawing.Color.White;
            this.btn_removeProduct.Location = new System.Drawing.Point(282, 257);
            this.btn_removeProduct.Name = "btn_removeProduct";
            this.btn_removeProduct.Size = new System.Drawing.Size(134, 50);
            this.btn_removeProduct.TabIndex = 222;
            this.btn_removeProduct.Text = "حذف المنتج";
            this.btn_removeProduct.UseVisualStyleBackColor = false;
            this.btn_removeProduct.Click += new System.EventHandler(this.btn_removeProduct_Click);
            // 
            // btn_addProduct
            // 
            this.btn_addProduct.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_addProduct.BackColor = System.Drawing.Color.Purple;
            this.btn_addProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_addProduct.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_addProduct.ForeColor = System.Drawing.Color.White;
            this.btn_addProduct.Location = new System.Drawing.Point(430, 257);
            this.btn_addProduct.Name = "btn_addProduct";
            this.btn_addProduct.Size = new System.Drawing.Size(134, 50);
            this.btn_addProduct.TabIndex = 221;
            this.btn_addProduct.Text = "اضافه المنتج";
            this.btn_addProduct.UseVisualStyleBackColor = false;
            this.btn_addProduct.Click += new System.EventHandler(this.btn_addProduct_Click);
            // 
            // label12
            // 
            this.label12.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Purple;
            this.label12.Location = new System.Drawing.Point(189, 129);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(87, 23);
            this.label12.TabIndex = 220;
            this.label12.Text = ":كميه المنتج";
            // 
            // txt_productQuantity
            // 
            this.txt_productQuantity.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_productQuantity.BackColor = System.Drawing.Color.White;
            this.txt_productQuantity.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.txt_productQuantity.Font = new System.Drawing.Font("Palatino Linotype", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_productQuantity.ForeColor = System.Drawing.Color.Black;
            this.txt_productQuantity.Location = new System.Drawing.Point(14, 119);
            this.txt_productQuantity.Multiline = true;
            this.txt_productQuantity.Name = "txt_productQuantity";
            this.txt_productQuantity.ShortcutsEnabled = false;
            this.txt_productQuantity.Size = new System.Drawing.Size(169, 45);
            this.txt_productQuantity.TabIndex = 219;
            this.txt_productQuantity.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_productQuantity.TextChanged += new System.EventHandler(this.txt_productQuantity_TextChanged);
            this.txt_productQuantity.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_supplierInvoices_KeyDown);
            this.txt_productQuantity.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_productQuantity_KeyPress);
            // 
            // txt_searchedProductBarCode
            // 
            this.txt_searchedProductBarCode.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_searchedProductBarCode.BackColor = System.Drawing.Color.White;
            this.txt_searchedProductBarCode.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.txt_searchedProductBarCode.Font = new System.Drawing.Font("Palatino Linotype", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_searchedProductBarCode.ForeColor = System.Drawing.Color.Black;
            this.txt_searchedProductBarCode.Location = new System.Drawing.Point(289, 185);
            this.txt_searchedProductBarCode.Multiline = true;
            this.txt_searchedProductBarCode.Name = "txt_searchedProductBarCode";
            this.txt_searchedProductBarCode.ReadOnly = true;
            this.txt_searchedProductBarCode.Size = new System.Drawing.Size(188, 45);
            this.txt_searchedProductBarCode.TabIndex = 218;
            this.txt_searchedProductBarCode.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label11
            // 
            this.label11.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Purple;
            this.label11.Location = new System.Drawing.Point(497, 195);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(67, 23);
            this.label11.TabIndex = 217;
            this.label11.Text = ":الباركود";
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Purple;
            this.label10.Location = new System.Drawing.Point(483, 129);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(81, 23);
            this.label10.TabIndex = 216;
            this.label10.Text = ":اسم المنتج";
            // 
            // txt_searchedProductName
            // 
            this.txt_searchedProductName.DropDownHeight = 200;
            this.txt_searchedProductName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txt_searchedProductName.Font = new System.Drawing.Font("Palatino Linotype", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_searchedProductName.FormattingEnabled = true;
            this.txt_searchedProductName.IntegralHeight = false;
            this.txt_searchedProductName.Location = new System.Drawing.Point(289, 119);
            this.txt_searchedProductName.Name = "txt_searchedProductName";
            this.txt_searchedProductName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txt_searchedProductName.Size = new System.Drawing.Size(188, 40);
            this.txt_searchedProductName.TabIndex = 215;
            this.txt_searchedProductName.SelectedIndexChanged += new System.EventHandler(this.txt_searchedProductName_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Purple;
            this.label7.Location = new System.Drawing.Point(231, 2);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(48, 23);
            this.label7.TabIndex = 214;
            this.label7.Text = "المنتج";
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Purple;
            this.label9.Location = new System.Drawing.Point(490, 38);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(74, 23);
            this.label9.TabIndex = 213;
            this.label9.Text = ": البحث بـ";
            // 
            // txt_searchProductType
            // 
            this.txt_searchProductType.DropDownHeight = 200;
            this.txt_searchProductType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txt_searchProductType.Font = new System.Drawing.Font("Palatino Linotype", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_searchProductType.FormattingEnabled = true;
            this.txt_searchProductType.IntegralHeight = false;
            this.txt_searchProductType.Location = new System.Drawing.Point(360, 28);
            this.txt_searchProductType.Name = "txt_searchProductType";
            this.txt_searchProductType.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txt_searchProductType.Size = new System.Drawing.Size(124, 40);
            this.txt_searchProductType.TabIndex = 211;
            // 
            // txt_searchProduct
            // 
            this.txt_searchProduct.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_searchProduct.BackColor = System.Drawing.Color.White;
            this.txt_searchProduct.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.txt_searchProduct.Font = new System.Drawing.Font("Palatino Linotype", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_searchProduct.ForeColor = System.Drawing.Color.Black;
            this.txt_searchProduct.Location = new System.Drawing.Point(117, 28);
            this.txt_searchProduct.Multiline = true;
            this.txt_searchProduct.Name = "txt_searchProduct";
            this.txt_searchProduct.Size = new System.Drawing.Size(237, 45);
            this.txt_searchProduct.TabIndex = 210;
            this.txt_searchProduct.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_supplierInvoices_KeyDown);
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Purple;
            this.label8.Location = new System.Drawing.Point(205, 76);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(113, 23);
            this.label8.TabIndex = 209;
            this.label8.Text = "نتاج بحث المنتج";
            // 
            // pan_productDataGrid
            // 
            this.pan_productDataGrid.BackColor = System.Drawing.Color.Gray;
            this.pan_productDataGrid.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pan_productDataGrid.Controls.Add(this.db_productDataGridView);
            this.pan_productDataGrid.Location = new System.Drawing.Point(6, 313);
            this.pan_productDataGrid.Name = "pan_productDataGrid";
            this.pan_productDataGrid.Size = new System.Drawing.Size(558, 330);
            this.pan_productDataGrid.TabIndex = 208;
            // 
            // db_productDataGridView
            // 
            this.db_productDataGridView.AllowUserToAddRows = false;
            this.db_productDataGridView.AllowUserToDeleteRows = false;
            this.db_productDataGridView.AllowUserToResizeColumns = false;
            this.db_productDataGridView.AllowUserToResizeRows = false;
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
            this.db_productDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.db_productDataGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.db_productDataGridView.EnableHeadersVisualStyles = false;
            this.db_productDataGridView.GridColor = System.Drawing.Color.Silver;
            this.db_productDataGridView.Location = new System.Drawing.Point(0, 0);
            this.db_productDataGridView.MultiSelect = false;
            this.db_productDataGridView.Name = "db_productDataGridView";
            this.db_productDataGridView.ReadOnly = true;
            this.db_productDataGridView.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.db_productDataGridView.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.db_productDataGridView.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Palatino Linotype", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.db_productDataGridView.RowTemplate.Height = 24;
            this.db_productDataGridView.Size = new System.Drawing.Size(556, 328);
            this.db_productDataGridView.TabIndex = 1;
            this.db_productDataGridView.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.db_productDataGridView_CellMouseDoubleClick);
            // 
            // pan_save
            // 
            this.pan_save.BackColor = System.Drawing.Color.Gainsboro;
            this.pan_save.Controls.Add(this.btn_saveInovice);
            this.pan_save.Location = new System.Drawing.Point(587, 552);
            this.pan_save.Name = "pan_save";
            this.pan_save.Size = new System.Drawing.Size(239, 105);
            this.pan_save.TabIndex = 212;
            // 
            // btn_saveInovice
            // 
            this.btn_saveInovice.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_saveInovice.BackColor = System.Drawing.Color.Purple;
            this.btn_saveInovice.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_saveInovice.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_saveInovice.ForeColor = System.Drawing.Color.White;
            this.btn_saveInovice.Location = new System.Drawing.Point(52, 27);
            this.btn_saveInovice.Name = "btn_saveInovice";
            this.btn_saveInovice.Size = new System.Drawing.Size(134, 50);
            this.btn_saveInovice.TabIndex = 223;
            this.btn_saveInovice.Text = "حفظ الفاتورة";
            this.btn_saveInovice.UseVisualStyleBackColor = false;
            this.btn_saveInovice.Click += new System.EventHandler(this.btn_saveInovice_Click);
            // 
            // btn_resetAll
            // 
            this.btn_resetAll.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_resetAll.BackColor = System.Drawing.Color.Purple;
            this.btn_resetAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_resetAll.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_resetAll.ForeColor = System.Drawing.Color.White;
            this.btn_resetAll.Location = new System.Drawing.Point(859, 579);
            this.btn_resetAll.Name = "btn_resetAll";
            this.btn_resetAll.Size = new System.Drawing.Size(134, 50);
            this.btn_resetAll.TabIndex = 224;
            this.btn_resetAll.Text = "مسح الكل";
            this.btn_resetAll.UseVisualStyleBackColor = false;
            this.btn_resetAll.Click += new System.EventHandler(this.btn_resetAll_Click);
            // 
            // pcb_searchProduct
            // 
            this.pcb_searchProduct.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pcb_searchProduct.Image = global::SuperMarket.Properties.Resources.icons8_search_48px_1;
            this.pcb_searchProduct.Location = new System.Drawing.Point(66, 28);
            this.pcb_searchProduct.Name = "pcb_searchProduct";
            this.pcb_searchProduct.Size = new System.Drawing.Size(45, 45);
            this.pcb_searchProduct.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcb_searchProduct.TabIndex = 212;
            this.pcb_searchProduct.TabStop = false;
            this.pcb_searchProduct.Click += new System.EventHandler(this.pcb_searchProduct_Click);
            this.pcb_searchProduct.MouseEnter += new System.EventHandler(this.pcb_supplier_MouseEnter);
            this.pcb_searchProduct.MouseLeave += new System.EventHandler(this.pcb_supplier_MouseLeave);
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
            // label17
            // 
            this.label17.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.Color.Purple;
            this.label17.Location = new System.Drawing.Point(197, 195);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(82, 23);
            this.label17.TabIndex = 227;
            this.label17.Text = ":سعرالجملة";
            // 
            // txt_productPriceWholeSale
            // 
            this.txt_productPriceWholeSale.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_productPriceWholeSale.BackColor = System.Drawing.Color.White;
            this.txt_productPriceWholeSale.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.txt_productPriceWholeSale.Font = new System.Drawing.Font("Palatino Linotype", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_productPriceWholeSale.ForeColor = System.Drawing.Color.Black;
            this.txt_productPriceWholeSale.Location = new System.Drawing.Point(14, 185);
            this.txt_productPriceWholeSale.Multiline = true;
            this.txt_productPriceWholeSale.Name = "txt_productPriceWholeSale";
            this.txt_productPriceWholeSale.ShortcutsEnabled = false;
            this.txt_productPriceWholeSale.Size = new System.Drawing.Size(169, 45);
            this.txt_productPriceWholeSale.TabIndex = 226;
            this.txt_productPriceWholeSale.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_productPriceWholeSale.TextChanged += new System.EventHandler(this.txt_productQuantity_TextChanged);
            this.txt_productPriceWholeSale.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_supplierInvoices_KeyDown);
            this.txt_productPriceWholeSale.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_productQuantity_KeyPress);
            // 
            // txt_productPriceSell
            // 
            this.txt_productPriceSell.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_productPriceSell.BackColor = System.Drawing.Color.White;
            this.txt_productPriceSell.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.txt_productPriceSell.Font = new System.Drawing.Font("Palatino Linotype", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_productPriceSell.ForeColor = System.Drawing.Color.Black;
            this.txt_productPriceSell.Location = new System.Drawing.Point(14, 251);
            this.txt_productPriceSell.Multiline = true;
            this.txt_productPriceSell.Name = "txt_productPriceSell";
            this.txt_productPriceSell.ShortcutsEnabled = false;
            this.txt_productPriceSell.Size = new System.Drawing.Size(169, 45);
            this.txt_productPriceSell.TabIndex = 224;
            this.txt_productPriceSell.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_productPriceSell.TextChanged += new System.EventHandler(this.txt_productQuantity_TextChanged);
            this.txt_productPriceSell.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_supplierInvoices_KeyDown);
            this.txt_productPriceSell.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_productQuantity_KeyPress);
            // 
            // label19
            // 
            this.label19.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.ForeColor = System.Drawing.Color.Purple;
            this.label19.Location = new System.Drawing.Point(194, 261);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(82, 23);
            this.label19.TabIndex = 223;
            this.label19.Text = ":سعر البيع ";
            // 
            // SupplierInvoices
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btn_resetAll);
            this.Controls.Add(this.pan_save);
            this.Controls.Add(this.pan_payment);
            this.Controls.Add(this.pan_productResults);
            this.Controls.Add(this.pcb_searchSupplier);
            this.Controls.Add(this.txt_searchSupplierType);
            this.Controls.Add(this.pan_supplierResults);
            this.Controls.Add(this.txt_searchSupplier);
            this.Controls.Add(this.label6);
            this.MaximumSize = new System.Drawing.Size(1038, 660);
            this.MinimumSize = new System.Drawing.Size(1038, 660);
            this.Name = "SupplierInvoices";
            this.Size = new System.Drawing.Size(1038, 660);
            this.Load += new System.EventHandler(this.SupplierInvoices_Load);
            this.pan_supplierResults.ResumeLayout(false);
            this.pan_supplierResults.PerformLayout();
            this.pan_payment.ResumeLayout(false);
            this.pan_payment.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_paymentAmoutLeft)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_paymentAmoutRequired)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_paymentAmoutPaid)).EndInit();
            this.pan_productResults.ResumeLayout(false);
            this.pan_productResults.PerformLayout();
            this.pan_productDataGrid.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.db_productDataGridView)).EndInit();
            this.pan_save.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pcb_searchProduct)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcb_searchSupplier)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox txt_paymentMethod;
        private System.Windows.Forms.TextBox txt_searchSupplier;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_searchedSupplierContact;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_searchedSupplierAddress;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel pan_supplierResults;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox txt_searchSupplierType;
        private System.Windows.Forms.PictureBox pcb_searchSupplier;
        private System.Windows.Forms.Panel pan_payment;
        private System.Windows.Forms.ComboBox txt_searchedSupplierName;
        private System.Windows.Forms.Panel pan_productResults;
        private System.Windows.Forms.Panel pan_productDataGrid;
        private System.Windows.Forms.DataGridView db_productDataGridView;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.PictureBox pcb_searchProduct;
        private System.Windows.Forms.ComboBox txt_searchProductType;
        private System.Windows.Forms.TextBox txt_searchProduct;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox txt_searchedProductName;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txt_searchedProductBarCode;
        private System.Windows.Forms.TextBox txt_productQuantity;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btn_addProduct;
        private System.Windows.Forms.Button btn_removeProduct;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.NumericUpDown num_paymentAmoutPaid;
        private System.Windows.Forms.NumericUpDown num_paymentAmoutRequired;
        private System.Windows.Forms.NumericUpDown num_paymentAmoutLeft;
        private System.Windows.Forms.Panel pan_save;
        private System.Windows.Forms.Button btn_saveInovice;
        private System.Windows.Forms.Button btn_resetAll;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox txt_productPriceWholeSale;
        private System.Windows.Forms.TextBox txt_productPriceSell;
        private System.Windows.Forms.Label label19;
    }
}
