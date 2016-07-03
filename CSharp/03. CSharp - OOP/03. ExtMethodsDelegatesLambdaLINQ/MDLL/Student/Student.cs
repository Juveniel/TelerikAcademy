namespace MDLL
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class Student
    {
        private string firstName;
        private string lastName;
        private string telephone;
        private string email;
        private int facultyNumber;
        private int groupNumber;
        private int age;
        private List<double> marks;

        public Student()
        {
        }

        public Student(string firstName, string lastName) : this()
        {
            this.FirstName = firstName;
            this.LastName = lastName;
        }

        public Student(string firstName, string lastName, string telephone, string email, int fn, int group, int age, List<double> marks) 
            : this(firstName, lastName)
        {
            this.Telephone = telephone;
            this.Email = email;
            this.FacultyNumber = fn;
            this.GroupNumber = group;
            this.Age = age;          
            this.Marks = new List<double>(marks);                                      
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
                    throw new ArgumentException("First Name cannot be empty!");
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
                    throw new ArgumentException("Last Name cannot be empty!");
                }

                this.lastName = value;
            }
        }

        public string Telephone
        {
            get
            {
                return this.telephone;
            }

            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Telephone cannot be empty!");
                }

                this.telephone = value;
            }
        }

        public string Email
        {
            get
            {
                return this.email;
            }

            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Email cannot be empty!");
                }

                this.email = value;
            }
        }

        public int FacultyNumber
        {
            get
            {
                return this.facultyNumber;
            }

            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Faculty Number cannot be 0!");
                }

                this.facultyNumber = value;
            }
        }

        public int Age
        {
            get
            {
                return this.age;
            }

            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Age cannot be negative value!");
                }

                this.age = value;
            }
        }

        public int GroupNumber
        {
            get
            {
                return this.groupNumber;
            }

            set
            {
                this.groupNumber = value;
            }
        }

        public List<double> Marks
        {
            get
            {
                return this.marks;
            }

            set
            {
                this.marks = value;
            }
        }

        public override string ToString()
        {
            var studentInformation = new StringBuilder();

            studentInformation.AppendLine("Student information: ");
            studentInformation.AppendFormat("First name: {0}", this.firstName).AppendLine();
            studentInformation.AppendFormat("Last name: {0}", this.lastName).AppendLine();
            studentInformation.AppendFormat("Telephone: {0}", this.telephone).AppendLine();
            studentInformation.AppendFormat("Email: {0}", this.email).AppendLine();
            studentInformation.AppendFormat("Faculty number: {0}", this.facultyNumber).AppendLine();
            studentInformation.AppendFormat("Age: {0}", this.age).AppendLine();
            studentInformation.AppendFormat("Goup: {0}", this.groupNumber).AppendLine();

            if (this.marks.Count > 0)
            {
                studentInformation.AppendFormat("Marks: {0}", string.Join(",", this.marks)).AppendLine();
            }
         
            return studentInformation.ToString();
        }
    }
}
