
namespace SuperMarket.UserControls
{
    partial class Orders
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
            this.db_ordersDataGridView = new System.Windows.Forms.DataGridView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txt_customername = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_invoiceno = new System.Windows.Forms.TextBox();
            this.btn_refresh = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pcb_search_by_customer_name = new System.Windows.Forms.PictureBox();
            this.pcb_search_by_invoiceno = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.db_ordersDataGridView)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcb_search_by_customer_name)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcb_search_by_invoiceno)).BeginInit();
            this.SuspendLayout();
            // 
            // db_ordersDataGridView
            // 
            this.db_ordersDataGridView.AllowUserToAddRows = false;
            this.db_ordersDataGridView.AllowUserToDeleteRows = false;
            this.db_ordersDataGridView.AllowUserToResizeColumns = false;
            this.db_ordersDataGridView.AllowUserToResizeRows = false;
            this.db_ordersDataGridView.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Purple;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.db_ordersDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.db_ordersDataGridView.ColumnHeadersHeight = 35;
            this.db_ordersDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.db_ordersDataGridView.EnableHeadersVisualStyles = false;
            this.db_ordersDataGridView.GridColor = System.Drawing.Color.Silver;
            this.db_ordersDataGridView.Location = new System.Drawing.Point(0, 0);
            this.db_ordersDataGridView.MultiSelect = false;
            this.db_ordersDataGridView.Name = "db_ordersDataGridView";
            this.db_ordersDataGridView.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.db_ordersDataGridView.RowHeadersVisible = false;
            this.db_ordersDataGridView.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.db_ordersDataGridView.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Palatino Linotype", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.db_ordersDataGridView.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            this.db_ordersDataGridView.RowTemplate.Height = 30;
            this.db_ordersDataGridView.Size = new System.Drawing.Size(1032, 531);
            this.db_ordersDataGridView.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Gray;
            this.panel3.Controls.Add(this.db_ordersDataGridView);
            this.panel3.Location = new System.Drawing.Point(3, 121);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1032, 531);
            this.panel3.TabIndex = 17;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Purple;
            this.label2.Location = new System.Drawing.Point(211, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 23);
            this.label2.TabIndex = 46;
            this.label2.Text = ":رقم الفاتورة";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.pcb_search_by_customer_name);
            this.panel2.Controls.Add(this.txt_customername);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(405, 9);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(396, 100);
            this.panel2.TabIndex = 19;
            // 
            // txt_customername
            // 
            this.txt_customername.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_customername.BackColor = System.Drawing.Color.White;
            this.txt_customername.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.txt_customername.Font = new System.Drawing.Font("Palatino Linotype", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_customername.ForeColor = System.Drawing.Color.Black;
            this.txt_customername.Location = new System.Drawing.Point(24, 42);
            this.txt_customername.Multiline = true;
            this.txt_customername.Name = "txt_customername";
            this.txt_customername.Size = new System.Drawing.Size(304, 45);
            this.txt_customername.TabIndex = 48;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Purple;
            this.label1.Location = new System.Drawing.Point(227, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 23);
            this.label1.TabIndex = 46;
            this.label1.Text = ":اسم العميل";
            // 
            // txt_invoiceno
            // 
            this.txt_invoiceno.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_invoiceno.BackColor = System.Drawing.Color.White;
            this.txt_invoiceno.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.txt_invoiceno.Font = new System.Drawing.Font("Palatino Linotype", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_invoiceno.ForeColor = System.Drawing.Color.Black;
            this.txt_invoiceno.Location = new System.Drawing.Point(17, 42);
            this.txt_invoiceno.Multiline = true;
            this.txt_invoiceno.Name = "txt_invoiceno";
            this.txt_invoiceno.Size = new System.Drawing.Size(304, 45);
            this.txt_invoiceno.TabIndex = 47;
            // 
            // btn_refresh
            // 
            this.btn_refresh.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_refresh.BackColor = System.Drawing.Color.Purple;
            this.btn_refresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_refresh.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_refresh.ForeColor = System.Drawing.Color.White;
            this.btn_refresh.Location = new System.Drawing.Point(14, 25);
            this.btn_refresh.Name = "btn_refresh";
            this.btn_refresh.Size = new System.Drawing.Size(200, 50);
            this.btn_refresh.TabIndex = 139;
            this.btn_refresh.Text = "Refresh";
            this.btn_refresh.UseVisualStyleBackColor = false;
            this.btn_refresh.Click += new System.EventHandler(this.btn_refresh_Click);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.btn_refresh);
            this.panel4.Location = new System.Drawing.Point(807, 9);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(228, 100);
            this.panel4.TabIndex = 20;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.pcb_search_by_invoiceno);
            this.panel1.Controls.Add(this.txt_invoiceno);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(3, 9);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(396, 100);
            this.panel1.TabIndex = 18;
            // 
            // pcb_search_by_customer_name
            // 
            this.pcb_search_by_customer_name.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pcb_search_by_customer_name.Image = global::SuperMarket.Properties.Resources.icons8_search_48px_1;
            this.pcb_search_by_customer_name.Location = new System.Drawing.Point(346, 42);
            this.pcb_search_by_customer_name.Name = "pcb_search_by_customer_name";
            this.pcb_search_by_customer_name.Size = new System.Drawing.Size(45, 45);
            this.pcb_search_by_customer_name.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcb_search_by_customer_name.TabIndex = 138;
            this.pcb_search_by_customer_name.TabStop = false;
            this.pcb_search_by_customer_name.Click += new System.EventHandler(this.pcb_search_by_customer_name_Click);
            this.pcb_search_by_customer_name.MouseEnter += new System.EventHandler(this.pcb_search_by_MouseEnter);
            this.pcb_search_by_customer_name.MouseLeave += new System.EventHandler(this.pcb_search_by_MouseLeave);
            // 
            // pcb_search_by_invoiceno
            // 
            this.pcb_search_by_invoiceno.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pcb_search_by_invoiceno.Image = global::SuperMarket.Properties.Resources.icons8_search_48px_1;
            this.pcb_search_by_invoiceno.Location = new System.Drawing.Point(336, 42);
            this.pcb_search_by_invoiceno.Name = "pcb_search_by_invoiceno";
            this.pcb_search_by_invoiceno.Size = new System.Drawing.Size(45, 45);
            this.pcb_search_by_invoiceno.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcb_search_by_invoiceno.TabIndex = 138;
            this.pcb_search_by_invoiceno.TabStop = false;
            this.pcb_search_by_invoiceno.Click += new System.EventHandler(this.pcb_search_by_invoiceno_Click);
            this.pcb_search_by_invoiceno.MouseEnter += new System.EventHandler(this.pcb_search_by_MouseEnter);
            this.pcb_search_by_invoiceno.MouseLeave += new System.EventHandler(this.pcb_search_by_MouseLeave);
            // 
            // Orders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel1);
            this.MinimumSize = new System.Drawing.Size(1038, 660);
            this.Name = "Orders";
            this.Size = new System.Drawing.Size(1038, 660);
            this.Load += new System.EventHandler(this.Orders_Load);
            ((System.ComponentModel.ISupportInitialize)(this.db_ordersDataGridView)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcb_search_by_customer_name)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcb_search_by_invoiceno)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView db_ordersDataGridView;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox pcb_search_by_invoiceno;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pcb_search_by_customer_name;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txt_customername;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_invoiceno;
        private System.Windows.Forms.Button btn_refresh;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel1;
    }
}
