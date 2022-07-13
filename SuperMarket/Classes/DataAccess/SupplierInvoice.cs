using Dapper;
using SuperMarket.Classes.Models;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace SuperMarket.Classes.DataAccess
{
    class SupplierInvoice
    {
        private static readonly string TableName = "SupplierInvoices";

        internal static void SaveSupplierInvoice(SupplierInvoiceModel supplierInvoice)
        {
            try
            {
                using (IDbConnection cnn = new SqlConnection(GlobalVars.LoadConnectionString()))
                {
                    cnn.Execute($"INSERT INTO {TableName} (SupplierId, PaymentMethod, AmountPaid, AmountLeft," +
                        $"AmountTotal, PaymentStatus, SupplierInvoiceProductId, CreationDate) VALUES " +
                        $"(@SupplierId, @PaymentMethod, @AmountPaid, @AmountLeft, @AmountTotal, @PaymentStatus," +
                        $" @SupplierInvoiceProductId, '{DateTime.Now}')", supplierInvoice);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"حدث خطأ أثناء حفظ فاتورة المورد {supplierInvoice.SupplierInvoiceProductId}", "خطأ",
                      MessageBoxButtons.OK, MessageBoxIcon.Error);

                Logger.Log($"while saving a supplier invoice for supplier with id = {supplierInvoice.SupplierId} & error: {ex.Message}",
                            System.Reflection.MethodInfo.GetCurrentMethod().Name, TableName, Logger.ERROR);
            }
        }
    }
}
