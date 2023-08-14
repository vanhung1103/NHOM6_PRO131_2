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
    public class VoucherServices : IVoucherServices
    {
         public IVoucherResponsitory _voucherResponsitory;

        public VoucherServices()
        {
            _voucherResponsitory = new VoucherRepository();

        }

        public string AddVoucher(VoucherView voucher)
        {
            if (voucher == null) return "Thêm không thành công!";
            var vou = new Voucher()
            {
                Id = voucher.Id,
                Name= voucher.Name,
                Create_Date = voucher.Create_Date,
                End_Date= voucher.End_Date,
                Status= voucher.Status,
                Voucher_Percent= voucher.Voucher_Percent,

            };
            if (_voucherResponsitory.CreateVoucher(vou)) return "Thêm  thành công!";
            return "Thêm không thành công!";
        }

        public string DeleteVoucher(Guid id)
        {

            if (_voucherResponsitory.DeleteVoucher(id))
            {
                return "Xóa voucher thành công";

            }
            return "Xóa voucher không thành công";
        }

        public List<VoucherView> GetAllVoucher()
        {
            List<VoucherView> lst = new List<VoucherView>();
            lst =
                (
                from a in _voucherResponsitory.GetAllVoucher()
                select new VoucherView()
                {
                    Id = a.Id,
                    Name= a.Name,
                    Create_Date = a.Create_Date,
                    End_Date = a.End_Date,
                    Status= a.Status,
                    Voucher_Percent= a.Voucher_Percent,
                }
                ).ToList();
            return lst;
        }
        public string UpdateVoucher(VoucherView voucher)
        {
            if (voucher == null) return "Sửa không thành công!";
            var vou = new Voucher()
            {
                Id = voucher.Id,
                Name= voucher.Name,
                Create_Date = voucher.Create_Date,
                End_Date= voucher.End_Date,
                Status = voucher.Status,
                Voucher_Percent= voucher.Voucher_Percent,
            };
            if (_voucherResponsitory.UpdateVoucher(vou)) return "Sửa  thành công!";
            return "Sửa không thành công!";
        }
    }
}
