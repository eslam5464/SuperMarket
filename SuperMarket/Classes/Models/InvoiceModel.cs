using System;

namespace POSWarehouse.Classes.Models
{
    internal class InvoiceModel
    {
        public long Id { get; set; }
        public long InvoiceNumber { get; set; }
        public DateTime CreationDate { get; set; }
        public long CustomerId { get; set; }
        public string CustomerName { get; set; }
        public string CustomerContact { get; set; }
        public string CustomerAddress { get; set; }
        public long ProductID { get; set; }
        public long ProductBarCode { get; set; }
        public string ProductName { get; set; }
        public double ProductQuantity { get; set; }
        public decimal ProductPrice { get; set; }
        public decimal PriceTotal { get; set; }
    }
}