using _1_DAL.Data;
using _1_DAL.IResponsitory;
using _1_DAL.Models;
using _1_DAL.Responsitory;
using _2_BUS.IServices;
using _2_BUS.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_BUS.Services
{
    public class RoleService : IRoleServices
    {
        IRoleResponsitory roleRespon;

        public RoleService()
        {
            roleRespon = new RoleResponsitory();

        }
        public string CreateRole(RoleView role)
        {
            if (role == null) return "Thêm không thành công!";
            var role1 = new Role()
            {
                Id = role.Id,
                Name = role.Name,
            };
            if (roleRespon.CreateRole(role1)) return "Thêm  thành công!";
            return "Thêm không thành công!";
        }

        public string DeleteRole(Guid role)
        {
            if (role == null) return "Xóa không thành công!";
            if (roleRespon.DeleteRole(role)) return "Xóa  thành công!";
            return "Xóa không thành công!";
        }

        public List<RoleView> GetRole()
        {
            List<RoleView> lst = new List<RoleView>();
            lst =
                (
                from a in roleRespon.GetAllRole()
                select new RoleView()
                {
                    Id= a.Id,
                    Name= a.Name,
                }
                ).ToList();
            return lst;
        }

        public Role GetRoleById(Guid id)
        {
            return roleRespon.GetRoleId(id);
        }

        public string UpdateRole(RoleView role)
        {
            if (role == null) return "Sửa không thành công!";
            var role1 = new Role()
            {
                Id = role.Id,
                Name = role.Name,
            };
            if (roleRespon.UpdateRole(role1)) return "Sửa  thành công!";
            return "Sửa không thành công!";
        }
    }
}
