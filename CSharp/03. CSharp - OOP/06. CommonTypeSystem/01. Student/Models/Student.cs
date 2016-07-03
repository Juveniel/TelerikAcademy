namespace Student.Models
{
    using System;
    using System.IO;
    using System.Runtime.Serialization.Formatters.Binary;
    using System.Text;     
    using Enumarations;

    [Serializable]
    public class Student : ICloneable, IComparable<Student>
    {       
        public Student(
            string firstName, 
            string middleName,
            string lastName, 
            string ssn, 
            string address,
            string mobile,
            string email,
            string course,
            Specialties specialty,
            Faculties faculty,
            Universities university)
        {
            this.FirstName = firstName;
            this.MiddleName = middleName;
            this.LastName = lastName;
            this.Ssn = ssn;
            this.PermanentAddress = address;
            this.MobilePhone = mobile;
            this.Email = email;
            this.Course = course;
            this.Specialty = specialty;
            this.Faculty = faculty;
            this.University = university;
        }

        public string FirstName { get; set; }

        public string MiddleName { get; set; }

        public string LastName { get; set; }

        public string Ssn { get; set; }

        public string PermanentAddress { get; set; }

        public string MobilePhone { get; set; }

        public string Email { get; set; }

        public string Course { get; set; }

        public Specialties Specialty { get; set; }

        public Faculties Faculty { get; set; }

        public Universities University { get; set; }     

        public static bool operator ==(Student student1, Student student2)
        {
            return Student.Equals(student1, student2);
        }

        public static bool operator !=(Student student1, Student student2)
        {
            return !Student.Equals(student1, student2);
        }

        public override bool Equals(object obj)
        {            
            Student student = obj as Student;

            if (student == null)
            {
                return false;
            }
                
            if (this.GetFullName() != student.GetFullName() ||
                this.Ssn != student.Ssn ||
                this.PermanentAddress != student.PermanentAddress ||
                this.MobilePhone != student.MobilePhone ||
                this.Email != student.Email ||
                this.Course != student.Course ||
                this.Specialty != student.Specialty ||
                this.Faculty != student.Faculty ||
                this.University != student.University)
            {
                return false;
            }

            return true;            
        }       

        public override int GetHashCode()
        {
            int hash = 17;
   
            hash = (hash * 29) + this.FirstName.GetHashCode();
            hash = (hash * 29) + this.MiddleName.GetHashCode();
            hash = (hash * 29) + this.LastName.GetHashCode();
            hash = (hash * 29) + this.Ssn.GetHashCode();
            hash = (hash * 29) + this.PermanentAddress.GetHashCode();
            hash = (hash * 29) + this.MobilePhone.GetHashCode();
            hash = (hash * 29) + this.Email.GetHashCode();
            hash = (hash * 29) + this.Course.GetHashCode();
            hash = (hash * 29) + this.Specialty.GetHashCode();
            hash = (hash * 29) + this.Faculty.GetHashCode();
            hash = (hash * 29) + this.University.GetHashCode();

            return hash;
        }

        public object Clone()
        {
            object copiedObj;

            using (var ms = new MemoryStream())
            {
                var formatter = new BinaryFormatter();
                formatter.Serialize(ms, this);
                ms.Position = 0;

                copiedObj = formatter.Deserialize(ms);
            }

            return copiedObj;
        }

        public int CompareTo(Student otherStudent)
        {
            if (this.FirstName == otherStudent.FirstName)
            {
                return this.FirstName.CompareTo(otherStudent.FirstName);
            }
            else if (this.LastName == otherStudent.LastName)
            {
                return this.LastName.CompareTo(otherStudent.LastName);
            }
            else
            {
                return this.Ssn.CompareTo(otherStudent.Ssn);
            }           
        }

        public string GetFullName()
        {
            return string.Format($"{this.FirstName} {this.MiddleName} {this.LastName}");
        }

        public override string ToString()
        {
            var studentData = new StringBuilder();

            studentData.AppendLine("Student information: ");
            studentData.AppendFormat("First Name: {0} \n", this.FirstName);
            studentData.AppendFormat("Second Name: {0} \n", this.MiddleName);
            studentData.AppendFormat("Last Name: {0} \n", this.LastName);
            studentData.AppendFormat("SNN : {0} \n", this.Ssn);
            studentData.AppendFormat("Address: {0} \n", this.PermanentAddress);
            studentData.AppendFormat("Phone number : {0} \n", this.MobilePhone);
            studentData.AppendFormat("Email: {0} \n", this.Email);
            studentData.AppendFormat("Course: {0} \n", this.Course);
            studentData.AppendFormat("Specialty: {0} \n", this.Specialty);
            studentData.AppendFormat("University: {0} \n", this.University);
            studentData.AppendFormat("Faculty: {0} \n", this.Faculty);

            return studentData.ToString();
        }
    }
}
