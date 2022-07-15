﻿
namespace SuperMarket.UserControls
{
    partial class Safe
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel3 = new System.Windows.Forms.Panel();
            this.db_safeTransactionDataGridView = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_safeDelete = new System.Windows.Forms.Button();
            this.txt_safeNameEdit = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btn_safeEdit = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_safeSave = new System.Windows.Forms.Button();
            this.txt_safeName = new System.Windows.Forms.TextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.txt_safeTransactionAmount = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txt_safeTransactionNotes = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_safeTransactionNameSearch = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_exportPDF = new System.Windows.Forms.Button();
            this.txt_safeTransactionId = new System.Windows.Forms.TextBox();
            this.txt_safeTransactionName = new System.Windows.Forms.TextBox();
            this.pcb_searchName = new System.Windows.Forms.PictureBox();
            this.btn_safeTransactionRemove = new System.Windows.Forms.Button();
            this.pcb_searchID = new System.Windows.Forms.PictureBox();
            this.btn_safeTransactionEdit = new System.Windows.Forms.Button();
            this.btn_safeTransactionSave = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.db_safeTransactionDataGridView)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcb_searchName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcb_searchID)).BeginInit();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Gray;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.db_safeTransactionDataGridView);
            this.panel3.Location = new System.Drawing.Point(6, 399);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1026, 256);
            this.panel3.TabIndex = 208;
            // 
            // db_safeTransactionDataGridView
            // 
            this.db_safeTransactionDataGridView.AllowUserToAddRows = false;
            this.db_safeTransactionDataGridView.AllowUserToDeleteRows = false;
            this.db_safeTransactionDataGridView.AllowUserToResizeColumns = false;
            this.db_safeTransactionDataGridView.AllowUserToResizeRows = false;
            this.db_safeTransactionDataGridView.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Purple;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.db_safeTransactionDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.db_safeTransactionDataGridView.ColumnHeadersHeight = 40;
            this.db_safeTransactionDataGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.db_safeTransactionDataGridView.EnableHeadersVisualStyles = false;
            this.db_safeTransactionDataGridView.GridColor = System.Drawing.Color.Silver;
            this.db_safeTransactionDataGridView.Location = new System.Drawing.Point(3, 3);
            this.db_safeTransactionDataGridView.MultiSelect = false;
            this.db_safeTransactionDataGridView.Name = "db_safeTransactionDataGridView";
            this.db_safeTransactionDataGridView.ReadOnly = true;
            this.db_safeTransactionDataGridView.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.db_safeTransactionDataGridView.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.db_safeTransactionDataGridView.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Palatino Linotype", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.db_safeTransactionDataGridView.RowTemplate.Height = 24;
            this.db_safeTransactionDataGridView.Size = new System.Drawing.Size(1018, 515);
            this.db_safeTransactionDataGridView.TabIndex = 1;
            this.db_safeTransactionDataGridView.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.db_safeTransactionDataGridView_CellMouseClick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gainsboro;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btn_safeDelete);
            this.panel1.Controls.Add(this.txt_safeNameEdit);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.btn_safeEdit);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(539, 156);
            this.panel1.TabIndex = 210;
            // 
            // btn_safeDelete
            // 
            this.btn_safeDelete.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_safeDelete.BackColor = System.Drawing.Color.Purple;
            this.btn_safeDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_safeDelete.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_safeDelete.ForeColor = System.Drawing.Color.White;
            this.btn_safeDelete.Location = new System.Drawing.Point(21, 99);
            this.btn_safeDelete.Name = "btn_safeDelete";
            this.btn_safeDelete.Size = new System.Drawing.Size(154, 50);
            this.btn_safeDelete.TabIndex = 203;
            this.btn_safeDelete.Text = "مسح";
            this.btn_safeDelete.UseVisualStyleBackColor = false;
            // 
            // txt_safeNameEdit
            // 
            this.txt_safeNameEdit.DropDownHeight = 200;
            this.txt_safeNameEdit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txt_safeNameEdit.Font = new System.Drawing.Font("Palatino Linotype", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_safeNameEdit.FormattingEnabled = true;
            this.txt_safeNameEdit.IntegralHeight = false;
            this.txt_safeNameEdit.Location = new System.Drawing.Point(227, 95);
            this.txt_safeNameEdit.Name = "txt_safeNameEdit";
            this.txt_safeNameEdit.Size = new System.Drawing.Size(300, 40);
            this.txt_safeNameEdit.TabIndex = 202;
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Purple;
            this.label7.Location = new System.Drawing.Point(194, 6);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(148, 28);
            this.label7.TabIndex = 201;
            this.label7.Text = "تعديل خزنه المال";
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Purple;
            this.label8.Location = new System.Drawing.Point(363, 53);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(145, 28);
            this.label8.TabIndex = 200;
            this.label8.Text = ": اسماء المخازن";
            // 
            // btn_safeEdit
            // 
            this.btn_safeEdit.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_safeEdit.BackColor = System.Drawing.Color.Purple;
            this.btn_safeEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_safeEdit.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_safeEdit.ForeColor = System.Drawing.Color.White;
            this.btn_safeEdit.Location = new System.Drawing.Point(21, 43);
            this.btn_safeEdit.Name = "btn_safeEdit";
            this.btn_safeEdit.Size = new System.Drawing.Size(154, 50);
            this.btn_safeEdit.TabIndex = 199;
            this.btn_safeEdit.Text = "تعديل";
            this.btn_safeEdit.UseVisualStyleBackColor = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Gainsboro;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.btn_safeSave);
            this.panel2.Controls.Add(this.txt_safeName);
            this.panel2.Location = new System.Drawing.Point(548, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(487, 156);
            this.panel2.TabIndex = 209;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Purple;
            this.label6.Location = new System.Drawing.Point(171, 6);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(142, 28);
            this.label6.TabIndex = 201;
            this.label6.Text = "اضافه خزنه مال";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Purple;
            this.label5.Location = new System.Drawing.Point(324, 53);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(144, 28);
            this.label5.TabIndex = 200;
            this.label5.Text = ":اسم خزنه جديده";
            // 
            // btn_safeSave
            // 
            this.btn_safeSave.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_safeSave.BackColor = System.Drawing.Color.Purple;
            this.btn_safeSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_safeSave.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_safeSave.ForeColor = System.Drawing.Color.White;
            this.btn_safeSave.Location = new System.Drawing.Point(155, 99);
            this.btn_safeSave.Name = "btn_safeSave";
            this.btn_safeSave.Size = new System.Drawing.Size(154, 50);
            this.btn_safeSave.TabIndex = 199;
            this.btn_safeSave.Text = "حفظ";
            this.btn_safeSave.UseVisualStyleBackColor = false;
            this.btn_safeSave.Click += new System.EventHandler(this.btn_safeSave_Click);
            // 
            // txt_safeName
            // 
            this.txt_safeName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_safeName.BackColor = System.Drawing.Color.White;
            this.txt_safeName.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.txt_safeName.Font = new System.Drawing.Font("Palatino Linotype", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_safeName.ForeColor = System.Drawing.Color.Black;
            this.txt_safeName.Location = new System.Drawing.Point(9, 48);
            this.txt_safeName.Multiline = true;
            this.txt_safeName.Name = "txt_safeName";
            this.txt_safeName.Size = new System.Drawing.Size(300, 45);
            this.txt_safeName.TabIndex = 198;
            this.txt_safeName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_safeTransaction_KeyDown);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Gainsboro;
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.label11);
            this.panel4.Controls.Add(this.txt_safeTransactionAmount);
            this.panel4.Controls.Add(this.label10);
            this.panel4.Controls.Add(this.txt_safeTransactionNotes);
            this.panel4.Controls.Add(this.label9);
            this.panel4.Controls.Add(this.txt_safeTransactionNameSearch);
            this.panel4.Controls.Add(this.label2);
            this.panel4.Controls.Add(this.label4);
            this.panel4.Controls.Add(this.label3);
            this.panel4.Controls.Add(this.btn_exportPDF);
            this.panel4.Controls.Add(this.txt_safeTransactionId);
            this.panel4.Controls.Add(this.txt_safeTransactionName);
            this.panel4.Controls.Add(this.pcb_searchName);
            this.panel4.Controls.Add(this.btn_safeTransactionRemove);
            this.panel4.Controls.Add(this.pcb_searchID);
            this.panel4.Controls.Add(this.btn_safeTransactionEdit);
            this.panel4.Controls.Add(this.btn_safeTransactionSave);
            this.panel4.Controls.Add(this.label1);
            this.panel4.Location = new System.Drawing.Point(3, 165);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1032, 228);
            this.panel4.TabIndex = 211;
            // 
            // label11
            // 
            this.label11.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Purple;
            this.label11.Location = new System.Drawing.Point(336, 77);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(59, 28);
            this.label11.TabIndex = 205;
            this.label11.Text = ":المال";
            // 
            // txt_safeTransactionAmount
            // 
            this.txt_safeTransactionAmount.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_safeTransactionAmount.BackColor = System.Drawing.Color.White;
            this.txt_safeTransactionAmount.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.txt_safeTransactionAmount.Font = new System.Drawing.Font("Palatino Linotype", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_safeTransactionAmount.ForeColor = System.Drawing.Color.Black;
            this.txt_safeTransactionAmount.Location = new System.Drawing.Point(245, 108);
            this.txt_safeTransactionAmount.Multiline = true;
            this.txt_safeTransactionAmount.Name = "txt_safeTransactionAmount";
            this.txt_safeTransactionAmount.Size = new System.Drawing.Size(203, 45);
            this.txt_safeTransactionAmount.TabIndex = 206;
            this.txt_safeTransactionAmount.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_safeTransaction_KeyDown);
            this.txt_safeTransactionAmount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_safeTransactionAmount_KeyPress);
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Purple;
            this.label10.Location = new System.Drawing.Point(84, 77);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(93, 28);
            this.label10.TabIndex = 203;
            this.label10.Text = ":ملاحظات";
            // 
            // txt_safeTransactionNotes
            // 
            this.txt_safeTransactionNotes.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_safeTransactionNotes.BackColor = System.Drawing.Color.White;
            this.txt_safeTransactionNotes.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.txt_safeTransactionNotes.Font = new System.Drawing.Font("Palatino Linotype", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_safeTransactionNotes.ForeColor = System.Drawing.Color.Black;
            this.txt_safeTransactionNotes.Location = new System.Drawing.Point(28, 108);
            this.txt_safeTransactionNotes.Multiline = true;
            this.txt_safeTransactionNotes.Name = "txt_safeTransactionNotes";
            this.txt_safeTransactionNotes.Size = new System.Drawing.Size(203, 45);
            this.txt_safeTransactionNotes.TabIndex = 204;
            this.txt_safeTransactionNotes.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_safeTransaction_KeyDown);
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Purple;
            this.label9.Location = new System.Drawing.Point(336, 9);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(171, 28);
            this.label9.TabIndex = 202;
            this.label9.Text = "معاملات خزن المال";
            // 
            // txt_safeTransactionNameSearch
            // 
            this.txt_safeTransactionNameSearch.DropDownHeight = 200;
            this.txt_safeTransactionNameSearch.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txt_safeTransactionNameSearch.Font = new System.Drawing.Font("Palatino Linotype", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_safeTransactionNameSearch.FormattingEnabled = true;
            this.txt_safeTransactionNameSearch.IntegralHeight = false;
            this.txt_safeTransactionNameSearch.Location = new System.Drawing.Point(635, 9);
            this.txt_safeTransactionNameSearch.Name = "txt_safeTransactionNameSearch";
            this.txt_safeTransactionNameSearch.Size = new System.Drawing.Size(240, 40);
            this.txt_safeTransactionNameSearch.TabIndex = 197;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Purple;
            this.label2.Location = new System.Drawing.Point(797, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 28);
            this.label2.TabIndex = 130;
            this.label2.Text = ":رقم التصنيف";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Purple;
            this.label4.Location = new System.Drawing.Point(881, 14);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(128, 28);
            this.label4.TabIndex = 170;
            this.label4.Text = ": اختار الخزنة";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Purple;
            this.label3.Location = new System.Drawing.Point(525, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 28);
            this.label3.TabIndex = 129;
            this.label3.Text = ":اسم الخزنه";
            // 
            // btn_exportPDF
            // 
            this.btn_exportPDF.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_exportPDF.BackColor = System.Drawing.Color.Purple;
            this.btn_exportPDF.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_exportPDF.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_exportPDF.ForeColor = System.Drawing.Color.White;
            this.btn_exportPDF.Location = new System.Drawing.Point(762, 173);
            this.btn_exportPDF.Name = "btn_exportPDF";
            this.btn_exportPDF.Size = new System.Drawing.Size(154, 50);
            this.btn_exportPDF.TabIndex = 168;
            this.btn_exportPDF.Text = "طباعه الجدول";
            this.btn_exportPDF.UseVisualStyleBackColor = false;
            // 
            // txt_safeTransactionId
            // 
            this.txt_safeTransactionId.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_safeTransactionId.BackColor = System.Drawing.Color.White;
            this.txt_safeTransactionId.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.txt_safeTransactionId.Font = new System.Drawing.Font("Palatino Linotype", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_safeTransactionId.ForeColor = System.Drawing.Color.Black;
            this.txt_safeTransactionId.Location = new System.Drawing.Point(738, 108);
            this.txt_safeTransactionId.Multiline = true;
            this.txt_safeTransactionId.Name = "txt_safeTransactionId";
            this.txt_safeTransactionId.ShortcutsEnabled = false;
            this.txt_safeTransactionId.Size = new System.Drawing.Size(203, 45);
            this.txt_safeTransactionId.TabIndex = 132;
            this.txt_safeTransactionId.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_safeTransaction_KeyDown);
            // 
            // txt_safeTransactionName
            // 
            this.txt_safeTransactionName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_safeTransactionName.BackColor = System.Drawing.Color.White;
            this.txt_safeTransactionName.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.txt_safeTransactionName.Font = new System.Drawing.Font("Palatino Linotype", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_safeTransactionName.ForeColor = System.Drawing.Color.Black;
            this.txt_safeTransactionName.Location = new System.Drawing.Point(462, 108);
            this.txt_safeTransactionName.Multiline = true;
            this.txt_safeTransactionName.Name = "txt_safeTransactionName";
            this.txt_safeTransactionName.Size = new System.Drawing.Size(203, 45);
            this.txt_safeTransactionName.TabIndex = 131;
            this.txt_safeTransactionName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_safeTransaction_KeyDown);
            // 
            // pcb_searchName
            // 
            this.pcb_searchName.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pcb_searchName.Image = global::SuperMarket.Properties.Resources.icons8_search_48px_1;
            this.pcb_searchName.Location = new System.Drawing.Point(671, 108);
            this.pcb_searchName.Name = "pcb_searchName";
            this.pcb_searchName.Size = new System.Drawing.Size(45, 45);
            this.pcb_searchName.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcb_searchName.TabIndex = 133;
            this.pcb_searchName.TabStop = false;
            this.pcb_searchName.MouseEnter += new System.EventHandler(this.pcb_search_MouseEnter);
            this.pcb_searchName.MouseLeave += new System.EventHandler(this.pcb_search_MouseLeave);
            // 
            // btn_safeTransactionRemove
            // 
            this.btn_safeTransactionRemove.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_safeTransactionRemove.BackColor = System.Drawing.Color.Purple;
            this.btn_safeTransactionRemove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_safeTransactionRemove.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold);
            this.btn_safeTransactionRemove.ForeColor = System.Drawing.Color.White;
            this.btn_safeTransactionRemove.Location = new System.Drawing.Point(546, 173);
            this.btn_safeTransactionRemove.Name = "btn_safeTransactionRemove";
            this.btn_safeTransactionRemove.Size = new System.Drawing.Size(154, 50);
            this.btn_safeTransactionRemove.TabIndex = 137;
            this.btn_safeTransactionRemove.Text = "مسح";
            this.btn_safeTransactionRemove.UseVisualStyleBackColor = false;
            // 
            // pcb_searchID
            // 
            this.pcb_searchID.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pcb_searchID.Image = global::SuperMarket.Properties.Resources.icons8_search_48px_1;
            this.pcb_searchID.Location = new System.Drawing.Point(947, 108);
            this.pcb_searchID.Name = "pcb_searchID";
            this.pcb_searchID.Size = new System.Drawing.Size(45, 45);
            this.pcb_searchID.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcb_searchID.TabIndex = 134;
            this.pcb_searchID.TabStop = false;
            this.pcb_searchID.MouseEnter += new System.EventHandler(this.pcb_search_MouseEnter);
            this.pcb_searchID.MouseLeave += new System.EventHandler(this.pcb_search_MouseLeave);
            // 
            // btn_safeTransactionEdit
            // 
            this.btn_safeTransactionEdit.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_safeTransactionEdit.BackColor = System.Drawing.Color.Purple;
            this.btn_safeTransactionEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_safeTransactionEdit.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold);
            this.btn_safeTransactionEdit.ForeColor = System.Drawing.Color.White;
            this.btn_safeTransactionEdit.Location = new System.Drawing.Point(330, 173);
            this.btn_safeTransactionEdit.Name = "btn_safeTransactionEdit";
            this.btn_safeTransactionEdit.Size = new System.Drawing.Size(154, 50);
            this.btn_safeTransactionEdit.TabIndex = 136;
            this.btn_safeTransactionEdit.Text = "تعديل";
            this.btn_safeTransactionEdit.UseVisualStyleBackColor = false;
            // 
            // btn_safeTransactionSave
            // 
            this.btn_safeTransactionSave.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_safeTransactionSave.BackColor = System.Drawing.Color.Purple;
            this.btn_safeTransactionSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_safeTransactionSave.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_safeTransactionSave.ForeColor = System.Drawing.Color.White;
            this.btn_safeTransactionSave.Location = new System.Drawing.Point(114, 173);
            this.btn_safeTransactionSave.Name = "btn_safeTransactionSave";
            this.btn_safeTransactionSave.Size = new System.Drawing.Size(154, 50);
            this.btn_safeTransactionSave.TabIndex = 135;
            this.btn_safeTransactionSave.Text = "حفظ";
            this.btn_safeTransactionSave.UseVisualStyleBackColor = false;
            this.btn_safeTransactionSave.Click += new System.EventHandler(this.btn_safeTransactionSave_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(628, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 37);
            this.label1.TabIndex = 139;
            this.label1.Text = "*";
            // 
            // Safe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.MaximumSize = new System.Drawing.Size(1038, 660);
            this.MinimumSize = new System.Drawing.Size(1038, 660);
            this.Name = "Safe";
            this.Size = new System.Drawing.Size(1038, 660);
            this.Load += new System.EventHandler(this.Safe_Load);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.db_safeTransactionDataGridView)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcb_searchName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcb_searchID)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView db_safeTransactionDataGridView;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_safeDelete;
        private System.Windows.Forms.ComboBox txt_safeNameEdit;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btn_safeEdit;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn_safeSave;
        private System.Windows.Forms.TextBox txt_safeName;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox txt_safeTransactionNameSearch;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_exportPDF;
        private System.Windows.Forms.TextBox txt_safeTransactionId;
        private System.Windows.Forms.TextBox txt_safeTransactionName;
        private System.Windows.Forms.PictureBox pcb_searchName;
        private System.Windows.Forms.Button btn_safeTransactionRemove;
        private System.Windows.Forms.PictureBox pcb_searchID;
        private System.Windows.Forms.Button btn_safeTransactionEdit;
        private System.Windows.Forms.Button btn_safeTransactionSave;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txt_safeTransactionNotes;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txt_safeTransactionAmount;
    }
}
