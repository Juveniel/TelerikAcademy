namespace School.Models
{
    using System;
    using System.Text;
    using Interfaces;

    public class Discipline : ICommentable
    {
        private string name;
        private string comment;
        private int numberOfLectures;
        private int numberOfExercises;

        public Discipline(string name)
        {
            this.Name = name;
        }

        public Discipline(string name, int numberOfLectures, int numberOfExercises) : this(name)
        {
            this.NumberOfLectures = numberOfLectures;
            this.NumberOfExercises = numberOfExercises;
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
                    throw new ArgumentException("Discipline Name cannot be empty !");
                }

                this.name = value;
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

        public int NumberOfLectures
        {
            get
            {
                return this.numberOfLectures;
            }

            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Number of lectures cannot be negative!");
                }

                this.numberOfLectures = value;
            }
        }

        public int NumberOfExercises
        {
            get
            {
                return this.numberOfLectures;
            }

            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Number of exercises cannot be negative!");
                }

                this.numberOfExercises = value;
            }
        }

        public override string ToString()
        {
            var disciplineData = new StringBuilder();

            disciplineData.Append($"Disc: {this.name} | Num of lectures: {this.numberOfLectures} | Num of Exercises: {this.numberOfExercises}");

            if (!string.IsNullOrEmpty(this.comment))
            {
                disciplineData.Append($"| Comment: {this.comment}");
            }

            return disciplineData.ToString();
        }
    }
}
