
namespace SuperMarket.UserControls
{
    partial class Billing
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
            this.btn_print = new System.Windows.Forms.Button();
            this.btn_save = new System.Windows.Forms.Button();
            this.txt_grandtotal = new System.Windows.Forms.TextBox();
            this.btn_removeOrder = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_totalprice = new System.Windows.Forms.TextBox();
            this.txt_productquantity = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_removeFromCart = new System.Windows.Forms.Button();
            this.btn_addToCart = new System.Windows.Forms.Button();
            this.txt_cstAddress = new System.Windows.Forms.TextBox();
            this.txt_cstContact = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txt_productName = new System.Windows.Forms.TextBox();
            this.txt_cstName = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dtp_invoicedate = new System.Windows.Forms.DateTimePicker();
            this.txt_productprice = new System.Windows.Forms.TextBox();
            this.txt_invoiceno = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.db_procardsDataGridView = new System.Windows.Forms.DataGridView();
            this.label7 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.cb_defaultCST = new System.Windows.Forms.CheckBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txt_cstID = new System.Windows.Forms.TextBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txt_productBarCode = new System.Windows.Forms.TextBox();
            this.txt_prodSearch = new System.Windows.Forms.ComboBox();
            this.panel7 = new System.Windows.Forms.Panel();
            this.pic_barcode = new System.Windows.Forms.PictureBox();
            this.pcb_getInvoiceID = new System.Windows.Forms.PictureBox();
            this.pcb_searchCstID = new System.Windows.Forms.PictureBox();
            this.pcb_searchCstName = new System.Windows.Forms.PictureBox();
            this.pcb_searchProdName = new System.Windows.Forms.PictureBox();
            this.pcb_searchProdBarCode = new System.Windows.Forms.PictureBox();
            this.sqLiteCommand1 = new System.Data.SQLite.SQLiteCommand();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.db_procardsDataGridView)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_barcode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcb_getInvoiceID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcb_searchCstID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcb_searchCstName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcb_searchProdName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcb_searchProdBarCode)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_print
            // 
            this.btn_print.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_print.BackColor = System.Drawing.Color.Purple;
            this.btn_print.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_print.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold);
            this.btn_print.ForeColor = System.Drawing.Color.White;
            this.btn_print.Location = new System.Drawing.Point(429, 9);
            this.btn_print.Name = "btn_print";
            this.btn_print.Size = new System.Drawing.Size(200, 50);
            this.btn_print.TabIndex = 209;
            this.btn_print.Text = "طباعه";
            this.btn_print.UseVisualStyleBackColor = false;
            this.btn_print.Click += new System.EventHandler(this.btn_print_Click);
            // 
            // btn_save
            // 
            this.btn_save.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_save.BackColor = System.Drawing.Color.Purple;
            this.btn_save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_save.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold);
            this.btn_save.ForeColor = System.Drawing.Color.White;
            this.btn_save.Location = new System.Drawing.Point(17, 9);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(200, 50);
            this.btn_save.TabIndex = 205;
            this.btn_save.Text = "حفظ";
            this.btn_save.UseVisualStyleBackColor = false;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // txt_grandtotal
            // 
            this.txt_grandtotal.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_grandtotal.BackColor = System.Drawing.Color.White;
            this.txt_grandtotal.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.txt_grandtotal.Font = new System.Drawing.Font("Palatino Linotype", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_grandtotal.ForeColor = System.Drawing.Color.Black;
            this.txt_grandtotal.Location = new System.Drawing.Point(36, 607);
            this.txt_grandtotal.Multiline = true;
            this.txt_grandtotal.Name = "txt_grandtotal";
            this.txt_grandtotal.ReadOnly = true;
            this.txt_grandtotal.Size = new System.Drawing.Size(303, 45);
            this.txt_grandtotal.TabIndex = 219;
            this.txt_grandtotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_grandtotal.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_billing_KeyDown);
            this.txt_grandtotal.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_grandtotal_KeyPress);
            // 
            // btn_removeOrder
            // 
            this.btn_removeOrder.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_removeOrder.BackColor = System.Drawing.Color.Purple;
            this.btn_removeOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_removeOrder.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold);
            this.btn_removeOrder.ForeColor = System.Drawing.Color.White;
            this.btn_removeOrder.Location = new System.Drawing.Point(223, 9);
            this.btn_removeOrder.Name = "btn_removeOrder";
            this.btn_removeOrder.Size = new System.Drawing.Size(200, 50);
            this.btn_removeOrder.TabIndex = 207;
            this.btn_removeOrder.Text = "ازاله الطلب";
            this.btn_removeOrder.UseVisualStyleBackColor = false;
            this.btn_removeOrder.Click += new System.EventHandler(this.btn_remove__Click);
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Purple;
            this.label4.Location = new System.Drawing.Point(130, 579);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(133, 25);
            this.label4.TabIndex = 218;
            this.label4.Text = ":المبلغ الإجمالي";
            // 
            // txt_totalprice
            // 
            this.txt_totalprice.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_totalprice.BackColor = System.Drawing.Color.White;
            this.txt_totalprice.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.txt_totalprice.Font = new System.Drawing.Font("Palatino Linotype", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_totalprice.ForeColor = System.Drawing.Color.Black;
            this.txt_totalprice.Location = new System.Drawing.Point(245, 230);
            this.txt_totalprice.Multiline = true;
            this.txt_totalprice.Name = "txt_totalprice";
            this.txt_totalprice.Size = new System.Drawing.Size(247, 45);
            this.txt_totalprice.TabIndex = 221;
            this.txt_totalprice.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_totalprice.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_billing_KeyDown);
            this.txt_totalprice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_grandtotal_KeyPress);
            // 
            // txt_productquantity
            // 
            this.txt_productquantity.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_productquantity.BackColor = System.Drawing.Color.White;
            this.txt_productquantity.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.txt_productquantity.Font = new System.Drawing.Font("Palatino Linotype", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_productquantity.ForeColor = System.Drawing.Color.Black;
            this.txt_productquantity.Location = new System.Drawing.Point(372, 156);
            this.txt_productquantity.Multiline = true;
            this.txt_productquantity.Name = "txt_productquantity";
            this.txt_productquantity.Size = new System.Drawing.Size(120, 45);
            this.txt_productquantity.TabIndex = 215;
            this.txt_productquantity.TextChanged += new System.EventHandler(this.txt_productquantity_TextChanged);
            this.txt_productquantity.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_billing_KeyDown);
            this.txt_productquantity.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_grandtotal_KeyPress);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Purple;
            this.label3.Location = new System.Drawing.Point(297, 204);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(163, 25);
            this.label3.TabIndex = 220;
            this.label3.Text = ":السعر الكلي للمنتج";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Gainsboro;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Purple;
            this.label2.Location = new System.Drawing.Point(383, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 25);
            this.label2.TabIndex = 213;
            this.label2.Text = ":كمية المنتج";
            // 
            // btn_removeFromCart
            // 
            this.btn_removeFromCart.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_removeFromCart.BackColor = System.Drawing.Color.Purple;
            this.btn_removeFromCart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_removeFromCart.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_removeFromCart.ForeColor = System.Drawing.Color.White;
            this.btn_removeFromCart.Location = new System.Drawing.Point(304, 235);
            this.btn_removeFromCart.Name = "btn_removeFromCart";
            this.btn_removeFromCart.Size = new System.Drawing.Size(150, 50);
            this.btn_removeFromCart.TabIndex = 217;
            this.btn_removeFromCart.Text = "حذف من السله";
            this.btn_removeFromCart.UseVisualStyleBackColor = false;
            this.btn_removeFromCart.Click += new System.EventHandler(this.btn_remove_Click);
            // 
            // btn_addToCart
            // 
            this.btn_addToCart.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_addToCart.BackColor = System.Drawing.Color.Purple;
            this.btn_addToCart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_addToCart.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold);
            this.btn_addToCart.ForeColor = System.Drawing.Color.White;
            this.btn_addToCart.Location = new System.Drawing.Point(59, 235);
            this.btn_addToCart.Name = "btn_addToCart";
            this.btn_addToCart.Size = new System.Drawing.Size(150, 50);
            this.btn_addToCart.TabIndex = 216;
            this.btn_addToCart.Text = "أضف إلى السلة";
            this.btn_addToCart.UseVisualStyleBackColor = false;
            this.btn_addToCart.Click += new System.EventHandler(this.btn_addtocard_Click);
            // 
            // txt_cstAddress
            // 
            this.txt_cstAddress.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_cstAddress.BackColor = System.Drawing.Color.White;
            this.txt_cstAddress.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.txt_cstAddress.Font = new System.Drawing.Font("Palatino Linotype", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_cstAddress.ForeColor = System.Drawing.Color.Black;
            this.txt_cstAddress.Location = new System.Drawing.Point(260, 128);
            this.txt_cstAddress.Multiline = true;
            this.txt_cstAddress.Name = "txt_cstAddress";
            this.txt_cstAddress.ReadOnly = true;
            this.txt_cstAddress.Size = new System.Drawing.Size(250, 45);
            this.txt_cstAddress.TabIndex = 204;
            this.txt_cstAddress.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_billing_KeyDown);
            // 
            // txt_cstContact
            // 
            this.txt_cstContact.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_cstContact.BackColor = System.Drawing.Color.White;
            this.txt_cstContact.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.txt_cstContact.Font = new System.Drawing.Font("Palatino Linotype", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_cstContact.ForeColor = System.Drawing.Color.Black;
            this.txt_cstContact.Location = new System.Drawing.Point(3, 128);
            this.txt_cstContact.Multiline = true;
            this.txt_cstContact.Name = "txt_cstContact";
            this.txt_cstContact.ReadOnly = true;
            this.txt_cstContact.Size = new System.Drawing.Size(250, 45);
            this.txt_cstContact.TabIndex = 202;
            this.txt_cstContact.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_billing_KeyDown);
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Gainsboro;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Purple;
            this.label10.Location = new System.Drawing.Point(42, 87);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(126, 25);
            this.label10.TabIndex = 193;
            this.label10.Text = ":تاريخ الفاتورة";
            // 
            // txt_productName
            // 
            this.txt_productName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_productName.BackColor = System.Drawing.Color.White;
            this.txt_productName.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.txt_productName.Font = new System.Drawing.Font("Palatino Linotype", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_productName.ForeColor = System.Drawing.Color.Black;
            this.txt_productName.Location = new System.Drawing.Point(72, 10);
            this.txt_productName.Multiline = true;
            this.txt_productName.Name = "txt_productName";
            this.txt_productName.Size = new System.Drawing.Size(303, 45);
            this.txt_productName.TabIndex = 211;
            this.txt_productName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_billing_KeyDown);
            // 
            // txt_cstName
            // 
            this.txt_cstName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_cstName.BackColor = System.Drawing.Color.White;
            this.txt_cstName.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.txt_cstName.Font = new System.Drawing.Font("Palatino Linotype", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_cstName.ForeColor = System.Drawing.Color.Black;
            this.txt_cstName.Location = new System.Drawing.Point(3, 50);
            this.txt_cstName.Multiline = true;
            this.txt_cstName.Name = "txt_cstName";
            this.txt_cstName.Size = new System.Drawing.Size(250, 45);
            this.txt_cstName.TabIndex = 196;
            this.txt_cstName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_billing_KeyDown);
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Gainsboro;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Purple;
            this.label8.Location = new System.Drawing.Point(107, 20);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(101, 25);
            this.label8.TabIndex = 194;
            this.label8.Text = ":اسم العميل";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Gainsboro;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Purple;
            this.label5.Location = new System.Drawing.Point(383, 18);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 25);
            this.label5.TabIndex = 210;
            this.label5.Text = ":اسم المنتج";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Gainsboro;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Purple;
            this.label1.Location = new System.Drawing.Point(261, 122);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 25);
            this.label1.TabIndex = 212;
            this.label1.Text = ":سعر المنتج";
            // 
            // dtp_invoicedate
            // 
            this.dtp_invoicedate.CustomFormat = "dd/MM/yyyy";
            this.dtp_invoicedate.Font = new System.Drawing.Font("Palatino Linotype", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_invoicedate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_invoicedate.Location = new System.Drawing.Point(3, 115);
            this.dtp_invoicedate.Name = "dtp_invoicedate";
            this.dtp_invoicedate.Size = new System.Drawing.Size(219, 40);
            this.dtp_invoicedate.TabIndex = 201;
            this.dtp_invoicedate.ValueChanged += new System.EventHandler(this.dtp_invoicedate_ValueChanged);
            // 
            // txt_productprice
            // 
            this.txt_productprice.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_productprice.BackColor = System.Drawing.Color.White;
            this.txt_productprice.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.txt_productprice.Font = new System.Drawing.Font("Palatino Linotype", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_productprice.ForeColor = System.Drawing.Color.Black;
            this.txt_productprice.Location = new System.Drawing.Point(245, 156);
            this.txt_productprice.Multiline = true;
            this.txt_productprice.Name = "txt_productprice";
            this.txt_productprice.Size = new System.Drawing.Size(120, 45);
            this.txt_productprice.TabIndex = 214;
            this.txt_productprice.TextChanged += new System.EventHandler(this.txt_productprice_TextChanged);
            this.txt_productprice.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_billing_KeyDown);
            this.txt_productprice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_grandtotal_KeyPress);
            // 
            // txt_invoiceno
            // 
            this.txt_invoiceno.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_invoiceno.BackColor = System.Drawing.Color.White;
            this.txt_invoiceno.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.txt_invoiceno.Font = new System.Drawing.Font("Palatino Linotype", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_invoiceno.ForeColor = System.Drawing.Color.Black;
            this.txt_invoiceno.Location = new System.Drawing.Point(279, 110);
            this.txt_invoiceno.Multiline = true;
            this.txt_invoiceno.Name = "txt_invoiceno";
            this.txt_invoiceno.ReadOnly = true;
            this.txt_invoiceno.Size = new System.Drawing.Size(231, 45);
            this.txt_invoiceno.TabIndex = 197;
            this.txt_invoiceno.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_invoiceno.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_billing_KeyDown);
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Gainsboro;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Purple;
            this.label9.Location = new System.Drawing.Point(392, 74);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(111, 25);
            this.label9.TabIndex = 195;
            this.label9.Text = ":رقم الفاتورة";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Gainsboro;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Purple;
            this.label6.Location = new System.Drawing.Point(353, 100);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 25);
            this.label6.TabIndex = 198;
            this.label6.Text = ":العنوان";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Gray;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.db_procardsDataGridView);
            this.panel3.Location = new System.Drawing.Point(9, 6);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1000, 203);
            this.panel3.TabIndex = 208;
            // 
            // db_procardsDataGridView
            // 
            this.db_procardsDataGridView.AllowUserToAddRows = false;
            this.db_procardsDataGridView.AllowUserToDeleteRows = false;
            this.db_procardsDataGridView.AllowUserToResizeColumns = false;
            this.db_procardsDataGridView.AllowUserToResizeRows = false;
            this.db_procardsDataGridView.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Purple;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.db_procardsDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.db_procardsDataGridView.ColumnHeadersHeight = 40;
            this.db_procardsDataGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.db_procardsDataGridView.EnableHeadersVisualStyles = false;
            this.db_procardsDataGridView.GridColor = System.Drawing.Color.Silver;
            this.db_procardsDataGridView.Location = new System.Drawing.Point(0, 0);
            this.db_procardsDataGridView.MultiSelect = false;
            this.db_procardsDataGridView.Name = "db_procardsDataGridView";
            this.db_procardsDataGridView.ReadOnly = true;
            this.db_procardsDataGridView.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.db_procardsDataGridView.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.db_procardsDataGridView.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Palatino Linotype", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.db_procardsDataGridView.RowTemplate.Height = 24;
            this.db_procardsDataGridView.Size = new System.Drawing.Size(998, 201);
            this.db_procardsDataGridView.TabIndex = 1;
            this.db_procardsDataGridView.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.db_procardsDataGridView_CellMouseClick);
            this.db_procardsDataGridView.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.db_procardsDataGridView_ColumnHeaderMouseClick);
            this.db_procardsDataGridView.ColumnHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.db_procardsDataGridView_ColumnHeaderMouseDoubleClick);
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Gainsboro;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Purple;
            this.label7.Location = new System.Drawing.Point(163, 100);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(83, 25);
            this.label7.TabIndex = 200;
            this.label7.Text = ":التواصل";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Location = new System.Drawing.Point(14, 8);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1021, 217);
            this.panel1.TabIndex = 222;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Gainsboro;
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.pic_barcode);
            this.panel2.Controls.Add(this.pcb_getInvoiceID);
            this.panel2.Controls.Add(this.txt_invoiceno);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.dtp_invoicedate);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Location = new System.Drawing.Point(520, 231);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(515, 160);
            this.panel2.TabIndex = 223;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Gainsboro;
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.cb_defaultCST);
            this.panel4.Controls.Add(this.pcb_searchCstID);
            this.panel4.Controls.Add(this.pcb_searchCstName);
            this.panel4.Controls.Add(this.label13);
            this.panel4.Controls.Add(this.txt_cstID);
            this.panel4.Controls.Add(this.txt_cstContact);
            this.panel4.Controls.Add(this.label7);
            this.panel4.Controls.Add(this.txt_cstName);
            this.panel4.Controls.Add(this.label8);
            this.panel4.Controls.Add(this.txt_cstAddress);
            this.panel4.Controls.Add(this.label6);
            this.panel4.Location = new System.Drawing.Point(520, 397);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(515, 179);
            this.panel4.TabIndex = 224;
            // 
            // cb_defaultCST
            // 
            this.cb_defaultCST.AutoSize = true;
            this.cb_defaultCST.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_defaultCST.ForeColor = System.Drawing.Color.Purple;
            this.cb_defaultCST.Location = new System.Drawing.Point(194, 3);
            this.cb_defaultCST.Name = "cb_defaultCST";
            this.cb_defaultCST.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cb_defaultCST.Size = new System.Drawing.Size(131, 23);
            this.cb_defaultCST.TabIndex = 208;
            this.cb_defaultCST.Text = "العميل الافتراضي";
            this.cb_defaultCST.UseVisualStyleBackColor = true;
            this.cb_defaultCST.CheckedChanged += new System.EventHandler(this.cb_defaultCST_CheckedChanged);
            // 
            // label13
            // 
            this.label13.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Gainsboro;
            this.label13.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.Purple;
            this.label13.Location = new System.Drawing.Point(331, 20);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(127, 25);
            this.label13.TabIndex = 206;
            this.label13.Text = ":الرقم التعريفي";
            // 
            // txt_cstID
            // 
            this.txt_cstID.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_cstID.BackColor = System.Drawing.Color.White;
            this.txt_cstID.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.txt_cstID.Font = new System.Drawing.Font("Palatino Linotype", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_cstID.ForeColor = System.Drawing.Color.Black;
            this.txt_cstID.Location = new System.Drawing.Point(310, 50);
            this.txt_cstID.Multiline = true;
            this.txt_cstID.Name = "txt_cstID";
            this.txt_cstID.Size = new System.Drawing.Size(148, 45);
            this.txt_cstID.TabIndex = 205;
            this.txt_cstID.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_billing_KeyDown);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Gainsboro;
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Controls.Add(this.txt_totalprice);
            this.panel5.Controls.Add(this.pcb_searchProdName);
            this.panel5.Controls.Add(this.label12);
            this.panel5.Controls.Add(this.label3);
            this.panel5.Controls.Add(this.pcb_searchProdBarCode);
            this.panel5.Controls.Add(this.label11);
            this.panel5.Controls.Add(this.txt_productprice);
            this.panel5.Controls.Add(this.txt_productBarCode);
            this.panel5.Controls.Add(this.txt_productquantity);
            this.panel5.Controls.Add(this.txt_prodSearch);
            this.panel5.Controls.Add(this.label2);
            this.panel5.Controls.Add(this.label1);
            this.panel5.Controls.Add(this.txt_productName);
            this.panel5.Controls.Add(this.label5);
            this.panel5.Location = new System.Drawing.Point(14, 294);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(497, 282);
            this.panel5.TabIndex = 225;
            // 
            // label12
            // 
            this.label12.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Gainsboro;
            this.label12.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Purple;
            this.label12.Location = new System.Drawing.Point(392, 79);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(68, 25);
            this.label12.TabIndex = 219;
            this.label12.Text = ":باركود";
            // 
            // label11
            // 
            this.label11.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Gainsboro;
            this.label11.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Purple;
            this.label11.Location = new System.Drawing.Point(67, 123);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(101, 25);
            this.label11.TabIndex = 217;
            this.label11.Text = ":ناتج البحث";
            // 
            // txt_productBarCode
            // 
            this.txt_productBarCode.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_productBarCode.BackColor = System.Drawing.Color.White;
            this.txt_productBarCode.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.txt_productBarCode.Font = new System.Drawing.Font("Palatino Linotype", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_productBarCode.ForeColor = System.Drawing.Color.Black;
            this.txt_productBarCode.Location = new System.Drawing.Point(72, 71);
            this.txt_productBarCode.MaxLength = 20;
            this.txt_productBarCode.Multiline = true;
            this.txt_productBarCode.Name = "txt_productBarCode";
            this.txt_productBarCode.Size = new System.Drawing.Size(303, 45);
            this.txt_productBarCode.TabIndex = 218;
            this.txt_productBarCode.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_billing_KeyDown);
            // 
            // txt_prodSearch
            // 
            this.txt_prodSearch.DropDownHeight = 200;
            this.txt_prodSearch.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txt_prodSearch.Font = new System.Drawing.Font("Palatino Linotype", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_prodSearch.FormattingEnabled = true;
            this.txt_prodSearch.IntegralHeight = false;
            this.txt_prodSearch.Location = new System.Drawing.Point(7, 153);
            this.txt_prodSearch.MaxDropDownItems = 10;
            this.txt_prodSearch.Name = "txt_prodSearch";
            this.txt_prodSearch.Size = new System.Drawing.Size(232, 40);
            this.txt_prodSearch.Sorted = true;
            this.txt_prodSearch.TabIndex = 216;
            this.txt_prodSearch.SelectedIndexChanged += new System.EventHandler(this.txt_prodSearch_SelectedIndexChanged);
            this.txt_prodSearch.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_billing_KeyDown);
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel7.Controls.Add(this.btn_save);
            this.panel7.Controls.Add(this.btn_print);
            this.panel7.Controls.Add(this.btn_removeOrder);
            this.panel7.Location = new System.Drawing.Point(387, 582);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(648, 70);
            this.panel7.TabIndex = 226;
            // 
            // pic_barcode
            // 
            this.pic_barcode.BackColor = System.Drawing.Color.Gainsboro;
            this.pic_barcode.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pic_barcode.Location = new System.Drawing.Point(130, 3);
            this.pic_barcode.Name = "pic_barcode";
            this.pic_barcode.Size = new System.Drawing.Size(225, 70);
            this.pic_barcode.TabIndex = 204;
            this.pic_barcode.TabStop = false;
            // 
            // pcb_getInvoiceID
            // 
            this.pcb_getInvoiceID.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pcb_getInvoiceID.Image = global::SuperMarket.Properties.Resources.icons8_synchronize_48;
            this.pcb_getInvoiceID.Location = new System.Drawing.Point(228, 110);
            this.pcb_getInvoiceID.Name = "pcb_getInvoiceID";
            this.pcb_getInvoiceID.Size = new System.Drawing.Size(45, 45);
            this.pcb_getInvoiceID.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcb_getInvoiceID.TabIndex = 198;
            this.pcb_getInvoiceID.TabStop = false;
            this.pcb_getInvoiceID.Click += new System.EventHandler(this.pcb_getInvoiceID_Click);
            this.pcb_getInvoiceID.MouseEnter += new System.EventHandler(this.pcb_search_MouseEnter);
            this.pcb_getInvoiceID.MouseLeave += new System.EventHandler(this.pcb_search_MouseLeave);
            // 
            // pcb_searchCstID
            // 
            this.pcb_searchCstID.BackColor = System.Drawing.Color.Gainsboro;
            this.pcb_searchCstID.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pcb_searchCstID.Image = global::SuperMarket.Properties.Resources.icons8_search_48px_1;
            this.pcb_searchCstID.Location = new System.Drawing.Point(464, 51);
            this.pcb_searchCstID.Name = "pcb_searchCstID";
            this.pcb_searchCstID.Size = new System.Drawing.Size(45, 45);
            this.pcb_searchCstID.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcb_searchCstID.TabIndex = 207;
            this.pcb_searchCstID.TabStop = false;
            this.pcb_searchCstID.Click += new System.EventHandler(this.pcb_searchCstID_Click);
            this.pcb_searchCstID.MouseEnter += new System.EventHandler(this.pcb_search_MouseEnter);
            this.pcb_searchCstID.MouseLeave += new System.EventHandler(this.pcb_search_MouseLeave);
            // 
            // pcb_searchCstName
            // 
            this.pcb_searchCstName.BackColor = System.Drawing.Color.Gainsboro;
            this.pcb_searchCstName.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pcb_searchCstName.Image = global::SuperMarket.Properties.Resources.icons8_search_48px_1;
            this.pcb_searchCstName.Location = new System.Drawing.Point(259, 51);
            this.pcb_searchCstName.Name = "pcb_searchCstName";
            this.pcb_searchCstName.Size = new System.Drawing.Size(45, 45);
            this.pcb_searchCstName.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcb_searchCstName.TabIndex = 203;
            this.pcb_searchCstName.TabStop = false;
            this.pcb_searchCstName.Click += new System.EventHandler(this.pcb_searchCstName_Click);
            this.pcb_searchCstName.MouseEnter += new System.EventHandler(this.pcb_search_MouseEnter);
            this.pcb_searchCstName.MouseLeave += new System.EventHandler(this.pcb_search_MouseLeave);
            // 
            // pcb_searchProdName
            // 
            this.pcb_searchProdName.BackColor = System.Drawing.Color.Gainsboro;
            this.pcb_searchProdName.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pcb_searchProdName.Image = global::SuperMarket.Properties.Resources.icons8_search_48px_1;
            this.pcb_searchProdName.Location = new System.Drawing.Point(21, 10);
            this.pcb_searchProdName.Name = "pcb_searchProdName";
            this.pcb_searchProdName.Size = new System.Drawing.Size(45, 45);
            this.pcb_searchProdName.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcb_searchProdName.TabIndex = 215;
            this.pcb_searchProdName.TabStop = false;
            this.pcb_searchProdName.Click += new System.EventHandler(this.pcb_searchProdName_Click);
            this.pcb_searchProdName.MouseEnter += new System.EventHandler(this.pcb_search_MouseEnter);
            this.pcb_searchProdName.MouseLeave += new System.EventHandler(this.pcb_search_MouseLeave);
            // 
            // pcb_searchProdBarCode
            // 
            this.pcb_searchProdBarCode.BackColor = System.Drawing.Color.Gainsboro;
            this.pcb_searchProdBarCode.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pcb_searchProdBarCode.Image = global::SuperMarket.Properties.Resources.icons8_search_48px_1;
            this.pcb_searchProdBarCode.Location = new System.Drawing.Point(21, 71);
            this.pcb_searchProdBarCode.Name = "pcb_searchProdBarCode";
            this.pcb_searchProdBarCode.Size = new System.Drawing.Size(45, 45);
            this.pcb_searchProdBarCode.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcb_searchProdBarCode.TabIndex = 218;
            this.pcb_searchProdBarCode.TabStop = false;
            this.pcb_searchProdBarCode.Click += new System.EventHandler(this.pcb_searchProdBarCode_Click);
            this.pcb_searchProdBarCode.MouseEnter += new System.EventHandler(this.pcb_search_MouseEnter);
            this.pcb_searchProdBarCode.MouseLeave += new System.EventHandler(this.pcb_search_MouseLeave);
            // 
            // sqLiteCommand1
            // 
            this.sqLiteCommand1.CommandText = null;
            // 
            // Billing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.txt_grandtotal);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btn_removeFromCart);
            this.Controls.Add(this.btn_addToCart);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel5);
            this.MinimumSize = new System.Drawing.Size(1038, 660);
            this.Name = "Billing";
            this.Size = new System.Drawing.Size(1038, 660);
            this.Load += new System.EventHandler(this.ub_billing_Load);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.db_procardsDataGridView)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pic_barcode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcb_getInvoiceID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcb_searchCstID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcb_searchCstName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcb_searchProdName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcb_searchProdBarCode)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_print;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.TextBox txt_grandtotal;
        private System.Windows.Forms.Button btn_removeOrder;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_totalprice;
        private System.Windows.Forms.TextBox txt_productquantity;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_removeFromCart;
        private System.Windows.Forms.Button btn_addToCart;
        private System.Windows.Forms.TextBox txt_cstAddress;
        private System.Windows.Forms.TextBox txt_cstContact;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txt_productName;
        private System.Windows.Forms.TextBox txt_cstName;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtp_invoicedate;
        private System.Windows.Forms.TextBox txt_productprice;
        private System.Windows.Forms.TextBox txt_invoiceno;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.PictureBox pcb_searchCstName;
        private System.Windows.Forms.PictureBox pcb_searchProdName;
        private System.Windows.Forms.ComboBox txt_prodSearch;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txt_productBarCode;
        private System.Windows.Forms.PictureBox pcb_getInvoiceID;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txt_cstID;
        private System.Windows.Forms.PictureBox pcb_searchCstID;
        private System.Windows.Forms.PictureBox pcb_searchProdBarCode;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.CheckBox cb_defaultCST;
        private System.Windows.Forms.DataGridView db_procardsDataGridView;
        private System.Windows.Forms.PictureBox pic_barcode;
        private System.Data.SQLite.SQLiteCommand sqLiteCommand1;
    }
}
