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

        private async void btn_save_Click(object sender, EventArgs e)
        {
            Control FocusedObject = (Control)sender;

            Logger.Log("user is trying to save  a category",
                System.Reflection.MethodInfo.GetCurrentMethod().Name, this.Name, Logger.INFO);

            if (txt_categoriename.Text.Trim() != "")
            {
                if (txt_storageNameSearch.SelectedIndex != -1)
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
                                Name = txt_categoriename.Text,
                                StorageId = int.Parse(txt_storageNameSearch.SelectedValue.ToString()),
                                StorageName = txt_storageNameSearch.Text
                            };
                            await Classes.DataAccess.Categories.UpdateCategory(category);


                            LoadDataGrid(Classes.DataAccess.Categories.GetCategoryParameter("Id", "" + category.Id));
                        }
                        ResetTextBoxes(true, false);

                        EditMode(false);
                    }
                    else
                    {
                        Logger.Log($"user is trying to add category: {txt_categoriename.Text}",
                            System.Reflection.MethodInfo.GetCurrentMethod().Name, this.Name, Logger.INFO);

                        string MsgResponse = $"هل تريد ان تحفظ {txt_categoriename.Text} ";

                        var CategoryResult = Classes.DataAccess.Categories.GetCategoryParameter("Name", txt_categoriename.Text);

                        if (CategoryResult.Count > 0)
                            MsgResponse += "لانه يوجد تصنيف بهذا الاسم";

                        if (MessageBox.Show(MsgResponse, "انتظر",
                            MessageBoxButtons.YesNo,
                            MessageBoxIcon.Information) == DialogResult.Yes)
                        {
                            CategoryModel category = new CategoryModel
                            {
                                Name = txt_categoriename.Text,
                                StorageId = int.Parse(txt_storageNameSearch.SelectedValue.ToString()),
                                StorageName = txt_storageNameSearch.Text
                            };
                            await Classes.DataAccess.Categories.SaveCategory(category);

                            LoadDataGrid(Classes.DataAccess.Categories.LoadCategories());

                            ResetTextBoxes(true, false);

                            Logger.Log($"user added category: {category.Name}",
                                System.Reflection.MethodInfo.GetCurrentMethod().Name, this.Name, Logger.INFO);
                        }
                        else
                            Logger.Log($"user didnt add category: {txt_categoriename.Text}",
                                System.Reflection.MethodInfo.GetCurrentMethod().Name, this.Name, Logger.INFO);
                    }
                }
                else
                {
                    MessageBox.Show("برجاء اختيار المخزن", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
                MessageBox.Show("برجاء ادخال اسم التصنيف", "حاول مره أخرى", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void ResetTextBoxes(bool ResetCategories, bool ResetStorages)
        {
            if (ResetStorages)
            {
                txt_storageName.Text = "";
            }

            if (ResetCategories)
            {
                txt_categoriename.Text = "";
                txt_categorieid.Text = "";
            }

            txt_storageNameSearch.SelectedIndex = -1;
        }

        private void LoadDataGrid(List<CategoryModel> Categories)
        {
            categoriesDataGridView.DataSource = null;
            categoriesDataGridView.DataSource = Categories;

            categoriesDataGridView.Columns["Id"].HeaderText = "رقم التصنيف";
            categoriesDataGridView.Columns["CategoryName"].HeaderText = "اسم التصنيف";
            categoriesDataGridView.Columns["StorageId"].HeaderText = "الرقم التعريفي للمخزن";
            categoriesDataGridView.Columns["StorageName"].HeaderText = "اسم المخزن";
            categoriesDataGridView.Columns["CreationDate"].HeaderText = "يوم اضافه التصنيف";
            categoriesDataGridView.Columns["CreationDate"].DefaultCellStyle.Format = "yyyy/MM/dd tt HH:mm:ss";

            categoriesDataGridView.AutoResizeColumns();
            categoriesDataGridView.Columns["CreationDate"].Width += 5;
        }

        private void Categories_Load(object sender, EventArgs e)
        {
            SetColors(Properties.Settings.Default.AppColor);

            LoadDataGrid(Classes.DataAccess.Categories.LoadCategories());

            RefreshComboBoxes();

            contextMenu = Methods.SetupContextMenuCopy(contextMenu, MenuItemCopyOption_Click);
        }

        internal void RefreshComboBoxes()
        {
            ComboBox[] AllComboBoxes =
            {
                txt_storageNameSearch,
                txt_storageNameEdit,
            };

            List<StorageModel> AllStoragesData;

            foreach (ComboBox comboBox in AllComboBoxes)
            {
                AllStoragesData = Classes.DataAccess.Storage.LoadStorages(false);
                comboBox.DataSource = null;
                comboBox.DataSource = AllStoragesData;
                comboBox.ValueMember = "Id";
                comboBox.DisplayMember = "Name";
                comboBox.SelectedIndex = -1;
            }
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
            btn_categoryEdit.BackColor = appColor;
            btn_CategoryRemove.BackColor = appColor;
            btn_saveCategory.BackColor = appColor;
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

        private async void btn_remove_Click(object sender, EventArgs e)
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
                        await Classes.DataAccess.Categories.RemoveCategory(CategoryID);
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
                btn_categoryEdit.BackColor = Color.Silver;
                btn_CategoryRemove.BackColor = Color.Silver;
            }
            else
            {
                btn_categoryEdit.BackColor = Properties.Settings.Default.AppColor;
                btn_CategoryRemove.BackColor = Properties.Settings.Default.AppColor;
            }

            txt_storageName.Enabled = !State;
            txt_storageNameEdit.Enabled = !State;
            txt_categorieid.Enabled = !State;

            btn_saveStorage.Enabled = !State;
            btn_storageDelete.Enabled = !State;
            btn_storageEdit.Enabled = !State;
            btn_categoryEdit.Enabled = !State;
            btn_CategoryRemove.Enabled = !State;
            btn_exportPDF.Enabled = !State;

            pcb_searchID.Enabled = !State;
            pcb_searchName.Enabled = !State;
        }

        private void txt_category_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                btn_saveCategory.PerformClick();
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

        private async void btn_exportPDF_Click(object sender, EventArgs e)
        {
            await Methods.ExportDGVtoPDF(categoriesDataGridView, "الاصناف");
        }

        private void categoriesDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void categoriesBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void txt_categorieid_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_categoriename_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_storageName_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private async void btn_saveStorage_Click(object sender, EventArgs e)
        {
            if (txt_storageName.Text.Trim() != "")
            {
                string MsgResponse = $"هل تريد ان تحفظ {txt_storageName.Text} ";

                var CategoryResult = Classes.DataAccess.Storage.GetStorageParameter("Name", txt_storageName.Text);

                if (CategoryResult.Count > 0)
                    MsgResponse += "لانه يوجد تصنيف بهذا الاسم";

                if (MessageBox.Show(MsgResponse, "انتظر",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    StorageModel storage = new StorageModel
                    {
                        Name = txt_storageName.Text,
                    };
                    await Classes.DataAccess.Storage.SaveStorage(storage);

                    ResetTextBoxes(false, true);

                    RefreshComboBoxes();

                    Logger.Log($"user added storage: {storage.Name}",
                        System.Reflection.MethodInfo.GetCurrentMethod().Name, this.Name, Logger.INFO);
                }
                else
                    Logger.Log($"user didnt add storage: {txt_storageName.Text}",
                        System.Reflection.MethodInfo.GetCurrentMethod().Name, this.Name, Logger.INFO);
            }
            else
                MessageBox.Show("برجاء ادخال اسم المخزن", "حاول مره أخرى", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private async void btn_storageDelete_Click(object sender, EventArgs e)
        {
            if (txt_storageNameEdit.SelectedIndex != -1)
            {
                if (MessageBox.Show($"هل انت متأكد من مسح {txt_storageName.Text} ", "انتظر",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    await Classes.DataAccess.Storage.RemoveStorage(int.Parse(txt_storageNameEdit.SelectedValue.ToString()));
                    RefreshComboBoxes();
                }
            }
            else
                MessageBox.Show("برجاءاختيار مخزن للحذف", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btn_storageEdit_Click(object sender, EventArgs e)
        {
            if (txt_storageNameEdit.SelectedIndex != -1)
            {
                string StorageNameEditResult = Microsoft.VisualBasic.Interaction.InputBox("",
                    $"تعديل اسم المخزن {txt_storageNameEdit.Text}", txt_storageNameEdit.Text);

                if (StorageNameEditResult != "")
                {
                    List<StorageModel> StorageSearch =
                        Classes.DataAccess.Storage.GetStorageParameter("Id", txt_storageNameEdit.SelectedValue.ToString());

                    if (StorageSearch.Count > 0)
                    {
                        StorageSearch[0].Name = StorageNameEditResult;
                        Classes.DataAccess.Storage.UpdateStorage(StorageSearch[0]);
                        RefreshComboBoxes();
                        MessageBox.Show("تم التعديل", "عمليه ناجحه", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("لا يمكن تعديل اسم المخزن لانه غير موجود", "حدث خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("test");
                }
            }
            else
                MessageBox.Show("برجاءاختيار مخزن للتعديل", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void txt_storageNameEdit_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
