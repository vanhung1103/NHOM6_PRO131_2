using _1_DAL.IResponsitory;
using _1_DAL.Models;
using _1_DAL.Responsitory;
using _2_BUS.IServices;
using _2_BUS.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_BUS.Services
{
    public class CustomerServices : ICustomerServices
    {
         ICustomerResponsitory _CustomerrRepon;
        public CustomerServices()
        {
            _CustomerrRepon = new CustomerResponsitory();
        }
        public string AddCustomer(CustomerView customer)
        {
            if (customer == null) return "Thêm không thành công!";
            var cus = new Customer()
            {
                CustomerId = customer.CustomerId,
                Name= customer.Name,
                Gender= customer.Gender,
                Address= customer.Address,
                Phone= customer.Phone,
                Email= customer.Email,
                Feedback= customer.Feedback,
                

            };
            if (_CustomerrRepon.CreateCustomer(cus)) return "Thêm  thành công!";
            return "Thêm không thành công!";
        }

        public string DeleteCustomer(Guid customer)
        {
            if (_CustomerrRepon.DeleteCustomer(customer))
            {
                return "Xóa thành công";
            }
            return "Eror";
        }
        public List<CustomerView> GetCustomer()
        {
            List<CustomerView> lst = new List<CustomerView>();
            lst =
                (
                from a in _CustomerrRepon.GetAllCustomer()
                select new CustomerView()
                {
                    CustomerId= a.CustomerId,
                    Name= a.Name,
                    Gender= a.Gender,
                    Address= a.Address,
                    Phone= a.Phone,
                    Email= a.Email,
                    Feedback= a.Feedback,
                }
                ).ToList();
            return lst;
        }

        public Customer GetCustomerById(Guid id)
        {
            return _CustomerrRepon.GetCustomerById(id);
        }

        public string UpdateCustomer(CustomerView customer)
        {
            if (customer == null) return "Sửa không thành công!";
            var cus = new Customer()
            {

                CustomerId = customer.CustomerId,
                Name = customer.Name,
                Gender = customer.Gender,
                Address = customer.Address,
                Phone = customer.Phone,
                Email = customer.Email,
                Feedback = customer.Feedback,
            };
            if (_CustomerrRepon.UpdateCustomer(cus)) return "Sửa  thành công!";
            return "Sửa không thành công!";
        }
    }
}
