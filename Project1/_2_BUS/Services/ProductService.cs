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
    public class ProductService : IProductService
    {
        public IProductRepo _productRepo;
        public ProductService()
        {
            _productRepo = new ProductRepo();
        }
        public string Add(ProductView p)
        {
            if (p == null) return "Thêm không thành công!";
            var billd = new Product()
            {
                Id = p.Id,
                Cate_Id = p.Cate_Id,
                Size_Id = p.Size_Id,
                Color_Id = p.Color_Id,
                Supplier_Id = p.Supplier_Id,
                MaSp = p.MaSp,
                Name = p.Name,
                Quantity = p.Quantity,
                Price = p.Price,
                Description = p.Description,
                Status = p.Status



            };
            if (_productRepo.Add(billd)) return "Thêm  thành công!";
            return "Thêm không thành công!";
        }

        public List<ProductView> GetAll()
        {
            List<ProductView> lst = new List<ProductView>();
            lst =
                (
                from p in _productRepo.GetAll()
                select new ProductView()
                {
                    Id = p.Id,
                    Cate_Id = p.Cate_Id,
                    Size_Id = p.Size_Id,
                    Color_Id = p.Color_Id,
                    Supplier_Id = p.Supplier_Id,
                    MaSp = p.MaSp,
                    Name = p.Name,
                    Quantity = p.Quantity,
                    Price = p.Price,
                    Description = p.Description,
                    Status = p.Status


                }
                ).ToList();
            return lst;
        }

        public string Remove(Guid p)
        {
            if (p == null) return "Xóa không thành công!";
            if (_productRepo.Remove(p)) return "Xóa  thành công!";
            return "Xóa không thành công!";
        }

        public string Update(ProductView p)
        {
            if (p == null) return "Thêm không thành công!";
            var bill = new Product()
            {
                Id = p.Id,
                Cate_Id = p.Cate_Id,
                Size_Id = p.Size_Id,
                Color_Id = p.Color_Id,
                Supplier_Id = p.Supplier_Id,
                MaSp = p.MaSp,
                Name = p.Name,
                Quantity = p.Quantity,
                Price = p.Price,
                Description = p.Description,
                Status = p.Status


            };
            if (_productRepo.Update(bill)) return "sửa  thành công!";
            return "sửa không thành công!";
        }
    }
}
