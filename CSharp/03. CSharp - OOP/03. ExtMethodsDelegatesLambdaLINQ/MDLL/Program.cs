namespace MDLL
{
    using MDLL.Tests;

    public class Program
    {
        public static void Main(string[] args)
        {                     
            // Task 1. StringBuilder Extension Test
            StringBuilderExtensionTest.Test();

            // Task 2. IEnumerable Extension Test
            IEnumerableExtensionTest.Test();

            // Tasks 3-5 Testing queris with a collection of students
            StudentsCollectionTest.Test();

            // Task 6.Integer Extension Test
            IntegerExtensionTest.Test();

            // Task 7 and 8. Timer Test -> UNCOMMENT TO RUN IT (aka thread.Sleep :) )
            // TimerTest.Test();  

            // Task 9
            LINQTests.Test();
        }
    }
}
