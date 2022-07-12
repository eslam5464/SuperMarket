using System;

namespace SuperMarket.Classes.Models
{
    class CategoryModel
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public int StorageId { get; set; }
        public string StorageName { get; set; }
        public DateTime CreationDate { get; set; }
    }
}
