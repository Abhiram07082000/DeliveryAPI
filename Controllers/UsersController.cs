using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using DeliveryAPI.Data;
using DeliveryAPI.Model;
using DeliveryAPI.UserProviderLayer;

namespace DeliveryAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly IUserProvider _prod;

        public UsersController(IUserProvider Prod)
        {
            _prod = Prod;
        }

        // GET: api/Users
        [HttpGet]
        public ActionResult<List<User>> GetUser()
        {
            return _prod.GetUsers();
        }

        // GET: api/Users/5
        [HttpGet("{id}")]
        public ActionResult<User> GetUser(int id)
        {
            var user = _prod.GetUserById(id);

            if (user == null)
            {
                return NotFound();
            }

            return user;
        }

        // PUT: api/Users/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public ActionResult PutUser(int id, User P)
        {
            try
            {
                _prod.UpdateUser(id, P);
            }
            catch (DbUpdateConcurrencyException)
            {
                if (_prod.UserExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }
            return NoContent();
        }

        // POST: api/Users
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public ActionResult<User> PostUser(User P)
        {
            _prod.AddNewUser(P);
           return CreatedAtAction("GetUser", new { id = P.UserId }, P);
        }

        // DELETE: api/Users/5
        [HttpDelete("{id}")]
        public ActionResult DeleteUser(int id)
        {
            _prod.DeleteUser(id);
            return NoContent();
        }

        //[HttpGet("id")]
        //public bool UserExists(int id)
        //{
        //    return _context.User.Any(e => e.UserId == id);
        //}
    }
}
