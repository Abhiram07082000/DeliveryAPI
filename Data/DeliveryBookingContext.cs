using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using DeliveryAPI.Model;
using DeliveryAPI.DelProviderLayer;

namespace DeliveryAPI.Data
{
    public class DeliveryBookingContext : DbContext
    {
        public DeliveryBookingContext()
        {

        }
        public DeliveryBookingContext (DbContextOptions<DeliveryBookingContext> options)
            : base(options)
        {
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //optionsBuilder.UseSqlServer(connectionString);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //Fluent APIs
            //modelBuilder.Entity<User>().HasKey(s => s.UserId);
            //modelBuilder.Entity<DeliveryBooking>().HasKey(b => b.BookingId);
            //modelBuilder.Entity<DeliveryBooking>().Property(b => b.BookingId).ValueGeneratedOnAdd();
            //modelBuilder.Entity<DeliveryBooking>()
            //    .HasOne<User>(s => s.UserName)
            //    .WithMany(ad => ad.Bookings)
            //    .HasForeignKey(ad => ad.UserId);
        }

        public DbSet<DeliveryAPI.Model.DeliveryBooking> DeliveryBooking { get; set; }
    }
}
