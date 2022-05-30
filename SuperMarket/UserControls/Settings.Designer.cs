
namespace SuperMarket.UserControls
{
    partial class Settings
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.txt_color = new System.Windows.Forms.ComboBox();
            this.pan_settingsParameters = new System.Windows.Forms.Panel();
            this.pan_color_sample = new System.Windows.Forms.Panel();
            this.btn_saveChanges = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9.055877F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 31.31021F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 59.63391F));
            this.tableLayoutPanel1.Controls.Add(this.txt_color, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.pan_settingsParameters, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.pan_color_sample, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.btn_saveChanges, 1, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 49F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 51F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1038, 660);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // txt_color
            // 
            this.txt_color.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txt_color.DropDownHeight = 200;
            this.txt_color.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txt_color.Font = new System.Drawing.Font("Palatino Linotype", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_color.FormattingEnabled = true;
            this.txt_color.IntegralHeight = false;
            this.txt_color.Location = new System.Drawing.Point(97, 3);
            this.txt_color.Name = "txt_color";
            this.txt_color.Size = new System.Drawing.Size(318, 40);
            this.txt_color.TabIndex = 197;
            this.txt_color.SelectedIndexChanged += new System.EventHandler(this.txt_color_SelectedIndexChanged);
            // 
            // pan_settingsParameters
            // 
            this.pan_settingsParameters.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pan_settingsParameters.Location = new System.Drawing.Point(421, 3);
            this.pan_settingsParameters.Name = "pan_settingsParameters";
            this.tableLayoutPanel1.SetRowSpan(this.pan_settingsParameters, 3);
            this.pan_settingsParameters.Size = new System.Drawing.Size(614, 144);
            this.pan_settingsParameters.TabIndex = 7;
            // 
            // pan_color_sample
            // 
            this.pan_color_sample.Location = new System.Drawing.Point(3, 3);
            this.pan_color_sample.Name = "pan_color_sample";
            this.pan_color_sample.Size = new System.Drawing.Size(88, 44);
            this.pan_color_sample.TabIndex = 198;
            // 
            // btn_saveChanges
            // 
            this.btn_saveChanges.Location = new System.Drawing.Point(97, 102);
            this.btn_saveChanges.Name = "btn_saveChanges";
            this.btn_saveChanges.Size = new System.Drawing.Size(75, 23);
            this.btn_saveChanges.TabIndex = 199;
            this.btn_saveChanges.Text = "button1";
            this.btn_saveChanges.UseVisualStyleBackColor = true;
            this.btn_saveChanges.Click += new System.EventHandler(this.btn_saveChanges_Click);
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.Controls.Add(this.tableLayoutPanel1);
            this.MinimumSize = new System.Drawing.Size(1038, 660);
            this.Name = "Settings";
            this.Size = new System.Drawing.Size(1038, 660);
            this.Load += new System.EventHandler(this.Settings_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel pan_settingsParameters;
        private System.Windows.Forms.ComboBox txt_color;
        private System.Windows.Forms.Panel pan_color_sample;
        private System.Windows.Forms.Button btn_saveChanges;
    }
}
