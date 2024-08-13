using Core.Entities.Abstract;
using Entities.Enums;

namespace Entities.Concrete
{
    public class Pricing : BaseEntity
    {
        public string Name { get; set; }
        public PackageDuration Duration { get; set; }
        public double Price { get; set; }
    }
}
