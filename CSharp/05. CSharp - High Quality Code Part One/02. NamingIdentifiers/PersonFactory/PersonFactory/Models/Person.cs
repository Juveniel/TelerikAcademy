namespace PersonFactory.Models
{
    using Enumeratons;

    internal class Person
    {
        public Person()
        {           
        }

        public Person(string name, GenderType gender, int age)
        {
            this.Name = name;
            this.Gender = gender;
            this.Age = age;
        }

        public string Name { get; set; }

        public GenderType Gender { get; set; }

        public int Age { get; set; }

        public static Person Create(int age)
        {
            var newPerson = new Person
            {
                Age = age
            };

            if (newPerson.Age % 2 == 0)
            {
                newPerson.Name = "Dude";
                newPerson.Gender = GenderType.Male;
            }
            else
            {
                newPerson.Name = "Chick";
                newPerson.Gender = GenderType.Female;              
            }

            return newPerson;
        }
    }
}
