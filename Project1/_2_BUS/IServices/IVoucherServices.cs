using _1_DAL.Models;
using _2_BUS.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_BUS.IServices
{
    public interface IVoucherServices
    {
        public List<VoucherView> GetAllVoucher();
        public string AddVoucher(VoucherView voucher);
        public string DeleteVoucher(Guid voucher);
        public string UpdateVoucher(VoucherView voucher);
    }
}
