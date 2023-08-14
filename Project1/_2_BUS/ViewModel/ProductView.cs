using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_BUS.ViewModel
{
    public class ProductView
    {
        public Guid Id { get; set; }
        public Guid Cate_Id { get; set; }

        public Guid Size_Id { get; set; }

        public Guid Color_Id { get; set; }

        public Guid Supplier_Id { get; set; }
        public string MaSp { get; set; }

        public string Name { get; set; }
        public int Quantity { get; set; }
        public float Price { get; set; }
        public string Description { get; set; }
        public int Status { get; set; }
    }
}
