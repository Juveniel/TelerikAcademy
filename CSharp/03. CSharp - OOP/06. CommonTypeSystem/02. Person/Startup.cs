namespace Person
{
    using System;
    using Models;

    public class Startup
    {
        internal static void Main()
        {
            var pesho = new Person("Pesho");
            var gosho = new Person("Gosho", 20);

            Console.WriteLine(pesho);
            Console.WriteLine(gosho);
        }
    }
}
