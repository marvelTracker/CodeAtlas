namespace ServiceMate.Common.Domain
{
    public class Consumer:BaseEntity
    {
        public virtual User User { get; set; }
        public int UserId { get; set; }

        public virtual Profile Profile { get; set; }
        public int? ProfileId { get; set; }

        public string ConsumerName { get; set; }
        public string PhoneNumber { get; set; }
    }
}
