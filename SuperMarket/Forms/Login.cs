﻿using SuperMarket.Classes;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace SuperMarket.Forms
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btn_about_Click(object sender, EventArgs e)
        {
            new About().ShowDialog();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            txt_Username.Text = "admin";
            txt_Password.Text = "passnot100%Safe";

            Logger.Log("user clicked on login button",
                        System.Reflection.MethodInfo.GetCurrentMethod().Name, this.Name, Logger.INFO);

            try
            {
                var AllUsers = Classes.DataAccess.Users.LoadAtiveUsers();

                var user = AllUsers.FindAll(User => Security.Decrypt(User.Username, Security.CPUID + Security.MOBOID) == txt_Username.Text);
                //if (txt_Username.Text == "admin" && txt_Password.Text == "admin")
                //{
                //    Main.LoggedUser = txt_Username.Text;
                //    Main.UserLevel = txt_Username.Text;
                //    Close();
                //}
                if (txt_Username.Text == "" || txt_Password.Text == "")
                    MessageBox.Show("برجاء ادخال اسم المستخدم وكلمه السر معا", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);

                else if (user.Count == 0)
                {
                    MessageBox.Show("البيانات المدخله غير صحيحة برجاء التأكد من اسم المستخدم وكلمه المرور", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    string username = Security.Decrypt(user[0].Username, Security.CPUID + Security.MOBOID),
                        password = Security.Decrypt(user[0].Password, Security.CPUID + Security.MOBOID),
                        fullname = Security.Decrypt(user[0].FullName, Security.CPUID + Security.MOBOID);
                    if (username == txt_Username.Text && password == txt_Password.Text)
                    {
                        Main.LoggedUser = fullname;
                        Main.UserLevel = user[0].UserLevel;
                        Logger.Log($"user entered the correct credentials. accessing the application now",
                                    System.Reflection.MethodInfo.GetCurrentMethod().Name, this.Name, Logger.INFO);
                        Close();
                    }
                    else
                    {
                        // ########################### change login
                        MessageBox.Show("اسم المستخدم أو كلمه المرور غير صحيحة", "حاول مره أخرى", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cbshowpassword_CheckedChanged(object sender, EventArgs e)
        {
            if (cbshowpassword.Checked)
                txt_Password.PasswordChar = '\0';
            else
                txt_Password.PasswordChar = '✪';
        }

        private void Login_Load(object sender, EventArgs e)
        {
            this.TopMost = false;

            SetColors(Properties.Settings.Default.AppColor);

            var Admins = Classes.DataAccess.Users.LoadAtiveUsersAdmin();
            if (Admins.Count == 0)
            {
                string CPUID = Security.CPUID, MOBOID = Security.MOBOID;
                Classes.Models.UserModel user = new Classes.Models.UserModel
                {
                    Username = Security.Encrypt("admin", CPUID + MOBOID),
                    Password = Security.Encrypt("passnot100%Safe", CPUID + MOBOID),
                    FullName = Security.Encrypt("admin", CPUID + MOBOID),
                    Phone = Security.Encrypt("01100308506", CPUID + MOBOID),
                    Email = Security.Encrypt("NA", CPUID + MOBOID),
                    UserLevel = "admin",
                    ActiveState = 1
                };
                Classes.DataAccess.Users.SaveUser(user);
            }
        }

        private void SetColors(Color appColor)
        {
            panel1.BackColor = appColor;
            panel2.BackColor = appColor;
            btn_close.BackColor = appColor;
            btn_login.BackColor = appColor;
            cbshowpassword.ForeColor = appColor;
            lbl_admin.ForeColor = appColor;
            lbl_appName.ForeColor = appColor;
            lbl_password.ForeColor = appColor;
            pic_logo.BackColor = appColor;
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
