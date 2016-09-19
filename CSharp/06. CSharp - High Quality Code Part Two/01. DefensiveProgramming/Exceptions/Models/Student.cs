namespace Exceptions.Models
{
    using System;  
    using System.Collections.Generic;
    using System.Linq;

    public class Student
    {
        private string firstName;
        private string lastName;

        public Student(string firstName, string lastName, IList<Exam> exams = null)
        {           
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Exams = exams;
        }

        public string FirstName
        {
            get
            {
                return this.firstName;                
            }

            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Firstname cannot be empty!");
                }

                this.firstName = value;
            }
        }

        public string LastName
        {
            get
            {
                return this.lastName;                
            }

            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Lastname cannot be empty!");
                }

                this.lastName = value;
            }
        }

        public IList<Exam> Exams { get; private set; }
        
        public IList<ExamResult> CheckExams()
        {
            if (this.Exams == null)
            {
                throw new ArgumentNullException($"Student: {this.GetFullName()}'s exam list is empty!");
            }

            if (this.Exams.Count == 0)
            {
                throw new ArgumentException($"Student: {this.GetFullName()} doesn't have any exams!");
            }

            var results = this.Exams.Select(e => e.Check()).ToList();

            return results;
        }

        public double CalcAverageExamResultInPercents()
        {
            if (this.Exams == null)
            {               
                throw new ArgumentNullException($"Student: {this.GetFullName()}'s exam list is empty!");
            }

            if (this.Exams.Count == 0)
            {
                throw new ArgumentException($"Student: {this.GetFullName()} doesn't have any exams!");
            }

            var examScore = new double[this.Exams.Count];
            var examResults = this.CheckExams();
            for (var i = 0; i < examResults.Count; i++)
            {
                examScore[i] =
                    ((double)examResults[i].Grade - examResults[i].MinGrade) /
                    (examResults[i].MaxGrade - examResults[i].MinGrade);
            }

            return examScore.Average();
        }

        public string GetFullName()
        {
            var fullName = $"{this.FirstName} {this.LastName}";

            return fullName;
        }
    }
}
