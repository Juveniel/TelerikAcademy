using Observer.Models.Abstract;

namespace Observer.Models
{
    internal class ConcreteSubject : Subject
    {
        public string SubjectState { get; set; }
    }
}
