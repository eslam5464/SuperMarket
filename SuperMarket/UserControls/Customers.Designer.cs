
namespace SuperMarket.UserControls
{
    partial class Customers
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
            this.btn_remove = new System.Windows.Forms.Button();
            this.db_customersDataGridView = new System.Windows.Forms.DataGridView();
            this.btn_edit = new System.Windows.Forms.Button();
            this.btn_save = new System.Windows.Forms.Button();
            this.txt_contact = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_address = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_customername = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_customerid = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pcb_searchPhone = new System.Windows.Forms.PictureBox();
            this.pcb_searchName = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.db_customersDataGridView)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcb_searchPhone)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcb_searchName)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_remove
            // 
            this.btn_remove.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_remove.BackColor = System.Drawing.Color.Purple;
            this.btn_remove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_remove.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_remove.ForeColor = System.Drawing.Color.White;
            this.btn_remove.Location = new System.Drawing.Point(853, 134);
            this.btn_remove.Name = "btn_remove";
            this.btn_remove.Size = new System.Drawing.Size(154, 50);
            this.btn_remove.TabIndex = 163;
            this.btn_remove.Text = "مسح";
            this.btn_remove.UseVisualStyleBackColor = false;
            this.btn_remove.Click += new System.EventHandler(this.btn_remove_Click);
            // 
            // db_customersDataGridView
            // 
            this.db_customersDataGridView.AllowUserToAddRows = false;
            this.db_customersDataGridView.AllowUserToDeleteRows = false;
            this.db_customersDataGridView.AllowUserToResizeColumns = false;
            this.db_customersDataGridView.AllowUserToResizeRows = false;
            this.db_customersDataGridView.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Purple;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Palatino Linotype", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.db_customersDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.db_customersDataGridView.ColumnHeadersHeight = 40;
            this.db_customersDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.db_customersDataGridView.EnableHeadersVisualStyles = false;
            this.db_customersDataGridView.GridColor = System.Drawing.Color.Silver;
            this.db_customersDataGridView.Location = new System.Drawing.Point(0, 0);
            this.db_customersDataGridView.MultiSelect = false;
            this.db_customersDataGridView.Name = "db_customersDataGridView";
            this.db_customersDataGridView.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.db_customersDataGridView.RowHeadersVisible = false;
            this.db_customersDataGridView.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.db_customersDataGridView.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.db_customersDataGridView.RowTemplate.Height = 30;
            this.db_customersDataGridView.Size = new System.Drawing.Size(1032, 447);
            this.db_customersDataGridView.TabIndex = 1;
            // 
            // btn_edit
            // 
            this.btn_edit.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_edit.BackColor = System.Drawing.Color.Purple;
            this.btn_edit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_edit.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_edit.ForeColor = System.Drawing.Color.White;
            this.btn_edit.Location = new System.Drawing.Point(853, 78);
            this.btn_edit.Name = "btn_edit";
            this.btn_edit.Size = new System.Drawing.Size(154, 50);
            this.btn_edit.TabIndex = 160;
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
            this.btn_save.Location = new System.Drawing.Point(853, 22);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(154, 50);
            this.btn_save.TabIndex = 159;
            this.btn_save.Text = "حفظ";
            this.btn_save.UseVisualStyleBackColor = false;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // txt_contact
            // 
            this.txt_contact.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_contact.BackColor = System.Drawing.Color.White;
            this.txt_contact.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.txt_contact.Font = new System.Drawing.Font("Palatino Linotype", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_contact.ForeColor = System.Drawing.Color.Black;
            this.txt_contact.Location = new System.Drawing.Point(50, 44);
            this.txt_contact.Multiline = true;
            this.txt_contact.Name = "txt_contact";
            this.txt_contact.Size = new System.Drawing.Size(341, 45);
            this.txt_contact.TabIndex = 158;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Purple;
            this.label1.Location = new System.Drawing.Point(766, 106);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 23);
            this.label1.TabIndex = 155;
            this.label1.Text = ":العنوان";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Purple;
            this.label4.Location = new System.Drawing.Point(298, 13);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 23);
            this.label4.TabIndex = 156;
            this.label4.Text = ":رقم الإتصال";
            // 
            // txt_address
            // 
            this.txt_address.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_address.BackColor = System.Drawing.Color.White;
            this.txt_address.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.txt_address.Font = new System.Drawing.Font("Palatino Linotype", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_address.ForeColor = System.Drawing.Color.Black;
            this.txt_address.Location = new System.Drawing.Point(486, 137);
            this.txt_address.Multiline = true;
            this.txt_address.Name = "txt_address";
            this.txt_address.Size = new System.Drawing.Size(341, 45);
            this.txt_address.TabIndex = 157;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Purple;
            this.label3.Location = new System.Drawing.Point(307, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 23);
            this.label3.TabIndex = 151;
            this.label3.Text = ":اسم العميل";
            // 
            // txt_customername
            // 
            this.txt_customername.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_customername.BackColor = System.Drawing.Color.White;
            this.txt_customername.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.txt_customername.Font = new System.Drawing.Font("Palatino Linotype", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_customername.ForeColor = System.Drawing.Color.Black;
            this.txt_customername.Location = new System.Drawing.Point(50, 137);
            this.txt_customername.Multiline = true;
            this.txt_customername.Name = "txt_customername";
            this.txt_customername.Size = new System.Drawing.Size(341, 45);
            this.txt_customername.TabIndex = 153;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Purple;
            this.label2.Location = new System.Drawing.Point(674, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(153, 23);
            this.label2.TabIndex = 152;
            this.label2.Text = ":الرقم التعريفي للعميل";
            // 
            // txt_customerid
            // 
            this.txt_customerid.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_customerid.BackColor = System.Drawing.Color.White;
            this.txt_customerid.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.txt_customerid.Font = new System.Drawing.Font("Palatino Linotype", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_customerid.ForeColor = System.Drawing.Color.Black;
            this.txt_customerid.Location = new System.Drawing.Point(486, 44);
            this.txt_customerid.Multiline = true;
            this.txt_customerid.Name = "txt_customerid";
            this.txt_customerid.Size = new System.Drawing.Size(341, 45);
            this.txt_customerid.TabIndex = 154;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gray;
            this.panel1.Controls.Add(this.db_customersDataGridView);
            this.panel1.Location = new System.Drawing.Point(3, 201);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1032, 447);
            this.panel1.TabIndex = 150;
            // 
            // pcb_searchPhone
            // 
            this.pcb_searchPhone.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pcb_searchPhone.Image = global::SuperMarket.Properties.Resources.icons8_search_48px_1;
            this.pcb_searchPhone.Location = new System.Drawing.Point(403, 44);
            this.pcb_searchPhone.Name = "pcb_searchPhone";
            this.pcb_searchPhone.Size = new System.Drawing.Size(45, 45);
            this.pcb_searchPhone.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcb_searchPhone.TabIndex = 162;
            this.pcb_searchPhone.TabStop = false;
            this.pcb_searchPhone.Click += new System.EventHandler(this.pcb_searchPhone_Click);
            this.pcb_searchPhone.DoubleClick += new System.EventHandler(this.pcb_search_DoubleClick);
            this.pcb_searchPhone.MouseEnter += new System.EventHandler(this.pcb_search_MouseEnter);
            this.pcb_searchPhone.MouseLeave += new System.EventHandler(this.pcb_search_MouseLeave);
            // 
            // pcb_searchName
            // 
            this.pcb_searchName.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pcb_searchName.Image = global::SuperMarket.Properties.Resources.icons8_search_48px_1;
            this.pcb_searchName.Location = new System.Drawing.Point(403, 137);
            this.pcb_searchName.Name = "pcb_searchName";
            this.pcb_searchName.Size = new System.Drawing.Size(45, 45);
            this.pcb_searchName.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcb_searchName.TabIndex = 161;
            this.pcb_searchName.TabStop = false;
            this.pcb_searchName.Click += new System.EventHandler(this.pcb_searchName_Click);
            this.pcb_searchName.DoubleClick += new System.EventHandler(this.pcb_search_DoubleClick);
            this.pcb_searchName.MouseEnter += new System.EventHandler(this.pcb_search_MouseEnter);
            this.pcb_searchName.MouseLeave += new System.EventHandler(this.pcb_search_MouseLeave);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(39, 118);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 37);
            this.label5.TabIndex = 164;
            this.label5.Text = "*";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Red;
            this.label6.Location = new System.Drawing.Point(471, 116);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 37);
            this.label6.TabIndex = 165;
            this.label6.Text = "*";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Red;
            this.label7.Location = new System.Drawing.Point(34, 27);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(29, 37);
            this.label7.TabIndex = 166;
            this.label7.Text = "*";
            // 
            // Customers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.txt_address);
            this.Controls.Add(this.txt_contact);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txt_customername);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btn_remove);
            this.Controls.Add(this.pcb_searchPhone);
            this.Controls.Add(this.pcb_searchName);
            this.Controls.Add(this.btn_edit);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_customerid);
            this.Controls.Add(this.panel1);
            this.MinimumSize = new System.Drawing.Size(1038, 660);
            this.Name = "Customers";
            this.Size = new System.Drawing.Size(1038, 660);
            this.Load += new System.EventHandler(this.Customers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.db_customersDataGridView)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pcb_searchPhone)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcb_searchName)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_remove;
        private System.Windows.Forms.DataGridView db_customersDataGridView;
        private System.Windows.Forms.PictureBox pcb_searchPhone;
        private System.Windows.Forms.PictureBox pcb_searchName;
        private System.Windows.Forms.Button btn_edit;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.TextBox txt_contact;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_address;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_customername;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_customerid;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
    }
}
