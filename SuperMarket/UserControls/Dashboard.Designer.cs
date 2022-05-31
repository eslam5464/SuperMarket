
namespace SuperMarket.UserControls
{
    partial class Dashboard
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
            this.label9 = new System.Windows.Forms.Label();
            this.lbl_user_count = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.pan_user_count = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.label12 = new System.Windows.Forms.Label();
            this.lbl_customer_count = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.panel8 = new System.Windows.Forms.Panel();
            this.pan_customer_count = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_orders_count = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.lbl_orders_sum = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.pan_orders_sum = new System.Windows.Forms.Panel();
            this.label15 = new System.Windows.Forms.Label();
            this.lbl_product_count = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.panel10 = new System.Windows.Forms.Panel();
            this.pan_product_count = new System.Windows.Forms.Panel();
            this.pan_orders_count = new System.Windows.Forms.Panel();
            this.btn_refresh = new System.Windows.Forms.Button();
            this.pan_user_count.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel8.SuspendLayout();
            this.pan_customer_count.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.pan_orders_sum.SuspendLayout();
            this.panel10.SuspendLayout();
            this.pan_product_count.SuspendLayout();
            this.pan_orders_count.SuspendLayout();
            this.SuspendLayout();
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Gray;
            this.label9.Location = new System.Drawing.Point(62, 8);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(128, 25);
            this.label9.TabIndex = 22;
            this.label9.Text = "اجمالي البائعين";
            // 
            // lbl_user_count
            // 
            this.lbl_user_count.AutoSize = true;
            this.lbl_user_count.Font = new System.Drawing.Font("Palatino Linotype", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_user_count.ForeColor = System.Drawing.Color.White;
            this.lbl_user_count.Location = new System.Drawing.Point(99, 49);
            this.lbl_user_count.Name = "lbl_user_count";
            this.lbl_user_count.Size = new System.Drawing.Size(48, 41);
            this.lbl_user_count.TabIndex = 23;
            this.lbl_user_count.Text = "00";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(145, 9);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(99, 25);
            this.label8.TabIndex = 22;
            this.label8.Text = ":عدد بائعين";
            // 
            // pan_user_count
            // 
            this.pan_user_count.BackColor = System.Drawing.Color.Purple;
            this.pan_user_count.Controls.Add(this.lbl_user_count);
            this.pan_user_count.Controls.Add(this.label8);
            this.pan_user_count.Controls.Add(this.panel6);
            this.pan_user_count.Location = new System.Drawing.Point(692, 410);
            this.pan_user_count.Name = "pan_user_count";
            this.pan_user_count.Size = new System.Drawing.Size(258, 148);
            this.pan_user_count.TabIndex = 37;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.Gold;
            this.panel6.Controls.Add(this.label9);
            this.panel6.Location = new System.Drawing.Point(3, 105);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(252, 40);
            this.panel6.TabIndex = 19;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Gray;
            this.label12.Location = new System.Drawing.Point(64, 8);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(125, 25);
            this.label12.TabIndex = 22;
            this.label12.Text = "اجمالي العملاء";
            // 
            // lbl_customer_count
            // 
            this.lbl_customer_count.AutoSize = true;
            this.lbl_customer_count.Font = new System.Drawing.Font("Palatino Linotype", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_customer_count.ForeColor = System.Drawing.Color.White;
            this.lbl_customer_count.Location = new System.Drawing.Point(99, 49);
            this.lbl_customer_count.Name = "lbl_customer_count";
            this.lbl_customer_count.Size = new System.Drawing.Size(48, 41);
            this.lbl_customer_count.TabIndex = 23;
            this.lbl_customer_count.Text = "00";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(145, 9);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(99, 25);
            this.label11.TabIndex = 22;
            this.label11.Text = ":عدد عملاء";
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.Gold;
            this.panel8.Controls.Add(this.label12);
            this.panel8.Location = new System.Drawing.Point(3, 105);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(252, 40);
            this.panel8.TabIndex = 19;
            // 
            // pan_customer_count
            // 
            this.pan_customer_count.BackColor = System.Drawing.Color.Purple;
            this.pan_customer_count.Controls.Add(this.lbl_customer_count);
            this.pan_customer_count.Controls.Add(this.label11);
            this.pan_customer_count.Controls.Add(this.panel8);
            this.pan_customer_count.Location = new System.Drawing.Point(88, 410);
            this.pan_customer_count.Name = "pan_customer_count";
            this.pan_customer_count.Size = new System.Drawing.Size(258, 148);
            this.pan_customer_count.TabIndex = 38;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Gray;
            this.label1.Location = new System.Drawing.Point(61, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 25);
            this.label1.TabIndex = 22;
            this.label1.Text = "اجمالي الطلبات";
            // 
            // lbl_orders_count
            // 
            this.lbl_orders_count.AutoSize = true;
            this.lbl_orders_count.Font = new System.Drawing.Font("Palatino Linotype", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_orders_count.ForeColor = System.Drawing.Color.White;
            this.lbl_orders_count.Location = new System.Drawing.Point(99, 49);
            this.lbl_orders_count.Name = "lbl_orders_count";
            this.lbl_orders_count.Size = new System.Drawing.Size(48, 41);
            this.lbl_orders_count.TabIndex = 23;
            this.lbl_orders_count.Text = "00";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(131, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 25);
            this.label3.TabIndex = 22;
            this.label3.Text = ":عدد الطلبات";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Gold;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(3, 105);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(252, 40);
            this.panel2.TabIndex = 19;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Gray;
            this.label6.Location = new System.Drawing.Point(30, 8);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(192, 25);
            this.label6.TabIndex = 22;
            this.label6.Text = "اجمالي حساب الطلبات ";
            // 
            // lbl_orders_sum
            // 
            this.lbl_orders_sum.AutoSize = true;
            this.lbl_orders_sum.Font = new System.Drawing.Font("Palatino Linotype", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_orders_sum.ForeColor = System.Drawing.Color.White;
            this.lbl_orders_sum.Location = new System.Drawing.Point(99, 49);
            this.lbl_orders_sum.Name = "lbl_orders_sum";
            this.lbl_orders_sum.Size = new System.Drawing.Size(48, 41);
            this.lbl_orders_sum.TabIndex = 23;
            this.lbl_orders_sum.Text = "00";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(110, 11);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(133, 25);
            this.label5.TabIndex = 22;
            this.label5.Text = ":حساب الطلبات";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Gold;
            this.panel4.Controls.Add(this.label6);
            this.panel4.Location = new System.Drawing.Point(3, 105);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(252, 40);
            this.panel4.TabIndex = 19;
            // 
            // pan_orders_sum
            // 
            this.pan_orders_sum.BackColor = System.Drawing.Color.Purple;
            this.pan_orders_sum.Controls.Add(this.lbl_orders_sum);
            this.pan_orders_sum.Controls.Add(this.label5);
            this.pan_orders_sum.Controls.Add(this.panel4);
            this.pan_orders_sum.Location = new System.Drawing.Point(389, 256);
            this.pan_orders_sum.Name = "pan_orders_sum";
            this.pan_orders_sum.Size = new System.Drawing.Size(258, 148);
            this.pan_orders_sum.TabIndex = 36;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.Gray;
            this.label15.Location = new System.Drawing.Point(57, 8);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(138, 25);
            this.label15.TabIndex = 22;
            this.label15.Text = "اجمالي المنتجات";
            // 
            // lbl_product_count
            // 
            this.lbl_product_count.AutoSize = true;
            this.lbl_product_count.Font = new System.Drawing.Font("Palatino Linotype", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_product_count.ForeColor = System.Drawing.Color.White;
            this.lbl_product_count.Location = new System.Drawing.Point(99, 49);
            this.lbl_product_count.Name = "lbl_product_count";
            this.lbl_product_count.Size = new System.Drawing.Size(48, 41);
            this.lbl_product_count.TabIndex = 23;
            this.lbl_product_count.Text = "00";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.White;
            this.label14.Location = new System.Drawing.Point(123, 9);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(121, 25);
            this.label14.TabIndex = 22;
            this.label14.Text = ":عدد المنتجات";
            // 
            // panel10
            // 
            this.panel10.BackColor = System.Drawing.Color.Gold;
            this.panel10.Controls.Add(this.label15);
            this.panel10.Location = new System.Drawing.Point(3, 105);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(252, 40);
            this.panel10.TabIndex = 19;
            // 
            // pan_product_count
            // 
            this.pan_product_count.BackColor = System.Drawing.Color.Purple;
            this.pan_product_count.Controls.Add(this.lbl_product_count);
            this.pan_product_count.Controls.Add(this.label14);
            this.pan_product_count.Controls.Add(this.panel10);
            this.pan_product_count.Location = new System.Drawing.Point(692, 103);
            this.pan_product_count.Name = "pan_product_count";
            this.pan_product_count.Size = new System.Drawing.Size(258, 148);
            this.pan_product_count.TabIndex = 39;
            // 
            // pan_orders_count
            // 
            this.pan_orders_count.BackColor = System.Drawing.Color.Purple;
            this.pan_orders_count.Controls.Add(this.lbl_orders_count);
            this.pan_orders_count.Controls.Add(this.label3);
            this.pan_orders_count.Controls.Add(this.panel2);
            this.pan_orders_count.Location = new System.Drawing.Point(88, 103);
            this.pan_orders_count.Name = "pan_orders_count";
            this.pan_orders_count.Size = new System.Drawing.Size(258, 148);
            this.pan_orders_count.TabIndex = 35;
            // 
            // btn_refresh
            // 
            this.btn_refresh.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_refresh.BackColor = System.Drawing.Color.Purple;
            this.btn_refresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_refresh.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold);
            this.btn_refresh.ForeColor = System.Drawing.Color.White;
            this.btn_refresh.Location = new System.Drawing.Point(419, 498);
            this.btn_refresh.Name = "btn_refresh";
            this.btn_refresh.Size = new System.Drawing.Size(200, 50);
            this.btn_refresh.TabIndex = 138;
            this.btn_refresh.Text = "حساب اجمالي الكل";
            this.btn_refresh.UseVisualStyleBackColor = false;
            this.btn_refresh.Click += new System.EventHandler(this.btn_refresh_Click);
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btn_refresh);
            this.Controls.Add(this.pan_user_count);
            this.Controls.Add(this.pan_customer_count);
            this.Controls.Add(this.pan_orders_sum);
            this.Controls.Add(this.pan_product_count);
            this.Controls.Add(this.pan_orders_count);
            this.MinimumSize = new System.Drawing.Size(1038, 660);
            this.Name = "Dashboard";
            this.Size = new System.Drawing.Size(1038, 660);
            this.Load += new System.EventHandler(this.Dashboard_Load);
            this.pan_user_count.ResumeLayout(false);
            this.pan_user_count.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.pan_customer_count.ResumeLayout(false);
            this.pan_customer_count.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.pan_orders_sum.ResumeLayout(false);
            this.pan_orders_sum.PerformLayout();
            this.panel10.ResumeLayout(false);
            this.panel10.PerformLayout();
            this.pan_product_count.ResumeLayout(false);
            this.pan_product_count.PerformLayout();
            this.pan_orders_count.ResumeLayout(false);
            this.pan_orders_count.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lbl_user_count;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel pan_user_count;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label lbl_customer_count;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Panel pan_customer_count;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_orders_count;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lbl_orders_sum;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel pan_orders_sum;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label lbl_product_count;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Panel pan_product_count;
        private System.Windows.Forms.Panel pan_orders_count;
        private System.Windows.Forms.Button btn_refresh;
    }
}
