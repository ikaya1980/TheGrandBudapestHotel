using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TheGrandBudapestHotel.Core;

namespace TheGrandBudapestHotel.Data
{
    public class InMemoryCustomerData : ICustomerData
    {
        readonly List<Customer> customers;

        public InMemoryCustomerData()
        {
            customers = new List<Customer>()
            {
                new Customer { CustomerID = 1, FirstName= "Scott", LastName="Alen", MiddleName="", Nationality=Nationality.Others},
                new Customer { CustomerID = 2, FirstName= "Allison", LastName="Parker", MiddleName="", Nationality=Nationality.Others},
                new Customer { CustomerID = 3, FirstName= "Jonathan", LastName="Larson", MiddleName="J.", Nationality=Nationality.Others}

            };
        }


        public Customer Add(Customer customer)
        {
            this.customers.Add(customer);
            customer.CustomerID++;
            return customer;
        }

        public int Commit()
        {
            return 0;
        }

        public Customer Delete(int id)
        {
            var customer = customers.FirstOrDefault(r => r.CustomerID == id);
            if (customer != null)
            {
                customers.Remove(customer);
            }
            return null;
        }

        public Customer GetById(int id)
        {
            return customers.SingleOrDefault(r => r.CustomerID == id);
        }

        public IEnumerable<Customer> GetCustomers()
        {
            return customers;
        }

        public Customer Update(Customer updateCustomer)
        {
            var customer = customers.SingleOrDefault(r => r.CustomerID == updateCustomer.CustomerID);
            if (customer != null)
            {
                customer.FirstName = updateCustomer.FirstName;
                customer.MiddleName = updateCustomer.MiddleName;
                customer.LastName = updateCustomer.LastName;
                customer.Nationality = updateCustomer.Nationality;
                
            }
            return customer;
        }
    }
}
