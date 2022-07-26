using POSWarehouse.Classes;
using POSWarehouse.Classes.Models;
using POSWarehouse.Forms;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace POSWarehouse.UserControls
{
    public partial class BillsEdit : UserControl
    {
        public BillsEdit()
        {
            InitializeComponent();
        }

        private ContextMenu contextMenu = new ContextMenu();
        private DataGridViewCell ContextMenuSelectedCell;
        private readonly IDictionary<int, string> ProductSearchType = new Dictionary<int, string>();
        private readonly string[] ProductSearchString = { "اسم المنتج", "الباركود", "الرقم التعريفي" };
        private List<long> DeletedProducts = new List<long>();
        private long ShownInvoiceNumber;

        private void MenuItemCopyOption_Click(Object sender, EventArgs e)
        {
            string CellText = db_probillsDataGridView.Rows[ContextMenuSelectedCell.RowIndex].
                Cells[ContextMenuSelectedCell.ColumnIndex].Value.ToString();
            Clipboard.SetText(CellText);
        }

        public void SetFocusOnInvoiceNumber()
        {
            txt_invoiceno.Focus();
        }

        private void pcb_search_MouseEnter(object sender, EventArgs e)
        {
            Control FocusedObject = (Control)sender;
            FocusedObject.BackColor = Properties.Settings.Default.AppColor;
        }

        private void pcb_search_MouseLeave(object sender, EventArgs e)
        {
            Control FocusedObject = (Control)sender;
            FocusedObject.BackColor = Color.Gainsboro;
        }

        private void BillsEdit_Load(object sender, EventArgs e)
        {
            SetColors(Properties.Settings.Default.AppColor);
            //dtp_invoicedate.Text = DateTime.Now.ToString();
            //dtp_invoicedate.CustomFormat = DateTime.Now.ToString("dd/MM/yyyy hh:mm:ss tt", new System.Globalization.CultureInfo("ar-AE"));

            contextMenu = Methods.SetupContextMenuCopy(contextMenu, MenuItemCopyOption_Click);

            SetComboBox(ProductSearchString, ProductSearchType, txt_searchProductType);

            ResizeAndRenameCoulmns();
        }

        private void SetComboBox(string[] SearchString, IDictionary<int, string> SearchType, ComboBox SearchComboBox)
        {
            for (int i = 0; i < SearchString.Length; i++)
                SearchType.Add(i, SearchString[i]);

            SearchComboBox.DataSource = null;
            SearchComboBox.DataSource = new BindingSource(SearchType, null);
            SearchComboBox.DisplayMember = "Value";
            SearchComboBox.ValueMember = "Key";
            SearchComboBox.SelectedIndex = -1;
        }

        private void SetColors(Color appColor)
        {
            Label[] AllLabels = {
                label1,
                label3,
                label4,
                label5,
                label9,
            };

            Button[] AllButtons = {
                btn_addToBill,
                btn_removeFromBill
            };

            foreach (Label label in AllLabels)
                label.ForeColor = appColor;

            foreach (Button button in AllButtons)
                button.BackColor = appColor;

            db_probillsDataGridView.ColumnHeadersDefaultCellStyle.BackColor = appColor;
        }

        private void btn_removeFromBill_Click(object sender, EventArgs e)
        {
            if (db_probillsDataGridView.DataSource != null && db_probillsDataGridView.CurrentCell != null)
            {
                int rowindex = db_probillsDataGridView.CurrentCell.RowIndex;
                long InvoiceID = long.Parse(db_probillsDataGridView.Rows[rowindex].Cells["Id"].Value.ToString());
                long ProductId = long.Parse(db_probillsDataGridView.Rows[rowindex].Cells["ProductId"].Value.ToString());
                string ProductName = db_probillsDataGridView.Rows[rowindex].Cells["ProductName_"].Value.ToString();

                if (MessageBox.Show($"هل تريد انت تحذف من السله {ProductName}", "انتظر",
                           MessageBoxButtons.YesNo,
                           MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    DeletedProducts.Add(ProductId);

                    List<InvoiceModel> datasource = (List<InvoiceModel>)db_probillsDataGridView.DataSource;
                    db_probillsDataGridView.DataSource = null;
                    datasource.Remove(datasource.Find(invoice => invoice.Id == InvoiceID));
                    db_probillsDataGridView.DataSource = datasource;
                    ResizeAndRenameCoulmns();
                    CalculateGrandTotal();
                }
            }
            else
                new Notification().ShowAlert($"رجاء اختيار منتج أولا قبل الحذف", Notification.EnmType.Error);
        }

        private void btn_addToBill_Click(object sender, EventArgs e)
        {

        }

        private async void db_probillsDataGridView_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            //db_probillsDataGridView.DataSource = new Methods().DataGridToDataTable(db_probillsDataGridView);

            //db_probillsDataGridView.Sort(db_probillsDataGridView.Columns[e.ColumnIndex], ListSortDirection.Ascending);

            System.Data.DataTable data = await new Methods().DataGridToDataTable(db_probillsDataGridView);

            data.DefaultView.Sort = $"{db_probillsDataGridView.Columns[e.ColumnIndex].Name} ASC";

            db_probillsDataGridView.DataSource = new BindingSource(data, null);
        }

        private async void db_probillsDataGridView_ColumnHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            //db_probillsDataGridView.DataSource = new Methods().DataGridToDataTable(db_probillsDataGridView);

            //db_probillsDataGridView.Sort(db_probillsDataGridView.Columns[e.ColumnIndex], ListSortDirection.Descending);

            System.Data.DataTable data = await new Methods().DataGridToDataTable(db_probillsDataGridView);

            data.DefaultView.Sort = $"{db_probillsDataGridView.Columns[e.ColumnIndex].Name} DESC";

            db_probillsDataGridView.DataSource = new BindingSource(data, null);
        }

        private void db_probillsDataGridView_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                int cellColumnIndex = db_probillsDataGridView.CurrentCell.ColumnIndex;
                int cellRowIndex = db_probillsDataGridView.CurrentCell.RowIndex;

                int CellX = db_probillsDataGridView.GetCellDisplayRectangle(cellColumnIndex, cellRowIndex, false).Left;
                int CellY = db_probillsDataGridView.GetCellDisplayRectangle(cellColumnIndex, cellRowIndex, false).Top;

                ContextMenuSelectedCell = (sender as DataGridView).Rows[cellRowIndex].Cells[cellColumnIndex];

                if (ContextMenuSelectedCell != null)
                {
                    contextMenu.Show(db_probillsDataGridView, new Point(CellX, CellY));
                }
            }
        }

        private void pcb_searchProduct_Click(object sender, EventArgs e)
        {
            if (txt_searchProductType.SelectedIndex != -1)
            {
                if (txt_searchProductType.Text == ProductSearchType[0].ToString())
                {
                    List<ProductModel> SearchedProducts = Classes.DataAccess.Products.GetProductLikeParameter("Name",
                        txt_searchProduct.Text);

                    if (SearchedProducts.Count > 0)
                    {
                        FillProductComboBox(txt_searchedProductName, SearchedProducts, "Id", "Name");
                    }
                    else
                        new Notification().ShowAlert($"لا يوجد منتج بهذه البيانات", Notification.EnmType.Error);
                }

                else if (txt_searchProductType.Text == ProductSearchType[1].ToString())
                {
                    List<ProductModel> SearchedProducts = Classes.DataAccess.Products.GetProductParameter("BarCode",
                        txt_searchProduct.Text);

                    if (SearchedProducts.Count > 0)
                    {
                        FillProductComboBox(txt_searchedProductName, SearchedProducts, "Id", "Name");
                    }
                    else
                        new Notification().ShowAlert($"لا يوجد منتج بهذه البيانات", Notification.EnmType.Error);
                }

                else if (txt_searchProductType.Text == ProductSearchType[2].ToString())
                {
                    List<ProductModel> SearchedProducts = Classes.DataAccess.Products.GetProductParameter("Id",
                        txt_searchProduct.Text);

                    if (SearchedProducts.Count > 0)
                    {
                        FillProductComboBox(txt_searchedProductName, SearchedProducts, "Id", "Name");
                    }
                    else
                        new Notification().ShowAlert($"لا يوجد منتج بهذه البيانات", Notification.EnmType.Error);
                }
            }
            else
                new Notification().ShowAlert($"برجاء اختيار نوع البحث اولا", Notification.EnmType.Error);
        }

        private void FillProductComboBox(ComboBox comboBox, List<ProductModel> SearchedProducts, string Value, string Display)
        {
            comboBox.DataSource = null;
            comboBox.Items.Clear();
            comboBox.DataSource = new BindingSource(SearchedProducts, null);
            comboBox.ValueMember = Value;
            comboBox.DisplayMember = Display;


        }

        private void pcb_searchInvoiceNo_Click(object sender, EventArgs e)
        {
            if (txt_invoiceno.Text.Trim() != "")
            {
                List<InvoiceModel> searchedInvoice = Classes.DataAccess.Invoices.GetInvoice(long.Parse(txt_invoiceno.Text));

                if (searchedInvoice.Count > 0)
                {
                    ShownInvoiceNumber = searchedInvoice[0].InvoiceNumber;

                    db_probillsDataGridView.DataSource = searchedInvoice;
                    ResizeAndRenameCoulmns();
                    CalculateGrandTotal();
                }
                else
                    new Notification().ShowAlert($"لا يوجد فاتورة بهذه البيانات", Notification.EnmType.Error);
            }
            else
                new Notification().ShowAlert($"برجاء كتبه رقم الفاتورة اولا", Notification.EnmType.Error);
        }

        private void CalculateGrandTotal()
        {
            if (db_probillsDataGridView.DataSource != null)
            {
                List<InvoiceModel> CartDataSource = (List<InvoiceModel>)db_probillsDataGridView.DataSource;

                decimal sum = 0;
                foreach (InvoiceModel product in CartDataSource)
                {
                    sum += decimal.Parse("" + product.PriceTotal);
                }

                txt_grandtotal.Text = "" + sum;
            }
        }

        private void AddDataGrid(InvoiceModel invoice)
        {
            if (db_probillsDataGridView.DataSource != null)
            {
                List<InvoiceModel> datasource = (List<InvoiceModel>)db_probillsDataGridView.DataSource;
                db_probillsDataGridView.DataSource = null;
                datasource.Add(invoice);
                db_probillsDataGridView.DataSource = datasource;
                ResizeAndRenameCoulmns();
            }
            else
            {
                List<InvoiceModel> InvoiceList = new List<InvoiceModel>
                {
                    invoice
                };
                db_probillsDataGridView.DataSource = InvoiceList;
                ResizeAndRenameCoulmns();
            }
        }

        private void ResizeAndRenameCoulmns()
        {
            db_probillsDataGridView.Columns["CreationDate"].HeaderText = "يوم اضافه المنتج";
            db_probillsDataGridView.Columns["CustomerName"].HeaderText = "اسم العميل";
            db_probillsDataGridView.Columns["ProductID"].HeaderText = "الرقم التعريفي للمنتج";
            db_probillsDataGridView.Columns["ProductBarCode"].HeaderText = "باركود المنتج";
            db_probillsDataGridView.Columns["ProductName_"].HeaderText = "اسم المنتج";
            db_probillsDataGridView.Columns["ProductQuantity"].HeaderText = "كميه المنتج";
            db_probillsDataGridView.Columns["ProductPrice"].HeaderText = "سعر المنتج";
            db_probillsDataGridView.Columns["PriceTotal"].HeaderText = "السعر الكلي";
            db_probillsDataGridView.Columns["InvoiceNumber"].HeaderText = "رقم الفاتورة";

            db_probillsDataGridView.Columns["Id"].Visible = false;
            db_probillsDataGridView.Columns["CustomerId"].Visible = false;
            db_probillsDataGridView.Columns["CustomerAddress"].Visible = false;
            db_probillsDataGridView.Columns["CustomerContact"].Visible = false;

            db_probillsDataGridView.AutoResizeColumns();
            db_probillsDataGridView.Columns["CreationDate"].Width += 5;
        }

        private void txt_searchedProductName_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (txt_searchedProductName.SelectedIndex != -1 && txt_searchedProductName.DataSource != null &&
                txt_searchedProductName.SelectedValue.GetType() == typeof(long))
            {
                List<ProductModel> SearchedProducts = Classes.DataAccess.Products.GetProductLikeParameter("Id",
                        txt_searchedProductName.SelectedValue.ToString());

                if (SearchedProducts.Count != 0)
                {
                    txt_searchedProductBarCode.Text = "" + SearchedProducts[0].BarCode;
                }
            }
        }

        private async void btn_save_Click(object sender, EventArgs e)
        {
            if (db_probillsDataGridView.DataSource != null && db_probillsDataGridView.CurrentCell != null)
            {
                foreach (long ProductId in DeletedProducts)
                {
                    List<InvoiceModel> DeletedProductFromInvoice = Classes.DataAccess.Invoices.GetInvoiceTwoParameter
                        ("ProductID", "" + ProductId, "InvoiceNumber", "" + ShownInvoiceNumber);

                    if (DeletedProductFromInvoice.Count > 0)
                    {
                        double SearchedInvoiceProductQuantity = DeletedProductFromInvoice[0].ProductQuantity;
                        long SearchedInvoiceProductId = DeletedProductFromInvoice[0].ProductID;

                        List<ProductModel> SearchedProduct = Classes.DataAccess.Products.GetProductParameter("Id", "" + SearchedInvoiceProductId);

                        if (SearchedProduct.Count > 0)
                        {
                            ProductModel UpdatedProduct = new ProductModel()
                            {
                                Id = SearchedProduct[0].Id,
                                BarCode = SearchedProduct[0].BarCode,
                                CategoryID = SearchedProduct[0].CategoryID,
                                CategoryName = SearchedProduct[0].CategoryName,
                                CreationDate = SearchedProduct[0].CreationDate,
                                Description = SearchedProduct[0].Description,
                                Name = SearchedProduct[0].Name,
                                PriceModificationDate = SearchedProduct[0].PriceModificationDate,
                                Quantity = SearchedProduct[0].Quantity + SearchedInvoiceProductQuantity,
                                QuantityMinimum = SearchedProduct[0].QuantityMinimum
                            };

                            await Classes.DataAccess.Products.UpdateProduct(UpdatedProduct);

                            await Classes.DataAccess.Invoices.RemoveProductFromInvoice(ProductId, ShownInvoiceNumber);

                        }
                    }
                }
            }
            else
            {
                new Notification().ShowAlert($"لا يوجد منتجات للحفظ", Notification.EnmType.Error);
            }
        }
    }
}
