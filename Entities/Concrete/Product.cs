using Core.Entities.Abstract;

namespace Entities.Concrete
{
    public class Product : BaseEntity
    {
        public Product()
        {
            Categories = new HashSet<Category>();
        }
        public string Name { get; set; }
        public string Description { get; set; }
        public double Rating { get; set; }
        public decimal Price { get; set; }
        public string ImageUrl { get; set; }
        public ICollection<Category> Categories{ get; set; }
    }
}
