namespace SuperMarket.Classes.Models
{
    internal class ProductModel
    {
        public int Id { get; set; }
        public string BarCode { get; set; }
        public string Name { get; set; }
        public string Quantity { get; set; }
        public string Price { get; set; }
        public string Description { get; set; }
        public int CategoryID { get; set; }
        public string CategoryName { get; set; }
        public string CreationDate { get; set; }
    }
}