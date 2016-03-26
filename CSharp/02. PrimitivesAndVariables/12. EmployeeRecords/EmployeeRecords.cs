using System;

namespace _12.EmployeeRecords
{
    class EmployeeRecords
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-/- Marketing company employee record data -/-");
            
            /* Receive user input */
            Console.Write("Enter employee first name: ");
            string empFirstName = Console.ReadLine();

            Console.Write("Enter employee last name: ");
            string empLastName = Console.ReadLine();

            Console.Write("Enter employee age:  ");
            int empAge = int.Parse(Console.ReadLine());

            Console.Write("Enter employee gender:  ");
            char empGender = char.Parse(Console.ReadLine());

            Console.Write("Enter employee unique code:  ");
            int empUniqueCode = int.Parse(Console.ReadLine());

            Console.WriteLine();

            /* Print the result */
            Console.WriteLine("====================================");
            Console.WriteLine("-/- Employee record -/-");
            Console.WriteLine("====================================");
            Console.Write("Employee:   ");
            Console.WriteLine(empFirstName + " " + empLastName);
            Console.Write("Age: ");
            Console.WriteLine(empAge);
            Console.Write("Gender: ");
            Console.WriteLine(empGender == 'm' ? "Male" : "Female");
            Console.Write("Unique ID: ");
            Console.WriteLine(empUniqueCode);
            Console.WriteLine("====================================\n");
        }
    }
}
