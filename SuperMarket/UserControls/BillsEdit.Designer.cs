
namespace SuperMarket.UserControls
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.txt_invoiceno = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.db_probillsDataGridView = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pcb_getInvoiceID = new System.Windows.Forms.PictureBox();
            this.dtp_invoicedate = new System.Windows.Forms.DateTimePicker();
            this.label10 = new System.Windows.Forms.Label();
            this.pcb_searchInvoiceNo = new System.Windows.Forms.PictureBox();
            this.btn_removeFromBill = new System.Windows.Forms.Button();
            this.btn_addToBill = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.pcb_searchCstID = new System.Windows.Forms.PictureBox();
            this.pcb_searchCstName = new System.Windows.Forms.PictureBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txt_cstID = new System.Windows.Forms.TextBox();
            this.txt_cstContact = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_cstName = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_cstAddress = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_productprice = new System.Windows.Forms.TextBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.txt_totalprice = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.pcb_searchProdBarCode = new System.Windows.Forms.PictureBox();
            this.pcb_searchProdName = new System.Windows.Forms.PictureBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txt_productBarCode = new System.Windows.Forms.TextBox();
            this.txt_productquantity = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_productName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_grandtotal = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.db_probillsDataGridView)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcb_getInvoiceID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcb_searchInvoiceNo)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcb_searchCstID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcb_searchCstName)).BeginInit();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcb_searchProdBarCode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcb_searchProdName)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_invoiceno
            // 
            this.txt_invoiceno.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_invoiceno.BackColor = System.Drawing.Color.White;
            this.txt_invoiceno.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.txt_invoiceno.Font = new System.Drawing.Font("Palatino Linotype", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_invoiceno.ForeColor = System.Drawing.Color.Black;
            this.txt_invoiceno.Location = new System.Drawing.Point(59, 57);
            this.txt_invoiceno.Multiline = true;
            this.txt_invoiceno.Name = "txt_invoiceno";
            this.txt_invoiceno.Size = new System.Drawing.Size(263, 45);
            this.txt_invoiceno.TabIndex = 197;
            this.txt_invoiceno.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Gainsboro;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Purple;
            this.label9.Location = new System.Drawing.Point(396, 65);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(111, 25);
            this.label9.TabIndex = 195;
            this.label9.Text = ":رقم الفاتورة";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Gray;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.db_probillsDataGridView);
            this.panel3.Location = new System.Drawing.Point(23, 15);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(998, 203);
            this.panel3.TabIndex = 227;
            // 
            // db_probillsDataGridView
            // 
            this.db_probillsDataGridView.AllowUserToAddRows = false;
            this.db_probillsDataGridView.AllowUserToDeleteRows = false;
            this.db_probillsDataGridView.AllowUserToResizeColumns = false;
            this.db_probillsDataGridView.AllowUserToResizeRows = false;
            this.db_probillsDataGridView.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Purple;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.db_probillsDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.db_probillsDataGridView.ColumnHeadersHeight = 40;
            this.db_probillsDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.db_probillsDataGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.db_probillsDataGridView.EnableHeadersVisualStyles = false;
            this.db_probillsDataGridView.GridColor = System.Drawing.Color.Silver;
            this.db_probillsDataGridView.Location = new System.Drawing.Point(0, 0);
            this.db_probillsDataGridView.MultiSelect = false;
            this.db_probillsDataGridView.Name = "db_probillsDataGridView";
            this.db_probillsDataGridView.ReadOnly = true;
            this.db_probillsDataGridView.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.db_probillsDataGridView.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.db_probillsDataGridView.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Palatino Linotype", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.db_probillsDataGridView.RowTemplate.Height = 24;
            this.db_probillsDataGridView.Size = new System.Drawing.Size(996, 201);
            this.db_probillsDataGridView.TabIndex = 1;
            this.db_probillsDataGridView.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.db_probillsDataGridView_CellMouseClick);
            this.db_probillsDataGridView.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.db_probillsDataGridView_ColumnHeaderMouseClick);
            this.db_probillsDataGridView.ColumnHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.db_probillsDataGridView_ColumnHeaderMouseDoubleClick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Location = new System.Drawing.Point(14, 9);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1015, 217);
            this.panel1.TabIndex = 235;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Gainsboro;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.pcb_getInvoiceID);
            this.panel2.Controls.Add(this.txt_invoiceno);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.dtp_invoicedate);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.pcb_searchInvoiceNo);
            this.panel2.Controls.Add(this.btn_removeFromBill);
            this.panel2.Controls.Add(this.btn_addToBill);
            this.panel2.Location = new System.Drawing.Point(14, 233);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(512, 208);
            this.panel2.TabIndex = 236;
            // 
            // pcb_getInvoiceID
            // 
            this.pcb_getInvoiceID.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pcb_getInvoiceID.Image = global::SuperMarket.Properties.Resources.icons8_synchronize_48;
            this.pcb_getInvoiceID.Location = new System.Drawing.Point(8, 57);
            this.pcb_getInvoiceID.Name = "pcb_getInvoiceID";
            this.pcb_getInvoiceID.Size = new System.Drawing.Size(45, 45);
            this.pcb_getInvoiceID.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcb_getInvoiceID.TabIndex = 198;
            this.pcb_getInvoiceID.TabStop = false;
            this.pcb_getInvoiceID.MouseEnter += new System.EventHandler(this.pcb_search_MouseEnter);
            this.pcb_getInvoiceID.MouseLeave += new System.EventHandler(this.pcb_search_MouseLeave);
            // 
            // dtp_invoicedate
            // 
            this.dtp_invoicedate.CustomFormat = "dd/MM/yyyy";
            this.dtp_invoicedate.Font = new System.Drawing.Font("Palatino Linotype", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_invoicedate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_invoicedate.Location = new System.Drawing.Point(68, 7);
            this.dtp_invoicedate.Name = "dtp_invoicedate";
            this.dtp_invoicedate.Size = new System.Drawing.Size(302, 40);
            this.dtp_invoicedate.TabIndex = 201;
            this.dtp_invoicedate.Value = new System.DateTime(2022, 6, 1, 11, 11, 29, 0);
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Gainsboro;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Purple;
            this.label10.Location = new System.Drawing.Point(381, 18);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(126, 25);
            this.label10.TabIndex = 193;
            this.label10.Text = ":تاريخ الفاتورة";
            // 
            // pcb_searchInvoiceNo
            // 
            this.pcb_searchInvoiceNo.BackColor = System.Drawing.Color.Gainsboro;
            this.pcb_searchInvoiceNo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pcb_searchInvoiceNo.Image = global::SuperMarket.Properties.Resources.icons8_search_48px_1;
            this.pcb_searchInvoiceNo.Location = new System.Drawing.Point(335, 57);
            this.pcb_searchInvoiceNo.Name = "pcb_searchInvoiceNo";
            this.pcb_searchInvoiceNo.Size = new System.Drawing.Size(45, 45);
            this.pcb_searchInvoiceNo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcb_searchInvoiceNo.TabIndex = 199;
            this.pcb_searchInvoiceNo.TabStop = false;
            this.pcb_searchInvoiceNo.MouseEnter += new System.EventHandler(this.pcb_search_MouseEnter);
            this.pcb_searchInvoiceNo.MouseLeave += new System.EventHandler(this.pcb_search_MouseLeave);
            // 
            // btn_removeFromBill
            // 
            this.btn_removeFromBill.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_removeFromBill.BackColor = System.Drawing.Color.Purple;
            this.btn_removeFromBill.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_removeFromBill.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_removeFromBill.ForeColor = System.Drawing.Color.White;
            this.btn_removeFromBill.Location = new System.Drawing.Point(282, 138);
            this.btn_removeFromBill.Name = "btn_removeFromBill";
            this.btn_removeFromBill.Size = new System.Drawing.Size(187, 50);
            this.btn_removeFromBill.TabIndex = 230;
            this.btn_removeFromBill.Text = "حذف من الفاتورة";
            this.btn_removeFromBill.UseVisualStyleBackColor = false;
            this.btn_removeFromBill.Click += new System.EventHandler(this.btn_removeFromBill_Click);
            // 
            // btn_addToBill
            // 
            this.btn_addToBill.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_addToBill.BackColor = System.Drawing.Color.Purple;
            this.btn_addToBill.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_addToBill.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold);
            this.btn_addToBill.ForeColor = System.Drawing.Color.White;
            this.btn_addToBill.Location = new System.Drawing.Point(68, 138);
            this.btn_addToBill.Name = "btn_addToBill";
            this.btn_addToBill.Size = new System.Drawing.Size(187, 50);
            this.btn_addToBill.TabIndex = 229;
            this.btn_addToBill.Text = "أضف إلى الفاتورة";
            this.btn_addToBill.UseVisualStyleBackColor = false;
            this.btn_addToBill.Click += new System.EventHandler(this.btn_addToBill_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Gainsboro;
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
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
            this.panel4.Location = new System.Drawing.Point(14, 448);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(512, 200);
            this.panel4.TabIndex = 237;
            // 
            // pcb_searchCstID
            // 
            this.pcb_searchCstID.BackColor = System.Drawing.Color.Gainsboro;
            this.pcb_searchCstID.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pcb_searchCstID.Image = global::SuperMarket.Properties.Resources.icons8_search_48px_1;
            this.pcb_searchCstID.Location = new System.Drawing.Point(462, 42);
            this.pcb_searchCstID.Name = "pcb_searchCstID";
            this.pcb_searchCstID.Size = new System.Drawing.Size(45, 45);
            this.pcb_searchCstID.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcb_searchCstID.TabIndex = 209;
            this.pcb_searchCstID.TabStop = false;
            // 
            // pcb_searchCstName
            // 
            this.pcb_searchCstName.BackColor = System.Drawing.Color.Gainsboro;
            this.pcb_searchCstName.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pcb_searchCstName.Image = global::SuperMarket.Properties.Resources.icons8_search_48px_1;
            this.pcb_searchCstName.Location = new System.Drawing.Point(462, 139);
            this.pcb_searchCstName.Name = "pcb_searchCstName";
            this.pcb_searchCstName.Size = new System.Drawing.Size(45, 45);
            this.pcb_searchCstName.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcb_searchCstName.TabIndex = 208;
            this.pcb_searchCstName.TabStop = false;
            // 
            // label13
            // 
            this.label13.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Gainsboro;
            this.label13.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.Purple;
            this.label13.Location = new System.Drawing.Point(329, 14);
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
            this.txt_cstID.Location = new System.Drawing.Point(306, 42);
            this.txt_cstID.Multiline = true;
            this.txt_cstID.Name = "txt_cstID";
            this.txt_cstID.Size = new System.Drawing.Size(150, 45);
            this.txt_cstID.TabIndex = 205;
            // 
            // txt_cstContact
            // 
            this.txt_cstContact.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_cstContact.BackColor = System.Drawing.Color.White;
            this.txt_cstContact.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.txt_cstContact.Font = new System.Drawing.Font("Palatino Linotype", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_cstContact.ForeColor = System.Drawing.Color.Black;
            this.txt_cstContact.Location = new System.Drawing.Point(3, 139);
            this.txt_cstContact.Multiline = true;
            this.txt_cstContact.Name = "txt_cstContact";
            this.txt_cstContact.Size = new System.Drawing.Size(249, 45);
            this.txt_cstContact.TabIndex = 202;
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Gainsboro;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Purple;
            this.label7.Location = new System.Drawing.Point(125, 111);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(83, 25);
            this.label7.TabIndex = 200;
            this.label7.Text = ":التواصل";
            // 
            // txt_cstName
            // 
            this.txt_cstName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_cstName.BackColor = System.Drawing.Color.White;
            this.txt_cstName.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.txt_cstName.Font = new System.Drawing.Font("Palatino Linotype", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_cstName.ForeColor = System.Drawing.Color.Black;
            this.txt_cstName.Location = new System.Drawing.Point(258, 139);
            this.txt_cstName.Multiline = true;
            this.txt_cstName.Name = "txt_cstName";
            this.txt_cstName.Size = new System.Drawing.Size(198, 45);
            this.txt_cstName.TabIndex = 196;
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Gainsboro;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Purple;
            this.label8.Location = new System.Drawing.Point(330, 111);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(101, 25);
            this.label8.TabIndex = 194;
            this.label8.Text = ":اسم العميل";
            // 
            // txt_cstAddress
            // 
            this.txt_cstAddress.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_cstAddress.BackColor = System.Drawing.Color.White;
            this.txt_cstAddress.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.txt_cstAddress.Font = new System.Drawing.Font("Palatino Linotype", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_cstAddress.ForeColor = System.Drawing.Color.Black;
            this.txt_cstAddress.Location = new System.Drawing.Point(4, 42);
            this.txt_cstAddress.Multiline = true;
            this.txt_cstAddress.Name = "txt_cstAddress";
            this.txt_cstAddress.Size = new System.Drawing.Size(296, 45);
            this.txt_cstAddress.TabIndex = 204;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Gainsboro;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Purple;
            this.label6.Location = new System.Drawing.Point(135, 14);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 25);
            this.label6.TabIndex = 198;
            this.label6.Text = ":العنوان";
            // 
            // txt_productprice
            // 
            this.txt_productprice.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_productprice.BackColor = System.Drawing.Color.White;
            this.txt_productprice.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.txt_productprice.Font = new System.Drawing.Font("Palatino Linotype", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_productprice.ForeColor = System.Drawing.Color.Black;
            this.txt_productprice.Location = new System.Drawing.Point(19, 153);
            this.txt_productprice.Multiline = true;
            this.txt_productprice.Name = "txt_productprice";
            this.txt_productprice.Size = new System.Drawing.Size(220, 45);
            this.txt_productprice.TabIndex = 214;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Gainsboro;
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Controls.Add(this.txt_totalprice);
            this.panel5.Controls.Add(this.label3);
            this.panel5.Controls.Add(this.pcb_searchProdBarCode);
            this.panel5.Controls.Add(this.pcb_searchProdName);
            this.panel5.Controls.Add(this.label12);
            this.panel5.Controls.Add(this.txt_productprice);
            this.panel5.Controls.Add(this.txt_productBarCode);
            this.panel5.Controls.Add(this.txt_productquantity);
            this.panel5.Controls.Add(this.label2);
            this.panel5.Controls.Add(this.label1);
            this.panel5.Controls.Add(this.txt_productName);
            this.panel5.Controls.Add(this.label5);
            this.panel5.Location = new System.Drawing.Point(532, 233);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(497, 308);
            this.panel5.TabIndex = 238;
            // 
            // txt_totalprice
            // 
            this.txt_totalprice.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_totalprice.BackColor = System.Drawing.Color.White;
            this.txt_totalprice.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.txt_totalprice.Font = new System.Drawing.Font("Palatino Linotype", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_totalprice.ForeColor = System.Drawing.Color.Black;
            this.txt_totalprice.Location = new System.Drawing.Point(122, 243);
            this.txt_totalprice.Multiline = true;
            this.txt_totalprice.Name = "txt_totalprice";
            this.txt_totalprice.Size = new System.Drawing.Size(257, 45);
            this.txt_totalprice.TabIndex = 234;
            this.txt_totalprice.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Purple;
            this.label3.Location = new System.Drawing.Point(163, 215);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(163, 25);
            this.label3.TabIndex = 233;
            this.label3.Text = ":السعر الكلي للمنتج";
            // 
            // pcb_searchProdBarCode
            // 
            this.pcb_searchProdBarCode.BackColor = System.Drawing.Color.Gainsboro;
            this.pcb_searchProdBarCode.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pcb_searchProdBarCode.Image = global::SuperMarket.Properties.Resources.icons8_search_48px_1;
            this.pcb_searchProdBarCode.Location = new System.Drawing.Point(7, 71);
            this.pcb_searchProdBarCode.Name = "pcb_searchProdBarCode";
            this.pcb_searchProdBarCode.Size = new System.Drawing.Size(45, 45);
            this.pcb_searchProdBarCode.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcb_searchProdBarCode.TabIndex = 221;
            this.pcb_searchProdBarCode.TabStop = false;
            this.pcb_searchProdBarCode.MouseEnter += new System.EventHandler(this.pcb_search_MouseEnter);
            this.pcb_searchProdBarCode.MouseLeave += new System.EventHandler(this.pcb_search_MouseLeave);
            // 
            // pcb_searchProdName
            // 
            this.pcb_searchProdName.BackColor = System.Drawing.Color.Gainsboro;
            this.pcb_searchProdName.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pcb_searchProdName.Image = global::SuperMarket.Properties.Resources.icons8_search_48px_1;
            this.pcb_searchProdName.Location = new System.Drawing.Point(7, 10);
            this.pcb_searchProdName.Name = "pcb_searchProdName";
            this.pcb_searchProdName.Size = new System.Drawing.Size(45, 45);
            this.pcb_searchProdName.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcb_searchProdName.TabIndex = 220;
            this.pcb_searchProdName.TabStop = false;
            this.pcb_searchProdName.MouseEnter += new System.EventHandler(this.pcb_search_MouseEnter);
            this.pcb_searchProdName.MouseLeave += new System.EventHandler(this.pcb_search_MouseLeave);
            // 
            // label12
            // 
            this.label12.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Gainsboro;
            this.label12.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Purple;
            this.label12.Location = new System.Drawing.Point(408, 79);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(68, 25);
            this.label12.TabIndex = 219;
            this.label12.Text = ":باركود";
            // 
            // txt_productBarCode
            // 
            this.txt_productBarCode.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_productBarCode.BackColor = System.Drawing.Color.White;
            this.txt_productBarCode.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.txt_productBarCode.Font = new System.Drawing.Font("Palatino Linotype", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_productBarCode.ForeColor = System.Drawing.Color.Black;
            this.txt_productBarCode.Location = new System.Drawing.Point(58, 71);
            this.txt_productBarCode.Multiline = true;
            this.txt_productBarCode.Name = "txt_productBarCode";
            this.txt_productBarCode.Size = new System.Drawing.Size(302, 45);
            this.txt_productBarCode.TabIndex = 218;
            // 
            // txt_productquantity
            // 
            this.txt_productquantity.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_productquantity.BackColor = System.Drawing.Color.White;
            this.txt_productquantity.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.txt_productquantity.Font = new System.Drawing.Font("Palatino Linotype", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_productquantity.ForeColor = System.Drawing.Color.Black;
            this.txt_productquantity.Location = new System.Drawing.Point(256, 153);
            this.txt_productquantity.Multiline = true;
            this.txt_productquantity.Name = "txt_productquantity";
            this.txt_productquantity.Size = new System.Drawing.Size(220, 45);
            this.txt_productquantity.TabIndex = 215;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Gainsboro;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Purple;
            this.label2.Location = new System.Drawing.Point(373, 124);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 25);
            this.label2.TabIndex = 213;
            this.label2.Text = ":كمية المنتج";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Gainsboro;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Purple;
            this.label1.Location = new System.Drawing.Point(135, 124);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 25);
            this.label1.TabIndex = 212;
            this.label1.Text = ":سعر المنتج";
            // 
            // txt_productName
            // 
            this.txt_productName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_productName.BackColor = System.Drawing.Color.White;
            this.txt_productName.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.txt_productName.Font = new System.Drawing.Font("Palatino Linotype", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_productName.ForeColor = System.Drawing.Color.Black;
            this.txt_productName.Location = new System.Drawing.Point(58, 10);
            this.txt_productName.Multiline = true;
            this.txt_productName.Name = "txt_productName";
            this.txt_productName.Size = new System.Drawing.Size(302, 45);
            this.txt_productName.TabIndex = 211;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Gainsboro;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Purple;
            this.label5.Location = new System.Drawing.Point(378, 18);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 25);
            this.label5.TabIndex = 210;
            this.label5.Text = ":اسم المنتج";
            // 
            // txt_grandtotal
            // 
            this.txt_grandtotal.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_grandtotal.BackColor = System.Drawing.Color.White;
            this.txt_grandtotal.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.txt_grandtotal.Font = new System.Drawing.Font("Palatino Linotype", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_grandtotal.ForeColor = System.Drawing.Color.Black;
            this.txt_grandtotal.Location = new System.Drawing.Point(655, 588);
            this.txt_grandtotal.Multiline = true;
            this.txt_grandtotal.Name = "txt_grandtotal";
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
            this.label4.Location = new System.Drawing.Point(713, 560);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(133, 25);
            this.label4.TabIndex = 231;
            this.label4.Text = ":المبلغ الإجمالي";
            // 
            // BillsEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.txt_grandtotal);
            this.Controls.Add(this.label4);
            this.MinimumSize = new System.Drawing.Size(1038, 660);
            this.Name = "BillsEdit";
            this.Size = new System.Drawing.Size(1038, 660);
            this.Load += new System.EventHandler(this.BillsEdit_Load);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.db_probillsDataGridView)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcb_getInvoiceID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcb_searchInvoiceNo)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcb_searchCstID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcb_searchCstName)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcb_searchProdBarCode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcb_searchProdName)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_invoiceno;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView db_probillsDataGridView;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pcb_getInvoiceID;
        private System.Windows.Forms.DateTimePicker dtp_invoicedate;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.PictureBox pcb_searchInvoiceNo;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txt_cstID;
        private System.Windows.Forms.TextBox txt_cstContact;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_cstName;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_cstAddress;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_productprice;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txt_productBarCode;
        private System.Windows.Forms.TextBox txt_productquantity;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_productName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_grandtotal;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_totalprice;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_removeFromBill;
        private System.Windows.Forms.Button btn_addToBill;
        private System.Windows.Forms.PictureBox pcb_searchProdBarCode;
        private System.Windows.Forms.PictureBox pcb_searchProdName;
        private System.Windows.Forms.PictureBox pcb_searchCstID;
        private System.Windows.Forms.PictureBox pcb_searchCstName;
    }
}
