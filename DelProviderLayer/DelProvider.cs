using DeliveryAPI.DelRepoLayer;
using DeliveryAPI.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DeliveryAPI.DelProviderLayer
{
    public class DelProvider:IDelProvider
    {
        private readonly IDelRepo _repo;
        public DelProvider()
        {

        }
        public DelProvider(IDelRepo repo)
        {
            _repo = repo;
        }
        public DeliveryBooking AddNewBooking(DeliveryBooking P)
        {
            _repo.AddNewBooking(P);
            return P;
        }

        public void DeleteBooking(int id)
        {
            _repo.DeleteBooking(id);
        }

        public List<DeliveryBooking> GetAllBookings()
        {
            return _repo.GetAllBookings();
        }

        public DeliveryBooking GetByBookingId(int id)
        {
            return _repo.GetByBookingId(id);
        }

       
        public DeliveryBooking UpdateBooking(int id, DeliveryBooking P)
        {
            _repo.UpdateBooking(id, P);
            return P;
        }
        public bool DeliveryBookingExists(int id)
        {
            return _repo.DeliveryBookingExists(id);
        }
    }
}
