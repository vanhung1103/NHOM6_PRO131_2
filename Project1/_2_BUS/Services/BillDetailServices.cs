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
    public class BillDetailServices : IBillDetailServices
    {
        public IBillDetailResponsitory _ibillDetailResponsitory;
        public BillDetailServices()
        {
            _ibillDetailResponsitory = new BilllDetailResponsitory();
        }
        public string Add(BillDetailView obj)
        {
            if (obj == null) return "Thêm không thành công!";
            var billd = new BillDetail()
            {
                MaHDCT = obj.MaHDCT,
                Bill_Id = obj.Bill_Id,
                Pro_Id = obj.Pro_Id,
                Id = obj.Id,
                Quantity = obj.Quantity,
                Price = obj.Price,
                Image = obj.Image
               

            };
            if (_ibillDetailResponsitory.Add(billd)) return "Thêm  thành công!";
            return "Thêm không thành công!";
        }

        public List<BillDetailView> Get()
        {
            List<BillDetailView> lst = new List<BillDetailView>();
            lst =
                (
                from a in _ibillDetailResponsitory.GetAll()
                select new BillDetailView()
                {
                    MaHDCT = a.MaHDCT,
                    Bill_Id = a.Bill_Id,
                    Pro_Id = a.Pro_Id,
                    Id = a.Id,
                    Quantity = a.Quantity,
                    Price = a.Price,
                    Image = a.Image


                }
                ).ToList();
            return lst;
        }

        public string Remove(Guid obj)
        {
            if (obj == null) return "Xóa không thành công!";
            if (_ibillDetailResponsitory.Remove(obj)) return "Xóa  thành công!";
            return "Xóa không thành công!";
        }

        public string Update(BillDetailView obj)
        {
            if (obj == null) return "Thêm không thành công!";
            var bill = new BillDetail()
            {
                MaHDCT = obj.MaHDCT,
                Bill_Id = obj.Bill_Id,
                Pro_Id = obj.Pro_Id,
                Id = obj.Id,
                Quantity = obj.Quantity,
                Price = obj.Price,
                Image = obj.Image


            };
            if (_ibillDetailResponsitory.Update(bill)) return "sửa  thành công!";
            return "sửa không thành công!";
        }
    }
}
