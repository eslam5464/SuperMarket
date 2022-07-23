
namespace POSWarehouse.Forms
{
    partial class About
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(About));
            this.tableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.pic_logo = new System.Windows.Forms.PictureBox();
            this.lbl_ProductName = new System.Windows.Forms.Label();
            this.lbl_Version = new System.Windows.Forms.Label();
            this.lbl_additionalInfo = new System.Windows.Forms.Label();
            this.lbl_CompanyName = new System.Windows.Forms.Label();
            this.tb_Description = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbl_main = new System.Windows.Forms.Label();
            this.btn_close = new System.Windows.Forms.Button();
            this.tableLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_logo)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel
            // 
            this.tableLayoutPanel.BackColor = System.Drawing.Color.White;
            this.tableLayoutPanel.ColumnCount = 2;
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 67F));
            this.tableLayoutPanel.Controls.Add(this.pic_logo, 0, 1);
            this.tableLayoutPanel.Controls.Add(this.lbl_ProductName, 1, 1);
            this.tableLayoutPanel.Controls.Add(this.lbl_Version, 1, 2);
            this.tableLayoutPanel.Controls.Add(this.lbl_additionalInfo, 1, 3);
            this.tableLayoutPanel.Controls.Add(this.lbl_CompanyName, 1, 4);
            this.tableLayoutPanel.Controls.Add(this.tb_Description, 1, 5);
            this.tableLayoutPanel.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel.Controls.Add(this.btn_close, 1, 6);
            this.tableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel.Location = new System.Drawing.Point(9, 9);
            this.tableLayoutPanel.Name = "tableLayoutPanel";
            this.tableLayoutPanel.RowCount = 7;
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.090909F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.090909F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.090909F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.090909F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.090909F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 45.45454F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.090909F));
            this.tableLayoutPanel.Size = new System.Drawing.Size(711, 346);
            this.tableLayoutPanel.TabIndex = 1;
            // 
            // pic_logo
            // 
            this.pic_logo.BackColor = System.Drawing.Color.Purple;
            this.pic_logo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pic_logo.Image = global::POSWarehouse.Properties.Resources.pic_logo_Image;
            this.pic_logo.Location = new System.Drawing.Point(3, 34);
            this.pic_logo.Name = "pic_logo";
            this.tableLayoutPanel.SetRowSpan(this.pic_logo, 6);
            this.pic_logo.Size = new System.Drawing.Size(228, 309);
            this.pic_logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic_logo.TabIndex = 12;
            this.pic_logo.TabStop = false;
            // 
            // lbl_ProductName
            // 
            this.lbl_ProductName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_ProductName.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ProductName.Location = new System.Drawing.Point(240, 31);
            this.lbl_ProductName.Margin = new System.Windows.Forms.Padding(6, 0, 3, 0);
            this.lbl_ProductName.MaximumSize = new System.Drawing.Size(0, 17);
            this.lbl_ProductName.Name = "lbl_ProductName";
            this.lbl_ProductName.Size = new System.Drawing.Size(468, 17);
            this.lbl_ProductName.TabIndex = 19;
            this.lbl_ProductName.Text = "برنامج المخازن والمبيعات";
            this.lbl_ProductName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_Version
            // 
            this.lbl_Version.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_Version.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Version.Location = new System.Drawing.Point(240, 62);
            this.lbl_Version.Margin = new System.Windows.Forms.Padding(6, 0, 3, 0);
            this.lbl_Version.MaximumSize = new System.Drawing.Size(0, 17);
            this.lbl_Version.Name = "lbl_Version";
            this.lbl_Version.Size = new System.Drawing.Size(468, 17);
            this.lbl_Version.TabIndex = 0;
            this.lbl_Version.Text = "الاصدار";
            this.lbl_Version.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_additionalInfo
            // 
            this.lbl_additionalInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_additionalInfo.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.lbl_additionalInfo.ForeColor = System.Drawing.Color.Red;
            this.lbl_additionalInfo.Location = new System.Drawing.Point(240, 93);
            this.lbl_additionalInfo.Margin = new System.Windows.Forms.Padding(6, 0, 3, 0);
            this.lbl_additionalInfo.MaximumSize = new System.Drawing.Size(0, 17);
            this.lbl_additionalInfo.Name = "lbl_additionalInfo";
            this.lbl_additionalInfo.Size = new System.Drawing.Size(468, 17);
            this.lbl_additionalInfo.TabIndex = 21;
            this.lbl_additionalInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_CompanyName
            // 
            this.lbl_CompanyName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_CompanyName.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_CompanyName.ForeColor = System.Drawing.Color.Red;
            this.lbl_CompanyName.Location = new System.Drawing.Point(240, 124);
            this.lbl_CompanyName.Margin = new System.Windows.Forms.Padding(6, 0, 3, 0);
            this.lbl_CompanyName.MaximumSize = new System.Drawing.Size(0, 17);
            this.lbl_CompanyName.Name = "lbl_CompanyName";
            this.lbl_CompanyName.Size = new System.Drawing.Size(468, 17);
            this.lbl_CompanyName.TabIndex = 22;
            this.lbl_CompanyName.Text = "رقم الاستفسار 01069056049";
            this.lbl_CompanyName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tb_Description
            // 
            this.tb_Description.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_Description.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Description.Location = new System.Drawing.Point(240, 158);
            this.tb_Description.Margin = new System.Windows.Forms.Padding(6, 3, 3, 3);
            this.tb_Description.Multiline = true;
            this.tb_Description.Name = "tb_Description";
            this.tb_Description.ReadOnly = true;
            this.tb_Description.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.tb_Description.Size = new System.Drawing.Size(468, 151);
            this.tb_Description.TabIndex = 23;
            this.tb_Description.TabStop = false;
            this.tb_Description.Text = "للاسفتسارات برجاء الاتصال بالبيانات الموجوده بـالاعلى";
            this.tb_Description.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // panel1
            // 
            this.tableLayoutPanel.SetColumnSpan(this.panel1, 2);
            this.panel1.Controls.Add(this.lbl_main);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(705, 25);
            this.panel1.TabIndex = 25;
            // 
            // lbl_main
            // 
            this.lbl_main.AutoSize = true;
            this.lbl_main.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_main.ForeColor = System.Drawing.Color.Purple;
            this.lbl_main.Location = new System.Drawing.Point(311, 1);
            this.lbl_main.Name = "lbl_main";
            this.lbl_main.Size = new System.Drawing.Size(80, 19);
            this.lbl_main.TabIndex = 1;
            this.lbl_main.Text = "عن البرنامج";
            // 
            // btn_close
            // 
            this.btn_close.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_close.BackColor = System.Drawing.Color.Purple;
            this.btn_close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_close.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_close.ForeColor = System.Drawing.Color.White;
            this.btn_close.Location = new System.Drawing.Point(403, 314);
            this.btn_close.Margin = new System.Windows.Forms.Padding(2);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(139, 30);
            this.btn_close.TabIndex = 83;
            this.btn_close.Text = "اغلاق";
            this.btn_close.UseVisualStyleBackColor = false;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // About
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Purple;
            this.ClientSize = new System.Drawing.Size(729, 364);
            this.Controls.Add(this.tableLayoutPanel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "About";
            this.Padding = new System.Windows.Forms.Padding(9);
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "عن البرنامج";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.About_Load);
            this.tableLayoutPanel.ResumeLayout(false);
            this.tableLayoutPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_logo)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel;
        private System.Windows.Forms.PictureBox pic_logo;
        private System.Windows.Forms.Label lbl_ProductName;
        private System.Windows.Forms.Label lbl_Version;
        private System.Windows.Forms.Label lbl_additionalInfo;
        private System.Windows.Forms.Label lbl_CompanyName;
        private System.Windows.Forms.TextBox tb_Description;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbl_main;
        private System.Windows.Forms.Button btn_close;
    }
}