namespace StudentsAndWorkers.Models
{
    using System;

    public class Student : Human
    {
        private int grade;

        public Student(string firstName, string lastName, int grade) : base(firstName, lastName)
        {
            this.Grade = grade;
        }

        public int Grade
        {
            get
            {
                return this.grade;
            }

            set
            {
                if (value < 2 || value > 6)
                {
                    throw new ArgumentException("Grade must be between 2 and 6!");
                }

                this.grade = value;
            }
        }

        public override string ToString()
        {
            return string.Format("Student: {0} | Greade: {1}", this.GetFullName(), this.grade);
        }
    }
}
