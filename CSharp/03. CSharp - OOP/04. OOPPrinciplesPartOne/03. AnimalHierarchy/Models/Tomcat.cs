namespace AnimalHierarchy.Models
{
    using System;
    using Interfaces;

    public class Tomcat : Animal, ISound
    {
        public Tomcat(string name, int age) : base(name, age, Sex.Male)
        {

        }

        public override void MakeSound()
        {
            Console.WriteLine("Tomcat miao");
        }
    }
}
