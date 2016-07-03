namespace AnimalHierarchy.Models
{
    using System;
    using Interfaces;

    public class Cat : Animal, ISound
    {
        public Cat(string name, int age, Sex sex) : base(name, age, sex)
        {

        }

        public override void MakeSound()
        {
            Console.WriteLine("Myauu");
        }
    }
}
