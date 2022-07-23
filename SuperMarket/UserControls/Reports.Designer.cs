
namespace POSWarehouse.UserControls
{
    partial class Reports
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
            this.btn_printPDF = new System.Windows.Forms.Button();
            this.cb_printType = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_printPDF
            // 
            this.btn_printPDF.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_printPDF.BackColor = System.Drawing.Color.Purple;
            this.btn_printPDF.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_printPDF.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_printPDF.ForeColor = System.Drawing.Color.White;
            this.btn_printPDF.Location = new System.Drawing.Point(137, 119);
            this.btn_printPDF.Name = "btn_printPDF";
            this.btn_printPDF.Size = new System.Drawing.Size(154, 50);
            this.btn_printPDF.TabIndex = 160;
            this.btn_printPDF.Text = "تحديد المكان";
            this.btn_printPDF.UseVisualStyleBackColor = false;
            this.btn_printPDF.Click += new System.EventHandler(this.btn_printPDF_Click);
            // 
            // cb_printType
            // 
            this.cb_printType.DropDownHeight = 200;
            this.cb_printType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_printType.Font = new System.Drawing.Font("Palatino Linotype", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_printType.FormattingEnabled = true;
            this.cb_printType.IntegralHeight = false;
            this.cb_printType.Location = new System.Drawing.Point(21, 55);
            this.cb_printType.MaxDropDownItems = 10;
            this.cb_printType.Name = "cb_printType";
            this.cb_printType.Size = new System.Drawing.Size(280, 40);
            this.cb_printType.Sorted = true;
            this.cb_printType.TabIndex = 217;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gainsboro;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.cb_printType);
            this.panel1.Controls.Add(this.btn_printPDF);
            this.panel1.Location = new System.Drawing.Point(6, 7);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(429, 193);
            this.panel1.TabIndex = 218;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Gainsboro;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Purple;
            this.label2.Location = new System.Drawing.Point(145, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(138, 28);
            this.label2.TabIndex = 219;
            this.label2.Text = " استخراج PDF";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Gainsboro;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Purple;
            this.label1.Location = new System.Drawing.Point(307, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 25);
            this.label1.TabIndex = 218;
            this.label1.Text = ":اختر الفئة";
            // 
            // Reports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.panel1);
            this.MinimumSize = new System.Drawing.Size(1038, 660);
            this.Name = "Reports";
            this.Size = new System.Drawing.Size(1038, 660);
            this.Load += new System.EventHandler(this.Reports_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_printPDF;
        private System.Windows.Forms.ComboBox cb_printType;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}
