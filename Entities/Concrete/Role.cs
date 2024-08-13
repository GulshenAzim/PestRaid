using Core.Entities.Abstract;

namespace Entities.Concrete
{
    public class Role : BaseEntity
    {
        public string Name { get; set; }
        public ICollection<UserRole> Users { get; set; }

    }
}
