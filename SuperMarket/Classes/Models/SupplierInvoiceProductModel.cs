using System;

namespace SuperMarket.Classes.Models
{
    class SupplierInvoiceProductModel
    {
        public long Id { get; set; }
        public long ProductId { get; set; }
        public string ProductName { get; set; }
        public float Quantity { get; set; }
        public DateTime CreationDate { get; set; }
    }
}
