namespace School.Models
{
    using System.Collections.Generic;
    using Common;
    using Constants;
    using Contracts;

    public class Course : ICourse
    {
        private const int MaxStudentsCount = 30;

        private string name;
        private ICollection<IStudent> students;        

        public Course(string name)
        {
            this.Name = name;
            this.students = new List<IStudent>();
        }

        public string Name
        {
            get
            {
                return this.name;
            }

            set
            {
                Validator.CheckIfStringIsNullOrEmpty(value, string.Format(ValidatorConstants.ValueCannotBeNull, "Course name"));
                this.name = value;
            }
        }

        public ICollection<IStudent> Students
        {
            get
            {
                return new List<IStudent>(this.students);
            }
        }

        public void AddStudent(IStudent student)
        {
            Validator.CheckIfNull(student, string.Format(ValidatorConstants.ValueCannotBeNull, "Student"));
            Validator.ValidateIntRange(this.Students.Count, 0, MaxStudentsCount, string.Format(ValidatorConstants.NumbersMustBeBetweenMinAndMax, "Sudent count", 0, MaxStudentsCount));
            Validator.CheckExisting<IStudent>(this.students, student, string.Format(ValidatorConstants.ValueMustBeUnique, "Student", this.Name));

            this.students.Add(student);
        }

        public void RemoveStudent(IStudent student)
        {
            Validator.CheckIfNull(student, string.Format(ValidatorConstants.ValueCannotBeNull, "Student"));
            Validator.CheckNotExisting<IStudent>(this.students, student, string.Format(ValidatorConstants.ValueNotExisting, "Student", this.Name));

            this.students.Remove(student);
        }
    }
}
