using Core.Entities.Abstract;

namespace Entities.Concrete
{
    public class TeamRole : BaseEntity
    {
        public string Name { get; set; }
        public string Description { get; set; }
    }
}
