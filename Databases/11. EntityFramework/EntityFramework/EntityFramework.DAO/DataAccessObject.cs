using System;
using System.Collections.Generic;
using System.Linq;
using EntityFramework.Data;

namespace EntityFramework.DAO
{
    public static class DataAccessObject
    {
        public static void InsertCustomer(Customer customer) 
        {
            if (customer == null)
            {
                throw new ArgumentNullException(nameof(customer));
            }

            using (var dbContext = new NorthwindEntities())
            {
                dbContext.Customers.Add(customer);
                dbContext.SaveChanges();
            }
        }      

        public static void UpdateCustomer(Customer customer)
        {
            if (customer == null)
            {
                throw new ArgumentNullException(nameof(customer));
            }

            using (var dbContext = new NorthwindEntities())
            {
                var customerToUpdate = dbContext.Customers.SingleOrDefault(c => c.CustomerID == customer.CustomerID);

                if (customerToUpdate == null)
                {
                    throw new ArgumentNullException(nameof(customerToUpdate));
                }

                dbContext.Entry(customerToUpdate).CurrentValues.SetValues(customer);
                dbContext.SaveChanges();
            }
        }

        public static void RemoveCustomer(Customer customer)
        {
            if (customer == null)
            {
                throw new ArgumentNullException(nameof(customer));
            }

            using (var dbContext = new NorthwindEntities())
            {
                var customerToRemove = dbContext.Customers.SingleOrDefault(c => c.CustomerID == customer.CustomerID);

                if (customerToRemove == null)
                {
                    throw new ArgumentNullException(nameof(customerToRemove));
                }

                dbContext.Customers.Remove(customerToRemove);
                dbContext.SaveChanges();
            }
        }

        public static Customer GetCustomerById(string id)
        {
            Customer customer = null;

            using (var dbContext = new NorthwindEntities())
            {
                customer = dbContext.Customers.SingleOrDefault(c => c.CustomerID == id);
            }
 
            return customer;
        }

        public static IEnumerable<Customer> GetCustomersByOrderYearAndShipmentDestinationCountry(int year, string destinationCountry)
        {
            var customers = new List<Customer>();

            using (var dbContext = new NorthwindEntities())
            {
                customers = dbContext.Orders
                    .Where(o => o.OrderDate.Value.Year == year && o.ShipCountry == destinationCountry)
                    .Select(o => o.Customer)
                    .Distinct()
                    .ToList();
            }

            return customers;
        }

        public static IEnumerable<Customer> GetCustomersByOrderYearAndShipmentDestinationCountrySql(int year, string destinationCountry)
        {
            var customers = new List<Customer>();

            using (var dbContext = new NorthwindEntities())
            {
                 customers = dbContext.Database.SqlQuery<Customer>(
                     $@"SELECT * FROM Customers c 
                        JOIN Orders o
                            ON c.CustomerId = o.CustomerId
                        WHERE YEAR(o.OrderDate) = '{year}'
                        AND o.ShipCountry = '{destinationCountry}'"
                 ).ToList();
            }

            return customers;
        }
    
        public static IEnumerable<Order> GetSalesByRegionAndPeriod(string region, DateTime? startDate, DateTime? endDate)
        {
            var orders = new List<Order>();

            using (var dbContext = new NorthwindEntities())
            {
                orders = dbContext.Orders
                    .Where(o => o.ShipRegion == region &&
                                o.OrderDate >= startDate &&
                                o.OrderDate <= endDate)
                    .ToList();
            }

            return orders;
        }

        public static void CreateNorthwindTwin()
        {
            //Alter connectionconnection string 
            using (var northwindEntities = new NorthwindEntities())
            {
                northwindEntities.Database.CreateIfNotExists();               
            }
        }

        public static void ConcurrentChangesTest()
        {
            using (var northwindEntities = new NorthwindEntities())
            {
                var employee = northwindEntities.Employees.FirstOrDefault();

                if (employee != null)
                {
                    employee.FirstName = "Gosho";
                    employee.LastName = "Petrov";
                    northwindEntities.SaveChanges();
                }
            }

            using (var northwindEntities = new NorthwindEntities())
            {
                var employee = northwindEntities.Employees.FirstOrDefault();

                if (employee != null)
                {
                    employee.FirstName = "Gosho123";
                    employee.LastName = "Petrov123";
                    northwindEntities.SaveChanges();
                }
            }                     
        }    
    }
}
