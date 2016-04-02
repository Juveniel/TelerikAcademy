using System;

namespace _02.CompanyInfo
{
    /// <summary>
    /// Write a program that reads the information about a 
    /// company and its manager and prints it back on the console.
    /// </summary>
    class CompanyInfo
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            string address = Console.ReadLine();
            string mobile = Console.ReadLine();
            string fax = Console.ReadLine();
            string site = Console.ReadLine();
            string managerFirstName = Console.ReadLine();
            string managerLastName = Console.ReadLine();
            string managerAge = Console.ReadLine();
            string managerPhone = Console.ReadLine();

            string managerFullName = managerFirstName + " " + managerLastName;
            string managerContacts = "age: " + managerAge + ", tel. " + managerPhone;
            string faxFormatted = fax != "" ? fax : "(no fax)";

            Console.WriteLine("{0}", name);
            Console.WriteLine("Address: {0}", address);
            Console.WriteLine("Tel. {0}", mobile);
            Console.WriteLine("Fax: {0}", faxFormatted);
            Console.WriteLine("Web site: {0}", site);
            Console.WriteLine("Manager: {0}({1})", managerFullName, managerContacts);
        }
    }
}
