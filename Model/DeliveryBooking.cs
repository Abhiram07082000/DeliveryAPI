using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DeliveryAPI.Model
{
    public class DeliveryBooking
    {
        [Key]
        public int BookingId { get; set; }
        public int UserId { get; set; }
        public string UserName { get; set; }        
        public DateTime DateAndTime { get; set; }
        public float Weight { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string DeliveryExecutive { get; set; }
        public string BookingStatus { get; set; }
        public float Price { get; set; }

        public DeliveryBooking()
        {

        }
        public DeliveryBooking(int bookingid, int userid, string username, DateTime dateandtime, float weight, string address, string city, string exec, string status, float price)
        {
            BookingId = bookingid;
            UserId = userid;
            UserName = username;
            DateAndTime = dateandtime;
            Weight = weight;
            Address = address;
            City = city;
            DeliveryExecutive = exec;
            BookingStatus = status;
            Price = price;
        }
    }
   
       
}
