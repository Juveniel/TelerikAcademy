namespace School.Models
{
    using Common;
    using Constants;
    using Contracts;

    public class Student : IStudent
    {
        private const int MinIdValue = 10000;
        private const int MaxIdValue = 99999;

        private string name;
        private int id;

        public Student(string name, int id)
        {
            this.Name = name;
            this.Id = id;
        }

        public string Name
        {
            get
            {
                return this.name;                
            }

            set
            {
                Validator.CheckIfStringIsNullOrEmpty(value, string.Format(ValidatorConstants.ValueCannotBeNull, "Student name"));
                this.name = value;                
            }
        }

        public int Id
        {
            get
            {
                return this.id;                
            }

            set
            {
                Validator.ValidateIntRange(value, MinIdValue, MaxIdValue, 
                    string.Format(ValidatorConstants.NumbersMustBeBetweenMinAndMax, "Student id", MinIdValue, MaxIdValue));

                this.id = value;
            } 
        }

        public void JoinCourse(ICourse course)
        {
            Validator.CheckIfNull(course, string.Format(ValidatorConstants.ValueCannotBeNull, "Course"));

            course.AddStudent(this);
        }

        public void LeaveCourse(ICourse course)
        {
            Validator.CheckIfNull(course, string.Format(ValidatorConstants.ValueCannotBeNull, "Course"));

            course.RemoveStudent(this);
        }
    }
}
