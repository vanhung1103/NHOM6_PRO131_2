using _1_DAL.Models;
using _2_BUS.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_BUS.IServices
{
    public interface IUserServices
    {
        public List<UserView> GetAllUser();
        public string AddUser(UserView user);
        public string DeleteUser(Guid id);
        public string UpdateUser(UserView user);
        public User GetUsersId(Guid id);
    }
}
