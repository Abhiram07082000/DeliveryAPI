using DeliveryAPI.Model;
using DeliveryAPI.UserProviderLayer;
using DeliveryAPI.UserRepoLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DeliveryAPI.UserProviderLayer
{
    public class UserProvider:IUserProvider
    {
        private readonly IUserRepo _repo;
        public UserProvider()
        {

        }

        public UserProvider(IUserRepo repo)
        {
            _repo = repo;
        }
        public User AddNewUser(User P)
        {
            _repo.AddNewUser(P);
            return P;
        }

        public void DeleteUser(int id)
        {
            _repo.DeleteUser(id);
        }

        public User GetUserById(int id)
        {
            return _repo.GetUserById(id);
        }

        public List<User> GetUsers()
        {
            return _repo.GetUsers();
        }

        public User UpdateUser(int id, User P)
        {
            _repo.UpdateUser(id, P);
            return P;
        }
        public bool UserExists(int id)
        {
            return _repo.UserExists(id);
        }
    }
}
