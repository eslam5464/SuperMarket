using System;

namespace POSWarehouse.Classes.Models
{
    class SupplierInvoiceProductModel
    {
        public long Id { get; set; }
        public long ProductId { get; set; }
        public string ProductName { get; set; }
        public decimal ProductPriceWholesale { get; set; }
        public decimal ProductPriceSell { get; set; }
        public float Quantity { get; set; }
        public DateTime CreationDate { get; set; }
    }
}
