using Core.Entities.Abstract;

namespace Entities.Concrete
{
    public class Team : BaseEntity
    {
        public string FullName { get; set; }
        public string ImageUrl { get; set; }
        public TeamRole Role { get; set; }
        public List<Service> Services { get; set; }
        public List<Employee> Employees { get; set; }
        public bool IsSingleTeam { get; set; }
    }
}
