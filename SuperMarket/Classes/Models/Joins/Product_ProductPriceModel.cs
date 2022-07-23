using System;

namespace POSWarehouse.Classes.Models.Joins
{
    class Product_ProductPriceModel
    {
        public long Id { get; set; }
        public string BarCode { get; set; }
        public string Name { get; set; }
        public double Quantity { get; set; }
        public double QuantityMinimum { get; set; }
        public decimal PriceWholesale { get; set; }
        public decimal PriceSell { get; set; }
        public string Description { get; set; }
        public long CategoryID { get; set; }
        public string CategoryName { get; set; }
        public DateTime CreationDate { get; set; }
        public DateTime PriceModificationDate { get; set; }
    }
}
