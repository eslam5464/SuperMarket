
namespace SuperMarket.UserControls
{
    partial class AdminPanel
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
            this.btn_openBackupLocation = new System.Windows.Forms.Button();
            this.btn_getSerial = new System.Windows.Forms.Button();
            this.txt_serialKey = new System.Windows.Forms.TextBox();
            this.btn_restoreDatabase = new System.Windows.Forms.Button();
            this.btn_trialDaysLeft = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_openBackupLocation
            // 
            this.btn_openBackupLocation.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_openBackupLocation.BackColor = System.Drawing.Color.Purple;
            this.btn_openBackupLocation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_openBackupLocation.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_openBackupLocation.ForeColor = System.Drawing.Color.White;
            this.btn_openBackupLocation.Location = new System.Drawing.Point(34, 20);
            this.btn_openBackupLocation.Name = "btn_openBackupLocation";
            this.btn_openBackupLocation.Size = new System.Drawing.Size(207, 50);
            this.btn_openBackupLocation.TabIndex = 200;
            this.btn_openBackupLocation.Text = "Backup location";
            this.btn_openBackupLocation.UseVisualStyleBackColor = false;
            this.btn_openBackupLocation.Click += new System.EventHandler(this.btn_openBackupLocation_Click);
            // 
            // btn_getSerial
            // 
            this.btn_getSerial.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_getSerial.BackColor = System.Drawing.Color.Purple;
            this.btn_getSerial.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_getSerial.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_getSerial.ForeColor = System.Drawing.Color.White;
            this.btn_getSerial.Location = new System.Drawing.Point(286, 20);
            this.btn_getSerial.Name = "btn_getSerial";
            this.btn_getSerial.Size = new System.Drawing.Size(207, 50);
            this.btn_getSerial.TabIndex = 201;
            this.btn_getSerial.Text = "Serial Key";
            this.btn_getSerial.UseVisualStyleBackColor = false;
            this.btn_getSerial.Click += new System.EventHandler(this.btn_getSerial_Click);
            // 
            // txt_serialKey
            // 
            this.txt_serialKey.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_serialKey.BackColor = System.Drawing.Color.White;
            this.txt_serialKey.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.txt_serialKey.Font = new System.Drawing.Font("Palatino Linotype", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_serialKey.ForeColor = System.Drawing.Color.Black;
            this.txt_serialKey.Location = new System.Drawing.Point(499, 25);
            this.txt_serialKey.Multiline = true;
            this.txt_serialKey.Name = "txt_serialKey";
            this.txt_serialKey.Size = new System.Drawing.Size(486, 45);
            this.txt_serialKey.TabIndex = 202;
            // 
            // btn_restoreDatabase
            // 
            this.btn_restoreDatabase.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_restoreDatabase.BackColor = System.Drawing.Color.Purple;
            this.btn_restoreDatabase.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_restoreDatabase.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_restoreDatabase.ForeColor = System.Drawing.Color.White;
            this.btn_restoreDatabase.Location = new System.Drawing.Point(34, 110);
            this.btn_restoreDatabase.Name = "btn_restoreDatabase";
            this.btn_restoreDatabase.Size = new System.Drawing.Size(207, 50);
            this.btn_restoreDatabase.TabIndex = 203;
            this.btn_restoreDatabase.Text = "Restore Database";
            this.btn_restoreDatabase.UseVisualStyleBackColor = false;
            this.btn_restoreDatabase.Click += new System.EventHandler(this.btn_restoreDatabase_Click);
            // 
            // btn_trialDaysLeft
            // 
            this.btn_trialDaysLeft.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_trialDaysLeft.BackColor = System.Drawing.Color.Purple;
            this.btn_trialDaysLeft.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_trialDaysLeft.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_trialDaysLeft.ForeColor = System.Drawing.Color.White;
            this.btn_trialDaysLeft.Location = new System.Drawing.Point(286, 110);
            this.btn_trialDaysLeft.Name = "btn_trialDaysLeft";
            this.btn_trialDaysLeft.Size = new System.Drawing.Size(207, 50);
            this.btn_trialDaysLeft.TabIndex = 204;
            this.btn_trialDaysLeft.Text = "Trial days left";
            this.btn_trialDaysLeft.UseVisualStyleBackColor = false;
            this.btn_trialDaysLeft.Click += new System.EventHandler(this.btn_trialDaysLeft_Click);
            // 
            // AdminPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btn_trialDaysLeft);
            this.Controls.Add(this.btn_restoreDatabase);
            this.Controls.Add(this.txt_serialKey);
            this.Controls.Add(this.btn_getSerial);
            this.Controls.Add(this.btn_openBackupLocation);
            this.MaximumSize = new System.Drawing.Size(1038, 660);
            this.MinimumSize = new System.Drawing.Size(1038, 660);
            this.Name = "AdminPanel";
            this.Size = new System.Drawing.Size(1038, 660);
            this.Load += new System.EventHandler(this.AdminPanel_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_openBackupLocation;
        private System.Windows.Forms.Button btn_getSerial;
        private System.Windows.Forms.TextBox txt_serialKey;
        private System.Windows.Forms.Button btn_restoreDatabase;
        private System.Windows.Forms.Button btn_trialDaysLeft;
    }
}
