namespace AnimalHierarchy.Models
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using Interfaces;

    public enum Sex
    {
        Male,
        Female
    }

    public abstract class Animal : ISound
    {
        private string name;
        private int age;
        private Sex sex; 

        public Animal(string name, int age)
        {
            this.Name = name;
            this.Age = age;
        }

        public Animal(string name, int age, Sex sex) : this (name, age)
        {
            this.Sex = sex;
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
                    throw new ArgumentException("Animal name cannot be empty!");
                }

                this.name = value;
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
                if(value < 0)
                {
                    throw new ArgumentException("Animal age cannot be negative!");
                }

                this.age = value;
            }
        }

        public Sex Sex
        {
            get
            {
                return this.sex;
            }

            set
            {
                this.sex = value;
            }
        }

        public abstract void MakeSound();

        public override string ToString()
        {
            return string.Format("{0} {1} {2}", this.name, this.sex, this.age);
        }

        public static void PrintAverageAge(IEnumerable<Animal> animals)
        {
            var animalsByType = animals.GroupBy(x => x.GetType());

            foreach(var animalGroup in animalsByType)
            {
                Console.WriteLine("{0} = {1:F2}", animalGroup.Key.Name, animalGroup.Average(a => a.age));
            }
        }
    }
}
