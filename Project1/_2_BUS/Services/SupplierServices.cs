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
    public class SupplierServices : ISupplierServices
    {
        IResSupplier ressup;
        public SupplierServices()
        {
            ressup = new ResSupplier();
        }

        public string Add(SupplierView obj)
        {
            if (obj == null) return "Thêm không thành công!";
            var bill = new Supplier()
            {
                Id = obj.Id,
                Name = obj.Name,

            };
            if (ressup.Add(bill)) return "Thêm  thành công!";
            return "Thêm không thành công!";
        }

        public List<SupplierView> GetSuppliers()
        {
            List<SupplierView> lst = new List<SupplierView>();
            lst =
                (
                from a in ressup.GetAll()
                select new SupplierView()
                {
                    Id = a.Id,
                    Name = a.Name,
                }
                ).ToList();
            return lst;
        }

        public string Remove(Guid obj)
        {
            if (obj == null) return "Xóa không thành công!";
            if (ressup.Remove(obj)) return "Xóa  thành công!";
            return "Xóa không thành công!";
        }

        public string Update(SupplierView obj)
        {
            if (obj == null) return "Sửa không thành công!";
            var bill = new Supplier()
            {
                Id = obj.Id,
                Name = obj.Name,

            };
            if (ressup.Update(bill)) return "Sửa thành công!";
            return "Sửa không thành công!";
        }
    }
}