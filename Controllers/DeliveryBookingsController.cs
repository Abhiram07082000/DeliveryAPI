using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using DeliveryAPI.Data;
using DeliveryAPI.Model;
using DeliveryAPI.DelProviderLayer;

namespace DeliveryAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DeliveryBookingsController : ControllerBase
    {
        private readonly IDelProvider _prod;

        public DeliveryBookingsController(IDelProvider Prod)
        {
            _prod = Prod;
        }


        // GET: api/DeliveryBookings
        [HttpGet]
        public ActionResult<List<DeliveryBooking>> GetDeliveryBooking()
        {
            return _prod.GetAllBookings();
        }

        // GET: api/DeliveryBookings/5
        [HttpGet("{id}")]
        public ActionResult<DeliveryBooking> GetDeliveryBooking(int id)
        {
            return _prod.GetByBookingId(id);
        }

        // PUT: api/DeliveryBookings/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public ActionResult PutDeliveryBooking(int id, DeliveryBooking P)
        {
            try
            {
                _prod.UpdateBooking(id, P);
            }
            catch (DbUpdateConcurrencyException)
            {
                if (_prod.DeliveryBookingExists(id))
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
       
        // POST: api/DeliveryBookings
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public ActionResult <DeliveryBooking> PostDeliveryBooking(DeliveryBooking P)
        {
            _prod.AddNewBooking(P);

            return CreatedAtAction("GetDeliveryBooking", new { id = P.BookingId }, P);
        }
        // DELETE: api/DeliveryBookings/5
        [HttpDelete("{id}")]
        public ActionResult DeleteDeliveryBooking(int id)
        {
            _prod.DeleteBooking(id);
            return NoContent();
        }
        
        //[HttpGet("id")]
        //private ActionResult DeliveryBookingExists(int id)
        //{
        //    _prod.DeliveryBookingExists(id);

        //}
    }
}
