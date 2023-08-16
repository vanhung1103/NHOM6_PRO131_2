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
    public class BillServices : IBillServices

    {
        public IBillResponsitory _IbillResponsitory;
        public ICustomerResponsitory _IcustomerResponsitory;
        public BillServices() {
            _IbillResponsitory = new BillResponsitory();
            _IcustomerResponsitory = new CustomerResponsitory();
        }

        public string Add(BillView obj)
        {
            if (obj == null) return "Thêm không thành công!";
            var bill = new Bill()
            {
                Id = obj.Id,
                User_Id = obj.User_Id,
                Create_Date = obj.Create_Date,
                Discount = obj.Discount,
                MaHD = obj.MaHD,
                Status = obj.Status,
                Customer_Id = obj.Customer_Id


            };
            if (_IbillResponsitory.Add(bill)) return "Thêm  thành công!";
            return "Thêm không thành công!";
        }

        public List<BillView> Get()
        {
            List<BillView> lst = new List<BillView>();
            lst =
                (
                from a in _IbillResponsitory.GetAll()
                join b in _IcustomerResponsitory.GetAllCustomer() on a.Customer_Id equals b.CustomerId
                select new BillView()
                {
                    Id = a.Id,
                    User_Id = a.User_Id,
                    Create_Date = a.Create_Date,
                    Discount = a.Discount,
                    MaHD = a.MaHD,
                    Customer_Id = a.Customer_Id,
                    Status = a.Status,
                    Name = b.Name,
                    Phone = b.Phone,
                    Email = b.Email,
                    Gender = b.Gender,
                    Address = b.Address
                }
                ).ToList();
            return lst;
        }

        public string Remove(Guid obj)
        {
            if (obj == null) return "Xóa không thành công!";
            if (_IbillResponsitory.Remove(obj)) return "Xóa  thành công!";
            return "Xóa không thành công!";
        }

        public string Update(BillView obj)
        {
            if (obj == null) return "Sửa không thành công!";
            var bill = new Bill()
            {
                Id = obj.Id,
                User_Id = obj.User_Id,
                Create_Date = obj.Create_Date,
                Discount = obj.Discount,
                MaHD = obj.MaHD,
                Status = obj.Status,
                Customer_Id = obj.Customer_Id
                

            };
            if (_IbillResponsitory.Update(bill)) return "Sửa thành công!";
            return "Sửa không thành công!";
        }
    }
}
