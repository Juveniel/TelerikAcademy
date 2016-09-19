namespace Exceptions
{
    using System;
    using System.Collections.Generic;
    using Models;
    using Utils;

    public class Startup
    {
        public static void Main()
        {
            // 1. Subsequence
            var substr = MathHelper.Subsequence("Hello!".ToCharArray(), 2, 3);
            Console.WriteLine(substr);

            var subarr = MathHelper.Subsequence(new int[] { -1, 3, 2, 1 }, 0, 2);
            Console.WriteLine(string.Join(" ", subarr));

            var allarr = MathHelper.Subsequence(new int[] { -1, 3, 2, 1 }, 0, 4);
            Console.WriteLine(string.Join(" ", allarr));

            var emptyarr = MathHelper.Subsequence(new int[] { -1, 3, 2, 1 }, 0, 0);
            Console.WriteLine(string.Join(" ", emptyarr));
           
            // 2. String Helper
            try
            {
                Console.WriteLine(StringHelper.ExtractEnding("I love C#", 2));
                Console.WriteLine(StringHelper.ExtractEnding("Nakov", 4));
                Console.WriteLine(StringHelper.ExtractEnding("beer", 4));
                Console.WriteLine(StringHelper.ExtractEnding("Hi", 100));
            }
            catch (ArgumentOutOfRangeException)
            {
                Console.WriteLine("Invalid parameters");
            }

            // 3. Prime Checker
            try
            {
                MathHelper.CheckPrime(23);
                Console.WriteLine("23 is prime.");
            }
            catch (Exception)
            {
                Console.WriteLine("23 is not prime");
            }

            try
            {
                MathHelper.CheckPrime(33);
                Console.WriteLine("33 is prime.");
            }
            catch (Exception)
            {
                Console.WriteLine("33 is not prime");
            }

            // 4. Exam System
            var peterExams = new List<Exam>()
            {
                new SimpleMathExam(2),
                new CSharpExam(55),
                new CSharpExam(100),
                new SimpleMathExam(1),
                new CSharpExam(0),
            };

            var peter = new Student("Peter", "Petrov", peterExams);
            var peterAverageResult = peter.CalcAverageExamResultInPercents();
            Console.WriteLine($"Average results = {peterAverageResult:p0}");
        }
    }
}
