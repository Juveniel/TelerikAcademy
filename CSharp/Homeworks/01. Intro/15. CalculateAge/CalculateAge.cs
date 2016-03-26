using System;
using System.Globalization;

namespace _15.CalculateAge
{
    class CalculateAge
    {
        static void Main(string[] args)
        {        
            DateTime birthDate = DateTime.ParseExact(Console.ReadLine(), "MM.dd.yyyy", CultureInfo.InvariantCulture);
            
            if(birthDate.Year <= 2016)
            {
                int currentAge = GetAge(birthDate);
               
                Console.WriteLine(currentAge);
                Console.WriteLine(currentAge + 10);             
            }
            else
            {
                Console.WriteLine("Birth year must be less than 2016!");
            }                      
        }

        static int GetAge(DateTime dateOfBirth)
        {
            DateTime today = DateTime.Today;
            int age = today.Year - dateOfBirth.Year;

            if (dateOfBirth > today.AddYears(-age))
            {
                age--;
            }

            return age;
        }
    }
}
