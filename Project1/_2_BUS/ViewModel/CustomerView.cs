using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_BUS.ViewModel
{
    public class CustomerView
    {
        public Guid CustomerId { get; set; }
       
        public string Name { get; set; }
        public string Gender { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public int PurchaseHistory { get; set; }
        public string Feedback { get; set; }
        public Guid Voucher_Id { get; set; }
    }
}
