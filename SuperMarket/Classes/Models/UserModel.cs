namespace SuperMarket.Classes.Models
{
    class UserModel
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string FullName { get; set; }
        public string UserLevel { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string CreationDate { get; set; }
        public string ModifyDate { get; set; }
        public int ActiveState { get; set; }
    }
}
