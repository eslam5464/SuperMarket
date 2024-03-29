﻿using POSWarehouse.Classes;
using POSWarehouse.Classes.Models;
using POSWarehouse.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POSWarehouse.UserControls
{
    public partial class Users : UserControl
    {
        public Users()
        {
            InitializeComponent();
        }

        private static long EditedUserId = -1;
        private readonly IDictionary<int, string> UserLevelDict = new Dictionary<int, string>();
        private ContextMenu contextMenu = new ContextMenu();
        private DataGridViewCell ContextMenuSelectedCell;

        private void HideAndTranslateColums()
        {
            usersDataGridView.Columns["FullNameDataGridViewTextBoxColumn_"].HeaderText = "الاسم بالكامل";
            usersDataGridView.Columns["UserNameDataGridViewTextBoxColumn_"].HeaderText = "اسم المستخدم";
            usersDataGridView.Columns["PhoneDataGridViewTextBoxColumn_"].HeaderText = "رقم الهاتف";
            usersDataGridView.Columns["CreationDateDataGridViewTextBoxColumn_"].HeaderText = "يوم الاضافه";
            usersDataGridView.Columns["CreationDateDataGridViewTextBoxColumn_"].DefaultCellStyle.Format = "yyyy/MM/dd tt HH:mm:ss";
            usersDataGridView.Columns["ModifyDateDataGridViewTextBoxColumn_"].HeaderText = "يوم التعديل";
            usersDataGridView.Columns["ModifyDateDataGridViewTextBoxColumn_"].DefaultCellStyle.Format = "yyyy/MM/dd tt HH:mm:ss";
            usersDataGridView.Columns["UserLevelDataGridViewTextBoxColumn_"].HeaderText = "مكانه المستخدم";

            usersDataGridView.Columns["IdDataGridViewTextBoxColumn_"].Visible = false;
            usersDataGridView.Columns["PasswordDataGridViewTextBoxColumn_"].Visible = false;
            usersDataGridView.Columns["EmailDataGridViewTextBoxColumn_"].Visible = false;
            usersDataGridView.Columns["ActiveStateDataGridViewTextBoxColumn_"].Visible = false;

            usersDataGridView.AutoResizeColumns();

            usersDataGridView.Columns["CreationDateDataGridViewTextBoxColumn_"].Width += 5;
            usersDataGridView.Columns["ModifyDateDataGridViewTextBoxColumn_"].Width += 5;
        }

        private void RefreshDataGrid()
        {
            usersDataGridView.DataSource = null;
            List<UserModel> AllUsers = DecryptUsers(Classes.DataAccess.Users.LoadAtiveUsersNonAdmin());

            foreach (UserModel user in AllUsers)
            {
                user.UserLevel = UserLevelDict[int.Parse(user.UserLevel)];
            }

            usersDataGridView.DataSource = AllUsers;
            HideAndTranslateColums();
        }

        private List<UserModel> DecryptUsers(List<UserModel> AllUsers)
        {
            string CPUID = Security.CPUID, MOBOID = Security.MOBOID;

            AllUsers.Select(user =>
            {
                user.Username = Security.Decrypt(user.Username, CPUID + MOBOID);
                user.Password = Security.Decrypt(user.Password, CPUID + MOBOID);
                user.FullName = user.FullName;
                user.Phone = user.Phone;
                user.Email = user.Email;
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

            contextMenu = Methods.SetupContextMenuCopy(contextMenu, MenuItemCopyOption_Click);
        }

        private void MenuItemCopyOption_Click(Object sender, EventArgs e)
        {
            string CellText = usersDataGridView.Rows[ContextMenuSelectedCell.RowIndex].
                Cells[ContextMenuSelectedCell.ColumnIndex].Value.ToString();
            Clipboard.SetText(CellText);
        }

        private void SetUserLevel()
        {
            for (int i = 0; i < GlobalVars.UserLevels.Length; i++)
                UserLevelDict.Add(i, GlobalVars.UserLevels[i]);

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
            usersDataGridView.ColumnHeadersDefaultCellStyle.BackColor = appColor;
        }

        private async void btn_save_Click(object sender, EventArgs e)
        {
            try
            {
                if (txt_Username.Text.Trim() == "" || txt_Password.Text.Trim() == "" || txt_fullname.Text.Trim() == "")
                    new Notification().ShowAlert($"برجاء ادخال البيانات من اسم المستخدم وكلمه المروروالاسم بالكامل",
                        Notification.EnmType.Error);

                else
                {
                    if (!btn_edit.Enabled)
                    {
                        Logger.Log($"user is trying to edit seller with id: {EditedUserId}",
                           System.Reflection.MethodInfo.GetCurrentMethod().Name, this.Name, Logger.INFO);

                        if (MessageBox.Show($"هل تريد تأكيد هذا التعديل", "انتظر",
                            MessageBoxButtons.YesNo,
                            MessageBoxIcon.Information) == DialogResult.Yes)
                        {
                            long UseriD = EditedUserId;
                            string CPUID = Security.CPUID, MOBOID = Security.MOBOID;

                            UserModel user = new UserModel
                            {
                                Id = UseriD,
                                Username = await Security.EncryptAsync(txt_Username.Text, CPUID + MOBOID),
                                Password = await Security.EncryptAsync(txt_Password.Text, CPUID + MOBOID),
                                FullName = txt_fullname.Text,
                                Phone = txt_mobailno.Text,
                                Email = "NA",
                                UserLevel = txt_userLevel.SelectedValue.ToString()
                            };
                            Classes.DataAccess.Users.UpdateUser(user);

                            RefreshDataGrid();

                            Logger.Log($"user has edited seller: {txt_Username.Text} with id: {user.Id}",
                           System.Reflection.MethodInfo.GetCurrentMethod().Name, this.Name, Logger.INFO);
                        }

                        ResetTextBoxes();
                        SetEditMode(false);
                    }
                    else
                    {
                        if (txt_userLevel.SelectedIndex != -1)
                        {
                            List<UserModel> AllUsers = Classes.DataAccess.Users.LoadAllUsers(true);

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
                                        Username = await Security.EncryptAsync(txt_Username.Text, CPUID + MOBOID),
                                        Password = await Security.EncryptAsync(txt_Password.Text, CPUID + MOBOID),
                                        FullName = txt_fullname.Text,
                                        Phone = txt_mobailno.Text,
                                        Email = "NA",
                                        UserLevel = txt_userLevel.SelectedValue.ToString(),
                                        ActiveState = true
                                    };
                                    Classes.DataAccess.Users.SaveUser(user);

                                    List<UserModel> LastAddedUser = Classes.DataAccess.Users.LoadLastAddedUser();

                                    if (LastAddedUser.Count != 0)
                                    {
                                        UserLevelAccessModel UserAccessLevel = new UserLevelAccessModel
                                        {
                                            UserId = LastAddedUser[0].Id,
                                            UserFullName = LastAddedUser[0].FullName,
                                            UserLevel = LastAddedUser[0].UserLevel,
                                            Billing = true,
                                            BillsEdit = true,
                                            Dashboard = true,
                                            Categories = true,
                                            Customers = true,
                                            Products = true,
                                            Reports = true,
                                            Settings = true,
                                            Users = true,
                                            Orders = true,
                                            Safe = true,
                                            SupplierInvoices = true,
                                            SuppliersEdit = true,
                                        };
                                        Classes.DataAccess.UserLevelAccess.SaveUserLevelAccess(UserAccessLevel);
                                    }

                                    RefreshDataGrid();

                                    Logger.Log($"user has added seller: {txt_Username.Text} with user level: {user.UserLevel}",
                                        System.Reflection.MethodInfo.GetCurrentMethod().Name, this.Name, Logger.INFO);

                                    ResetTextBoxes();
                                }
                            }
                            else
                            {
                                new Notification().ShowAlert($"يوجد مستخدم بنفس البيانات برجاء استخدام بيانات أخرى غير اسم المستخدم هذا",
                                    Notification.EnmType.Error);
                            }
                        }
                        else
                        {
                            new Notification().ShowAlert($"برجاء اختيار مكانه المستخدم", Notification.EnmType.Error);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Logger.Log($"While saving users & error: {ex.Message}",
                    System.Reflection.MethodInfo.GetCurrentMethod().Name, this.Name, Logger.ERROR);

                MessageBox.Show(ex.Message);
            }
        }

        internal void CheckUserAccess()
        {
            if (!Main.LoggedUserAccess.Reports)
            {
                btn_exportPDF.Enabled = false;
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
            if (usersDataGridView != null)
            {
                if (usersDataGridView.CurrentCell != null)
                {
                    int RowIndex = usersDataGridView.CurrentCell.RowIndex;

                    string UserName = usersDataGridView.Rows[RowIndex].Cells["UserNameDataGridViewTextBoxColumn_"].Value.ToString(),
                        Password = usersDataGridView.Rows[RowIndex].Cells["PasswordDataGridViewTextBoxColumn_"].Value.ToString(),
                        FullName = usersDataGridView.Rows[RowIndex].Cells["FullNameDataGridViewTextBoxColumn_"].Value.ToString(),
                        UserLevel = usersDataGridView.Rows[RowIndex].Cells["UserLevelDataGridViewTextBoxColumn_"].Value.ToString(),
                        Phone = usersDataGridView.Rows[RowIndex].Cells["PhoneDataGridViewTextBoxColumn_"].Value.ToString();

                    EditedUserId = long.Parse(usersDataGridView.Rows[RowIndex].Cells["IdDataGridViewTextBoxColumn_"].Value.ToString());

                    txt_userLevel.Text = UserLevel;
                    txt_Username.Text = UserName;
                    txt_Password.Text = Password;
                    txt_fullname.Text = FullName;
                    txt_mobailno.Text = Phone;

                    SetEditMode(true);
                }
                else
                {
                    new Notification().ShowAlert($"يجب أن تختار مستخدم للتعديل", Notification.EnmType.Error);
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
            if (txt_Username.Text.Trim() == "")
            {
                RefreshDataGrid();
            }

            else
            {
                Logger.Log($"user is trying to search for seller by username: {txt_Username.Text}",
                              System.Reflection.MethodInfo.GetCurrentMethod().Name, this.Name, Logger.INFO);

                List<UserModel> AllUsers = Classes.DataAccess.Users.LoadAtiveUsersNonAdmin();
                usersDataGridView.DataSource = null;

                var user = AllUsers.FindAll(User => Security.Decrypt(User.Username, Security.CPUID + Security.MOBOID) == txt_Username.Text);

                usersDataGridView.DataSource = DecryptUsers(user);
                HideAndTranslateColums();
            }
        }

        private void pcb_serchbyfullname_Click(object sender, EventArgs e)
        {
            if (txt_Username.Text.Trim() == "")
            {
                RefreshDataGrid();
            }
            else
            {
                Logger.Log($"user is trying to search by full name for seller: {txt_fullname.Text}",
                                System.Reflection.MethodInfo.GetCurrentMethod().Name, this.Name, Logger.INFO);

                usersDataGridView.DataSource = null;

                List<UserModel> AllUsers = Classes.DataAccess.Users.LoadAtiveUsersNonAdmin();
                var user = AllUsers.FindAll(User => User.FullName == txt_fullname.Text);

                usersDataGridView.DataSource = DecryptUsers(user);

                HideAndTranslateColums();
            }
        }

        private void btn_remove_Click(object sender, EventArgs e)
        {
            if (usersDataGridView != null)
            {
                if (usersDataGridView.CurrentCell != null)
                {
                    int rowindex = usersDataGridView.CurrentCell.RowIndex;
                    long UserId = long.Parse(usersDataGridView.Rows[rowindex].Cells["IdDataGridViewTextBoxColumn_"].Value.ToString());
                    string UserName = usersDataGridView.Rows[rowindex].Cells["UserNameDataGridViewTextBoxColumn_"].Value.ToString();

                    Logger.Log($"user is trying to remove seller: {UserName}",
                             System.Reflection.MethodInfo.GetCurrentMethod().Name, this.Name, Logger.INFO);

                    if (MessageBox.Show($"هل تريد ان تمسح {UserName}", "انتظر",
                                MessageBoxButtons.YesNo,
                                MessageBoxIcon.Information) == DialogResult.Yes)
                    {
                        Logger.Log($"user has removed seller: {UserName} with id: {UserId}",
                                  System.Reflection.MethodInfo.GetCurrentMethod().Name, this.Name, Logger.INFO);

                        Classes.DataAccess.Users.StopUser(UserId);
                        RefreshDataGrid();
                    }
                }
            }
        }

        private void pcb_search_DoubleClick(object sender, EventArgs e)
        {
            RefreshDataGrid();
        }

        private void pcb_serchbyPhone_Click(object sender, EventArgs e)
        {
            if (txt_Username.Text.Trim() == "")
            {
                RefreshDataGrid();
            }
            else
            {
                Logger.Log($"user is trying to search by phone for seller: {txt_mobailno.Text}",
                                System.Reflection.MethodInfo.GetCurrentMethod().Name, this.Name, Logger.INFO);

                usersDataGridView.DataSource = null;

                List<UserModel> AllUsers = Classes.DataAccess.Users.LoadAtiveUsersNonAdmin();
                var user = AllUsers.FindAll(User => User.Phone == txt_mobailno.Text);

                usersDataGridView.DataSource = DecryptUsers(user);

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

        private void txt_Password_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                btn_save.PerformClick();
            }
        }

        private async void db_userDataGridView_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            //usersDataGridView.DataSource = new Methods().DataGridToDataTable(usersDataGridView);
            DataTable data = await new Methods().DataGridToDataTable(usersDataGridView);


            data.DefaultView.Sort = $"{usersDataGridView.Columns[e.ColumnIndex].Name} ASC";

            usersDataGridView.DataSource = data;

            usersDataGridView.Sort(usersDataGridView.Columns[e.ColumnIndex], ListSortDirection.Ascending);
        }

        private async void db_userDataGridView_ColumnHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            //usersDataGridView.DataSource = new BindingSource(new Methods().DataGridToDataTable(usersDataGridView), null);

            DataTable data = await new Methods().DataGridToDataTable(usersDataGridView);

            data.DefaultView.Sort = $"{usersDataGridView.Columns[e.ColumnIndex].Name} DESC";

            usersDataGridView.DataSource = data;

            usersDataGridView.Sort(usersDataGridView.Columns[e.ColumnIndex], ListSortDirection.Descending);
        }

        private void usersDataGridView_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                int cellColumnIndex = usersDataGridView.CurrentCell.ColumnIndex;
                int cellRowIndex = usersDataGridView.CurrentCell.RowIndex;

                int CellX = usersDataGridView.GetCellDisplayRectangle(cellColumnIndex, cellRowIndex, false).Left;
                int CellY = usersDataGridView.GetCellDisplayRectangle(cellColumnIndex, cellRowIndex, false).Top;

                ContextMenuSelectedCell = (sender as DataGridView).Rows[cellRowIndex].Cells[cellColumnIndex];

                if (ContextMenuSelectedCell != null)
                {
                    contextMenu.Show(usersDataGridView, new Point(CellX, CellY));
                }
            }
        }

        private void btn_exportPDF_Click(object sender, EventArgs e)
        {
            //await Methods.ExportDGVtoPDF(usersDataGridView, "الموظفين");
            Forms.ReportViewer.SelectedReport = Forms.ReportViewer.AvailableReports.Users;

            using (Forms.ReportViewer reportViewer = new Forms.ReportViewer())
            {
                reportViewer.ShowDialog();
                reportViewer.Dispose();
                reportViewer.Close();
            }
        }

        private async void usersDataGridView_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (usersDataGridView != null)
            {
                if (usersDataGridView.CurrentCell != null)
                {
                    int rowindex = usersDataGridView.CurrentCell.RowIndex;
                    long UserId = long.Parse(usersDataGridView.Rows[rowindex].Cells["IdDataGridViewTextBoxColumn_"].Value.ToString());

                    List<UserLevelAccessModel> SearchedUser =
                       await Task.Run(() => Classes.DataAccess.UserLevelAccess.GetUserLevelAccessParameter("UserId", $"{UserId}"));

                    if (SearchedUser.Count > 0)
                    {
                        UserAccess ac = new UserAccess();
                        UserAccess.SetSelectedUser(SearchedUser[0]);
                        ac.ShowDialog();
                    }
                }
            }
        }
    }
}
