using System;
using System.Text;
using EntityFramework.Data;
using EntityFramework.DAO;

namespace EntityFramework.ConsoleClient
{
    public class Startup
    {
        private static StringBuilder builder = new StringBuilder();
        private const string CustomerId = "QWER";

        public static void Main()
        {
            /* 1. Customer CRUD */
            InsertCustomer(CustomerId, "ALPHAXasd");
            UpdateCustomer(CustomerId);
            RemoveCustomer(CustomerId);

            /* 2. Customer queries */
            var foundCustomers = CustomersByOrderYearAndShipmentDestinationCountry(1998, "Germany");
            Console.WriteLine(foundCustomers);

            var foundCustomersSql = CustomersByOrderYearAndShipmentDestinationCountrySQL(1998, "Spain");
            Console.WriteLine(foundCustomersSql);

            var orderStartDate = new DateTime(1996, 10, 01);
            var orderEndDate = new DateTime(1998, 10, 01);
            var ordersFound = FindsAllSalesByRegionAndPeriod("Isle of Wight", orderStartDate, orderEndDate);
            Console.WriteLine(ordersFound);

            /* 3. Create twin database */
           // DataAccessObject.CreateNorthwindTwin();

            /* 4. Concurrency test */
            DataAccessObject.ConcurrentChangesTest();

        }

        private static void InsertCustomer(string customerId, string companyName)
        {
            var customer = new Customer()
            {
                CustomerID = customerId,
                CompanyName = companyName                         
            };

            DataAccessObject.InsertCustomer(customer);
        }

        private static void UpdateCustomer(string customerId)
        {
            var customer = DataAccessObject.GetCustomerById(customerId);
            customer.Country = "TestCountry";
            customer.Address = "TestAddress";
            customer.City = "TestCity";

            DataAccessObject.UpdateCustomer(customer);
        }

        private static void RemoveCustomer(string customerId)
        {
            var customer = DataAccessObject.GetCustomerById(customerId);

            DataAccessObject.RemoveCustomer(customer);
        }

        private static string CustomersByOrderYearAndShipmentDestinationCountry(int year, string destinationCountry)
        {                                 
            var customers = DataAccessObject.GetCustomersByOrderYearAndShipmentDestinationCountry(year, destinationCountry);

            var customersListBuilder = builder;
            customersListBuilder.Clear();
            customersListBuilder.AppendLine($"Customers by: OrderYear: {year}, Country: {destinationCountry}");

            foreach (var customer in customers)
            {
                customersListBuilder.AppendLine($" - Name: {customer.ContactName}, Country: {customer.Country}");
            }

            return customersListBuilder.ToString();
        }

        private static string CustomersByOrderYearAndShipmentDestinationCountrySQL(int year, string destinationCountry)
        {
            var customers = DataAccessObject.GetCustomersByOrderYearAndShipmentDestinationCountrySql(year, destinationCountry);

            var customersListBuilder = builder;
            customersListBuilder.Clear();
            customersListBuilder.AppendLine($"Customers(SQL) by: OrderYear: {year}, Country: {destinationCountry}");

            foreach (var customer in customers)
            {
                customersListBuilder.AppendLine($" - Name: {customer.ContactName}, Country: {customer.Country}");
            }

            return customersListBuilder.ToString();
        }

        private static string FindsAllSalesByRegionAndPeriod(string shipReagion, DateTime startDate, DateTime endDate)
        {
            var orders = DataAccessObject.GetSalesByRegionAndPeriod(shipReagion, startDate, endDate);

            var ordersListBuilder = builder;
            ordersListBuilder.Clear();
            ordersListBuilder.AppendLine($"Orders by: Region: {shipReagion}, Start date: {startDate}, End date: {endDate}");

            foreach (var order in orders)
            {
                ordersListBuilder.AppendLine($" - Region: {order.ShipRegion}, Date: {order.OrderDate}");
            }

            return ordersListBuilder.ToString();
        }
    }
}
