namespace School.Contracts
{
    using System.Collections.Generic;

    public interface ICourse
    {
        ICollection<IStudent> Students { get; }

        void AddStudent(IStudent student);

        void RemoveStudent(IStudent student);
    }
}