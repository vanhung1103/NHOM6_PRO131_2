using _1_DAL.Models;
using _2_BUS.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_BUS.IServices
{
    public interface IProductService
    {
         string Add(ProductView p);
         string Update(ProductView p);
         string Remove(Guid p);
        List<ProductView> GetAll();
        
    }
}
