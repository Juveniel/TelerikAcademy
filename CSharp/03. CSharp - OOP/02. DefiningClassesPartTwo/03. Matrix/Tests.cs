namespace _03.Matrix
{
    using System;

    public class Tests
    {
        public static void Main()
        {
            // Create
            Matrix<int> firstMatrix = new Matrix<int>(3, 3); // cahnge rows to 1 to trigger true/false etc :)
            Matrix<int> secondMatrix = new Matrix<int>(3, 3);  // cahnge rows to 1 to trigger true/false etc :)

            // Test indexer
            firstMatrix[0, 0] = 1;
            firstMatrix[0, 1] = 2;
            firstMatrix[0, 2] = 3;

            secondMatrix[0, 0] = 1;
            secondMatrix[0, 1] = 2;
            secondMatrix[0, 2] = 3;

            // Print
            Console.WriteLine("Initial values: ");
            Console.WriteLine(new string('=', 20));
            Console.WriteLine(firstMatrix.ToString());
            Console.WriteLine(secondMatrix.ToString());
            Console.WriteLine(new string('=', 20));

            // Test * operator
            Console.WriteLine("Multiplication result: ");
            var resultProduct = firstMatrix * secondMatrix;
            Console.WriteLine(resultProduct.ToString());
            Console.WriteLine(new string('=', 20));

            // Test + operator
            Console.WriteLine("Addition result: ");
            var resultAddition = firstMatrix + secondMatrix;
            Console.WriteLine(resultAddition.ToString());
            Console.WriteLine(new string('=', 20));

            // Test - operator
            Console.WriteLine("Substraction result: ");
            var resultSubstraction = firstMatrix - secondMatrix;
            Console.WriteLine(resultSubstraction.ToString());
            Console.WriteLine(new string('=', 20));

            // Test boolean operator
            Console.WriteLine("Boolean test: ");
            if (firstMatrix)
            {
                Console.WriteLine("true");
            }
            else
            {
                Console.WriteLine("false");
            } 
        }      
    }
}
