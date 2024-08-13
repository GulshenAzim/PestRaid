using Core.Entities.Abstract;

namespace Entities.Concrete
{
    public class Employee : BaseEntity
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public int Experience { get; set; }
        public int TeamId { get; set; }
        public Team Team { get; set; }

    }
}
