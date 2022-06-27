using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace SuperMarket.Classes
{
    internal class Methods
    {
        internal virtual DataTable DataGridToDataTable(DataGridView dataGridView)
        {
            DataTable dataTable = new DataTable();

            foreach (DataGridViewColumn column in dataGridView.Columns)
            {
                dataTable.Columns.Add(column.Name, column.ValueType);
            }

            foreach (DataGridViewRow row in dataGridView.Rows)
            {
                dataTable.Rows.Add();
                foreach (DataGridViewCell cell in row.Cells)
                {
                    dataTable.Rows[dataTable.Rows.Count - 1][cell.ColumnIndex] = cell.Value.ToString();
                }

            }
            return dataTable;
        }

        internal static DataTable ListToDataTable<T>(List<T> items)
        {
            DataTable dataTable = new DataTable(typeof(T).Name);

            System.Reflection.PropertyInfo[] Props = typeof(T).GetProperties(System.Reflection.BindingFlags.Public | System.Reflection.BindingFlags.Instance);
            foreach (System.Reflection.PropertyInfo prop in Props)
            {
                dataTable.Columns.Add(prop.Name);
            }
            foreach (T item in items)
            {
                var values = new object[Props.Length];
                for (int i = 0; i < Props.Length; i++)
                {
                    values[i] = Props[i].GetValue(item, null);
                }
                dataTable.Rows.Add(values);
            }
            return dataTable;
        }

        internal static string GetUniqueInvoiceID(int Length = 12)
        {
            char[] chars = new char[62];
            chars = "0123456789".ToCharArray();
            byte[] data = new byte[1];
            System.Security.Cryptography.RNGCryptoServiceProvider crypto = new
                System.Security.Cryptography.RNGCryptoServiceProvider();
            crypto.GetNonZeroBytes(data);
            data = new byte[Length];
            crypto.GetNonZeroBytes(data);
            System.Text.StringBuilder result = new System.Text.StringBuilder(Length);
            foreach (byte b in data)
            {
                result.Append(chars[b % (chars.Length)]);
            }
            result[0] = '6';
            result[1] = '2';
            result[2] = '2';
            result[3] = '2';
            result[4] = '2';
            result[5] = '2';
            return result.ToString();
        }

        internal virtual Image CreateBarcodeImage(string Barcode)
        {
            //var barcode = new Barcode("543534"); // default: Code128

            BarcodeLib.Barcode b = new BarcodeLib.Barcode();
            Image img = b.Encode(BarcodeLib.TYPE.UPCA, Barcode, Color.Black, Color.White, 290, 120);
            return img;
        }

        internal virtual Image CreateBarcodeImage(string Barcode, int Width, int Height)
        {
            BarcodeLib.Barcode b = new BarcodeLib.Barcode();
            Image img = b.Encode(BarcodeLib.TYPE.UPCA, Barcode, Color.Black, Color.White, Width, Height);
            return img;
        }

        //private ContextMenu contextMenu = new ContextMenu();

        //private void SetupContextMenu()
        //{
        //    contextMenu.MenuItems.Add(new MenuItem("تعديل", MenuItemEdit_Click));
        //}

        //private void MenuItemEdit_Click(Object sender, System.EventArgs e)
        //{
        //    txt_productName.Text = db_procardsDataGridView.Rows[EditedRowID].Cells["ProductName"].Value.ToString();
        //    //MessageBox.Show("invoice: " + InvoiceID); // TO DO: finish editing
        //    txt_productBarCode.Text = db_procardsDataGridView.Rows[EditedRowID].Cells["ProductBarCode"].Value.ToString();
        //    txt_productquantity.Text = db_procardsDataGridView.Rows[EditedRowID].Cells["ProductQuantity"].Value.ToString();
        //    txt_productprice.Text = db_procardsDataGridView.Rows[EditedRowID].Cells["ProductPrice"].Value.ToString();
        //    txt_totalprice.Text = db_procardsDataGridView.Rows[EditedRowID].Cells["PriceTotal"].Value.ToString();
        //    contextMenu.MenuItems.Add(new MenuItem("حفظ التعديل", MenuItemSaveEdit_Click));
        //}

        //private void MenuItemSaveEdit_Click(Object sender, System.EventArgs e)
        //{
        //    db_procardsDataGridView.Rows[EditedRowID].Cells["ProductPrice"].Value = txt_productprice.Text;

        //    contextMenu.MenuItems.RemoveAt(1);
        //}
    }
}
