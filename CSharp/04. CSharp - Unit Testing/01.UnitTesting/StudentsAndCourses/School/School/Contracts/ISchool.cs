namespace School.Contracts
{
    using System.Collections.Generic;

    public interface ISchool
    {
        ICollection<ICourse> Courses { get; }

        ICollection<IStudent> Students { get; }

        void RegisterStudent(IStudent student);

        void UnregisterStudent(IStudent student);

        void CreateCourse(ICourse course);

        void RemoveCourse(ICourse course);
    }
}