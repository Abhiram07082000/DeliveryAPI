using DeliveryAPI.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DeliveryAPI.UserProviderLayer
{
    public interface IUserProvider
    {
        public List<User> GetUsers();
        public User GetUserById(int id);
        public User AddNewUser(User P);
        public void DeleteUser(int id);
        public User UpdateUser(int id, User P);
        public bool UserExists(int id);
    }
}
