using System;

namespace SuperMarket.Classes.Models
{
    class SafeTransactionModel
    {
        public long Id { get; set; }
        public int SafeId { get; set; }
        public string SafeName { get; set; }
        public decimal AmountAdded { get; set; }
        public decimal AmountTotal { get; set; }
        public long AdjustedByUserId { get; set; }
        public string AdjustedByUserFullName { get; set; }
        public string Notes { get; set; }
        public DateTime CreationDate { get; set; }
    }
}
