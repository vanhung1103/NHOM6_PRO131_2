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
    public class CategoryServices : ICategoryServices
    {
        IResCategory categoryres;
        public CategoryServices()
        {
            categoryres = new ResCategory();
        }

        public string Add(CategoryView obj)
        {
            if (obj == null) return "Thêm không thành công!";
            var bill = new Category()
            {
                Id = obj.Id,
                Name = obj.Name,

            };
            if (categoryres.Add(bill)) return "Thêm  thành công!";
            return "Thêm không thành công!";
        }

        public List<CategoryView> GetCategorys()
        {
            List<CategoryView> lst = new List<CategoryView>();
            lst =
                (
                from a in categoryres.GetAll()
                select new CategoryView()
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
            if (categoryres.Remove(obj)) return "Xóa  thành công!";
            return "Xóa không thành công!";
        }

        public string Update(CategoryView obj)
        {
            if (obj == null) return "Sửa không thành công!";
            var bill = new Category()
            {
                Id = obj.Id,
                Name = obj.Name,
            };
            if (categoryres.Update(bill)) return "Sửa thành công!";
            return "Sửa không thành công!";
        }
    }
}