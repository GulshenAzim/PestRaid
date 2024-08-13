using Core.Entities.Abstract;

namespace Entities.Concrete
{
    public class PackageType : BaseEntity
    {
        public string Type { get; set; }
        public string Description { get; set; }
    }
}
