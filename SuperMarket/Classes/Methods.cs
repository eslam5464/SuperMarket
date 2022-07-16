using QRCoder;
using SuperMarket.Classes.Helpers;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Net;
using System.Net.Cache;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SuperMarket.Classes
{
    public class Methods
    {
        internal async static Task<object> GetTimeOnline()
        {
            try
            {
                DateTime dateTime = DateTime.MinValue;
                HttpWebRequest request = await Task.Run(() => (HttpWebRequest)WebRequest.Create("https://www.google.com.eg"));
                request.Method = "GET";
                request.Accept = "text/html, application/xhtml+xml, */*";
                request.UserAgent = "Mozilla/5.0 (compatible; MSIE 10.0; Windows NT 6.1; Trident/6.0)";
                request.ContentType = "application/x-www-form-urlencoded";
                request.CachePolicy = await Task.Run(() => new RequestCachePolicy(RequestCacheLevel.NoCacheNoStore));
                HttpWebResponse response = await Task.Run(() => (HttpWebResponse)request.GetResponse());
                if (response.StatusCode == HttpStatusCode.OK)
                {
                    string todaysDates = response.Headers["date"];

                    dateTime = await Task.Run(() => DateTime.ParseExact(todaysDates, "ddd, dd MMM yyyy HH:mm:ss 'GMT'", System.Globalization.CultureInfo.InvariantCulture.DateTimeFormat, System.Globalization.DateTimeStyles.AssumeUniversal));
                }

                return dateTime;
            }
            catch (Exception ex)
            {
                Logger.Log($"Error while fetching the online date now & error: {ex.Message}",
                          System.Reflection.MethodInfo.GetCurrentMethod().Name, "Methods", Logger.ERROR);
            }
            return null;
        }

        internal async virtual Task<DataTable> DataGridToDataTable(DataGridView dataGridView)
        {
            DataTable dataTable = new DataTable();

            foreach (DataGridViewColumn column in dataGridView.Columns)
            {
                await Task.Run(() => dataTable.Columns.Add(column.Name, column.ValueType));
            }

            foreach (DataGridViewRow row in dataGridView.Rows)
            {
                dataTable.Rows.Add();
                foreach (DataGridViewCell cell in row.Cells)
                {
                    if (cell.Value == null)
                        await Task.Run(() => dataTable.Rows[dataTable.Rows.Count - 1][cell.ColumnIndex] = "");

                    else
                        await Task.Run(() => dataTable.Rows[dataTable.Rows.Count - 1][cell.ColumnIndex] = cell.Value.ToString());
                }
            }
            return dataTable;
        }

        internal async virtual Task<DataTable> ListToDataTable<T>(List<T> items)
        {
            DataTable dataTable = new DataTable(typeof(T).Name);

            System.Reflection.PropertyInfo[] Props =
                await Task.Run(() => typeof(T).GetProperties(System.Reflection.BindingFlags.Public | System.Reflection.BindingFlags.Instance));

            foreach (System.Reflection.PropertyInfo prop in Props)
            {
                await Task.Run(() => dataTable.Columns.Add(prop.Name, prop.PropertyType));
            }
            foreach (T item in items)
            {
                var values = new object[Props.Length];
                for (int i = 0; i < Props.Length; i++)
                {
                    values[i] = await Task.Run(() => Props[i].GetValue(item, null));
                }
                await Task.Run(() => dataTable.Rows.Add(values));
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
            return result.ToString();
        }

        internal async virtual Task<Image> CreateBarcodeImage(string Barcode)
        {
            BarcodeLib.Barcode b = new BarcodeLib.Barcode();
            Image img = await Task.Run(() => b.Encode(BarcodeLib.TYPE.Interleaved2of5, Barcode, Color.Black, Color.White, 290, 120));
            return img;
        }

        internal async virtual Task<Image> CreateBarcodeImage(string Barcode, int Width, int Height)
        {
            BarcodeLib.Barcode b = new BarcodeLib.Barcode();
            Image img = await Task.Run(() => b.Encode(BarcodeLib.TYPE.Interleaved2of5, Barcode, Color.Black, Color.White, Width, Height));
            return img;
        }

        internal async virtual Task<Image> CreateQRCodeImage(string Text)
        {
            QRCodeGenerator qrGenerator = new QRCodeGenerator();
            QRCodeData qrCodeData = await Task.Run(() => qrGenerator.CreateQrCode(Text, QRCodeGenerator.ECCLevel.Q));
            QRCode qrCode = new QRCode(qrCodeData);
            Bitmap qrCodeImage = await Task.Run(() => qrCode.GetGraphic(20));
            return qrCodeImage;
        }

        internal async virtual Task<Image> CreateQRCodeImage(string Text, Color DarkColor, Color LightColor)
        {
            QRCodeGenerator qrGenerator = new QRCodeGenerator();
            QRCodeData qrCodeData = await Task.Run(() => qrGenerator.CreateQrCode(Text, QRCodeGenerator.ECCLevel.Q));
            QRCode qrCode = new QRCode(qrCodeData);
            Bitmap qrCodeImage = await Task.Run(() => qrCode.GetGraphic(20, DarkColor, LightColor, true));
            return qrCodeImage;
        }

        internal static ContextMenu SetupContextMenuCopy(ContextMenu contextMenu, EventHandler Event)
        {
            contextMenu.MenuItems.Add(new MenuItem("نسخ الخانه", Event));
            return contextMenu;
        }

        internal async static Task ExportDGVtoPDF(DataGridView categoriesDataGridView, string TitleName)
        {
            DGVPrinter dGVPrinter = new DGVPrinter
            {
                Title = TitleName,
                //SubTitle = "1234",
                SubTitleFormatFlags = StringFormatFlags.LineLimit | StringFormatFlags.NoClip,
                PageNumbers = true,
                PageNumberInHeader = false,
                PorportionalColumns = true,
                HeaderCellAlignment = StringAlignment.Near,
                //Footer = "111223344",
                FooterSpacing = 15,
            };

            await Task.Run(() => dGVPrinter.PrintDataGridView(categoriesDataGridView));
        }

        internal static int FindIndexFromArray(string[] SearchedArray, string Value)
        {
            int Index = Array.FindIndex(SearchedArray, row => row.Contains(Value));
            return Index;
        }

        internal static void OpenCalculator()
        {
            System.Diagnostics.Process.Start("calc.exe");
        }

        //Array.FindIndex(GlobalVars.PaymentMethod, row => row.Contains("نقدي"))

        //---------------------------------------------------------------


        //private ContextMenu contextMenu = new ContextMenu();

        //private void SetupContextMenu()
        //{
        //    contextMenu.MenuItems.Add(new MenuItem("تعديل", MenuItemEdit_Click));
        //}

        //private void MenuItemEdit_Click(Object sender, System.EventArgs e)
        //{
        //    txt_productName.Text = db_procardsDataGridView.Rows[EditedRowID].Cells["ProductName"].Value.ToString();
        //    //MessageBox.Show("invoice: " + InvoiceID); // TODO: finish editing
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
