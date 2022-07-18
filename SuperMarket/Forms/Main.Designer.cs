
namespace SuperMarket.Forms
{
    partial class Main
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.pan_controls = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.btn_settings = new System.Windows.Forms.Button();
            this.btn_adminPanel = new System.Windows.Forms.Button();
            this.btn_users = new System.Windows.Forms.Button();
            this.btn_safe = new System.Windows.Forms.Button();
            this.btn_advancedSearch = new System.Windows.Forms.Button();
            this.pan_suppliers = new System.Windows.Forms.Panel();
            this.btn_suppliersEdit = new System.Windows.Forms.Button();
            this.btn_supplierInvoices = new System.Windows.Forms.Button();
            this.btn_suppliers = new System.Windows.Forms.Button();
            this.btn_reports = new System.Windows.Forms.Button();
            this.pan_billing = new System.Windows.Forms.Panel();
            this.btn_billingEdit = new System.Windows.Forms.Button();
            this.btn_billingAdd = new System.Windows.Forms.Button();
            this.btn_billing = new System.Windows.Forms.Button();
            this.btn_Orders = new System.Windows.Forms.Button();
            this.btn_Customers = new System.Windows.Forms.Button();
            this.btn_Products = new System.Windows.Forms.Button();
            this.btn_Categories = new System.Windows.Forms.Button();
            this.btn_dashborad = new System.Windows.Forms.Button();
            this.panel8 = new System.Windows.Forms.Panel();
            this.SidePanel = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_Help = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.lbl_welcome = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.pic_help = new System.Windows.Forms.PictureBox();
            this.panel6 = new System.Windows.Forms.Panel();
            this.lbl_welcomeName = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.UserSession = new System.Windows.Forms.Timer(this.components);
            this.HourlyChecker = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            this.panel7.SuspendLayout();
            this.pan_suppliers.SuspendLayout();
            this.pan_billing.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_help)).BeginInit();
            this.panel6.SuspendLayout();
            this.SuspendLayout();
            // 
            // pan_controls
            // 
            this.pan_controls.AutoScroll = true;
            this.pan_controls.BackColor = System.Drawing.Color.White;
            this.pan_controls.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pan_controls.Location = new System.Drawing.Point(258, 65);
            this.pan_controls.Name = "pan_controls";
            this.pan_controls.Size = new System.Drawing.Size(996, 657);
            this.pan_controls.TabIndex = 27;
            this.pan_controls.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panels_MouseMove);
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.BackColor = System.Drawing.Color.Purple;
            this.panel1.Controls.Add(this.panel7);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.btn_Help);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(258, 732);
            this.panel1.TabIndex = 23;
            // 
            // panel7
            // 
            this.panel7.AutoScroll = true;
            this.panel7.Controls.Add(this.btn_settings);
            this.panel7.Controls.Add(this.btn_adminPanel);
            this.panel7.Controls.Add(this.btn_users);
            this.panel7.Controls.Add(this.btn_safe);
            this.panel7.Controls.Add(this.btn_advancedSearch);
            this.panel7.Controls.Add(this.pan_suppliers);
            this.panel7.Controls.Add(this.btn_suppliers);
            this.panel7.Controls.Add(this.btn_reports);
            this.panel7.Controls.Add(this.pan_billing);
            this.panel7.Controls.Add(this.btn_billing);
            this.panel7.Controls.Add(this.btn_Orders);
            this.panel7.Controls.Add(this.btn_Customers);
            this.panel7.Controls.Add(this.btn_Products);
            this.panel7.Controls.Add(this.btn_Categories);
            this.panel7.Controls.Add(this.btn_dashborad);
            this.panel7.Controls.Add(this.panel8);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel7.Location = new System.Drawing.Point(0, 66);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(258, 666);
            this.panel7.TabIndex = 8;
            this.panel7.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panels_MouseMove);
            // 
            // btn_settings
            // 
            this.btn_settings.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_settings.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_settings.FlatAppearance.BorderSize = 0;
            this.btn_settings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_settings.Font = new System.Drawing.Font("Palatino Linotype", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_settings.ForeColor = System.Drawing.Color.White;
            this.btn_settings.Image = global::SuperMarket.Properties.Resources.icons8_settings_48;
            this.btn_settings.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_settings.Location = new System.Drawing.Point(13, 722);
            this.btn_settings.Margin = new System.Windows.Forms.Padding(0);
            this.btn_settings.Name = "btn_settings";
            this.btn_settings.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btn_settings.Size = new System.Drawing.Size(228, 45);
            this.btn_settings.TabIndex = 22;
            this.btn_settings.Text = "   اعدادات";
            this.btn_settings.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_settings.UseVisualStyleBackColor = true;
            this.btn_settings.Click += new System.EventHandler(this.btn_settings_Click);
            // 
            // btn_adminPanel
            // 
            this.btn_adminPanel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_adminPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_adminPanel.FlatAppearance.BorderSize = 0;
            this.btn_adminPanel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_adminPanel.Font = new System.Drawing.Font("Palatino Linotype", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_adminPanel.ForeColor = System.Drawing.Color.White;
            this.btn_adminPanel.Image = global::SuperMarket.Properties.Resources.icons8_admin_settings_male_48;
            this.btn_adminPanel.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_adminPanel.Location = new System.Drawing.Point(13, 677);
            this.btn_adminPanel.Margin = new System.Windows.Forms.Padding(0);
            this.btn_adminPanel.Name = "btn_adminPanel";
            this.btn_adminPanel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btn_adminPanel.Size = new System.Drawing.Size(228, 45);
            this.btn_adminPanel.TabIndex = 31;
            this.btn_adminPanel.Text = "   ادوات المشرف";
            this.btn_adminPanel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_adminPanel.UseVisualStyleBackColor = true;
            this.btn_adminPanel.Visible = false;
            this.btn_adminPanel.Click += new System.EventHandler(this.btn_adminPanel_Click);
            // 
            // btn_users
            // 
            this.btn_users.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_users.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_users.FlatAppearance.BorderSize = 0;
            this.btn_users.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_users.Font = new System.Drawing.Font("Palatino Linotype", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_users.ForeColor = System.Drawing.Color.White;
            this.btn_users.Image = global::SuperMarket.Properties.Resources.icons8_user_48;
            this.btn_users.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_users.Location = new System.Drawing.Point(13, 632);
            this.btn_users.Margin = new System.Windows.Forms.Padding(0);
            this.btn_users.Name = "btn_users";
            this.btn_users.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btn_users.Size = new System.Drawing.Size(228, 45);
            this.btn_users.TabIndex = 21;
            this.btn_users.Text = "   مستخدمين";
            this.btn_users.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_users.UseVisualStyleBackColor = true;
            this.btn_users.Click += new System.EventHandler(this.btn_sellers_Click);
            // 
            // btn_safe
            // 
            this.btn_safe.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_safe.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_safe.FlatAppearance.BorderSize = 0;
            this.btn_safe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_safe.Font = new System.Drawing.Font("Palatino Linotype", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_safe.ForeColor = System.Drawing.Color.White;
            this.btn_safe.Image = global::SuperMarket.Properties.Resources.icons8_safe_48;
            this.btn_safe.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_safe.Location = new System.Drawing.Point(13, 587);
            this.btn_safe.Margin = new System.Windows.Forms.Padding(0);
            this.btn_safe.Name = "btn_safe";
            this.btn_safe.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btn_safe.Size = new System.Drawing.Size(228, 45);
            this.btn_safe.TabIndex = 30;
            this.btn_safe.Text = "   خزنة المال";
            this.btn_safe.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_safe.UseVisualStyleBackColor = true;
            this.btn_safe.Click += new System.EventHandler(this.btn_safe_Click);
            // 
            // btn_advancedSearch
            // 
            this.btn_advancedSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_advancedSearch.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_advancedSearch.FlatAppearance.BorderSize = 0;
            this.btn_advancedSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_advancedSearch.Font = new System.Drawing.Font("Palatino Linotype", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_advancedSearch.ForeColor = System.Drawing.Color.White;
            this.btn_advancedSearch.Image = global::SuperMarket.Properties.Resources.icons8_look_up_48;
            this.btn_advancedSearch.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_advancedSearch.Location = new System.Drawing.Point(13, 542);
            this.btn_advancedSearch.Margin = new System.Windows.Forms.Padding(0);
            this.btn_advancedSearch.Name = "btn_advancedSearch";
            this.btn_advancedSearch.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btn_advancedSearch.Size = new System.Drawing.Size(228, 45);
            this.btn_advancedSearch.TabIndex = 27;
            this.btn_advancedSearch.Text = "   بحث متقدم";
            this.btn_advancedSearch.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_advancedSearch.UseVisualStyleBackColor = true;
            this.btn_advancedSearch.Visible = false;
            this.btn_advancedSearch.Click += new System.EventHandler(this.btn_advancedSearch_Click);
            // 
            // pan_suppliers
            // 
            this.pan_suppliers.AutoSize = true;
            this.pan_suppliers.BackColor = System.Drawing.Color.Purple;
            this.pan_suppliers.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pan_suppliers.Controls.Add(this.btn_suppliersEdit);
            this.pan_suppliers.Controls.Add(this.btn_supplierInvoices);
            this.pan_suppliers.Dock = System.Windows.Forms.DockStyle.Top;
            this.pan_suppliers.Location = new System.Drawing.Point(13, 450);
            this.pan_suppliers.Name = "pan_suppliers";
            this.pan_suppliers.Size = new System.Drawing.Size(228, 92);
            this.pan_suppliers.TabIndex = 26;
            this.pan_suppliers.Visible = false;
            // 
            // btn_suppliersEdit
            // 
            this.btn_suppliersEdit.BackColor = System.Drawing.Color.Magenta;
            this.btn_suppliersEdit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_suppliersEdit.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_suppliersEdit.FlatAppearance.BorderSize = 0;
            this.btn_suppliersEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_suppliersEdit.Font = new System.Drawing.Font("Palatino Linotype", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_suppliersEdit.ForeColor = System.Drawing.Color.White;
            this.btn_suppliersEdit.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_suppliersEdit.Location = new System.Drawing.Point(0, 45);
            this.btn_suppliersEdit.Margin = new System.Windows.Forms.Padding(0);
            this.btn_suppliersEdit.Name = "btn_suppliersEdit";
            this.btn_suppliersEdit.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btn_suppliersEdit.Size = new System.Drawing.Size(226, 45);
            this.btn_suppliersEdit.TabIndex = 30;
            this.btn_suppliersEdit.Text = "البيانات";
            this.btn_suppliersEdit.UseVisualStyleBackColor = false;
            this.btn_suppliersEdit.Click += new System.EventHandler(this.btn_suppliersEdit_Click);
            // 
            // btn_supplierInvoices
            // 
            this.btn_supplierInvoices.BackColor = System.Drawing.Color.Magenta;
            this.btn_supplierInvoices.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_supplierInvoices.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_supplierInvoices.FlatAppearance.BorderSize = 0;
            this.btn_supplierInvoices.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_supplierInvoices.Font = new System.Drawing.Font("Palatino Linotype", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_supplierInvoices.ForeColor = System.Drawing.Color.White;
            this.btn_supplierInvoices.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_supplierInvoices.Location = new System.Drawing.Point(0, 0);
            this.btn_supplierInvoices.Margin = new System.Windows.Forms.Padding(0);
            this.btn_supplierInvoices.Name = "btn_supplierInvoices";
            this.btn_supplierInvoices.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btn_supplierInvoices.Size = new System.Drawing.Size(226, 45);
            this.btn_supplierInvoices.TabIndex = 29;
            this.btn_supplierInvoices.Text = "اضافه فاتورة";
            this.btn_supplierInvoices.UseVisualStyleBackColor = false;
            this.btn_supplierInvoices.Click += new System.EventHandler(this.btn_supplierInvoices_Click);
            // 
            // btn_suppliers
            // 
            this.btn_suppliers.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_suppliers.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_suppliers.FlatAppearance.BorderSize = 0;
            this.btn_suppliers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_suppliers.Font = new System.Drawing.Font("Palatino Linotype", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_suppliers.ForeColor = System.Drawing.Color.White;
            this.btn_suppliers.Image = global::SuperMarket.Properties.Resources.icons8_supplier_48;
            this.btn_suppliers.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_suppliers.Location = new System.Drawing.Point(13, 405);
            this.btn_suppliers.Margin = new System.Windows.Forms.Padding(0);
            this.btn_suppliers.Name = "btn_suppliers";
            this.btn_suppliers.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btn_suppliers.Size = new System.Drawing.Size(228, 45);
            this.btn_suppliers.TabIndex = 28;
            this.btn_suppliers.Text = "   موردين";
            this.btn_suppliers.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_suppliers.UseVisualStyleBackColor = true;
            this.btn_suppliers.Click += new System.EventHandler(this.btn_suppliers_Click);
            // 
            // btn_reports
            // 
            this.btn_reports.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_reports.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_reports.FlatAppearance.BorderSize = 0;
            this.btn_reports.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_reports.Font = new System.Drawing.Font("Palatino Linotype", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_reports.ForeColor = System.Drawing.Color.White;
            this.btn_reports.Image = global::SuperMarket.Properties.Resources.icons8_business_report_48;
            this.btn_reports.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_reports.Location = new System.Drawing.Point(13, 360);
            this.btn_reports.Margin = new System.Windows.Forms.Padding(0);
            this.btn_reports.Name = "btn_reports";
            this.btn_reports.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btn_reports.Size = new System.Drawing.Size(228, 45);
            this.btn_reports.TabIndex = 24;
            this.btn_reports.Text = "   تقارير";
            this.btn_reports.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_reports.UseVisualStyleBackColor = true;
            this.btn_reports.Visible = false;
            this.btn_reports.Click += new System.EventHandler(this.btn_reports_Click);
            // 
            // pan_billing
            // 
            this.pan_billing.AutoSize = true;
            this.pan_billing.BackColor = System.Drawing.Color.Purple;
            this.pan_billing.Controls.Add(this.btn_billingEdit);
            this.pan_billing.Controls.Add(this.btn_billingAdd);
            this.pan_billing.Dock = System.Windows.Forms.DockStyle.Top;
            this.pan_billing.Location = new System.Drawing.Point(13, 270);
            this.pan_billing.Name = "pan_billing";
            this.pan_billing.Size = new System.Drawing.Size(228, 90);
            this.pan_billing.TabIndex = 26;
            // 
            // btn_billingEdit
            // 
            this.btn_billingEdit.BackColor = System.Drawing.Color.Magenta;
            this.btn_billingEdit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_billingEdit.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_billingEdit.FlatAppearance.BorderSize = 0;
            this.btn_billingEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_billingEdit.Font = new System.Drawing.Font("Palatino Linotype", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_billingEdit.ForeColor = System.Drawing.Color.White;
            this.btn_billingEdit.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_billingEdit.Location = new System.Drawing.Point(0, 45);
            this.btn_billingEdit.Margin = new System.Windows.Forms.Padding(0);
            this.btn_billingEdit.Name = "btn_billingEdit";
            this.btn_billingEdit.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btn_billingEdit.Size = new System.Drawing.Size(228, 45);
            this.btn_billingEdit.TabIndex = 23;
            this.btn_billingEdit.Text = "تعديل الفواتير";
            this.btn_billingEdit.UseVisualStyleBackColor = false;
            this.btn_billingEdit.Click += new System.EventHandler(this.btn_editBills_Click);
            // 
            // btn_billingAdd
            // 
            this.btn_billingAdd.BackColor = System.Drawing.Color.Magenta;
            this.btn_billingAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_billingAdd.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_billingAdd.FlatAppearance.BorderSize = 0;
            this.btn_billingAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_billingAdd.Font = new System.Drawing.Font("Palatino Linotype", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_billingAdd.ForeColor = System.Drawing.Color.White;
            this.btn_billingAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_billingAdd.Location = new System.Drawing.Point(0, 0);
            this.btn_billingAdd.Margin = new System.Windows.Forms.Padding(0);
            this.btn_billingAdd.Name = "btn_billingAdd";
            this.btn_billingAdd.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btn_billingAdd.Size = new System.Drawing.Size(228, 45);
            this.btn_billingAdd.TabIndex = 24;
            this.btn_billingAdd.Text = "اضافه فاتورة";
            this.btn_billingAdd.UseVisualStyleBackColor = false;
            this.btn_billingAdd.Click += new System.EventHandler(this.btn_billingAdd_Click);
            // 
            // btn_billing
            // 
            this.btn_billing.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_billing.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_billing.FlatAppearance.BorderSize = 0;
            this.btn_billing.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_billing.Font = new System.Drawing.Font("Palatino Linotype", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_billing.ForeColor = System.Drawing.Color.White;
            this.btn_billing.Image = global::SuperMarket.Properties.Resources.icons8_receipt_48;
            this.btn_billing.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_billing.Location = new System.Drawing.Point(13, 225);
            this.btn_billing.Margin = new System.Windows.Forms.Padding(0);
            this.btn_billing.Name = "btn_billing";
            this.btn_billing.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btn_billing.Size = new System.Drawing.Size(228, 45);
            this.btn_billing.TabIndex = 20;
            this.btn_billing.Text = "   فواتير";
            this.btn_billing.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_billing.UseVisualStyleBackColor = true;
            this.btn_billing.Click += new System.EventHandler(this.btn_billing_Click);
            // 
            // btn_Orders
            // 
            this.btn_Orders.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Orders.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_Orders.FlatAppearance.BorderSize = 0;
            this.btn_Orders.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Orders.Font = new System.Drawing.Font("Palatino Linotype", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Orders.ForeColor = System.Drawing.Color.White;
            this.btn_Orders.Image = global::SuperMarket.Properties.Resources.icons8_report_card_48;
            this.btn_Orders.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Orders.Location = new System.Drawing.Point(13, 180);
            this.btn_Orders.Margin = new System.Windows.Forms.Padding(0);
            this.btn_Orders.Name = "btn_Orders";
            this.btn_Orders.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btn_Orders.Size = new System.Drawing.Size(228, 45);
            this.btn_Orders.TabIndex = 19;
            this.btn_Orders.Text = "   طلبات";
            this.btn_Orders.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Orders.UseVisualStyleBackColor = true;
            this.btn_Orders.Click += new System.EventHandler(this.btn_Orders_Click);
            // 
            // btn_Customers
            // 
            this.btn_Customers.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Customers.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_Customers.FlatAppearance.BorderSize = 0;
            this.btn_Customers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Customers.Font = new System.Drawing.Font("Palatino Linotype", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Customers.ForeColor = System.Drawing.Color.White;
            this.btn_Customers.Image = global::SuperMarket.Properties.Resources.icons8_customer_48;
            this.btn_Customers.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Customers.Location = new System.Drawing.Point(13, 135);
            this.btn_Customers.Margin = new System.Windows.Forms.Padding(0);
            this.btn_Customers.Name = "btn_Customers";
            this.btn_Customers.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btn_Customers.Size = new System.Drawing.Size(228, 45);
            this.btn_Customers.TabIndex = 18;
            this.btn_Customers.Text = "   عملاء";
            this.btn_Customers.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Customers.UseVisualStyleBackColor = true;
            this.btn_Customers.Click += new System.EventHandler(this.btn_Customers_Click);
            // 
            // btn_Products
            // 
            this.btn_Products.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Products.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_Products.FlatAppearance.BorderSize = 0;
            this.btn_Products.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Products.Font = new System.Drawing.Font("Palatino Linotype", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Products.ForeColor = System.Drawing.Color.White;
            this.btn_Products.Image = global::SuperMarket.Properties.Resources.icons8_products_pile_48;
            this.btn_Products.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Products.Location = new System.Drawing.Point(13, 90);
            this.btn_Products.Margin = new System.Windows.Forms.Padding(0);
            this.btn_Products.Name = "btn_Products";
            this.btn_Products.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btn_Products.Size = new System.Drawing.Size(228, 45);
            this.btn_Products.TabIndex = 17;
            this.btn_Products.Text = "   منتجات";
            this.btn_Products.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Products.UseVisualStyleBackColor = true;
            this.btn_Products.Click += new System.EventHandler(this.btn_Products_Click);
            // 
            // btn_Categories
            // 
            this.btn_Categories.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Categories.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_Categories.FlatAppearance.BorderSize = 0;
            this.btn_Categories.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Categories.Font = new System.Drawing.Font("Palatino Linotype", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Categories.ForeColor = System.Drawing.Color.White;
            this.btn_Categories.Image = global::SuperMarket.Properties.Resources.icons8_warehouse_48;
            this.btn_Categories.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Categories.Location = new System.Drawing.Point(13, 45);
            this.btn_Categories.Margin = new System.Windows.Forms.Padding(0);
            this.btn_Categories.Name = "btn_Categories";
            this.btn_Categories.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btn_Categories.Size = new System.Drawing.Size(228, 45);
            this.btn_Categories.TabIndex = 16;
            this.btn_Categories.Text = "   اصناف ومخازن";
            this.btn_Categories.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Categories.UseVisualStyleBackColor = true;
            this.btn_Categories.Click += new System.EventHandler(this.btn_Categories_Click);
            // 
            // btn_dashborad
            // 
            this.btn_dashborad.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_dashborad.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_dashborad.FlatAppearance.BorderSize = 0;
            this.btn_dashborad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_dashborad.Font = new System.Drawing.Font("Palatino Linotype", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_dashborad.ForeColor = System.Drawing.Color.White;
            this.btn_dashborad.Image = global::SuperMarket.Properties.Resources.icons8_combo_chart_48;
            this.btn_dashborad.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_dashborad.Location = new System.Drawing.Point(13, 0);
            this.btn_dashborad.Margin = new System.Windows.Forms.Padding(0);
            this.btn_dashborad.Name = "btn_dashborad";
            this.btn_dashborad.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btn_dashborad.Size = new System.Drawing.Size(228, 45);
            this.btn_dashborad.TabIndex = 11;
            this.btn_dashborad.Text = "   الرئيسية";
            this.btn_dashborad.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_dashborad.UseVisualStyleBackColor = true;
            this.btn_dashborad.Click += new System.EventHandler(this.btn_dashborad_Click);
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.Purple;
            this.panel8.Controls.Add(this.SidePanel);
            this.panel8.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel8.Location = new System.Drawing.Point(0, 0);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(13, 767);
            this.panel8.TabIndex = 26;
            // 
            // SidePanel
            // 
            this.SidePanel.BackColor = System.Drawing.Color.Gold;
            this.SidePanel.Location = new System.Drawing.Point(0, 4);
            this.SidePanel.Margin = new System.Windows.Forms.Padding(4);
            this.SidePanel.Name = "SidePanel";
            this.SidePanel.Size = new System.Drawing.Size(13, 46);
            this.SidePanel.TabIndex = 4;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.pictureBox1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(258, 66);
            this.panel3.TabIndex = 7;
            this.panel3.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panels_MouseMove);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(109, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 52);
            this.label2.TabIndex = 15;
            this.label2.Text = "برنامج المخازن\r\nوالمبيعات";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 62);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // btn_Help
            // 
            this.btn_Help.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_Help.FlatAppearance.BorderSize = 0;
            this.btn_Help.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Help.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Help.ForeColor = System.Drawing.Color.White;
            this.btn_Help.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Help.Location = new System.Drawing.Point(43, 514);
            this.btn_Help.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Help.Name = "btn_Help";
            this.btn_Help.Size = new System.Drawing.Size(48, 42);
            this.btn_Help.TabIndex = 4;
            this.btn_Help.Text = "?";
            this.btn_Help.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_Help.UseVisualStyleBackColor = true;
            this.btn_Help.Visible = false;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Purple;
            this.panel5.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel5.Location = new System.Drawing.Point(1254, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(10, 732);
            this.panel5.TabIndex = 26;
            // 
            // lbl_welcome
            // 
            this.lbl_welcome.AutoSize = true;
            this.lbl_welcome.Font = new System.Drawing.Font("Palatino Linotype", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_welcome.ForeColor = System.Drawing.Color.White;
            this.lbl_welcome.Location = new System.Drawing.Point(13, 4);
            this.lbl_welcome.Name = "lbl_welcome";
            this.lbl_welcome.Size = new System.Drawing.Size(72, 32);
            this.lbl_welcome.TabIndex = 7;
            this.lbl_welcome.Text = "User:";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Purple;
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.pic_help);
            this.panel2.Controls.Add(this.panel6);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(258, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(996, 65);
            this.panel2.TabIndex = 24;
            this.panel2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panels_MouseMove);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(176, 29);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 14;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pic_help
            // 
            this.pic_help.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pic_help.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pic_help.Image = global::SuperMarket.Properties.Resources.icons8_help_48;
            this.pic_help.Location = new System.Drawing.Point(940, 10);
            this.pic_help.Name = "pic_help";
            this.pic_help.Size = new System.Drawing.Size(50, 41);
            this.pic_help.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic_help.TabIndex = 11;
            this.pic_help.TabStop = false;
            this.pic_help.Click += new System.EventHandler(this.pic_help_Click);
            this.pic_help.MouseEnter += new System.EventHandler(this.pic_help_MouseEnter);
            this.pic_help.MouseLeave += new System.EventHandler(this.pic_help_MouseLeave);
            // 
            // panel6
            // 
            this.panel6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel6.Controls.Add(this.lbl_welcome);
            this.panel6.Controls.Add(this.lbl_welcomeName);
            this.panel6.Location = new System.Drawing.Point(349, 10);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(285, 44);
            this.panel6.TabIndex = 13;
            // 
            // lbl_welcomeName
            // 
            this.lbl_welcomeName.AutoSize = true;
            this.lbl_welcomeName.Font = new System.Drawing.Font("Palatino Linotype", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_welcomeName.ForeColor = System.Drawing.Color.White;
            this.lbl_welcomeName.Location = new System.Drawing.Point(113, 4);
            this.lbl_welcomeName.Name = "lbl_welcomeName";
            this.lbl_welcomeName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lbl_welcomeName.Size = new System.Drawing.Size(77, 32);
            this.lbl_welcomeName.TabIndex = 12;
            this.lbl_welcomeName.Text = "لا يوجد";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Purple;
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(258, 722);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(996, 10);
            this.panel4.TabIndex = 25;
            // 
            // UserSession
            // 
            this.UserSession.Interval = 1000;
            this.UserSession.Tick += new System.EventHandler(this.UserSession_Tick);
            // 
            // HourlyChecker
            // 
            this.HourlyChecker.Interval = 1000;
            this.HourlyChecker.Tick += new System.EventHandler(this.HourlyChecker_Tick);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 732);
            this.Controls.Add(this.pan_controls);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel5);
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(1280, 720);
            this.Name = "Main";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Main_FormClosing);
            this.Load += new System.EventHandler(this.Main_Load);
            this.panel1.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.pan_suppliers.ResumeLayout(false);
            this.pan_billing.ResumeLayout(false);
            this.panel8.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pic_help)).EndInit();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pan_controls;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_billing;
        private System.Windows.Forms.Button btn_Orders;
        private System.Windows.Forms.Button btn_Customers;
        private System.Windows.Forms.Button btn_Products;
        private System.Windows.Forms.Button btn_Categories;
        private System.Windows.Forms.Panel SidePanel;
        private System.Windows.Forms.Button btn_dashborad;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btn_Help;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.PictureBox pic_help;
        private System.Windows.Forms.Label lbl_welcome;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label lbl_welcomeName;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Timer UserSession;
        public System.Windows.Forms.Button btn_settings;
        private System.Windows.Forms.Button btn_billingEdit;
        private System.Windows.Forms.Button btn_reports;
        private System.Windows.Forms.Button btn_users;
        private System.Windows.Forms.Button btn_advancedSearch;
        private System.Windows.Forms.Timer HourlyChecker;
        public System.Windows.Forms.Button btn_suppliers;
        public System.Windows.Forms.Button btn_supplierInvoices;
        private System.Windows.Forms.Button btn_safe;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Panel pan_suppliers;
        public System.Windows.Forms.Button btn_suppliersEdit;
        private System.Windows.Forms.Panel pan_billing;
        private System.Windows.Forms.Button btn_billingAdd;
        public System.Windows.Forms.Button btn_adminPanel;
        private System.Windows.Forms.Button button1;
    }
}