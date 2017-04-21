using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JSjQuery.Models
{
    public class DataManager
    {
        static List<Customer> customers = new List<Customer>
        {
            new Customer {Name = "Carolina", Id = 1},
            new Customer {Name = "Sofia", Id = 2},
            new Customer {Name = "Fredrik", Id = 3}
        };

        public static CustomersIndexVM[] GetAllCustomers()
        {
            List<CustomersIndexVM> customersVM = new List<CustomersIndexVM>();

            foreach (var customer in customers)
            {
                customersVM.Add(new CustomersIndexVM { Name = customer.Name, Id = customer.Id });
            }


            return customersVM.ToArray();
        }

    }
}
