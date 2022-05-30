namespace SuperMarket.Classes.Models
{
    internal class InvoiceModel
    {
        public int Id { get; set; }
        public int InvoiceNumber { get; set; }
        public string CreationDate { get; set; }
        public int CustomerId { get; set; }
        public string CustomerName { get; set; }
        public string CustomerContact { get; set; }
        public string CustomerAddress { get; set; }
        public int ProductID { get; set; }
        public string ProductBarCode { get; set; }
        public string ProductName { get; set; }
        public string ProductQuantity { get; set; }
        public string ProductPrice { get; set; }
        public string PriceTotal { get; set; }
    }
}