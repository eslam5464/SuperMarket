using System;

namespace SuperMarket.Classes.Models
{
    internal class ProductModel
    {
        public long Id { get; set; }
        public long BarCode { get; set; }
        public string Name { get; set; }
        public double Quantity { get; set; }
        public decimal Price { get; set; }
        public string Description { get; set; }
        public long CategoryID { get; set; }
        public string CategoryName { get; set; }
        public DateTime CreationDate { get; set; }
    }
}