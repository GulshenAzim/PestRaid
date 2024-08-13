using Core.Entities.Abstract;

namespace Entities.Concrete
{
    public class Category : BaseEntity
    {
        public Category()
        {
            Products = new HashSet<Product>();
            News = new HashSet<News>();
        }
        public string Name { get; set; }
        public ICollection<Product> Products { get; set; }
        public ICollection<News> News { get; set; }

    }
}
