using System;

namespace SuperMarket.Classes.Models
{
    internal class OrderModel
    {
        public long Id { get; set; }
        public DateTime InvoiceDate { get; set; }
        public long InvoiceId { get; set; }
        public long CustomerId { get; set; }
        public string CustomerName { get; set; }
        public string ContactNumber { get; set; }
        public string Address { get; set; }
        public long CreatedByUserId { get; set; }
        public Decimal GrandTotal { get; set; }
        public string CreatedByUserFullName { get; internal set; }
    }
}