using Core.Entities.Abstract;

namespace Entities.Concrete
{
    public class About : BaseEntity
    {
        public string Title { get; set; }
        public string Description { get; set; }
    }
}
