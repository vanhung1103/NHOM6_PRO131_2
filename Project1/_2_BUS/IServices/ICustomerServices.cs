using _1_DAL.Models;
using _2_BUS.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_BUS.IServices
{
    public interface ICustomerServices
    {
        public List<CustomerView> GetCustomer();
        public string AddCustomer(CustomerView customer);
        public string DeleteCustomer(Guid id);
        public string UpdateCustomer(CustomerView customer);
        public Customer GetCustomerById(Guid id);
    }
}
