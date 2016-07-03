namespace School.Models
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class Teacher : Person
    {
        private List<Discipline> disciplines;

        public Teacher(string name) : base(name)
        {
            this.disciplines = new List<Discipline>();
        }

        public List<Discipline> Disciplines
        {
            get
            {
                return this.disciplines;
            }

            set
            {
                this.disciplines = value;
            }
        }

        public void AddDiscipline(Discipline d)
        {
            this.disciplines.Add(d);
        }

        public override string ToString()
        {
            var teacherData = new StringBuilder();

            teacherData.Append($"{this.Name} ");
            if (!string.IsNullOrEmpty(this.Comment))
            {
                teacherData.Append($" | Comment: {this.Comment}");
            }

            teacherData.AppendLine();
            if (this.disciplines.Count > 0)
            {
                foreach (var disc in this.disciplines)
                {
                    teacherData.AppendLine(disc.ToString());
                }
            }
           
            return teacherData.ToString();
        }
    }
}
