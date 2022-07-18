namespace SuperMarket.Classes.Models
{
    class UserLevelAccessModel
    {
        public int Id { get; set; }
        public long UserId { get; set; }
        public string UserFullName { get; set; }
        public string UserLevel { get; set; }
        public bool Billing { get; set; }
        public bool BillsEdit { get; set; }
        public bool Categories { get; set; }
        public bool Customers { get; set; }
        public bool Dashboard { get; set; }
        public bool Products { get; set; }
        public bool Reports { get; set; }
        public bool Users { get; set; }
        public bool Settings { get; set; }
        public bool Orders { get; set; }
        public bool Safe { get; set; }
        public bool SupplierInvoices { get; set; }
        public bool SuppliersEdit { get; set; }
    }
}
