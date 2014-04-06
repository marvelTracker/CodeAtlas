namespace ServiceMate.Common.Domain
{
    public class User:BaseEntity
    {
        public string Password { get; set; }

        public string Email { get; set; }

        public string Token { get; set; }

        public UserType UserType { get; set; }
    }
}
