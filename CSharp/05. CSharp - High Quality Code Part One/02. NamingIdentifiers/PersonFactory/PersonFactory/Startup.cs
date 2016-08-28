namespace PersonFactory
{
    using System;
    using Models;

    internal class Startup
    {
        public static void Main()
        {
            var dude = Person.Create(18);
            var chick = Person.Create(17);

            Console.WriteLine(dude.Name);
            Console.WriteLine(chick.Name);
        }
    }
}
