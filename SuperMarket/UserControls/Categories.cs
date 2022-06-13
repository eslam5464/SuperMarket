using SuperMarket.Classes;
using SuperMarket.Classes.Models;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace SuperMarket.UserControls
{
    public partial class Categories : UserControl
    {
        public Categories()
        {
            InitializeComponent();
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            Control FocusedObject = (Control)sender;

            Logger.Log("user is trying to save  a category",
                System.Reflection.MethodInfo.GetCurrentMethod().Name, this.Name, Logger.INFO);

            if (txt_categoriename.Text != "")
            {
                if (!txt_categorieid.Enabled)
                {
                    if (MessageBox.Show($"هل تريد ان تعدل {txt_categoriename.Text} ", "انتظر",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Information) == DialogResult.Yes)
                    {
                        Logger.Log($"user is trying to edit category: {txt_categoriename.Text}",
                            System.Reflection.MethodInfo.GetCurrentMethod().Name, this.Name, Logger.INFO);

                        CategoryModel category = new CategoryModel
                        {
                            Id = int.Parse(txt_categorieid.Text),
                            Name = txt_categoriename.Text
                        };
                        Classes.DataAccess.Categories.UpdateCategory(category);

                        LoadDataGrid(Classes.DataAccess.Categories.GetCategoryParameter("Id", "" + category.Id));

                        ResetTextBoxes();
                    }

                    EditMode(false);
                }
                else
                {
                    Logger.Log($"user is trying to add category: {txt_categoriename.Text}",
                        System.Reflection.MethodInfo.GetCurrentMethod().Name, this.Name, Logger.INFO);

                    string MsgResponse = $"هل تريد ان تحفظ {txt_categoriename.Text} ";

                    var CategoryResult = Classes.DataAccess.Categories.GetCategoryParameter("Name", txt_categoriename.Text);

                    if (CategoryResult.Count > 0)
                        MsgResponse += "لانه يوجد صنف بهذا الاسم";

                    if (MessageBox.Show(MsgResponse, "انتظر",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Information) == DialogResult.Yes)
                    {
                        CategoryModel category = new CategoryModel
                        {
                            Name = txt_categoriename.Text
                        };
                        Classes.DataAccess.Categories.SaveCategory(category);

                        LoadDataGrid(Classes.DataAccess.Categories.LoadCategories());

                        ResetTextBoxes();

                        Logger.Log($"user added category: {category.Name}",
                            System.Reflection.MethodInfo.GetCurrentMethod().Name, this.Name, Logger.INFO);
                    }
                    else
                        Logger.Log($"user didnt add category: {txt_categoriename.Text}",
                            System.Reflection.MethodInfo.GetCurrentMethod().Name, this.Name, Logger.INFO);
                }
            }
            else
                MessageBox.Show("برجاء ادخال اسم الصنف", "حاول مره أخرى", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void ResetTextBoxes()
        {
            txt_categoriename.Text = "";
            txt_categorieid.Text = "";
        }

        private void LoadDataGrid(List<CategoryModel> Categories)
        {
            db_categoriesDataGridView.DataSource = null;
            db_categoriesDataGridView.DataSource = Categories;

            db_categoriesDataGridView.Columns["Id"].HeaderText = "رقم الصنف";
            db_categoriesDataGridView.Columns["Name"].HeaderText = "اسم الصنف";
            db_categoriesDataGridView.Columns["CreationDate"].HeaderText = "يوم اضافه الصنف";

            db_categoriesDataGridView.AutoResizeColumns();
            db_categoriesDataGridView.Columns["CreationDate"].Width += 5;
        }

        private void Categories_Load(object sender, EventArgs e)
        {
            SetColors(Properties.Settings.Default.AppColor);

            LoadDataGrid(Classes.DataAccess.Categories.LoadCategories());
        }

        private void SetColors(Color appColor)
        {
            label1.ForeColor = appColor;
            label2.ForeColor = appColor;
            label3.ForeColor = appColor;
            btn_edit.BackColor = appColor;
            btn_remove.BackColor = appColor;
            btn_save.BackColor = appColor;
            db_categoriesDataGridView.ColumnHeadersDefaultCellStyle.BackColor = appColor;
        }

        private void pcb_searchID_Click(object sender, EventArgs e)
        {
            if (txt_categorieid.Text == "")
                LoadDataGrid(Classes.DataAccess.Categories.LoadCategories());

            else
            {
                Logger.Log($"user is searching for category id: {txt_categorieid.Text}",
                    System.Reflection.MethodInfo.GetCurrentMethod().Name, this.Name, Logger.INFO);
                List<CategoryModel> categorySearch = Classes.DataAccess.Categories.GetCategoryParameter("Id", txt_categorieid.Text);
                LoadDataGrid(categorySearch);
            }
        }

        private void pcb_searchName_Click(object sender, EventArgs e)
        {
            if (txt_categoriename.Text == "")
                LoadDataGrid(Classes.DataAccess.Categories.LoadCategories());

            else
            {
                Logger.Log($"user is searching for category name: {txt_categoriename.Text}",
                    System.Reflection.MethodInfo.GetCurrentMethod().Name, this.Name, Logger.INFO);
                List<CategoryModel> categorySearch = Classes.DataAccess.Categories.GetCategoryParameter("Name", txt_categoriename.Text);
                LoadDataGrid(categorySearch);
            }
        }

        private void btn_remove_Click(object sender, EventArgs e)
        {
            if (db_categoriesDataGridView != null)
            {
                if (db_categoriesDataGridView.CurrentCell != null)
                {
                    int rowindex = db_categoriesDataGridView.CurrentCell.RowIndex;

                    int CategoryID = int.Parse(db_categoriesDataGridView.Rows[rowindex].Cells["Id"].Value.ToString());
                    string CategoryName = db_categoriesDataGridView.Rows[rowindex].Cells["Name"].Value.ToString();

                    Logger.Log($"user is trying to remove {CategoryName}",
                        System.Reflection.MethodInfo.GetCurrentMethod().Name, this.Name, Logger.INFO);

                    if (MessageBox.Show($"هل تريد ان تمسح {CategoryName}", "انتظر",
                                MessageBoxButtons.YesNo,
                                MessageBoxIcon.Information) == DialogResult.Yes)
                    {
                        Classes.DataAccess.Categories.RemoveCategory(CategoryID);
                        LoadDataGrid(Classes.DataAccess.Categories.LoadCategories());

                        Logger.Log($"user has removed {CategoryName} with id: {CategoryID}",
                            System.Reflection.MethodInfo.GetCurrentMethod().Name, this.Name, Logger.INFO);
                    }
                    else
                        Logger.Log($"user didnt remove {CategoryName}",
                            System.Reflection.MethodInfo.GetCurrentMethod().Name, this.Name, Logger.INFO);
                }
            }
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            Logger.Log($"user clicked in edit button",
                System.Reflection.MethodInfo.GetCurrentMethod().Name, this.Name, Logger.INFO);

            int rowindex = db_categoriesDataGridView.CurrentCell.RowIndex;

            int CategoryID = int.Parse(db_categoriesDataGridView.Rows[rowindex].Cells["Id"].Value.ToString());
            string CategoryName = db_categoriesDataGridView.Rows[rowindex].Cells["Name"].Value.ToString();

            txt_categorieid.Text = "" + CategoryID;
            txt_categoriename.Text = CategoryName;

            EditMode(true);
        }

        private void EditMode(bool State)
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

            txt_categorieid.Enabled = !State;
            btn_edit.Enabled = !State;
            btn_remove.Enabled = !State;
            pcb_searchID.Enabled = !State;
            pcb_searchName.Enabled = !State;
        }

        private void txt_category_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                e.SuppressKeyPress = true;
        }

        private void pcb_search_DoubleClick(object sender, EventArgs e)
        {
            LoadDataGrid(Classes.DataAccess.Categories.LoadCategories());
        }

        private void pcb_search_MouseEnter(object sender, EventArgs e)
        {
            Control FocusedObject = (Control)sender;
            FocusedObject.BackColor = Properties.Settings.Default.AppColor;
        }

        private void pcb_search_MouseLeave(object sender, EventArgs e)
        {
            Control FocusedObject = (Control)sender;
            FocusedObject.BackColor = Color.Transparent;
        }
    }
}
