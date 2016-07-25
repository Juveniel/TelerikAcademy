namespace School.Models
{
    using System.Collections.Generic;
    using Common;
    using Constants;
    using Contracts;

    public class School : ISchool
    {
        private string name;
        private ICollection<ICourse> courses;
        private ICollection<IStudent> students;

        public School(string name)
        {
            this.Name = name;
            this.courses = new List<ICourse>();
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
                Validator.CheckIfStringIsNullOrEmpty(value, string.Format(ValidatorConstants.ValueCannotBeNull, "School name"));
                this.name = value;                
            }
        }

        public ICollection<ICourse> Courses
        {
            get
            {
                return new List<ICourse>(this.courses);
            }           
        }

        public ICollection<IStudent> Students
        {
            get
            {
                return new List<IStudent>(this.students);
            }
        }

        public void RegisterStudent(IStudent student)
        {
            Validator.CheckIfNull(student, string.Format(ValidatorConstants.ValueCannotBeNull, "Student"));
            Validator.CheckExisting<IStudent>(this.students, student, string.Format(ValidatorConstants.ValueMustBeUnique, "Student", this.Name));
            Validator.CheckStudentId(this.students, student, string.Format(ValidatorConstants.StudentWithIExists, student.Id));

            this.students.Add(student);
        }

        public void UnregisterStudent(IStudent student)
        {
            Validator.CheckIfNull(student, string.Format(ValidatorConstants.ValueCannotBeNull, "Student"));
            Validator.CheckNotExisting<IStudent>(this.students, student, string.Format(ValidatorConstants.ValueNotExisting, "Student", this.Name));

            this.students.Remove(student);
        }

        public void CreateCourse(ICourse course)
        {            
        }

        public void RemoveCourse(ICourse course)
        {            
        }
    }
}
