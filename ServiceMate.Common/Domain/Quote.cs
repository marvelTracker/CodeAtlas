namespace ServiceMate.Common.Domain
{
    public class Quotation:BaseEntity
    {
        public virtual ServiceProvider ServiceProvider { get; set; }
        public int ServiceProviderId { get; set; }

        public QuotationStatusType QuotationStatusType { get; set; }

        public virtual Review Review { get; set; }
        public int ReviewId { get; set; }
    }
}
