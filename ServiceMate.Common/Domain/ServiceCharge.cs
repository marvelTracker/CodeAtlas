namespace ServiceMate.Common.Domain
{
    public class ServiceCharge:BaseEntity
    {
        public ServiceChargeType ServiceChargeType { get; set; }

        public int Price { get; set; }
    }
}
