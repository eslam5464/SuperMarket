using SuperMarket.Classes;
using SuperMarket.Classes.Models;
using SuperMarket.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace SuperMarket.UserControls
{
    public partial class Billing : UserControl
    {
        public Billing()
        {
            InitializeComponent();
        }
        private static bool UsedBarCodeSearch = false;

        private void ub_billing_Load(object sender, EventArgs e)
        {
            SetColors(Properties.Settings.Default.AppColor);

            txt_invoiceno.Text = Methods.GetUniqueInvoiceID().ToString();

            pic_barcode.BackgroundImage = new Methods().CreateBarcodeImage(txt_invoiceno.Text, pic_barcode.Width, pic_barcode.Height);
            cb_defaultCST.Checked = true;
        }

        public void setFocusForBarcode()
        {
            txt_productBarCode.Focus();
        }



        private void SetColors(Color appColor)
        {
            Label[] AllLabels = {
                label1,
                label2,
                label3,
                label4,
                label5,
                label6,
                label7,
                label8,
                label9,
                label10,
                label11,
                label12,
                label13,
            };

            Button[] AllButtons =
            {
                btn_addToCart,
                btn_removeFromCart,
                btn_removeOrder,
                btn_save,
            };

            foreach (Label label in AllLabels)
                label.ForeColor = appColor;

            foreach (Button button in AllButtons)
                button.BackColor = appColor;

            db_procardsDataGridView.ColumnHeadersDefaultCellStyle.BackColor = appColor;
        }

        private void btn_print_Click(object sender, EventArgs e)
        {
            new Invoice().ShowDialog();
        }

        private void txt_billing_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Return)
            {
                e.SuppressKeyPress = true;

                if ((Control)sender == txt_productBarCode && txt_productBarCode.Text.Trim() != "")
                {
                    if (UsedBarCodeSearch)
                    {
                        btn_addToCart.PerformClick();
                        UsedBarCodeSearch = false;

                        txt_productBarCode.Focus();

                        ResetTextBoxes(false, false, false, false);
                    }

                    else
                    {
                        txt_prodSearch.DataSource = null;
                        txt_prodSearch.Items.Clear();

                        List<ProductModel> productSearch =
                            Classes.DataAccess.Products.GetProductLikeParameter("BarCode", txt_productBarCode.Text);

                        txt_prodSearch.DataSource = productSearch;
                        txt_prodSearch.ValueMember = "Id";
                        txt_prodSearch.DisplayMember = "Name";

                        UsedBarCodeSearch = true;
                    }

                }
                if ((Control)sender == txt_productprice || (Control)sender == txt_productquantity || (Control)sender == txt_totalprice)
                {
                    btn_addToCart.PerformClick();

                    txt_productBarCode.Focus();

                    UsedBarCodeSearch = false;
                    ResetTextBoxes(false, false, false, false);
                }

                if (txt_prodSearch.SelectedIndex != -1 && txt_productBarCode.Text.Trim() != "")
                {
                    //List<ProductModel> productSearch = Classes.DataAccess.Products.GetProductParameter("Id", txt_prodSearch.SelectedValue.ToString());

                    UsedBarCodeSearch = true;

                    //btn_addToCart.PerformClick();
                }
            }
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

        private void btn_addtocard_Click(object sender, EventArgs e)
        {
            if (txt_invoiceno.Text.Trim() == "" || txt_cstID.Text.Trim() == "" || txt_cstID.Text.Trim() == "" || txt_cstID.Text.Trim() == "" ||
                txt_cstID.Text.Trim() == "" || txt_cstID.Text.Trim() == "" || txt_cstID.Text.Trim() == "" || txt_cstID.Text.Trim() == "" || txt_cstID.Text.Trim() == "")
            {
                MessageBox.Show("اكمال البيانات لادخال المنتج إلى السله", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                List<CustomerModel> CstSearch = Classes.DataAccess.Customers.GetCustomerWithID(int.Parse(txt_cstID.Text));
                if (CstSearch.Count == 0)
                {
                    MessageBox.Show("لا يوجد عميل بهذه البيانات", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (txt_prodSearch.SelectedIndex == -1)
                {

                    MessageBox.Show("برجاء التأكد من بيانات المنتج و اختياره في ناتج البحث", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    txt_invoiceno.Enabled = false;

                    string cst_id = txt_cstID.Text, cst_name = txt_cstName.Text, cst_address = txt_cstAddress.Text,
                        cst_contact = txt_cstContact.Text;

                    string product_id = txt_prodSearch.SelectedValue.ToString(), product_name = txt_productName.Text,
                        product_barCode = txt_productBarCode.Text, product_quantity = txt_productquantity.Text,
                        product_price = txt_productprice.Text;

                    string priceTotal = txt_totalprice.Text;

                    string DateTimeNow = DateTime.Now.ToString();
                    InvoiceModel invoice = new InvoiceModel
                    {
                        InvoiceNumber = long.Parse(txt_invoiceno.Text),
                        CustomerId = long.Parse(cst_id),
                        CustomerName = cst_name,
                        CustomerContact = cst_contact,
                        CustomerAddress = cst_address,
                        ProductID = long.Parse(product_id),
                        ProductBarCode = long.Parse(product_barCode),
                        ProductName = product_name,
                        ProductQuantity = double.Parse(product_quantity),
                        ProductPrice = decimal.Parse(product_price),
                        PriceTotal = decimal.Parse(priceTotal),
                        CreationDate = DateTime.Parse(DateTimeNow)
                    };

                    List<ProductModel> ProductSearch = Classes.DataAccess.Products.GetProductParameter("Id", product_id);

                    if (ProductSearch.Count != 0)
                    {
                        double QuantityDiff = ProductSearch[0].Quantity - double.Parse(product_quantity);

                        if (QuantityDiff <= 0)
                        {
                            if (MessageBox.Show($"لا يوجد كمية كافيه من هذا المنتج .. هل تريد الاستمرار؟", "انتظر",
                                MessageBoxButtons.YesNo,
                                MessageBoxIcon.Information) == DialogResult.Yes)
                            {
                                UpdateDataGrid(invoice);

                                CalculateGrandTotal();

                                ResetTextBoxes(false, false, false, false);

                                txt_productBarCode.Focus();
                            }
                            else
                                Console.WriteLine("test");
                        }
                        else
                        {
                            UpdateDataGrid(invoice);

                            CalculateGrandTotal();

                            ResetTextBoxes(false, false, false, false);

                            txt_productBarCode.Focus();
                        }
                    }
                }
            }
        }

        private void CalculateGrandTotal()
        {
            if (db_procardsDataGridView.DataSource != null)
            {
                List<InvoiceModel> CartDataSource = (List<InvoiceModel>)db_procardsDataGridView.DataSource;

                decimal sum = 0;
                foreach (InvoiceModel product in CartDataSource)
                {
                    sum += decimal.Parse("" + product.PriceTotal);
                }

                txt_grandtotal.Text = "" + sum;
            }
        }

        private void UpdateDataGrid(InvoiceModel invoice)
        {
            if (db_procardsDataGridView.DataSource != null)
            {
                List<InvoiceModel> datasource = (List<InvoiceModel>)db_procardsDataGridView.DataSource;
                db_procardsDataGridView.DataSource = null;
                datasource.Add(invoice);
                db_procardsDataGridView.DataSource = datasource;
                ResizeAndRenameCoulmns();
            }
            else
            {
                dtp_invoicedate.Value = DateTime.Now;
                List<InvoiceModel> InvoiceList = new List<InvoiceModel>
                {
                    invoice
                };
                db_procardsDataGridView.DataSource = InvoiceList;
                ResizeAndRenameCoulmns();
            }
        }

        private void ResizeAndRenameCoulmns()
        {
            db_procardsDataGridView.Columns["CreationDate"].HeaderText = "يوم اضافه المنتج";
            db_procardsDataGridView.Columns["CustomerName"].HeaderText = "اسم العميل";
            db_procardsDataGridView.Columns["ProductBarCode"].HeaderText = "باركود المنتج";
            db_procardsDataGridView.Columns["ProductName"].HeaderText = "اسم المنتج";
            db_procardsDataGridView.Columns["ProductQuantity"].HeaderText = "كميه المنتج";
            db_procardsDataGridView.Columns["ProductPrice"].HeaderText = "سعر المنتج";
            db_procardsDataGridView.Columns["PriceTotal"].HeaderText = "السعر الكلي";
            db_procardsDataGridView.Columns["InvoiceNumber"].HeaderText = "رقم الفاتورة";

            db_procardsDataGridView.Columns["Id"].Visible = false;
            db_procardsDataGridView.Columns["ProductID"].Visible = false;
            db_procardsDataGridView.Columns["CustomerId"].Visible = false;
            db_procardsDataGridView.Columns["CustomerAddress"].Visible = false;
            db_procardsDataGridView.Columns["CustomerContact"].Visible = false;

            db_procardsDataGridView.AutoResizeColumns();
            db_procardsDataGridView.Columns["CreationDate"].Width += 5;
        }

        private void pcb_searchProdName_Click(object sender, EventArgs e)
        {
            if (txt_productName.Text.Trim() == "")
                MessageBox.Show("برجاء كتابه اسم المنتج قبل البحث", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);

            else
            {
                txt_prodSearch.DataSource = null;
                txt_prodSearch.Items.Clear();

                List<ProductModel> productSearch = Classes.DataAccess.Products.GetProductLikeParameter("Name", txt_productName.Text);

                DataTable dataProductSearch = Methods.ListToDataTable(productSearch);

                txt_prodSearch.DataSource = dataProductSearch;
                txt_prodSearch.ValueMember = "Id";
                txt_prodSearch.DisplayMember = "Name";
            }
        }

        private void txt_prodSearch_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (txt_prodSearch.SelectedIndex != -1 && txt_prodSearch.DataSource != null)
            {
                List<ProductModel> productSearch = Classes.DataAccess.Products.GetProductParameter("Id", txt_prodSearch.SelectedValue.ToString());

                if (productSearch.Count != 0)
                {
                    txt_productprice.Text = "" + productSearch[0].Price;
                    txt_productBarCode.Text = "" + productSearch[0].BarCode;
                    txt_productName.Text = productSearch[0].Name;
                    txt_productquantity.Text = "" + 1;

                    UsedBarCodeSearch = true;
                }
            }
        }

        private void txt_productprice_TextChanged(object sender, EventArgs e)
        {
            if (txt_productquantity.Text.Trim() != "" && txt_productquantity.Text.Trim() != "." &&
                txt_productprice.Text.Trim() != "" && txt_productprice.Text.Trim() != ".")
            {
                double total_price = double.Parse(txt_productquantity.Text) * double.Parse(txt_productprice.Text);
                txt_totalprice.Text = "" + Math.Round(total_price + 0.005, 2);
            }
        }

        private void txt_productquantity_TextChanged(object sender, EventArgs e)
        {
            if (txt_productquantity.Text.Trim() != "" && txt_productquantity.Text.Trim() != "." &&
                txt_productprice.Text.Trim() != "" && txt_productprice.Text.Trim() != ".")
            {
                double total_price = double.Parse(txt_productquantity.Text) * double.Parse(txt_productprice.Text);
                txt_totalprice.Text = "" + Math.Round(total_price + 0.005, 2);
            }
        }

        private void txt_grandtotal_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void pcb_getInvoiceID_Click(object sender, EventArgs e)
        {
            if (db_procardsDataGridView.DataSource == null)
            {
                string UniqueInvoiceID = Methods.GetUniqueInvoiceID();

                List<InvoiceModel> InvoiceSearch = Classes.DataAccess.Invoices.LoadInvoice(UniqueInvoiceID);

                while (InvoiceSearch.Count != 0)
                {
                    UniqueInvoiceID = Methods.GetUniqueInvoiceID();
                    InvoiceSearch = Classes.DataAccess.Invoices.LoadInvoice(UniqueInvoiceID);
                }

                txt_invoiceno.Text = "" + UniqueInvoiceID;

                pic_barcode.BackgroundImage = new Methods().CreateBarcodeImage(UniqueInvoiceID, pic_barcode.Width, pic_barcode.Height);
            }
        }

        private void btn_remove_Click(object sender, EventArgs e)
        {

            if (db_procardsDataGridView.DataSource != null && db_procardsDataGridView.CurrentCell != null)
            {
                int rowindex = db_procardsDataGridView.CurrentCell.RowIndex;
                long InvoiceID = long.Parse(db_procardsDataGridView.Rows[rowindex].Cells["Id"].Value.ToString());
                long ProductId = long.Parse(db_procardsDataGridView.Rows[rowindex].Cells["ProductId"].Value.ToString());
                string ProductName = db_procardsDataGridView.Rows[rowindex].Cells["ProductName"].Value.ToString();
                string DateCreated = db_procardsDataGridView.Rows[rowindex].Cells["CreationDate"].Value.ToString();

                if (MessageBox.Show($"هل تريد انت تحذف من السله {ProductName}", "انتظر",
                           MessageBoxButtons.YesNo,
                           MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    List<InvoiceModel> datasource = (List<InvoiceModel>)db_procardsDataGridView.DataSource;
                    db_procardsDataGridView.DataSource = null;
                    datasource.Remove(datasource.Find(invoice => invoice.CreationDate == DateTime.Parse(DateCreated)));
                    db_procardsDataGridView.DataSource = datasource;
                    ResizeAndRenameCoulmns();
                }
            }
            else
                MessageBox.Show("رجاء اختيار منتج أولا قبل الحذف", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void LoadDataGrid(List<InvoiceModel> Invoice)
        {
            db_procardsDataGridView.DataSource = null;
            db_procardsDataGridView.DataSource = Invoice;

            ResizeAndRenameCoulmns();
            CalculateGrandTotal();
        }

        private void btn_remove__Click(object sender, EventArgs e)
        {
            if (MessageBox.Show($"هل انت متأكد من ازالتك لجميع ما في العربه؟", "انتظر",
                           MessageBoxButtons.YesNo,
                           MessageBoxIcon.Information) == DialogResult.Yes)
            {
                ResetTextBoxes(true, true, true, true);
                db_procardsDataGridView.DataSource = null;
                txt_invoiceno.Enabled = true;
            }
        }

        private void ResetTextBoxes(bool ResetDate, bool ResetCST, bool ResetInvoice, bool ResetGrandTotal)
        {
            if (ResetCST)
            {
                txt_cstAddress.Text = "";
                txt_cstContact.Text = "";
                txt_cstID.Text = "";
                txt_cstName.Text = "";
            }

            if (ResetGrandTotal)
                txt_grandtotal.Text = "";

            if (ResetInvoice)
                txt_invoiceno.Text = "";

            txt_prodSearch.Text = "";
            txt_productBarCode.Text = "";
            txt_productName.Text = "";
            txt_productprice.Text = "";
            txt_productquantity.Text = "";

            txt_totalprice.Text = "";

            txt_prodSearch.SelectedIndex = -1;

            if (txt_prodSearch.Items.Count > 0)
            {
                txt_prodSearch.DataSource = null;
                txt_prodSearch.Items.Clear();
            }

            txt_invoiceno.Enabled = true;

            if (ResetDate)
                dtp_invoicedate.Refresh();
        }

        private void pcb_searchCstName_Click(object sender, EventArgs e)
        {
            if (txt_invoiceno.Text.Trim() == "")
                MessageBox.Show("برجاء كتابه اسم العميل", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                List<CustomerModel> CustomerSearch = Classes.DataAccess.Customers.GetCustomerParameter("Name", txt_invoiceno.Text);
                if (CustomerSearch.Count != 0)
                {
                    txt_cstAddress.Text = CustomerSearch[0].Address;
                    txt_cstContact.Text = CustomerSearch[0].ContactNo;
                    txt_cstID.Text = CustomerSearch[0].Id.ToString();
                    txt_cstName.Text = CustomerSearch[0].Name;
                }
            }
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            //int rowindex = db_procardsDataGridView.CurrentCell.RowIndex;
            //int InvoiceID = int.Parse(db_procardsDataGridView.Rows[rowindex].Cells["Id"].Value.ToString());
            //int ProductId = int.Parse(db_procardsDataGridView.Rows[rowindex].Cells["ProductId"].Value.ToString());
            //string ProductName = db_procardsDataGridView.Rows[rowindex].Cells["ProductName"].Value.ToString();
            //string DateCreated = db_procardsDataGridView.Rows[rowindex].Cells["CreationDate"].Value.ToString();
            if (db_procardsDataGridView.DataSource != null)
            {
                List<InvoiceModel> InvoiceSearch = Classes.DataAccess.Invoices.GetInvoice(int.Parse(txt_invoiceno.Text));
                if (InvoiceSearch.Count != 0)
                {//TO DO: finish searching for invoice
                    SetEditMode(true);
                }

            }
        }

        private void SetEditMode(bool State)
        {
            Button[] buttons = {
                btn_print,
                btn_removeOrder
            };

            TextBox[] textBoxes =
            {
                txt_invoiceno
            };

            if (State)
            {
                foreach (Button button in buttons)
                    button.BackColor = Color.Silver;
            }
            else
            {
                foreach (Button button in buttons)
                    button.BackColor = Properties.Settings.Default.AppColor;
            }

            foreach (Button button in buttons)
                button.Enabled = !State;

            foreach (TextBox textBox in textBoxes)
                textBox.Enabled = !State;
        }

        private void pcb_searchCstID_Click(object sender, EventArgs e)
        {
            if (txt_cstID.Text.Trim() == "")
                MessageBox.Show("برجاء كتابه اسم العميل", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                List<CustomerModel> CustomerSearch = Classes.DataAccess.Customers.GetCustomerParameter("Id", txt_cstID.Text);
                if (CustomerSearch.Count != 0)
                {
                    txt_cstAddress.Text = CustomerSearch[0].Address;
                    txt_cstContact.Text = CustomerSearch[0].ContactNo;
                    txt_cstID.Text = CustomerSearch[0].Id.ToString();
                    txt_cstName.Text = CustomerSearch[0].Name;
                }
            }
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            List<InvoiceModel> datasource = (List<InvoiceModel>)db_procardsDataGridView.DataSource;

            if (db_procardsDataGridView.DataSource != null)
            {
                if (datasource.Count != 0)
                {
                    if (MessageBox.Show($"هل انت متأكد من انتهائك من العربه؟", "انتظر",
                           MessageBoxButtons.YesNo,
                           MessageBoxIcon.Information) == DialogResult.Yes)
                    {
                        foreach (InvoiceModel invoice in datasource)
                        {
                            Classes.DataAccess.Invoices.AddToInvoice(invoice);
                            ProductModel ProductSearch = Classes.DataAccess.Products.GetProductParameter("Id", "" + invoice.ProductID).FirstOrDefault();
                            ProductSearch.Quantity -= invoice.ProductQuantity;
                            Classes.DataAccess.Products.UpdateProduct(ProductSearch);
                        }

                        OrderModel order = new OrderModel
                        {
                            InvoiceDate = dtp_invoicedate.Value,
                            InvoiceId = datasource[0].InvoiceNumber,
                            CustomerId = datasource[0].CustomerId,
                            CustomerName = datasource[0].CustomerName,
                            ContactNumber = datasource[0].CustomerContact,
                            Address = datasource[0].CustomerAddress,
                            GrandTotal = decimal.Parse(txt_grandtotal.Text),
                            CreatedByUserId = Main.LoggedUser.Id
                        };
                        Classes.DataAccess.Orders.AddOrder(order);

                        db_procardsDataGridView.DataSource = null;

                        ResetTextBoxes(true, false, true, true);

                        txt_invoiceno.Text = Methods.GetUniqueInvoiceID().ToString();
                    }

                }
                else
                    MessageBox.Show("لا يوجدأي اشياء في السله", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
                MessageBox.Show("لا يوجد بيانات للحفظ", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void cb_defaultCST_CheckedChanged(object sender, EventArgs e)
        {
            TextBox[] AllTextBoxes =
            {
                txt_cstContact,
                txt_cstAddress,
                txt_cstID,
                txt_cstName
            };

            if (cb_defaultCST.Checked)
            {
                List<CustomerModel> CustomerSearch = Classes.DataAccess.Customers.GetCustomerParameter("Name", "عميل افتراضي");

                if (CustomerSearch.Count == 0)
                {
                    CustomerModel customer = new CustomerModel()
                    {
                        Address = "لا يوجد",
                        ContactNo = "000000000",
                        Name = "عميل افتراضي"
                    };
                    Classes.DataAccess.Customers.SaveCustomer(customer);

                    CustomerSearch = Classes.DataAccess.Customers.GetCustomerParameter("Name", "عميل افتراضي");
                    if (CustomerSearch.Count != 0)
                    {
                        txt_cstAddress.Text = CustomerSearch[0].Address;
                        txt_cstContact.Text = CustomerSearch[0].ContactNo;
                        txt_cstID.Text = CustomerSearch[0].Id.ToString();
                        txt_cstName.Text = CustomerSearch[0].Name;

                        foreach (TextBox textBox in AllTextBoxes)
                            textBox.Enabled = false;
                    }
                }
                else
                {
                    txt_cstAddress.Text = CustomerSearch[0].Address;
                    txt_cstContact.Text = CustomerSearch[0].ContactNo;
                    txt_cstID.Text = CustomerSearch[0].Id.ToString();
                    txt_cstName.Text = CustomerSearch[0].Name;

                    foreach (TextBox textBox in AllTextBoxes)
                        textBox.Enabled = false;
                }
            }
            else
            {
                foreach (TextBox textBox in AllTextBoxes)
                {
                    textBox.Text = "";
                    textBox.Enabled = true;
                }
            }
        }

        private void pcb_searchProdBarCode_Click(object sender, EventArgs e)
        {
            if (txt_productBarCode.Text.Trim() == "")
                MessageBox.Show("برجاء كتابه باركود المنتج قبل البحث", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);

            else
            {
                txt_prodSearch.DataSource = null;
                txt_prodSearch.Items.Clear();

                List<ProductModel> productSearch = Classes.DataAccess.Products.GetProductParameter("BarCode", txt_productBarCode.Text);

                //DataTable dataProductSearch = ToDataTable(productSearch);

                txt_prodSearch.DataSource = productSearch;
                txt_prodSearch.ValueMember = "Id";
                txt_prodSearch.DisplayMember = "Name";
            }
        }

        private void db_procardsDataGridView_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            db_procardsDataGridView.DataSource = new Methods().DataGridToDataTable(db_procardsDataGridView);

            db_procardsDataGridView.Sort(db_procardsDataGridView.Columns[e.ColumnIndex], direction: ListSortDirection.Ascending);
        }

        private void db_procardsDataGridView_ColumnHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            db_procardsDataGridView.DataSource = new Methods().DataGridToDataTable(db_procardsDataGridView);

            db_procardsDataGridView.Sort(db_procardsDataGridView.Columns[e.ColumnIndex], ListSortDirection.Descending);
        }
    }
}
