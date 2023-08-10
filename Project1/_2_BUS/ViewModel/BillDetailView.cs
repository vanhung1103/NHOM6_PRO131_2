using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_BUS.ViewModel
{
    public class BillDetailView
    {
        public Guid Id { get; set; }

        public Guid Pro_Id { get; set; }

        public Guid Bill_Id { get; set; }
        public string MaHDCT { get; set; }

        public string Image { get; set; }
        public int Quantity { get; set; }
        public int Price { get; set; }
    }
}
