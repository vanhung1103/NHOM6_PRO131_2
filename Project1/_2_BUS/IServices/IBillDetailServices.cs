using _2_BUS.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_BUS.IServices
{
    public interface IBillDetailServices
    {
        List<BillDetailView> Get();
        string Add(BillDetailView obj);
        string Remove(Guid obj);
        string Update(BillDetailView obj);
    }
}
