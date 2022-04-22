using AFI_DAL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AFI_BussinesLayer
{
    interface ICustomerService
    {
        public int registerCustomer(Customer customer);
    }
}
