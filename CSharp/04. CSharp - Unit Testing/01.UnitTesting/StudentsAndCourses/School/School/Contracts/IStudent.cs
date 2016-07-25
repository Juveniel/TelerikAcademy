namespace School.Contracts
{
    public interface IStudent
    {
        int Id { get; set; }

        void JoinCourse(ICourse course);

        void LeaveCourse(ICourse course);
    }
}