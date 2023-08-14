using _1_DAL.IResponsitory;
using _1_DAL.Models;
using _1_DAL.Responsitory;
using _2_BUS.IServices;
using _2_BUS.ViewModel;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Size = _1_DAL.Models.Size;

namespace _2_BUS.Services
{
    public class SizeServices : ISizeServices
    {
        IResSize sizeres;
        public SizeServices()
        {
            sizeres = new ResSize();
        }

        public string Add(SizeView obj)
        {
            if (obj == null) return "Thêm không thành công!";
            var bill = new Size()
            {
                Id = obj.Id,
                Name = obj.Name,

            };
            if (sizeres.Add(bill)) return "Thêm  thành công!";
            return "Thêm không thành công!";
        }

        public List<SizeView> GetSizes()
        {
            List<SizeView> lst = new List<SizeView>();
            lst =
                (
                from a in sizeres.GetAll()
                select new SizeView()
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
            if (sizeres.Remove(obj)) return "Xóa  thành công!";
            return "Xóa không thành công!";
        }

        public string Update(SizeView obj)
        {
            if (obj == null) return "Sửa không thành công!";
            var bill = new Size()
            {
                Id = obj.Id,
                Name = obj.Name,
            };
            if (sizeres.Update(bill)) return "Sửa thành công!";
            return "Sửa không thành công!";
        }
    }
}