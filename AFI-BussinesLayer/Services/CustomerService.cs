using AFI_DAL.Context;
using AFI_DAL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AFI_BussinesLayer.Services
{
    public class CustomerService : ICustomerService
    {
        public int registerCustomer(Customer customer )
        {
            using (var context = new AFIContext())
            {
                var result = context.Customers.Add(customer);
                return result.Entity.ID;
            }
        }

    }
}
