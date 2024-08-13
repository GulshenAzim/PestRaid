using Core.Entities.Abstract;

namespace Entities.Concrete
{
    public class User : BaseEntity
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string ImageUrl { get; set; }
        public string PasswordHash { get; set; }
        public ICollection<UserRole> Roles { get; set; }
        public ICollection<Comment> Comments { get; set; }

    }
}
