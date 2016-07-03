namespace School.Models
{
    using System;
    using System.Text;

    public class Student : Person
    {
        private int id;

        public Student(int id, string name) : base(name)
        {
            this.Id = id;
        }

        public int Id
        {
            get
            {
                return this.id;
            }

            private set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Id cannot be less or equal ot 0");
                }

                this.id = value;
            }
        }

        public override string ToString()
        {
            var studentData = new StringBuilder();

            studentData.AppendFormat("Id:{0} | Name:{1}", this.id, this.Name);
            if (!string.IsNullOrEmpty(this.Comment))
            {
                studentData.Append($"| Comment: {this.Comment}");
            }

            return studentData.ToString();
        }
    }
}
