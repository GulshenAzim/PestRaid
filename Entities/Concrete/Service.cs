using Core.Entities.Abstract;

namespace Entities.Concrete
{
    public class Service : BaseEntity
    {
        public string Name { get; set; }
        public string ImageUrl { get; set; }
        public string Details { get; set; }
        public DateTime Date { get; set; }
        public List<Team> Teams { get; set; }
    }
}
