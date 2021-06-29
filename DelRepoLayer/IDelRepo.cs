using DeliveryAPI.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DeliveryAPI.DelRepoLayer
{
    public interface IDelRepo
    {
        public List<DeliveryBooking> GetAllBookings();
        public DeliveryBooking GetByBookingId(int id);
        public DeliveryBooking AddNewBooking(DeliveryBooking P);
        public void DeleteBooking(int id);
        public DeliveryBooking UpdateBooking(int id, DeliveryBooking P);
        public bool DeliveryBookingExists(int id);
    }
}
