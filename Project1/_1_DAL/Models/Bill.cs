using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_DAL.Models
{
    public class Bill
    {
        
        public Guid Id { get; set; }
       public Guid User_Id { get; set; }
       public Guid Customer_Id { get; set; }
       public Guid Voucher_Id { get; set; }
        public string MaHD { get; set; }

        public string ProductName { get; set; }
        public string Discount { get; set; }
        public DateTime Create_Date { get; set; }
        public int Total { get; set; }
        public string Description { get; set; }
        public bool Status { get; set; }
        public virtual User User { get; set; }
        public virtual  Customer customer { get; set; }
        public virtual  Voucher Voucher { get; set; }
    }
}
