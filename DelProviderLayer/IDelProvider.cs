using DeliveryAPI.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DeliveryAPI.DelProviderLayer
{
    public interface IDelProvider
    {
        public List<DeliveryBooking> GetAllBookings();
        public DeliveryBooking GetByBookingId(int id);
        //public DeliveryBooking GetBookingByUserId(int UserId);
        public DeliveryBooking AddNewBooking(DeliveryBooking P);
        public void DeleteBooking(int id);
        public DeliveryBooking UpdateBooking(int id, DeliveryBooking P);
        public bool DeliveryBookingExists(int id);
    }
}
