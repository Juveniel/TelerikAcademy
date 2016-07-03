namespace Person.Models
{
    using System;

    public class Person
    {
        private string name;
        private int? age;

        public Person(string name)
        {
            this.Name = name;
        }

        public Person(string name, int age)
            : this(name)
        {
            this.Age = age;
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
                    throw new ArgumentException("Person name cannot be empty!");
                }

                this.name = value;
            }
        }

        public int? Age
        {
            get
            {
                return this.age;
            }

            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Person age cannot be negative!");
                }

                this.age = value;
            }
        }

        public override string ToString()
        {
            return string.Format(
                "Person: {0} Age: {1}", 
                this.name,
                this.age != null ? this.age.ToString() : "Not specified");
        }
    }
}
