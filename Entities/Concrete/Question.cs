using Core.Entities.Abstract;

namespace Entities.Concrete
{
    public class Question : BaseEntity
    {
        public string QuestionText { get; set; }
        public string Answer { get; set; }
    }
}
