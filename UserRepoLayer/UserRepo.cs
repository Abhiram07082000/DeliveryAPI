using DeliveryAPI.Data;
using DeliveryAPI.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DeliveryAPI.UserRepoLayer
{
    public class UserRepo:IUserRepo
    {
        private readonly UserContext _context;
        public UserRepo()
        {

        }
        public UserRepo(UserContext context)
        {
            _context = context;
        }

        public User AddNewUser(User P)
        {
            _context.User.Add(P);
            _context.SaveChanges();
            return P;
        }

        public void DeleteUser(int id)
        {
            User P = _context.User.Find(id);
            _context.User.Remove(P);
            _context.SaveChanges();
        }

        public User GetUserById(int id)
        {
            User P = _context.User.Find(id);
            return P;
        }

        public List<User> GetUsers()
        {
            return _context.User.ToList();
        }

        public User UpdateUser(int id, User P)
        {
            _context.ChangeTracker.QueryTrackingBehavior = QueryTrackingBehavior.NoTracking;
            _context.Entry(P).State = EntityState.Modified;
            _context.SaveChanges();
            return P;
        }

        public bool UserExists(int id)
        {
            return _context.User.Any(e => e.UserId == id);
        }
    }
}
