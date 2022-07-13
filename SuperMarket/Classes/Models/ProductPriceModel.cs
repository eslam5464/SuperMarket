using System;

namespace SuperMarket.Classes.Models
{
    class ProductPriceModel
    {
        public int Id { get; set; }
        public long ProductId { get; set; }
        public string ProductName { get; set; }
        public decimal PriceWholesale { get; set; }
        public decimal PriceSell { get; set; }
        public DateTime CreationDate { get; set; }
    }
}
