using Core.Entities.Abstract;

namespace Entities.Concrete
{
    public class Comment : BaseEntity
    {
     
        public int NewsId { get; set; }
        public News News { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }
        public int CommentToId { get; set; }
        public Comment CommentTo { get; set; }
        public ICollection<Comment> Comments { get; set; }

    }
}
