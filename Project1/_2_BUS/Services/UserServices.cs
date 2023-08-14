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
    public class UserServices:IUserServices
    {
        public IUserResponsitory _userResponsitory;

        public UserServices()
        {
            _userResponsitory = new UserResponsitory();

        }

        public string AddUser(UserView user)
        {
            if (user == null) return "Thêm không thành công!";
            var use = new User()
            {
                Id = user.Id,
                UserName = user.UserName,
                PassWord = user.PassWord,
                Email = user.Email,
                role_Id = user.role_Id

            };
            if (_userResponsitory.CreateUser(use)) return "Thêm  thành công!";
            return "Thêm không thành công!";
        }

        public string DeleteUser(Guid user)
        {
            if (user == null) return "Xóa không thành công!";
            if (_userResponsitory.DeleteUser(user)) return "Xóa  thành công!";
            return "Xóa không thành công!";
        }

        public List<UserView> GetAllUser()
        {
            List<UserView> lst = new List<UserView>();
            lst =
                (
                from a in _userResponsitory.GetAllUser()
                select new UserView()
                {
                    Id = a.Id,
                    UserName = a.UserName,
                    PassWord = a.PassWord,
                    Email = a.Email,
                    role_Id = a.role_Id
                }
                ).ToList();
            return lst;
        }

        public User GetUsersId(Guid id)
        {
            return _userResponsitory.GetUserById(id);
        }

        public string UpdateUser(UserView user)
        {
            if (user == null) return "Sửa không thành công!";
            var use = new User()
            {
                Id = user.Id,
                UserName= user.UserName,
                PassWord = user.PassWord,
                Email = user.Email,
                role_Id = user.role_Id

            };
            if (_userResponsitory.UpdateUser(use)) return "Sửa  thành công!";
            return "Sửa không thành công!";
        }
    }
}
