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
        public BillServices() {
            _IbillResponsitory = new BillResponsitory();
        }

        public string Add(BillView obj)
        {
            if (obj == null) return "Thêm không thành công!";
            var bill = new Bill()
            {
                Id = obj.Id,
                User_Id = obj.User_Id,
                Voucher_Id = obj.Voucher_Id,
                ProductName = obj.ProductName,
                Create_Date = obj.Create_Date,
                Discount = obj.Discount,
                MaHD = obj.MaHD,
                Total = obj.Total,
                Description = obj.Description,

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
                select new BillView()
                {
                    Id = a.Id,
                    User_Id = a.User_Id,
                    Voucher_Id = a.Voucher_Id,
                    ProductName = a.ProductName,
                    Create_Date = a.Create_Date,
                    Discount = a.Discount,
                    MaHD = a.MaHD,
                    Total = a.Total,
                    Description = a.Description,
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
                Voucher_Id = obj.Voucher_Id,
                ProductName = obj.ProductName,
                Create_Date = obj.Create_Date,
                Discount = obj.Discount,
                MaHD = obj.MaHD,
                Total = obj.Total,
                Description = obj.Description,

            };
            if (_IbillResponsitory.Update(bill)) return "Sửa thành công!";
            return "Sửa không thành công!";
        }
    }
}
