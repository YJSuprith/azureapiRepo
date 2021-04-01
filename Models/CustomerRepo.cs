using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CustomerManagmentProject.Models
{
    public class CustomerRepo : IRepo<Customer>
    {
        public List<Customer> customers { get; set; }
        public CustomerRepo()
        {
            customers = new List<Customer>()
            {
                new Customer
                {
                    Id=101,
                    Name="Ramu",
                    Age=21
                }
            };
        }

        public void AddItem(Customer item)
        {
            customers.Add(item);
        }

        public IEnumerable<Customer> GetItems()
        {
            return customers;
        }
    }
}
