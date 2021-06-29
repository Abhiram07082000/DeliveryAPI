using DeliveryAPI.Data;
using DeliveryAPI.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DeliveryAPI.DelRepoLayer
{
    public class DelRepo:IDelRepo
    {
        private readonly DeliveryBookingContext _context;
        public DelRepo()
        {

        }
        public DelRepo(DeliveryBookingContext context)
        {
            _context = context;
        }
        public DeliveryBooking AddNewBooking(DeliveryBooking P)
        {
            _context.DeliveryBooking.Add(P);
            _context.SaveChanges();
            return P;
        }

        public void DeleteBooking(int id)
        {
             DeliveryBooking P = _context.DeliveryBooking.Find(id);
                _context.DeliveryBooking.Remove(P);
                _context.SaveChanges();
            
           
        }

        public List<DeliveryBooking> GetAllBookings()
        {
            return _context.DeliveryBooking.ToList();
        }

        public DeliveryBooking GetByBookingId(int id)
        {
           return(_context.DeliveryBooking.Find(id));
        }
        //public DeliveryBooking GetBookingByUserId(int UsrId)
        //{
        //        var GetByIdQuery = _context.Query;
        //        var dbooking = keywordSearchQuery
        //                        .GroupBy(k => k.Keyword_Id)
        //                        .Where(g => splitKeyWords.All(w => g.Any(k => w.Equals(k.Name))))
        //                        .Select(g => g.Key);
        //}
        public DeliveryBooking UpdateBooking(int id, DeliveryBooking P)
        {
            _context.ChangeTracker.QueryTrackingBehavior = QueryTrackingBehavior.NoTracking;
            _context.Entry(P).State = EntityState.Modified;
            _context.SaveChanges();
            return P;
        }
        public bool DeliveryBookingExists(int id)
        {
            return _context.DeliveryBooking.Any(e => e.BookingId == id);
        }
    }
}
