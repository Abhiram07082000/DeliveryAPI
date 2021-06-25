using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace DeliveryAPI.Model
{
    public class User
    {
        [Key]
        [Required]
        public int UserId { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string UserName { get; set; }
        //[Required]
        //[StringLength(15,ErrorMessage ="Please Enter 8 - 15 characters",MinimumLength =8)]
        
        public string Password { get; set; }
        [Required]
        public int Age { get; set; }
        //[Required]
        //[MaxLength(length:10,ErrorMessage ="Please Enter only 10 digits")]
        //[MinLength(length: 10, ErrorMessage = "Please Enter 10 digits")]
        //[RegularExpression(@"(^[0-9]{10}$")]
        public string Phone { get; set; }
        [Required]
        public string Address { get; set; }
        [Required]
        public string City { get; set; }
        [Required]
        public string UserType { get; set; }
        [NotMapped]
        public virtual List<DeliveryBooking> Bookings { get; set; }
        //public User()
        //{

        //}

        //public User(int userid, string name, string username, string password, int age, string phone, string address, string city, string usertype)
        //{
        //    UserId = userid;
        //    Name = name;
        //    UserName = username;
        //    Password = password;
        //    Age = age;
        //    Phone = phone;
        //    Address = address;
        //    City = city;
        //    UserType = usertype;
        //}
    }
}
