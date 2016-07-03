namespace School.Models
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using Interfaces;

    public class SchoolClass : ICommentable
    {
        private string id;
        private string comment;
        private List<Teacher> teachers;
        private List<Student> students;

        public SchoolClass(string id)
        {
            this.Id = id;
            this.teachers = new List<Teacher>();
            this.students = new List<Student>();
        }

        public List<Teacher> Teachers
        {
            get
            {
                return this.teachers;
            }

            set
            {
                this.teachers = value;
            }
        }

        public List<Student> Students
        {
            get
            {
                return this.students;
            }

            set
            {
                this.students = value;
            }
        }

        public string Id
        {
            get
            {
                return this.id;
            }

            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Class Id cannot be empty !");
                }

                this.id = value;
            }
        }

        public string Comment
        {
            get
            {
                return this.comment;
            }

            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Discipline Comment cannot be empty!");
                }

                this.comment = value;
            }
        }

        public void AddTeacher(Teacher t)
        {
            this.teachers.Add(t);
        }

        public void AddStudent(Student s)
        {
            this.students.Add(s);
        }

        public override string ToString()
        {
            var classData = new StringBuilder();
            var divider = new string('=', 80);

            classData.Append($"Class: {this.id}");

            if (!string.IsNullOrEmpty(this.comment))
            {
                classData.Append($" | Comment: {this.comment}");
            }

            classData.AppendLine();

            if (this.teachers.Count > 0)
            {
                foreach (var teacher in this.teachers)
                {
                    classData.AppendLine($"\r\nTeacher: {teacher.ToString()}");
                }
            }

            if (this.students.Count > 0)
            {
                classData.AppendLine("Students:");
                foreach (var student in this.students)
                {
                    classData.AppendLine(student.ToString());
                }
            }

            classData.AppendLine(divider);
           
            return classData.ToString();
        }
    }
}
