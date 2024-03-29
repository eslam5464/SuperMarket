﻿
namespace POSWarehouse.UserControls
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
            this.cb_color = new System.Windows.Forms.ComboBox();
            this.pan_color_sample = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel7 = new System.Windows.Forms.TableLayoutPanel();
            this.label3 = new System.Windows.Forms.Label();
            this.tableLayoutPanel8 = new System.Windows.Forms.TableLayoutPanel();
            this.pic_deleteAllDatabase = new System.Windows.Forms.PictureBox();
            this.btn_deleteAllDatabase = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_restoreDatabase = new System.Windows.Forms.Label();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_backupLocation = new System.Windows.Forms.Button();
            this.tb_backupLocation = new System.Windows.Forms.TextBox();
            this.lbl_backupLocation = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.lbl_appColor = new System.Windows.Forms.Label();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.pic_restoreDatabaseLoading = new System.Windows.Forms.PictureBox();
            this.btn_restoreDatabase = new System.Windows.Forms.Button();
            this.tableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
            this.pic_createBackupLoading = new System.Windows.Forms.PictureBox();
            this.btn_createBackup = new System.Windows.Forms.Button();
            this.btn_saveSettings = new System.Windows.Forms.Button();
            this.btn_resetDefault = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel7.SuspendLayout();
            this.tableLayoutPanel8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_deleteAllDatabase)).BeginInit();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_restoreDatabaseLoading)).BeginInit();
            this.tableLayoutPanel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_createBackupLoading)).BeginInit();
            this.SuspendLayout();
            // 
            // cb_color
            // 
            this.cb_color.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cb_color.DropDownHeight = 200;
            this.cb_color.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_color.Enabled = false;
            this.cb_color.Font = new System.Drawing.Font("Palatino Linotype", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_color.FormattingEnabled = true;
            this.cb_color.IntegralHeight = false;
            this.cb_color.Location = new System.Drawing.Point(3, 3);
            this.cb_color.Name = "cb_color";
            this.cb_color.Size = new System.Drawing.Size(538, 40);
            this.cb_color.TabIndex = 197;
            this.cb_color.SelectedIndexChanged += new System.EventHandler(this.txt_color_SelectedIndexChanged);
            // 
            // pan_color_sample
            // 
            this.pan_color_sample.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pan_color_sample.Location = new System.Drawing.Point(547, 3);
            this.pan_color_sample.Name = "pan_color_sample";
            this.pan_color_sample.Size = new System.Drawing.Size(161, 38);
            this.pan_color_sample.TabIndex = 198;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.InsetDouble;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel7, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.lbl_restoreDatabase, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.lbl_backupLocation, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.lbl_appColor, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel4, 1, 2);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 70F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1032, 263);
            this.tableLayoutPanel1.TabIndex = 200;
            // 
            // tableLayoutPanel7
            // 
            this.tableLayoutPanel7.ColumnCount = 2;
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel7.Controls.Add(this.label3, 1, 0);
            this.tableLayoutPanel7.Controls.Add(this.tableLayoutPanel8, 0, 0);
            this.tableLayoutPanel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel7.Location = new System.Drawing.Point(315, 195);
            this.tableLayoutPanel7.Name = "tableLayoutPanel7";
            this.tableLayoutPanel7.RowCount = 1;
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel7.Size = new System.Drawing.Size(711, 62);
            this.tableLayoutPanel7.TabIndex = 223;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(358, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(350, 62);
            this.label3.TabIndex = 223;
            this.label3.Text = "سوف يتم مسح جميع البيانات ماعدا المستخدمين";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel8
            // 
            this.tableLayoutPanel8.ColumnCount = 2;
            this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 83.66763F));
            this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.33238F));
            this.tableLayoutPanel8.Controls.Add(this.pic_deleteAllDatabase, 1, 0);
            this.tableLayoutPanel8.Controls.Add(this.btn_deleteAllDatabase, 0, 0);
            this.tableLayoutPanel8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel8.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel8.Name = "tableLayoutPanel8";
            this.tableLayoutPanel8.RowCount = 1;
            this.tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel8.Size = new System.Drawing.Size(349, 56);
            this.tableLayoutPanel8.TabIndex = 221;
            // 
            // pic_deleteAllDatabase
            // 
            this.pic_deleteAllDatabase.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pic_deleteAllDatabase.Image = global::POSWarehouse.Properties.Resources.gif_loading_48;
            this.pic_deleteAllDatabase.Location = new System.Drawing.Point(294, 3);
            this.pic_deleteAllDatabase.Name = "pic_deleteAllDatabase";
            this.pic_deleteAllDatabase.Size = new System.Drawing.Size(52, 50);
            this.pic_deleteAllDatabase.TabIndex = 221;
            this.pic_deleteAllDatabase.TabStop = false;
            this.pic_deleteAllDatabase.Visible = false;
            // 
            // btn_deleteAllDatabase
            // 
            this.btn_deleteAllDatabase.BackColor = System.Drawing.Color.Purple;
            this.btn_deleteAllDatabase.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_deleteAllDatabase.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_deleteAllDatabase.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_deleteAllDatabase.ForeColor = System.Drawing.Color.White;
            this.btn_deleteAllDatabase.Location = new System.Drawing.Point(3, 3);
            this.btn_deleteAllDatabase.Name = "btn_deleteAllDatabase";
            this.btn_deleteAllDatabase.Size = new System.Drawing.Size(285, 50);
            this.btn_deleteAllDatabase.TabIndex = 220;
            this.btn_deleteAllDatabase.Text = "مسح جميع البيانات";
            this.btn_deleteAllDatabase.UseVisualStyleBackColor = false;
            this.btn_deleteAllDatabase.Click += new System.EventHandler(this.btn_deleteAllDatabase_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(6, 192);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(300, 68);
            this.label2.TabIndex = 222;
            this.label2.Text = "مسح جميع البيانات";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_restoreDatabase
            // 
            this.lbl_restoreDatabase.AutoSize = true;
            this.lbl_restoreDatabase.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_restoreDatabase.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold);
            this.lbl_restoreDatabase.Location = new System.Drawing.Point(6, 129);
            this.lbl_restoreDatabase.Name = "lbl_restoreDatabase";
            this.lbl_restoreDatabase.Size = new System.Drawing.Size(300, 60);
            this.lbl_restoreDatabase.TabIndex = 221;
            this.lbl_restoreDatabase.Text = "البيانات المخزنه";
            this.lbl_restoreDatabase.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 3;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tableLayoutPanel3.Controls.Add(this.label1, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.btn_backupLocation, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.tb_backupLocation, 2, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(315, 59);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(711, 64);
            this.tableLayoutPanel3.TabIndex = 220;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(145, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 64);
            this.label1.TabIndex = 221;
            this.label1.Text = "المكان الحالي:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btn_backupLocation
            // 
            this.btn_backupLocation.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_backupLocation.BackColor = System.Drawing.Color.Purple;
            this.btn_backupLocation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_backupLocation.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_backupLocation.ForeColor = System.Drawing.Color.White;
            this.btn_backupLocation.Location = new System.Drawing.Point(3, 13);
            this.btn_backupLocation.Name = "btn_backupLocation";
            this.btn_backupLocation.Size = new System.Drawing.Size(136, 38);
            this.btn_backupLocation.TabIndex = 220;
            this.btn_backupLocation.Text = "تحديد المكان";
            this.btn_backupLocation.UseVisualStyleBackColor = false;
            this.btn_backupLocation.Click += new System.EventHandler(this.btn_backupLocation_Click);
            // 
            // tb_backupLocation
            // 
            this.tb_backupLocation.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_backupLocation.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_backupLocation.Location = new System.Drawing.Point(287, 3);
            this.tb_backupLocation.Multiline = true;
            this.tb_backupLocation.Name = "tb_backupLocation";
            this.tb_backupLocation.ReadOnly = true;
            this.tb_backupLocation.Size = new System.Drawing.Size(421, 58);
            this.tb_backupLocation.TabIndex = 221;
            this.tb_backupLocation.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lbl_backupLocation
            // 
            this.lbl_backupLocation.AutoSize = true;
            this.lbl_backupLocation.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_backupLocation.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold);
            this.lbl_backupLocation.Location = new System.Drawing.Point(6, 56);
            this.lbl_backupLocation.Name = "lbl_backupLocation";
            this.lbl_backupLocation.Size = new System.Drawing.Size(300, 70);
            this.lbl_backupLocation.TabIndex = 220;
            this.lbl_backupLocation.Text = "مكان النسخه الاحتياطيه للبيانات";
            this.lbl_backupLocation.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 76.55786F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 23.44214F));
            this.tableLayoutPanel2.Controls.Add(this.cb_color, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.pan_color_sample, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(315, 6);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(711, 44);
            this.tableLayoutPanel2.TabIndex = 201;
            // 
            // lbl_appColor
            // 
            this.lbl_appColor.AutoSize = true;
            this.lbl_appColor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_appColor.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold);
            this.lbl_appColor.Location = new System.Drawing.Point(6, 3);
            this.lbl_appColor.Name = "lbl_appColor";
            this.lbl_appColor.Size = new System.Drawing.Size(300, 50);
            this.lbl_appColor.TabIndex = 202;
            this.lbl_appColor.Text = "لون البرنامج";
            this.lbl_appColor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 2;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Controls.Add(this.tableLayoutPanel5, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.tableLayoutPanel6, 1, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(315, 132);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(711, 54);
            this.tableLayoutPanel4.TabIndex = 222;
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 2;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 83.66763F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.33238F));
            this.tableLayoutPanel5.Controls.Add(this.pic_restoreDatabaseLoading, 1, 0);
            this.tableLayoutPanel5.Controls.Add(this.btn_restoreDatabase, 0, 0);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 1;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(349, 48);
            this.tableLayoutPanel5.TabIndex = 221;
            // 
            // pic_restoreDatabaseLoading
            // 
            this.pic_restoreDatabaseLoading.Image = global::POSWarehouse.Properties.Resources.gif_loading_48;
            this.pic_restoreDatabaseLoading.Location = new System.Drawing.Point(294, 3);
            this.pic_restoreDatabaseLoading.Name = "pic_restoreDatabaseLoading";
            this.pic_restoreDatabaseLoading.Size = new System.Drawing.Size(51, 42);
            this.pic_restoreDatabaseLoading.TabIndex = 221;
            this.pic_restoreDatabaseLoading.TabStop = false;
            this.pic_restoreDatabaseLoading.Visible = false;
            // 
            // btn_restoreDatabase
            // 
            this.btn_restoreDatabase.BackColor = System.Drawing.Color.Purple;
            this.btn_restoreDatabase.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_restoreDatabase.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_restoreDatabase.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_restoreDatabase.ForeColor = System.Drawing.Color.White;
            this.btn_restoreDatabase.Location = new System.Drawing.Point(3, 3);
            this.btn_restoreDatabase.Name = "btn_restoreDatabase";
            this.btn_restoreDatabase.Size = new System.Drawing.Size(285, 42);
            this.btn_restoreDatabase.TabIndex = 220;
            this.btn_restoreDatabase.Text = "استرجاع نسخه احتياطية";
            this.btn_restoreDatabase.UseVisualStyleBackColor = false;
            this.btn_restoreDatabase.Click += new System.EventHandler(this.btn_restoreDatabase_Click);
            // 
            // tableLayoutPanel6
            // 
            this.tableLayoutPanel6.ColumnCount = 2;
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 82F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 18F));
            this.tableLayoutPanel6.Controls.Add(this.pic_createBackupLoading, 1, 0);
            this.tableLayoutPanel6.Controls.Add(this.btn_createBackup, 0, 0);
            this.tableLayoutPanel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel6.Location = new System.Drawing.Point(358, 3);
            this.tableLayoutPanel6.Name = "tableLayoutPanel6";
            this.tableLayoutPanel6.RowCount = 1;
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel6.Size = new System.Drawing.Size(350, 48);
            this.tableLayoutPanel6.TabIndex = 222;
            // 
            // pic_createBackupLoading
            // 
            this.pic_createBackupLoading.Image = global::POSWarehouse.Properties.Resources.gif_loading_48;
            this.pic_createBackupLoading.Location = new System.Drawing.Point(290, 3);
            this.pic_createBackupLoading.Name = "pic_createBackupLoading";
            this.pic_createBackupLoading.Size = new System.Drawing.Size(57, 42);
            this.pic_createBackupLoading.TabIndex = 220;
            this.pic_createBackupLoading.TabStop = false;
            this.pic_createBackupLoading.Visible = false;
            // 
            // btn_createBackup
            // 
            this.btn_createBackup.BackColor = System.Drawing.Color.Purple;
            this.btn_createBackup.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_createBackup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_createBackup.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_createBackup.ForeColor = System.Drawing.Color.White;
            this.btn_createBackup.Location = new System.Drawing.Point(3, 3);
            this.btn_createBackup.Name = "btn_createBackup";
            this.btn_createBackup.Size = new System.Drawing.Size(281, 42);
            this.btn_createBackup.TabIndex = 220;
            this.btn_createBackup.Text = "عمل نسخه احتياطية";
            this.btn_createBackup.UseVisualStyleBackColor = false;
            this.btn_createBackup.Click += new System.EventHandler(this.btn_createBackup_Click);
            // 
            // btn_saveSettings
            // 
            this.btn_saveSettings.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_saveSettings.BackColor = System.Drawing.Color.Purple;
            this.btn_saveSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_saveSettings.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_saveSettings.ForeColor = System.Drawing.Color.White;
            this.btn_saveSettings.Location = new System.Drawing.Point(581, 509);
            this.btn_saveSettings.Name = "btn_saveSettings";
            this.btn_saveSettings.Size = new System.Drawing.Size(229, 50);
            this.btn_saveSettings.TabIndex = 218;
            this.btn_saveSettings.Text = "حفظ الاعدادات";
            this.btn_saveSettings.UseVisualStyleBackColor = false;
            this.btn_saveSettings.Click += new System.EventHandler(this.btn_saveSettings_Click);
            // 
            // btn_resetDefault
            // 
            this.btn_resetDefault.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_resetDefault.BackColor = System.Drawing.Color.Purple;
            this.btn_resetDefault.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_resetDefault.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_resetDefault.ForeColor = System.Drawing.Color.White;
            this.btn_resetDefault.Location = new System.Drawing.Point(229, 509);
            this.btn_resetDefault.Name = "btn_resetDefault";
            this.btn_resetDefault.Size = new System.Drawing.Size(229, 50);
            this.btn_resetDefault.TabIndex = 219;
            this.btn_resetDefault.Text = "إعادة تعيين الافتراضي";
            this.btn_resetDefault.UseVisualStyleBackColor = false;
            this.btn_resetDefault.Click += new System.EventHandler(this.btn_resetDefault_Click);
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.btn_resetDefault);
            this.Controls.Add(this.btn_saveSettings);
            this.Controls.Add(this.tableLayoutPanel1);
            this.MinimumSize = new System.Drawing.Size(1038, 660);
            this.Name = "Settings";
            this.Size = new System.Drawing.Size(1038, 660);
            this.Load += new System.EventHandler(this.Settings_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel7.ResumeLayout(false);
            this.tableLayoutPanel7.PerformLayout();
            this.tableLayoutPanel8.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pic_deleteAllDatabase)).EndInit();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pic_restoreDatabaseLoading)).EndInit();
            this.tableLayoutPanel6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pic_createBackupLoading)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ComboBox cb_color;
        private System.Windows.Forms.Panel pan_color_sample;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button btn_saveSettings;
        private System.Windows.Forms.Button btn_resetDefault;
        private System.Windows.Forms.Label lbl_appColor;
        private System.Windows.Forms.Label lbl_backupLocation;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Button btn_backupLocation;
        private System.Windows.Forms.TextBox tb_backupLocation;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_restoreDatabase;
        private System.Windows.Forms.Button btn_restoreDatabase;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Button btn_createBackup;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel6;
        private System.Windows.Forms.PictureBox pic_restoreDatabaseLoading;
        private System.Windows.Forms.PictureBox pic_createBackupLoading;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel7;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel8;
        private System.Windows.Forms.PictureBox pic_deleteAllDatabase;
        private System.Windows.Forms.Button btn_deleteAllDatabase;
    }
}
