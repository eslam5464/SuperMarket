using SuperMarket.Classes.Models;
using SuperMarket.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SuperMarket.UserControls
{
    public partial class Billing : UserControl
    {
        public Billing()
        {
            InitializeComponent();
        }

        private void ub_billing_Load(object sender, EventArgs e)
        {
            SetColors(Properties.Settings.Default.AppColor);

            txt_invoiceno.Text = GetUniqueInvoiceID(9);
        }

        private string GetUniqueInvoiceID(int MaxSize)
        {
            char[] chars = new char[62];
            chars = "123456789".ToCharArray();
            byte[] data = new byte[1];
            RNGCryptoServiceProvider crypto = new RNGCryptoServiceProvider();
            crypto.GetNonZeroBytes(data);
            data = new byte[MaxSize];
            crypto.GetNonZeroBytes(data);
            StringBuilder result = new StringBuilder(MaxSize);
            foreach (byte b in data)
            {
                result.Append(chars[b % (chars.Length)]);
            }
            return result.ToString();
        }

        private void SetColors(Color appColor)
        {
            label1.ForeColor = appColor;
            label2.ForeColor = appColor;
            label3.ForeColor = appColor;
            label4.ForeColor = appColor;
            label5.ForeColor = appColor;
            label6.ForeColor = appColor;
            label7.ForeColor = appColor;
            label8.ForeColor = appColor;
            label9.ForeColor = appColor;
            label10.ForeColor = appColor;
            label11.ForeColor = appColor;
            label12.ForeColor = appColor;
            label13.ForeColor = appColor;
            btn_addtocard.BackColor = appColor;
            btn_print.BackColor = appColor;
            btn_remove.BackColor = appColor;
            btn_remove_.BackColor = appColor;
            btn_save.BackColor = appColor;
            btn_update.BackColor = appColor;
            db_procardsDataGridView.ColumnHeadersDefaultCellStyle.BackColor = appColor;
        }

        private void pcb_search_Click(object sender, EventArgs e)
        {
            if (txt_invoiceno.Text == "")
                MessageBox.Show("برجاء كتابه رقم الفاتورة أو الضغط على زر عمل رقم جديد", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (txt_invoiceno.Enabled)
            {
                List<InvoiceModel> InvoiceSearch = Classes.DataAccess.Invoices.GetInvoice(int.Parse(txt_invoiceno.Text));

                if (InvoiceSearch.Count != 0)
                    LoadDataGrid(InvoiceSearch);

                else
                    MessageBox.Show("برجاء التأكد من رقم الفاتورة", "حاول مره أخرى", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void btn_print_Click(object sender, EventArgs e)
        {
            new Invoice().ShowDialog();
        }

        private void txt_billing_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                e.SuppressKeyPress = true;
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
            if (txt_invoiceno.Text == "" || txt_cstID.Text == "" || txt_cstID.Text == "" || txt_cstID.Text == "" ||
                txt_cstID.Text == "" || txt_cstID.Text == "" || txt_cstID.Text == "" || txt_cstID.Text == "" || txt_cstID.Text == "")
            {
                MessageBox.Show("اكمال البيانات لادخال المنتج إلى السله", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                List<CustomerModel> CstSearch = Classes.DataAccess.Customers.GetCustomerWithID(txt_cstID.Text);
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

                    string product_id = txt_prodSearch.SelectedValue.ToString(), product_name = txt_productName.Text, product_barCode = txt_productBarCode.Text,
                        product_quantity = txt_productquantity.Text, product_price = txt_productprice.Text;

                    string priceTotal = txt_totalprice.Text;

                    string DateTimeNow = DateTime.Now.ToString("hh:mm:ss tt dd/MM/yyyy", new System.Globalization.CultureInfo("ar-AE"));
                    InvoiceModel invoice = new InvoiceModel
                    {
                        InvoiceNumber = int.Parse(txt_invoiceno.Text),
                        CustomerId = int.Parse(cst_id),
                        CustomerName = cst_name,
                        CustomerContact = cst_contact,
                        CustomerAddress = cst_address,
                        ProductID = int.Parse(product_id),
                        ProductBarCode = product_barCode,
                        ProductName = product_name,
                        ProductQuantity = product_quantity,
                        ProductPrice = product_price,
                        PriceTotal = priceTotal,
                        CreationDate = DateTimeNow
                    };

                    UpdateDataGrid(invoice);

                    CalculateGrandTotal();
                }
            }
        }

        private void CalculateGrandTotal()
        {
            if (db_procardsDataGridView.DataSource != null)
            {
                List<InvoiceModel> CartDataSource = (List<InvoiceModel>)db_procardsDataGridView.DataSource;

                double sum = 0.0;
                foreach (InvoiceModel product in CartDataSource)
                {
                    sum += double.Parse(product.PriceTotal);
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
            if (txt_productName.Text == "")
                MessageBox.Show("برجاء كتابه اسم المنتج قبل البحث", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);

            else
            {
                txt_prodSearch.DataSource = null;
                txt_prodSearch.Items.Clear();

                List<ProductModel> productSearch = Classes.DataAccess.Products.GetProductLikeParameter("Name", txt_productName.Text);

                txt_prodSearch.DataSource = productSearch;
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
                    txt_productprice.Text = productSearch[0].Price;
                    txt_productBarCode.Text = productSearch[0].BarCode;
                    txt_productName.Text = productSearch[0].Name;
                    txt_productquantity.Text = "" + 1;
                }
            }
        }

        private void txt_productprice_TextChanged(object sender, EventArgs e)
        {
            if (txt_productquantity.Text != "" && txt_productprice.Text != "")
            {
                double total_price = double.Parse(txt_productquantity.Text) * double.Parse(txt_productprice.Text);
                txt_totalprice.Text = "" + Math.Round(total_price + 0.005, 2);
            }
        }

        private void txt_productquantity_TextChanged(object sender, EventArgs e)
        {
            if (txt_productquantity.Text != "" && txt_productprice.Text != "")
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
            string UniqueInvoiceID = GetUniqueInvoiceID(9);

            List<InvoiceModel> InvoiceSearch = Classes.DataAccess.Invoices.LoadInvoice(int.Parse(UniqueInvoiceID));

            while (InvoiceSearch.Count != 0)
            {
                UniqueInvoiceID = GetUniqueInvoiceID(9);
                InvoiceSearch = Classes.DataAccess.Invoices.LoadInvoice(int.Parse(UniqueInvoiceID));
            }

            txt_invoiceno.Text = UniqueInvoiceID;
            db_procardsDataGridView.DataSource = null;
        }

        private void btn_remove_Click(object sender, EventArgs e)
        {

            if (db_procardsDataGridView.DataSource != null && db_procardsDataGridView.CurrentCell != null)
            {
                int rowindex = db_procardsDataGridView.CurrentCell.RowIndex;
                int InvoiceID = int.Parse(db_procardsDataGridView.Rows[rowindex].Cells["Id"].Value.ToString());
                int ProductId = int.Parse(db_procardsDataGridView.Rows[rowindex].Cells["ProductId"].Value.ToString());
                string ProductName = db_procardsDataGridView.Rows[rowindex].Cells["ProductName"].Value.ToString();
                string DateCreated = db_procardsDataGridView.Rows[rowindex].Cells["CreationDate"].Value.ToString();

                if (MessageBox.Show($"هل تريد انت تحذف من السله {ProductName}", "انتظر",
                           MessageBoxButtons.YesNo,
                           MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    List<InvoiceModel> datasource = (List<InvoiceModel>)db_procardsDataGridView.DataSource;
                    db_procardsDataGridView.DataSource = null;
                    datasource.Remove(datasource.Find(User => User.CreationDate == DateCreated));
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
            ResetTextBoxes();
            db_procardsDataGridView.DataSource = null;
            txt_invoiceno.Enabled = true;
        }

        private void ResetTextBoxes()
        {
            txt_cstAddress.Text = "";
            txt_cstContact.Text = "";
            txt_cstID.Text = "";
            txt_cstName.Text = "";
            txt_grandtotal.Text = "";
            txt_invoiceno.Text = "";
            txt_prodSearch.Text = "";
            txt_productBarCode.Text = "";
            txt_productName.Text = "";
            txt_productprice.Text = "";
            txt_productquantity.Text = "";
            txt_totalprice.Text = "";

            txt_prodSearch.SelectedIndex = -1;

            txt_invoiceno.Enabled = true;

            dtp_invoicedate.Refresh();
        }

        private void pcb_searchCstName_Click(object sender, EventArgs e)
        {
            if (txt_invoiceno.Text == "")
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
            btn_update.Enabled = !State;
        }

        private void pcb_searchCstID_Click(object sender, EventArgs e)
        {
            if (txt_cstID.Text == "")
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
                    if (MessageBox.Show($"هل تريد انت تحذف من السله {ProductName}", "انتظر",
                           MessageBoxButtons.YesNo,
                           MessageBoxIcon.Information) == DialogResult.Yes)
                    {
                        foreach (InvoiceModel invoice in datasource)
                        {
                            Classes.DataAccess.Invoices.AddToInvoice(invoice);
                            ProductModel ProductSearch = Classes.DataAccess.Products.GetProductParameter("Id", "" + invoice.ProductID).FirstOrDefault();
                            ProductSearch.Quantity = "" + (double.Parse(ProductSearch.Quantity) - double.Parse(invoice.ProductQuantity));
                            Classes.DataAccess.Products.UpdateProduct(ProductSearch);
                        }

                        OrderModel order = new OrderModel
                        {
                            InvoiceDate = dtp_invoicedate.Value.ToString("hh:mm:ss tt dd/MM/yyyy", new System.Globalization.CultureInfo("ar-AE")),
                            InvoiceId = datasource[0].InvoiceNumber,
                            CustomerId = datasource[0].CustomerId,
                            CustomerName = datasource[0].CustomerName,
                            ContactNumber = datasource[0].CustomerContact,
                            Address = datasource[0].CustomerAddress,
                            GrandTotal = txt_grandtotal.Text
                        };
                        Classes.DataAccess.Orders.AddOrder(order);

                        db_procardsDataGridView.DataSource = null;

                        ResetTextBoxes();

                        txt_invoiceno.Text = GetUniqueInvoiceID(9);
                    }
                }
                else
                    MessageBox.Show("لا يوجدأي اشياء في السله", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
                MessageBox.Show("لا يوجد بيانات للحفظ", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
