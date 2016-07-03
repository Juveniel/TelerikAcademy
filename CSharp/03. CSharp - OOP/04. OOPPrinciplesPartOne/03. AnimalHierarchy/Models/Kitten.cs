namespace AnimalHierarchy.Models
{
    using System;
    using Interfaces;

    public class Kitten : Cat, ISound
    {
        public Kitten(string name, int age) : base(name, age, Sex.Female)
        {

        }

        public override void MakeSound()
        {
            Console.WriteLine("Meow!");
        }
    }
}
