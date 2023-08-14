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
using Color = _1_DAL.Models.Color;

namespace _2_BUS.Services
{
    public class ColorServices : IColorServices
    {
        IResColor colorres;
        public ColorServices()
        {
            colorres = new ResColor();
        }

        public string Add(ColorView obj)
        {
            if (obj == null) return "Thêm không thành công!";
            var bill = new Color()
            {
                Id = obj.Id,
                Name = obj.Name,

            };
            if (colorres.Add(bill)) return "Thêm  thành công!";
            return "Thêm không thành công!";
        }

        public List<ColorView> GetColors()
        {
            List<ColorView> lst = new List<ColorView>();
            lst =
                (
                from a in colorres.GetAll()
                select new ColorView()
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
            if (colorres.Remove(obj)) return "Xóa  thành công!";
            return "Xóa không thành công!";
        }

        public string Update(ColorView obj)
        {
            if (obj == null) return "Sửa không thành công!";
            var bill = new Color()
            {
                Id = obj.Id,
                Name = obj.Name,
            };
            if (colorres.Update(bill)) return "Sửa thành công!";
            return "Sửa không thành công!";
        }
    }
}