namespace School.Models
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class School
    {
        private string name;
        private List<SchoolClass> classes;

        public School(string name)
        {
            this.Name = name;
            this.classes = new List<SchoolClass>();
        }

        public string Name
        {
            get
            {
                return this.name;
            }

            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("School name cannot be empty");
                }

                this.name = value;
            }
        }

        public List<SchoolClass> Classes
        {
            get
            {
                return this.classes;
            }

            private set
            {
                this.classes = value;
            }
        }

        public void AddClass(SchoolClass schoolClass)
        {
            this.classes.Add(schoolClass);
        }

        public override string ToString()
        {
            var schoolData = new StringBuilder();
            var divider = new string('-', 20);

            schoolData.AppendLine($"School name: {this.name}");
            schoolData.AppendLine(divider);

            foreach (var schoolClass in this.classes)
            {
                schoolData.AppendLine(schoolClass.ToString());
            }

            return schoolData.ToString();
        }
    }
}
