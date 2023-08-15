using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_BUS.ViewModel
{
    public class BillView
    {
        public Guid Id { get; set; }
        public Guid User_Id { get; set; }
        public Guid Customer_Id { get; set; }
        public string Discount { get; set; }
        public DateTime Create_Date { get; set; }
        public string MaHD { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Gender { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }

        public int Status { get; set; }
    }
}
