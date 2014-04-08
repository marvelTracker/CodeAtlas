namespace ServiceMate.Common.Domain
{
    public class ServiceProvider:BaseEntity
    {
        public virtual User User { get; set; }
        public int UserId { get; set; }

        public string BusinessName
        {
            get;
            set;
        }

        public string ABN { get; set; }

        public int SuburbList { get; set; }

        public int Range { get; set; }

        public Suburb Suburb { get; set; }

        public int ServiceProviderServiceList { get; set; }

        public virtual Profile Profile { get; set; }
        public int? ProfileId { get; set; }
    }
}
