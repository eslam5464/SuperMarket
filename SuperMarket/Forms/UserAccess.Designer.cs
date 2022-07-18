
namespace SuperMarket.Forms
{
    partial class UserAccess
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserAccess));
            this.pan_table_access = new System.Windows.Forms.TableLayoutPanel();
            this.chk_settings = new System.Windows.Forms.CheckBox();
            this.chk_users = new System.Windows.Forms.CheckBox();
            this.chk_reports = new System.Windows.Forms.CheckBox();
            this.chk_dashboard = new System.Windows.Forms.CheckBox();
            this.chk_products = new System.Windows.Forms.CheckBox();
            this.chk_billing = new System.Windows.Forms.CheckBox();
            this.chk_customers = new System.Windows.Forms.CheckBox();
            this.chk_billingEdit = new System.Windows.Forms.CheckBox();
            this.chk_categories = new System.Windows.Forms.CheckBox();
            this.btn_save = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_userId = new System.Windows.Forms.Label();
            this.lbl_userName = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.chk_orders = new System.Windows.Forms.CheckBox();
            this.chk_safe = new System.Windows.Forms.CheckBox();
            this.chk_suppliersEdit = new System.Windows.Forms.CheckBox();
            this.chk_supplierInvoices = new System.Windows.Forms.CheckBox();
            this.pan_table_access.SuspendLayout();
            this.SuspendLayout();
            // 
            // pan_table_access
            // 
            this.pan_table_access.ColumnCount = 4;
            this.pan_table_access.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.pan_table_access.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.pan_table_access.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.pan_table_access.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.pan_table_access.Controls.Add(this.chk_settings, 0, 2);
            this.pan_table_access.Controls.Add(this.chk_users, 1, 2);
            this.pan_table_access.Controls.Add(this.chk_reports, 2, 2);
            this.pan_table_access.Controls.Add(this.chk_dashboard, 2, 0);
            this.pan_table_access.Controls.Add(this.chk_products, 0, 1);
            this.pan_table_access.Controls.Add(this.chk_billing, 1, 0);
            this.pan_table_access.Controls.Add(this.chk_customers, 1, 1);
            this.pan_table_access.Controls.Add(this.chk_billingEdit, 0, 0);
            this.pan_table_access.Controls.Add(this.chk_categories, 2, 1);
            this.pan_table_access.Controls.Add(this.chk_orders, 3, 0);
            this.pan_table_access.Controls.Add(this.chk_safe, 3, 1);
            this.pan_table_access.Controls.Add(this.chk_supplierInvoices, 3, 2);
            this.pan_table_access.Controls.Add(this.chk_suppliersEdit, 3, 3);
            this.pan_table_access.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pan_table_access.Location = new System.Drawing.Point(0, 87);
            this.pan_table_access.Name = "pan_table_access";
            this.pan_table_access.RowCount = 4;
            this.pan_table_access.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.pan_table_access.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.pan_table_access.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.pan_table_access.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.pan_table_access.Size = new System.Drawing.Size(858, 386);
            this.pan_table_access.TabIndex = 222;
            // 
            // chk_settings
            // 
            this.chk_settings.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.chk_settings.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chk_settings.Font = new System.Drawing.Font("Palatino Linotype", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chk_settings.Image = global::SuperMarket.Properties.Resources.icons8_settings_48;
            this.chk_settings.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chk_settings.Location = new System.Drawing.Point(3, 195);
            this.chk_settings.Name = "chk_settings";
            this.chk_settings.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.chk_settings.Size = new System.Drawing.Size(208, 90);
            this.chk_settings.TabIndex = 222;
            this.chk_settings.Text = "الاعدادات";
            this.chk_settings.UseVisualStyleBackColor = true;
            this.chk_settings.MouseEnter += new System.EventHandler(this.chk_userAccess_MouseEnter);
            this.chk_settings.MouseLeave += new System.EventHandler(this.chk_userAccess_MouseLeave);
            // 
            // chk_users
            // 
            this.chk_users.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.chk_users.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chk_users.Font = new System.Drawing.Font("Palatino Linotype", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chk_users.Image = global::SuperMarket.Properties.Resources.icons8_user_48;
            this.chk_users.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chk_users.Location = new System.Drawing.Point(217, 195);
            this.chk_users.Name = "chk_users";
            this.chk_users.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.chk_users.Size = new System.Drawing.Size(208, 90);
            this.chk_users.TabIndex = 223;
            this.chk_users.Text = "المستخدمين";
            this.chk_users.UseVisualStyleBackColor = true;
            this.chk_users.MouseEnter += new System.EventHandler(this.chk_userAccess_MouseEnter);
            this.chk_users.MouseLeave += new System.EventHandler(this.chk_userAccess_MouseLeave);
            // 
            // chk_reports
            // 
            this.chk_reports.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.chk_reports.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chk_reports.Font = new System.Drawing.Font("Palatino Linotype", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chk_reports.Image = global::SuperMarket.Properties.Resources.icons8_business_report_48;
            this.chk_reports.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chk_reports.Location = new System.Drawing.Point(431, 195);
            this.chk_reports.Name = "chk_reports";
            this.chk_reports.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.chk_reports.Size = new System.Drawing.Size(208, 90);
            this.chk_reports.TabIndex = 224;
            this.chk_reports.Text = "التقارير";
            this.chk_reports.UseVisualStyleBackColor = true;
            this.chk_reports.MouseEnter += new System.EventHandler(this.chk_userAccess_MouseEnter);
            this.chk_reports.MouseLeave += new System.EventHandler(this.chk_userAccess_MouseLeave);
            // 
            // chk_dashboard
            // 
            this.chk_dashboard.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.chk_dashboard.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chk_dashboard.Font = new System.Drawing.Font("Palatino Linotype", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chk_dashboard.Image = global::SuperMarket.Properties.Resources.icons8_combo_chart_48;
            this.chk_dashboard.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chk_dashboard.Location = new System.Drawing.Point(431, 3);
            this.chk_dashboard.Name = "chk_dashboard";
            this.chk_dashboard.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.chk_dashboard.Size = new System.Drawing.Size(208, 90);
            this.chk_dashboard.TabIndex = 217;
            this.chk_dashboard.Text = "الرئيسية";
            this.chk_dashboard.UseVisualStyleBackColor = true;
            this.chk_dashboard.MouseEnter += new System.EventHandler(this.chk_userAccess_MouseEnter);
            this.chk_dashboard.MouseLeave += new System.EventHandler(this.chk_userAccess_MouseLeave);
            // 
            // chk_products
            // 
            this.chk_products.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.chk_products.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chk_products.Font = new System.Drawing.Font("Palatino Linotype", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chk_products.Image = global::SuperMarket.Properties.Resources.icons8_products_pile_48;
            this.chk_products.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chk_products.Location = new System.Drawing.Point(3, 99);
            this.chk_products.Name = "chk_products";
            this.chk_products.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.chk_products.Size = new System.Drawing.Size(208, 90);
            this.chk_products.TabIndex = 220;
            this.chk_products.Text = "المنتجات";
            this.chk_products.UseVisualStyleBackColor = true;
            this.chk_products.MouseEnter += new System.EventHandler(this.chk_userAccess_MouseEnter);
            this.chk_products.MouseLeave += new System.EventHandler(this.chk_userAccess_MouseLeave);
            // 
            // chk_billing
            // 
            this.chk_billing.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.chk_billing.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chk_billing.Font = new System.Drawing.Font("Palatino Linotype", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chk_billing.Image = global::SuperMarket.Properties.Resources.icons8_receipt_48;
            this.chk_billing.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chk_billing.Location = new System.Drawing.Point(217, 3);
            this.chk_billing.Name = "chk_billing";
            this.chk_billing.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.chk_billing.Size = new System.Drawing.Size(208, 90);
            this.chk_billing.TabIndex = 216;
            this.chk_billing.Text = "الفواتير";
            this.chk_billing.UseVisualStyleBackColor = true;
            this.chk_billing.MouseEnter += new System.EventHandler(this.chk_userAccess_MouseEnter);
            this.chk_billing.MouseLeave += new System.EventHandler(this.chk_userAccess_MouseLeave);
            // 
            // chk_customers
            // 
            this.chk_customers.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.chk_customers.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chk_customers.Font = new System.Drawing.Font("Palatino Linotype", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chk_customers.Image = global::SuperMarket.Properties.Resources.icons8_customer_48;
            this.chk_customers.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chk_customers.Location = new System.Drawing.Point(217, 99);
            this.chk_customers.Name = "chk_customers";
            this.chk_customers.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.chk_customers.Size = new System.Drawing.Size(208, 90);
            this.chk_customers.TabIndex = 219;
            this.chk_customers.Text = "العملاء";
            this.chk_customers.UseVisualStyleBackColor = true;
            this.chk_customers.MouseEnter += new System.EventHandler(this.chk_userAccess_MouseEnter);
            this.chk_customers.MouseLeave += new System.EventHandler(this.chk_userAccess_MouseLeave);
            // 
            // chk_billingEdit
            // 
            this.chk_billingEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.chk_billingEdit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chk_billingEdit.Font = new System.Drawing.Font("Palatino Linotype", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chk_billingEdit.Image = global::SuperMarket.Properties.Resources.icons8_edit_property_48;
            this.chk_billingEdit.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chk_billingEdit.Location = new System.Drawing.Point(3, 3);
            this.chk_billingEdit.Name = "chk_billingEdit";
            this.chk_billingEdit.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.chk_billingEdit.Size = new System.Drawing.Size(208, 90);
            this.chk_billingEdit.TabIndex = 215;
            this.chk_billingEdit.Text = "تعديل الفواتير";
            this.chk_billingEdit.UseVisualStyleBackColor = true;
            this.chk_billingEdit.MouseEnter += new System.EventHandler(this.chk_userAccess_MouseEnter);
            this.chk_billingEdit.MouseLeave += new System.EventHandler(this.chk_userAccess_MouseLeave);
            // 
            // chk_categories
            // 
            this.chk_categories.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.chk_categories.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chk_categories.Font = new System.Drawing.Font("Palatino Linotype", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chk_categories.Image = global::SuperMarket.Properties.Resources.icons8_warehouse_48;
            this.chk_categories.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chk_categories.Location = new System.Drawing.Point(431, 99);
            this.chk_categories.Name = "chk_categories";
            this.chk_categories.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.chk_categories.Size = new System.Drawing.Size(208, 90);
            this.chk_categories.TabIndex = 218;
            this.chk_categories.Text = "التصنيفات\r\nوالمخازن";
            this.chk_categories.UseVisualStyleBackColor = true;
            this.chk_categories.MouseEnter += new System.EventHandler(this.chk_userAccess_MouseEnter);
            this.chk_categories.MouseLeave += new System.EventHandler(this.chk_userAccess_MouseLeave);
            // 
            // btn_save
            // 
            this.btn_save.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_save.BackColor = System.Drawing.Color.Purple;
            this.btn_save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_save.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_save.ForeColor = System.Drawing.Color.White;
            this.btn_save.Location = new System.Drawing.Point(591, 12);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(167, 50);
            this.btn_save.TabIndex = 223;
            this.btn_save.Text = "حفظ التغيرات";
            this.btn_save.UseVisualStyleBackColor = false;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Purple;
            this.label2.Location = new System.Drawing.Point(366, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 23);
            this.label2.TabIndex = 224;
            this.label2.Text = ":الرقم التعريفي";
            // 
            // lbl_userId
            // 
            this.lbl_userId.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_userId.AutoSize = true;
            this.lbl_userId.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_userId.ForeColor = System.Drawing.Color.Black;
            this.lbl_userId.Location = new System.Drawing.Point(411, 39);
            this.lbl_userId.Name = "lbl_userId";
            this.lbl_userId.Size = new System.Drawing.Size(18, 23);
            this.lbl_userId.TabIndex = 225;
            this.lbl_userId.Text = "-";
            this.lbl_userId.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_userName
            // 
            this.lbl_userName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_userName.AutoSize = true;
            this.lbl_userName.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_userName.ForeColor = System.Drawing.Color.Black;
            this.lbl_userName.Location = new System.Drawing.Point(184, 39);
            this.lbl_userName.Name = "lbl_userName";
            this.lbl_userName.Size = new System.Drawing.Size(18, 23);
            this.lbl_userName.TabIndex = 227;
            this.lbl_userName.Text = "-";
            this.lbl_userName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Purple;
            this.label4.Location = new System.Drawing.Point(172, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 23);
            this.label4.TabIndex = 226;
            this.label4.Text = ":المستخدم";
            // 
            // chk_orders
            // 
            this.chk_orders.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.chk_orders.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chk_orders.Font = new System.Drawing.Font("Palatino Linotype", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chk_orders.Image = global::SuperMarket.Properties.Resources.icons8_report_card_48;
            this.chk_orders.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chk_orders.Location = new System.Drawing.Point(645, 3);
            this.chk_orders.Name = "chk_orders";
            this.chk_orders.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.chk_orders.Size = new System.Drawing.Size(210, 90);
            this.chk_orders.TabIndex = 225;
            this.chk_orders.Text = "الطلبات";
            this.chk_orders.UseVisualStyleBackColor = true;
            this.chk_orders.MouseEnter += new System.EventHandler(this.chk_userAccess_MouseEnter);
            this.chk_orders.MouseLeave += new System.EventHandler(this.chk_userAccess_MouseLeave);
            // 
            // chk_safe
            // 
            this.chk_safe.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.chk_safe.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chk_safe.Font = new System.Drawing.Font("Palatino Linotype", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chk_safe.Image = global::SuperMarket.Properties.Resources.icons8_safe_48;
            this.chk_safe.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chk_safe.Location = new System.Drawing.Point(645, 99);
            this.chk_safe.Name = "chk_safe";
            this.chk_safe.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.chk_safe.Size = new System.Drawing.Size(210, 90);
            this.chk_safe.TabIndex = 226;
            this.chk_safe.Text = "الخزنة";
            this.chk_safe.UseVisualStyleBackColor = true;
            this.chk_safe.MouseEnter += new System.EventHandler(this.chk_userAccess_MouseEnter);
            this.chk_safe.MouseLeave += new System.EventHandler(this.chk_userAccess_MouseLeave);
            // 
            // chk_suppliersEdit
            // 
            this.chk_suppliersEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.chk_suppliersEdit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chk_suppliersEdit.Font = new System.Drawing.Font("Palatino Linotype", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chk_suppliersEdit.Image = global::SuperMarket.Properties.Resources.icons8_supplier_48;
            this.chk_suppliersEdit.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chk_suppliersEdit.Location = new System.Drawing.Point(645, 291);
            this.chk_suppliersEdit.Name = "chk_suppliersEdit";
            this.chk_suppliersEdit.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.chk_suppliersEdit.Size = new System.Drawing.Size(210, 92);
            this.chk_suppliersEdit.TabIndex = 227;
            this.chk_suppliersEdit.Text = "بيانات\r\nالموردين";
            this.chk_suppliersEdit.UseVisualStyleBackColor = true;
            this.chk_suppliersEdit.MouseEnter += new System.EventHandler(this.chk_userAccess_MouseEnter);
            this.chk_suppliersEdit.MouseLeave += new System.EventHandler(this.chk_userAccess_MouseLeave);
            // 
            // chk_supplierInvoices
            // 
            this.chk_supplierInvoices.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.chk_supplierInvoices.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chk_supplierInvoices.Font = new System.Drawing.Font("Palatino Linotype", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chk_supplierInvoices.Image = global::SuperMarket.Properties.Resources.icons8_bill_48;
            this.chk_supplierInvoices.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chk_supplierInvoices.Location = new System.Drawing.Point(645, 195);
            this.chk_supplierInvoices.Name = "chk_supplierInvoices";
            this.chk_supplierInvoices.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.chk_supplierInvoices.Size = new System.Drawing.Size(210, 90);
            this.chk_supplierInvoices.TabIndex = 228;
            this.chk_supplierInvoices.Text = "فواتير\r\nالموردين";
            this.chk_supplierInvoices.UseVisualStyleBackColor = true;
            this.chk_supplierInvoices.MouseEnter += new System.EventHandler(this.chk_userAccess_MouseEnter);
            this.chk_supplierInvoices.MouseLeave += new System.EventHandler(this.chk_userAccess_MouseLeave);
            // 
            // UserAccess
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(858, 473);
            this.Controls.Add(this.lbl_userName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lbl_userId);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.pan_table_access);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "UserAccess";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "صلاحيات المستخدم";
            this.Load += new System.EventHandler(this.UserAccess_Load);
            this.pan_table_access.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel pan_table_access;
        private System.Windows.Forms.CheckBox chk_settings;
        private System.Windows.Forms.CheckBox chk_users;
        private System.Windows.Forms.CheckBox chk_reports;
        private System.Windows.Forms.CheckBox chk_dashboard;
        private System.Windows.Forms.CheckBox chk_products;
        private System.Windows.Forms.CheckBox chk_billing;
        private System.Windows.Forms.CheckBox chk_customers;
        private System.Windows.Forms.CheckBox chk_billingEdit;
        private System.Windows.Forms.CheckBox chk_categories;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl_userId;
        private System.Windows.Forms.Label lbl_userName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox chk_orders;
        private System.Windows.Forms.CheckBox chk_safe;
        private System.Windows.Forms.CheckBox chk_supplierInvoices;
        private System.Windows.Forms.CheckBox chk_suppliersEdit;
    }
}