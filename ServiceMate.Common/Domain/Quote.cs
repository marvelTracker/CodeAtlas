namespace ServiceMate.Common.Domain
{
    public class Quotation:BaseEntity
    {
        public virtual ServiceProvider ServiceProvider { get; set; }
        public int ServiceProviderID { get; set; }

        public QuotationStatusType QuotationStatusType { get; set; }
        public string Location { get; set; }
        public string TimeForStart{ get; set; }
        public string WorkType { get; set; }
        public string Description { get; set; }
        public string PropertType { get; set; }

        public virtual Review Review { get; set; }
        public int ReviewId { get; set; }
    }
    
}
