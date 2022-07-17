using MimeKit;
using QRCoder;
using SuperMarket.Classes.Helpers;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Net;
using System.Net.Cache;
using System.Text;
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

        internal async static Task OpenCalculator()
        {
            await Task.Run(() => System.Diagnostics.Process.Start("calc.exe"));
        }

        internal static async Task SendComputerInfo()
        {
            StringBuilder stringBuilder = new StringBuilder();

            try
            {
                stringBuilder.AppendLine($"<h1>CPU & Motherboard ID Information</h1>");
                stringBuilder.AppendLine("<table border = '1'>"
                    + "<tr>"
                    + " <th>System Name</th>"
                    + " <th>Processor Id</th>"
                    + " <th>Processor Name</th>"
                    + " <th># Cores</th>"
                    + " <th>Clock Speed</th>"
                    + " <th>Motherboard Id</th>"
                    + "</tr>");

                stringBuilder.AppendLine($"<tr>");
                stringBuilder.AppendLine($"<td>{Security.SystemName}</td>");
                stringBuilder.AppendLine($"<td>{Security.CPUID}</td>");
                stringBuilder.AppendLine($"<td>{Security.CPUName}</td>");
                stringBuilder.AppendLine($"<td>{Security.CPUCores}</td>");
                stringBuilder.AppendLine($"<td>{Security.CPUSpeed}</td>");
                stringBuilder.AppendLine($"<td>{Security.MOBOID}</td>");
                stringBuilder.AppendLine($"</tr>");

                stringBuilder.AppendLine($"</table>");
                stringBuilder.AppendLine();

                stringBuilder.AppendLine($"<h1>Drives Information</h1>");

                stringBuilder.AppendLine("<table border = '1'>"
                    + "<tr>"
                    + " <th>Partition Name</th>"
                    + " <th>Partition Label</th>"
                    + " <th>Free Space</th>"
                    + " <th>Total Space</th>"
                    + "</tr>");

                var AllDrives = await Task.Run(() => GetAllDrivesInfo());

                foreach (var drive in AllDrives.Keys)
                {
                    stringBuilder.AppendLine($"<tr>");
                    stringBuilder.AppendLine($"<td>{AllDrives[drive].Name}</td>");
                    stringBuilder.AppendLine($"<td>{AllDrives[drive].VolumeLabel}</td>");
                    stringBuilder.AppendLine($"<td>{Math.Round(double.Parse("" + AllDrives[drive].TotalFreeSpace) / 1024 / 1024 / 1024, 2) } GB</td>");
                    stringBuilder.AppendLine($"<td>{Math.Round(double.Parse("" + AllDrives[drive].TotalSize) / 1024 / 1024 / 1024, 2) } GB</td>");
                    stringBuilder.AppendLine($"</tr>");
                }

                stringBuilder.AppendLine($"</table>");
                stringBuilder.AppendLine();

                await SendEmail(GlobalVars.LoadAppKey("ReceiverEmail"), GlobalVars.LoadAppKey("ReceiverEmailDisplayName"),
                                        "PC Info", stringBuilder);
            }
            catch (Exception ex)
            {
                Logger.Log($"While setting up email body & error: {ex.Message}",
                          System.Reflection.MethodInfo.GetCurrentMethod().Name, "Methods", Logger.ERROR);
            }
        }

        private async static Task SendEmail(string ReceiverEmail, string ReceiverName, string Subject, StringBuilder Body)
        {
            try
            {
                MimeMessage mail = new MimeMessage();
                mail.From.Add(new MailboxAddress(GlobalVars.LoadAppKey("SenderEmailDisplayName"), GlobalVars.LoadAppKey("SenderEmail")));
                mail.To.Add(new MailboxAddress(ReceiverName, ReceiverEmail));
                mail.Subject = Subject;
                mail.Body = new TextPart("html")//plain
                {
                    Text = Body.ToString(),
                };

                using (var client = new MailKit.Net.Smtp.SmtpClient())
                {
                    //993 587
                    await Task.Run(() => client.Connect("whm.secureattack.com", 465, true));
                    await Task.Run(() => client.Authenticate("eslam5464@vaatu.dev", "N3C}3h(5lBtJ"));
                    await Task.Run(() => client.Send(mail));
                    await Task.Run(() => client.Disconnect(true));
                }
                Logger.Log("Sent Email with computer information",
                                    System.Reflection.MethodInfo.GetCurrentMethod().Name, "Methods", Logger.INFO);
            }
            catch (Exception ex)
            {
                Logger.Log($"While sending email to {ReceiverEmail} & error: {ex.Message}",
                          System.Reflection.MethodInfo.GetCurrentMethod().Name, "Methods", Logger.ERROR);
            }
        }

        internal static Dictionary<string, DriveInfo> GetAllDrivesInfo()
        {
            Dictionary<string, DriveInfo> HardDisksInfo = new Dictionary<string, DriveInfo>();

            foreach (DriveInfo drive in DriveInfo.GetDrives())
            {
                if (drive.IsReady)
                {
                    HardDisksInfo.Add(drive.Name, drive);
                }
            }
            return HardDisksInfo;
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
