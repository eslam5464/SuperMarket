using System;

namespace SuperMarket.Classes.Models
{
    class SafeModel
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public decimal AmountAdded { get; set; }
        public decimal AmountTotal { get; set; }
        public long AdjustedByUserId { get; set; }
        public string AdjustedByUserFullName { get; set; }
        public DateTime CreationDate { get; set; }
    }
}
