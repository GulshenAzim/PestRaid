using Core.Entities.Abstract;
using Entities.Enums;

namespace Entities.Concrete
{
    public class Package : BaseEntity
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public int PackageTypeId { get; set; }
        public PackageType PackageType { get; set; }
        public int PricingId { get; set; }
        public Pricing Pricing { get; set; }
        public List<Service> Services { get; set; }
    }
}
