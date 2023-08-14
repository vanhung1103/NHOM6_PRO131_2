using _1_DAL.Models;
using _2_BUS.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_BUS.IServices
{
    public interface ICategoryServices
    {
        List<CategoryView> GetCategorys();
        string Add(CategoryView obj);
        string Remove(Guid obj);
        string Update(CategoryView obj);
    }
}