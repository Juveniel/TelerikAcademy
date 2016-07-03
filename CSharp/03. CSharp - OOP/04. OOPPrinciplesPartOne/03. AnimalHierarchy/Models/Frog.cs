namespace AnimalHierarchy.Models
{
    using System;
    using Interfaces;

    public class Frog : Animal, ISound
    {
        public Frog(string name, int age, Sex sex) : base(name, age, sex)
        {

        }

        public override void MakeSound()
        {
            Console.WriteLine("Ribbet");
        }
    }
}
