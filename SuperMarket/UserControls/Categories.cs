using SuperMarket.Classes;
using SuperMarket.Classes.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
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
        private bool AddingToCB = false;
        private ContextMenu contextMenu = new ContextMenu();
        private DataGridViewCell ContextMenuSelectedCell;

        private void btn_save_Click(object sender, EventArgs e)
        {
            Control FocusedObject = (Control)sender;

            Logger.Log("user is trying to save  a category",
                System.Reflection.MethodInfo.GetCurrentMethod().Name, this.Name, Logger.INFO);

            if (txt_categoriename.Text.Trim() != "")
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
                            Id = long.Parse(txt_categorieid.Text),
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
            categoriesDataGridView.DataSource = null;
            categoriesDataGridView.DataSource = Categories;

            categoriesDataGridView.Columns["Id"].HeaderText = "رقم الصنف";
            categoriesDataGridView.Columns["CategoryName"].HeaderText = "اسم الصنف";
            categoriesDataGridView.Columns["CreationDate"].HeaderText = "يوم اضافه الصنف";
            categoriesDataGridView.Columns["CreationDate"].DefaultCellStyle.Format = "yyyy/MM/dd tt HH:mm:ss";

            categoriesDataGridView.AutoResizeColumns();
            categoriesDataGridView.Columns["CreationDate"].Width += 5;
        }

        private void Categories_Load(object sender, EventArgs e)
        {
            SetColors(Properties.Settings.Default.AppColor);

            LoadDataGrid(Classes.DataAccess.Categories.LoadCategories());

            contextMenu = Methods.SetupContextMenuCopy(contextMenu, MenuItemCopyOption_Click);
        }

        private void MenuItemCopyOption_Click(Object sender, EventArgs e)
        {
            string CellText = categoriesDataGridView.Rows[ContextMenuSelectedCell.RowIndex].
                Cells[ContextMenuSelectedCell.ColumnIndex].Value.ToString();
            Clipboard.SetText(CellText);
        }

        private void AddColumsNameToCB(ComboBox comboBox, DataGridView dataGridView)
        {
            if (!AddingToCB)
                AddingToCB = true;

            SortedDictionary<string, string> userCache = new SortedDictionary<string, string>();

            for (int i = 0; i < dataGridView.Columns.Count; i++)
            {
                userCache.Add(dataGridView.Columns[i].HeaderText,
                    dataGridView.Columns[i].Name);
            }

            comboBox.DataSource = new BindingSource(userCache, null);
            comboBox.DisplayMember = "Key";
            comboBox.ValueMember = "Value";
            comboBox.SelectedIndex = -1;

            if (AddingToCB)
                AddingToCB = false;
        }

        private void SetColors(Color appColor)
        {
            label2.ForeColor = appColor;
            label3.ForeColor = appColor;
            btn_edit.BackColor = appColor;
            btn_remove.BackColor = appColor;
            btn_save.BackColor = appColor;
            //db_categoriesDataGridView.ColumnHeadersDefaultCellStyle.BackColor = appColor;
            categoriesDataGridView.ColumnHeadersDefaultCellStyle.BackColor = appColor;
        }

        private void pcb_searchID_Click(object sender, EventArgs e)
        {
            if (txt_categorieid.Text.Trim() == "")
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
            if (txt_categoriename.Text.Trim() == "")
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
            if (categoriesDataGridView != null)
            {
                if (categoriesDataGridView.CurrentCell != null)
                {
                    int rowindex = categoriesDataGridView.CurrentCell.RowIndex;

                    long CategoryID = long.Parse(categoriesDataGridView.Rows[rowindex].Cells["Id"].Value.ToString());
                    string CategoryName = categoriesDataGridView.Rows[rowindex].Cells["CategoryName"].Value.ToString();

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

            int rowindex = categoriesDataGridView.CurrentCell.RowIndex;

            long CategoryID = long.Parse(categoriesDataGridView.Rows[rowindex].Cells["Id"].Value.ToString());
            string CategoryName = categoriesDataGridView.Rows[rowindex].Cells["CategoryName"].Value.ToString();

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
            {
                e.SuppressKeyPress = true;
                btn_save.PerformClick();
            }
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

        private void db_categoriesDataGridView_ColumnHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            categoriesDataGridView.DataSource = new Methods().DataGridToDataTable(categoriesDataGridView);

            categoriesDataGridView.Sort(categoriesDataGridView.Columns[e.ColumnIndex], ListSortDirection.Descending);
        }

        private void db_categoriesDataGridView_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            categoriesDataGridView.DataSource = new Methods().DataGridToDataTable(categoriesDataGridView);

            categoriesDataGridView.Sort(categoriesDataGridView.Columns[e.ColumnIndex], ListSortDirection.Ascending);
        }

        private void categoriesDataGridView_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                int cellColumnIndex = categoriesDataGridView.CurrentCell.ColumnIndex;
                int cellRowIndex = categoriesDataGridView.CurrentCell.RowIndex;

                int CellX = categoriesDataGridView.GetCellDisplayRectangle(cellColumnIndex, cellRowIndex, false).Left;
                int CellY = categoriesDataGridView.GetCellDisplayRectangle(cellColumnIndex, cellRowIndex, false).Top;

                ContextMenuSelectedCell = (sender as DataGridView).Rows[cellRowIndex].Cells[cellColumnIndex];
                
                if (ContextMenuSelectedCell != null)
                {
                    contextMenu.Show(categoriesDataGridView, new Point(CellX, CellY));
                }
            }
        }
    }
}
