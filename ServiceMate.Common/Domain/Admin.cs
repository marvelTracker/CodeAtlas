namespace ServiceMate.Common.Domain
{
    public class Admin:BaseEntity
    {
        public virtual  User User { get; set; }
        public int UserId { get; set; }
    }
}
