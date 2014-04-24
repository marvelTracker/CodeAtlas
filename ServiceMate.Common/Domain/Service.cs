namespace ServiceMate.Common.Domain
{
    public class Service
    {
        public int Id { get; set; }
        public int  ServiceCategoryID { get; set; }
        public virtual ServiceCategory ServiceCategory { get; set; }
        public string Name { get; set; }
    }
}
