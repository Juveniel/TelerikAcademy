namespace Matrix
{
    using System;
    using Contracts;
    using Models;
    using Utils;

    public class Startup
    {
        public static void Main()
        {
            Console.WriteLine("Enter a positive number ");
            var input = int.Parse(Console.ReadLine());
      
            var matrix = new Matrixx(input);
            var numberCounter = 1;
            var direction = new Direction(1, 1);

            matrix.Fill(direction, ref numberCounter);                 

            IWriter writer = new Writer();
            matrix.Print(writer);
        }
    }
}
