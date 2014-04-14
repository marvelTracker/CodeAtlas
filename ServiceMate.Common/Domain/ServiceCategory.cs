namespace ServiceMate.Common.Domain
{
    public class ServiceCategory:BaseEntity
    {
        
     
        public int ServiceCategoryCode { get; set; }
        public string Description { get; set; }
        public ServiceCategoryEnum Category { get; set; }
    }
    public enum ServiceCategoryEnum
    {
        Cleaning = 1,
    }
}
