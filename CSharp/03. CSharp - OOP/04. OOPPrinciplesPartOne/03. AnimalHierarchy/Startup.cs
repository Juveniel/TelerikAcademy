namespace AnimalHierarchy
{
    using System;
    using System.Collections.Generic;
    using Models;

    public class Startup
    {
        private static List<Animal> animals = new List<Animal>
        {
            new Dog("Doggy", 15, Sex.Male),
            new Cat("Catty", 5, Sex.Female),
            new Kitten("Kitty", 2),
            new Tomcat("Tomcatty", 15),
            new Frog("Froggy", 2, Sex.Male),
            new Dog("Doggy2", 13, Sex.Male),
            new Cat("Catty2", 3, Sex.Female),
            new Kitten("Kitty2", 1),
            new Tomcat("Tomcatty2", 9),
            new Frog("Froggy2", 8, Sex.Male),
            new Dog("Doggy3", 10, Sex.Male),
            new Cat("Catty3", 8, Sex.Female),
            new Kitten("Kitty3", 6),
            new Tomcat("Tomcatty3", 3),
            new Frog("Froggy3", 1, Sex.Male)
        };

        public static void Main()
        {
            // 1. Print collection
            Console.WriteLine("Original collection: ");
            foreach(var animal in animals)
            {
                Console.WriteLine(animal);
            }

            // 2. Calculate average age of each kinbd of animal
            Console.WriteLine("\r\nAverage age of each animal group: ");
            Animal.PrintAverageAge(animals);
        }
    }
}
