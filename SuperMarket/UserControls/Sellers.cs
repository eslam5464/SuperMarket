using SuperMarket.Classes;
using SuperMarket.Classes.DataAccess;
using SuperMarket.Classes.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace SuperMarket.UserControls
{
    public partial class Sellers : UserControl
    {
        public Sellers()
        {
            InitializeComponent();
        }

        private static int EditedUserId = -1;
        private readonly IDictionary<int, string> UserLevelDict = new Dictionary<int, string>();

        private void HideAndTranslateColums()
        {
            db_userDataGridView.Columns["FullName"].HeaderText = "الاسم بالكامل";
            db_userDataGridView.Columns["UserName"].HeaderText = "اسم المستخدم";
            db_userDataGridView.Columns["Phone"].HeaderText = "رقم الهاتف";
            db_userDataGridView.Columns["CreationDate"].HeaderText = "يوم الاضافه";
            db_userDataGridView.Columns["ModifyDate"].HeaderText = "يوم التعديل";
            db_userDataGridView.Columns["UserLevel"].HeaderText = "مكانه المستخدم";

            db_userDataGridView.Columns["Id"].Visible = false;
            db_userDataGridView.Columns["Password"].Visible = false;
            db_userDataGridView.Columns["Email"].Visible = false;
            db_userDataGridView.Columns["ActiveState"].Visible = false;

            db_userDataGridView.AutoResizeColumns();

            db_userDataGridView.Columns["CreationDate"].Width += 5;
            db_userDataGridView.Columns["ModifyDate"].Width += 5;
        }

        private void RefreshDataGrid()
        {
            db_userDataGridView.DataSource = null;
            List<UserModel> AllUsers = DecryptUsers(Users.LoadAtiveUsersNonAdmin());

            foreach (UserModel user in AllUsers)
            {
                user.UserLevel = UserLevelDict[int.Parse(user.UserLevel)];
            }

            db_userDataGridView.DataSource = AllUsers;
            HideAndTranslateColums();
        }

        private List<UserModel> DecryptUsers(List<UserModel> AllUsers)
        {
            string CPUID = Security.CPUID, MOBOID = Security.MOBOID;

            AllUsers.Select(user =>
            {
                user.Username = Security.Decrypt(user.Username, CPUID + MOBOID);
                user.Password = Security.Decrypt(user.Password, CPUID + MOBOID);
                user.FullName = Security.Decrypt(user.FullName, CPUID + MOBOID);
                user.Phone = Security.Decrypt(user.Phone, CPUID + MOBOID);
                user.Email = Security.Decrypt(user.Email, CPUID + MOBOID);
                user.UserLevel = user.UserLevel;
                return user;
            }).ToList();

            return AllUsers;
        }

        private void Sellers_Load(object sender, EventArgs e)
        {
            SetColors(Properties.Settings.Default.AppColor);
            SetUserLevel();
            RefreshDataGrid();
        }

        private void SetUserLevel()
        {
            string[] UserLevels = { "مدير", "مشرف", "موظف" };

            for (int i = 0; i < UserLevels.Length; i++)
                UserLevelDict.Add(i, UserLevels[i]);

            txt_userLevel.DataSource = new BindingSource(UserLevelDict, null);
            txt_userLevel.DisplayMember = "Value";
            txt_userLevel.ValueMember = "Key";

            txt_userLevel.SelectedIndex = -1;
        }

        private void SetColors(Color appColor)
        {
            label1.ForeColor = appColor;
            label2.ForeColor = appColor;
            label3.ForeColor = appColor;
            label4.ForeColor = appColor;
            label6.ForeColor = appColor;
            btn_edit.BackColor = appColor;
            btn_remove.BackColor = appColor;
            btn_save.BackColor = appColor;
            db_userDataGridView.ColumnHeadersDefaultCellStyle.BackColor = appColor;
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            try
            {
                if (txt_Username.Text == "" || txt_Password.Text == "")
                    MessageBox.Show("برجاء ادخال البيانات من اسم المستخدم وكلمه المرور", "حاول مره أخرى", MessageBoxButtons.OK, MessageBoxIcon.Error);

                else
                {
                    if (!btn_edit.Enabled)
                    {
                        if (MessageBox.Show($"هل تريد تأكيد هذا التعديل", "انتظر",
                            MessageBoxButtons.YesNo,
                            MessageBoxIcon.Information) == DialogResult.Yes)
                        {
                            int UseriD = EditedUserId;
                            string CPUID = Security.CPUID, MOBOID = Security.MOBOID;

                            UserModel user = new UserModel
                            {
                                Id = UseriD,
                                Username = Security.Encrypt(txt_Username.Text, CPUID + MOBOID),
                                Password = Security.Encrypt(txt_Password.Text, CPUID + MOBOID),
                                FullName = Security.Encrypt(txt_fullname.Text, CPUID + MOBOID),
                                Phone = Security.Encrypt(txt_mobailno.Text, CPUID + MOBOID),
                                Email = Security.Encrypt("NA", CPUID + MOBOID),
                                UserLevel = txt_userLevel.SelectedValue.ToString()
                            };
                            Users.UpdateUser(user);

                            RefreshDataGrid();

                            ResetTextBoxes();
                        }
                        SetEditMode(false);
                    }
                    else
                    {
                        if (txt_userLevel.SelectedIndex != -1)
                        {
                            List<UserModel> AllUsers = Users.LoadAllUsers();

                            var UserResult = AllUsers.FindAll(User => Security.Decrypt(User.Username,
                                Security.CPUID + Security.MOBOID) == txt_Username.Text);

                            if (UserResult.Count == 0)
                            {
                                if (MessageBox.Show($"هل تريد ان تحفظ {txt_Username.Text} ", "انتظر",
                                MessageBoxButtons.YesNo,
                                MessageBoxIcon.Information) == DialogResult.Yes)
                                {
                                    string CPUID = Security.CPUID, MOBOID = Security.MOBOID;

                                    UserModel user = new UserModel
                                    {
                                        Username = Security.Encrypt(txt_Username.Text, CPUID + MOBOID),
                                        Password = Security.Encrypt(txt_Password.Text, CPUID + MOBOID),
                                        FullName = Security.Encrypt(txt_fullname.Text, CPUID + MOBOID),
                                        Phone = Security.Encrypt(txt_mobailno.Text, CPUID + MOBOID),
                                        Email = Security.Encrypt("NA", CPUID + MOBOID),
                                        UserLevel = txt_userLevel.SelectedValue.ToString(),
                                        ActiveState = 1
                                    };
                                    Users.SaveUser(user);

                                    RefreshDataGrid();

                                    ResetTextBoxes();
                                }
                            }
                            else
                            {
                                MessageBox.Show("يوجد مستخدم بنفس البيانات برجاء استخدام بيانات أخرى غير اسم المستخدم هذا",
                                    "حاول مره أخرى", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        else
                        {
                            MessageBox.Show("برجاء اختيار مكانه المستخدم",
                                    "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ResetTextBoxes()
        {
            txt_Username.Text = "";
            txt_Password.Text = "";
            txt_fullname.Text = "";
            txt_mobailno.Text = "";
            txt_userLevel.SelectedIndex = -1;
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            if (db_userDataGridView != null)
            {
                if (db_userDataGridView.CurrentCell != null)
                {
                    int RowIndex = db_userDataGridView.CurrentCell.RowIndex;

                    string UserName = db_userDataGridView.Rows[RowIndex].Cells["UserName"].Value.ToString(),
                        Password = db_userDataGridView.Rows[RowIndex].Cells["Password"].Value.ToString(),
                        FullName = db_userDataGridView.Rows[RowIndex].Cells["FullName"].Value.ToString(),
                        UserLevel = db_userDataGridView.Rows[RowIndex].Cells["UserLevel"].Value.ToString(),
                        Phone = db_userDataGridView.Rows[RowIndex].Cells["Phone"].Value.ToString();

                    EditedUserId = int.Parse(db_userDataGridView.Rows[RowIndex].Cells["Id"].Value.ToString());

                    txt_userLevel.Text = UserLevel;
                    txt_Username.Text = UserName;
                    txt_Password.Text = Password;
                    txt_fullname.Text = FullName;
                    txt_mobailno.Text = Phone;

                    SetEditMode(true);
                }
                else
                {
                    MessageBox.Show("يجب أن تختار مستخدم للتعديل", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void SetEditMode(bool State)
        {
            if (State)
            {
                btn_edit.BackColor = Color.Silver;
                btn_remove.BackColor = Color.Silver;
            }
            else
            {
                btn_edit.BackColor = Properties.Settings.Default.AppColor;
                btn_remove.BackColor = Properties.Settings.Default.AppColor;
            }
            btn_edit.Enabled = !State;
            btn_remove.Enabled = !State;
        }

        private void pcb_serchbyname_Click(object sender, EventArgs e)
        {
            if (txt_Username.Text == "")
            {
                RefreshDataGrid();
            }
            else
            {
                List<UserModel> AllUsers = Users.LoadAtiveUsersNonAdmin();
                db_userDataGridView.DataSource = null;

                var user = AllUsers.FindAll(User => Security.Decrypt(User.Username, Security.CPUID + Security.MOBOID) == txt_Username.Text);

                db_userDataGridView.DataSource = DecryptUsers(user);
                HideAndTranslateColums();
            }
        }

        private void pcb_serchbyfullname_Click(object sender, EventArgs e)
        {
            if (txt_Username.Text == "")
            {
                RefreshDataGrid();
            }
            else
            {
                db_userDataGridView.DataSource = null;
                //db_userDataGridView.DataSource = DecryptUsers(Users.LoadUsersWithParamNonAdmin("FullName", txt_fullname.Text));

                List<UserModel> AllUsers = Users.LoadAtiveUsersNonAdmin();
                var user = AllUsers.FindAll(User => Security.Decrypt(User.FullName, Security.CPUID + Security.MOBOID) == txt_fullname.Text);

                db_userDataGridView.DataSource = DecryptUsers(user);

                HideAndTranslateColums();
            }
        }

        private void btn_remove_Click(object sender, EventArgs e)
        {
            if (db_userDataGridView != null)
            {
                if (db_userDataGridView.CurrentCell != null)
                {
                    int rowindex = db_userDataGridView.CurrentCell.RowIndex;
                    int UserId = int.Parse(db_userDataGridView.Rows[rowindex].Cells["Id"].Value.ToString());
                    string UserName = db_userDataGridView.Rows[rowindex].Cells["UserName"].Value.ToString();

                    if (MessageBox.Show($"هل تريد ان تمسح {UserName}", "انتظر",
                                MessageBoxButtons.YesNo,
                                MessageBoxIcon.Information) == DialogResult.Yes)
                    {
                        Users.StopUser(UserId);
                        RefreshDataGrid();
                    }

                    //if (txt_Username.Text == "" || txt_Password.Text == "" || txt_fullname.Text == "" || txt_mobailno.Text == "")
                    //{
                    //    MessageBox.Show("برجاء ادخال جميع البيانات", "حاول مره أخرى", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    //}
                    //else
                    //{
                    //    string CPUID = Security.CPUID, MOBOID = Security.MOBOID;

                    //    List<UserModel> AllUsers = Users.LoadAtiveUsersNonAdmin();

                    //    var userFind = AllUsers.FindAll(User => Security.Decrypt(User.Username, Security.CPUID + Security.MOBOID) == txt_Username.Text);


                    //    if (userFind.Count != 0)
                    //    {
                    //        try
                    //        {
                    //            UserModel user = new UserModel
                    //            {
                    //                Id = userFind[0].Id,
                    //                Username = Security.Encrypt(txt_Username.Text, CPUID + MOBOID),
                    //                Password = Security.Encrypt(txt_Password.Text, CPUID + MOBOID),
                    //                FullName = Security.Encrypt(txt_fullname.Text, CPUID + MOBOID),
                    //                Phone = Security.Encrypt(txt_mobailno.Text, CPUID + MOBOID),
                    //                ModifyDate = DateTime.Now.ToString()
                    //            };
                    //            Users.UpdateUser(user);

                    //            db_userDataGridView.DataSource = null;
                    //            AllUsers = Users.LoadAtiveUsersNonAdmin();
                    //            userFind = AllUsers.FindAll(User => Security.Decrypt(User.Username, Security.CPUID + Security.MOBOID) == txt_Username.Text);
                    //            db_userDataGridView.DataSource = DecryptUsers(userFind);
                    //            HideAndTranslateColums();
                    //        }
                    //        catch (Exception ex)
                    //        {
                    //            MessageBox.Show(ex.Message);
                    //        }
                    //    }
                    //    else
                    //    {
                    //        MessageBox.Show("لا يوجد مستخدم بهذه البيانات برجاء التأكد من اسم المستخدم",
                    //            "حاول مره أخرى", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    //    }
                    //}

                }
            }
        }

        private void pcb_search_DoubleClick(object sender, EventArgs e)
        {
            RefreshDataGrid();
        }

        private void pcb_serchbyPhone_Click(object sender, EventArgs e)
        {
            if (txt_Username.Text == "")
            {
                RefreshDataGrid();
            }
            else
            {
                db_userDataGridView.DataSource = null;

                List<UserModel> AllUsers = Users.LoadAtiveUsersNonAdmin();
                var user = AllUsers.FindAll(User => Security.Decrypt(User.Phone, Security.CPUID + Security.MOBOID) == txt_fullname.Text);

                db_userDataGridView.DataSource = DecryptUsers(user);

                HideAndTranslateColums();
            }
        }

        private void pcb_serchbyPhone_DoubleClick(object sender, EventArgs e)
        {
            RefreshDataGrid();
        }

        private void pcb_serchby_MouseEnter(object sender, EventArgs e)
        {
            Control FocusedObject = (Control)sender;
            FocusedObject.BackColor = Properties.Settings.Default.AppColor;
        }

        private void pcb_serchbyPhone_MouseLeave(object sender, EventArgs e)
        {
            Control FocusedObject = (Control)sender;
            FocusedObject.BackColor = Color.Transparent;
        }
    }
}
