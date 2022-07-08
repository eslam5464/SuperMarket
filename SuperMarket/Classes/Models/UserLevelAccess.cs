using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperMarket.Classes.Models
{
    class UserLevelAccess
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public bool UserFullName { get; set; }
        public bool UserLevel { get; set; }
        public bool Billing { get; set; }
        public bool BillsEdit { get; set; }
        public bool Categories { get; set; }
        public bool Customers { get; set; }
        public bool Dashboard { get; set; }
        public bool Products { get; set; }
        public bool Reports { get; set; }
        public bool Sellers { get; set; }
        public bool Settings { get; set; }
    }
}
