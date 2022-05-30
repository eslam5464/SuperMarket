namespace SuperMarket.Classes.Models
{
    internal class OrderModel
    {
        public int Id { get; set; }
        public string InvoiceDate { get; set; }
        public int InvoiceId { get; set; }
        public int CustomerId { get; set; }
        public string CustomerName { get; set; }
        public string ContactNumber { get; set; }
        public string Address { get; set; }
        public string GrandTotal { get; set; }
    }
}