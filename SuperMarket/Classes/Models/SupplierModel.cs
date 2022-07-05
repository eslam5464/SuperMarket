using System;

namespace SuperMarket.Classes.Models
{
    class SupplierModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Contact { get; set; }
        public string Address { get; set; }
        public DateTime CreationDate { get; set; }
    }
}
