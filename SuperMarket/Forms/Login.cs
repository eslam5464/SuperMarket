using SuperMarket.Classes;
using System;
using System.Drawing;
using System.Threading.Tasks;
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

        private async void btn_login_Click(object sender, EventArgs e)
        {
            txt_Username.Text = "admin";
            txt_Password.Text = "passnot100%Safe";

             Logger.Log("user clicked on login button",
                         System.Reflection.MethodInfo.GetCurrentMethod().Name, this.Name, Logger.INFO);

            try
            {
                var AllUsers = await Task.Run(() => Classes.DataAccess.Users.LoadAtiveUsers());

                var user = AllUsers.FindAll(User => Security.Decrypt(User.Username, Security.CPUID + Security.MOBOID) == txt_Username.Text);
                //if (txt_Username.Text == "admin" && txt_Password.Text == "admin")
                //{
                //    Main.LoggedUser = txt_Username.Text;
                //    Main.UserLevel = txt_Username.Text;
                //    Close();
                //}
                if (txt_Username.Text.Trim() == "" || txt_Password.Text.Trim() == "")
                    MessageBox.Show("برجاء ادخال اسم المستخدم وكلمه السر معا", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);

                else if (user.Count == 0)
                {
                    MessageBox.Show("البيانات المدخله غير صحيحة برجاء التأكد من اسم المستخدم و كلمه المرور", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    string username = await Security.DecryptAsync(user[0].Username, Security.CPUID + Security.MOBOID),
                        password = await Security.DecryptAsync(user[0].Password, Security.CPUID + Security.MOBOID),
                        fullname = await Security.DecryptAsync(user[0].FullName, Security.CPUID + Security.MOBOID),
                        email = await Security.DecryptAsync(user[0].Email, Security.CPUID + Security.MOBOID),
                        phone = await Security.DecryptAsync(user[0].Phone, Security.CPUID + Security.MOBOID);

                    if (username == txt_Username.Text && password == txt_Password.Text)
                    {
                        Classes.Models.UserModel LoggedUser = new Classes.Models.UserModel()
                        {
                            Id = user[0].Id,
                            ModifyDate = user[0].ModifyDate,
                            CreationDate = user[0].CreationDate,
                            UserLevel = user[0].UserLevel,
                            ActiveState = user[0].ActiveState,
                            Username = username,
                            Password = password,
                            FullName = fullname,
                            Email = email,
                            Phone = phone
                        };

                        Main.LoggedUser = LoggedUser;
                         Logger.Log($"user entered the correct credentials. accessing the application now",
                                    System.Reflection.MethodInfo.GetCurrentMethod().Name, this.Name, Logger.INFO);
                        Close();
                    }
                    else
                    {
                        // to do: ########################### change login
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

        private async void Login_Load(object sender, EventArgs e)
        {
            this.TopMost = false;

            SetColors(Properties.Settings.Default.AppColor);

            var Admins = Classes.DataAccess.Users.LoadAtiveUsersAdmin();
            if (Admins.Count == 0)
            {
                string CPUID = Security.CPUID, MOBOID = Security.MOBOID;
                Classes.Models.UserModel user = new Classes.Models.UserModel
                {
                    Username = await Security.EncryptAsync("admin", CPUID + MOBOID),
                    Password = await Security.EncryptAsync("passnot100%Safe", CPUID + MOBOID),
                    FullName = await Security.EncryptAsync("admin", CPUID + MOBOID),
                    Phone = await Security.EncryptAsync("01100308506", CPUID + MOBOID),
                    Email = await Security.EncryptAsync("NA", CPUID + MOBOID),
                    UserLevel = "admin",
                    ActiveState = true
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
