using System;

namespace SuperMarket.Classes.Models
{
    class SupplierInvoiceModel
    {
        public long Id { get; set; }
        public int SupplierId { get; set; }
        public int PaymentMethod { get; set; }
        public decimal AmountPaid { get; set; }
        public decimal AmountLeft { get; set; }
        public decimal AmountTotal { get; set; }
        public bool PaymentStatus { get; set; }
        public long SupplierInvoiceProductId { get; set; }
        public DateTime CreationDate { get; set; }

    }
}
