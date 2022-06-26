using System;

namespace SuperMarket.Classes.Models
{
    class UserModel
    {
        public long Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string FullName { get; set; }
        public string UserLevel { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public DateTime CreationDate { get; set; }
        public DateTime ModifyDate { get; set; }
        public bool ActiveState { get; set; }
    }
}
