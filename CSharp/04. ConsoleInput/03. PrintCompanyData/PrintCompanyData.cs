using System;

namespace _03.PrintCompanyData
{
    /// <summary>
    /// A given company has name, address, phone number, fax number,
    /// web site and manager. The manager has name, surname and phone number. 
    /// Write a program that reads information about the company and its 
    /// manager and then prints it on the console.
    /// </summary>
    class PrintCompanyData
    {
        static void Main(string[] args)
        {
            Console.Write("Enter company name: ");
            string name = Console.ReadLine();

            Console.Write("Enter address: ");
            string address = Console.ReadLine();

            Console.Write("Enter mobile: ");
            string mobile = Console.ReadLine();

            Console.Write("Enter fax: ");
            string fax = Console.ReadLine();

            Console.Write("Enter site url: ");
            string site = Console.ReadLine();

            Console.WriteLine("Enter the name of the manager: ");
            string manager = Console.ReadLine();

            Console.WriteLine("-/- Company Information -/-");
            Console.WriteLine("The company name is: {0}", name);
            Console.WriteLine("Address: {0}", address);
            Console.WriteLine("Phone number: {0}", mobile);
            Console.WriteLine("Fax number: {0}", fax);
            Console.WriteLine("Web site: {0}", site);
            Console.WriteLine("Manager first name: {0}", manager);
        }
    }
}
