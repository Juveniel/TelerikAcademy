namespace Inherirance.Models
{
    using System.Collections.Generic;
    using System.Text;

    internal class OffsiteCourse : Course
    {
        public OffsiteCourse(string name)
            : base(name)
        {
        }

        public OffsiteCourse(string name, string teacherName) 
            : base(name, teacherName)
        {
        }

        public OffsiteCourse(string name, string teacherName, IList<string> students)
            : base(name, teacherName, students)
        {
        }

        public string Town { get; set; }

        public override string ToString()
        {
            var result = new StringBuilder();
            result.Append(base.ToString());

            if (this.Town != null)
            {
                result.Append("; Town = ");
                result.Append(this.Town);
            }

            result.Append(" }");

            return result.ToString();
        }
    }
}
