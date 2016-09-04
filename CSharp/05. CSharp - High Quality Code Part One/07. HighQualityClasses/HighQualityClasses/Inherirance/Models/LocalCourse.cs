namespace Inherirance.Models
{
    using System.Collections.Generic;
    using System.Text;

    internal class LocalCourse : Course
    {
        public LocalCourse(string name)
            : base(name)
        {            
        }

        public LocalCourse(string name, string teacherName) 
            : base(name, teacherName)
        {
            this.Lab = null;
        }

        public LocalCourse(string name, string teacherName, IList<string> students)
            : base(name, teacherName, students)
        {
            this.Lab = null;
        }

        public string Lab { get; set; }

        public override string ToString()
        {
            var result = new StringBuilder();
            result.Append(base.ToString());

            if (this.Lab != null)
            {
                result.Append("; Lab = ");
                result.Append(this.Lab);
            }

            result.Append(" }");

            return result.ToString();
        }
    }
}
