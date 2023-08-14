using _1_DAL.Models;
using _2_BUS.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_BUS.IServices
{
    public interface IRoleServices
    {

        public string CreateRole(RoleView role);
        public string DeleteRole(Guid id);
        public string UpdateRole(RoleView role);
        public Role GetRoleById(Guid id);
        public List<RoleView> GetRole();
    }
}
