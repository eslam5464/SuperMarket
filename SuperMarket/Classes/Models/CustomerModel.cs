using System;

namespace POSWarehouse.Classes.Models
{
    class CustomerModel
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public string ContactNo { get; set; }
        public string Address { get; set; }
        public DateTime CreationDate { get; set; }
    }
}
