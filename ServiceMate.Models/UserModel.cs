namespace ServiceMate.Models
{
    public class UserModel
    {
        public int UserId { get; set; }
        public string EmailId { get; set; }
        public string Name { get; set; }
        public UserTypeModel UserType { get; set; }
    }
} 