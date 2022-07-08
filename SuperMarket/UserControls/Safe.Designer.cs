
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel3 = new System.Windows.Forms.Panel();
            this.db_procardsDataGridView = new System.Windows.Forms.DataGridView();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.db_procardsDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Gray;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.db_procardsDataGridView);
            this.panel3.Location = new System.Drawing.Point(6, 332);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1026, 323);
            this.panel3.TabIndex = 208;
            // 
            // db_procardsDataGridView
            // 
            this.db_procardsDataGridView.AllowUserToAddRows = false;
            this.db_procardsDataGridView.AllowUserToDeleteRows = false;
            this.db_procardsDataGridView.AllowUserToResizeColumns = false;
            this.db_procardsDataGridView.AllowUserToResizeRows = false;
            this.db_procardsDataGridView.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Purple;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.db_procardsDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.db_procardsDataGridView.ColumnHeadersHeight = 40;
            this.db_procardsDataGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.db_procardsDataGridView.EnableHeadersVisualStyles = false;
            this.db_procardsDataGridView.GridColor = System.Drawing.Color.Silver;
            this.db_procardsDataGridView.Location = new System.Drawing.Point(3, 3);
            this.db_procardsDataGridView.MultiSelect = false;
            this.db_procardsDataGridView.Name = "db_procardsDataGridView";
            this.db_procardsDataGridView.ReadOnly = true;
            this.db_procardsDataGridView.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.db_procardsDataGridView.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.db_procardsDataGridView.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Palatino Linotype", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.db_procardsDataGridView.RowTemplate.Height = 24;
            this.db_procardsDataGridView.Size = new System.Drawing.Size(1018, 515);
            this.db_procardsDataGridView.TabIndex = 1;
            // 
            // Safe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel3);
            this.MaximumSize = new System.Drawing.Size(1038, 660);
            this.MinimumSize = new System.Drawing.Size(1038, 660);
            this.Name = "Safe";
            this.Size = new System.Drawing.Size(1038, 660);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.db_procardsDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView db_procardsDataGridView;
    }
}
