using _1_DAL.Data;
using _1_DAL.IResponsitory;
using _1_DAL.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_DAL.Responsitory
{
    public class BillResponsitory : IBillResponsitory
    {
        ShopClothesContext _context;
        public BillResponsitory()
        {
            _context = new ShopClothesContext();
        }
        public bool Add(Bill x)
        {
            if (x == null) return false;
            x.Id = Guid.NewGuid();
            _context.Bills.Add(x);
            _context.SaveChanges();
            return true;
        }

        public List<Bill> GetAll()
        {
            return _context.Bills.ToList();
        }
        public bool Remove(Guid x)
        {
            if (x == null) return false;
            var tempobj = _context.Bills.FirstOrDefault(c => c.Id == x);
            _context.Remove(tempobj);
            _context.SaveChanges();
            return true;
        }

        public bool Update(Bill x)
        {
            if (x == null) return false;
            var tempobj = _context.Bills.FirstOrDefault(c => c.Id == x.Id);
            tempobj.Id = x.Id;
            tempobj.User_Id = x.User_Id;
            tempobj.Voucher_Id = x.Voucher_Id;
            tempobj.MaHD = x.MaHD;
            tempobj.Description = x.Description;
            tempobj.ProductName = x.ProductName;
            tempobj.Create_Date = x.Create_Date;
            tempobj.Total = x.Total;
            tempobj.Discount = x.Discount;
            _context.Update(tempobj);
            _context.SaveChanges();
            return true;
        }
    }
}
