using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace AZUL.COM.Models
{
    public partial class Customer
    {
        public Customer()
        {
            Charge = new HashSet<Charge>();
            CustomerServices = new HashSet<CustomerServices>();
            Login = new HashSet<Login>();
            Orders = new HashSet<Orders>();
            Payment = new HashSet<Payment>();
            Reports = new HashSet<Reports>();
            Reservation = new HashSet<Reservation>();
        }

        public int Id { get; set; }
        public string FName { get; set; }
        public string LName { get; set; }
        public string Email { get; set; }
        public int? NationalNumber { get; set; }
        public DateTime BirthDate { get; set; }
        public string PhoneNumber { get; set; }
        public string ImageName { get; set; }
        [NotMapped]
        [DisplayName("Uplode File")]
        public IFormFile ImageFile { get; set; }
        public virtual ICollection<Charge> Charge { get; set; }
        public virtual ICollection<CustomerServices> CustomerServices { get; set; }
        public virtual ICollection<Login> Login { get; set; }
        public virtual ICollection<Orders> Orders { get; set; }
        public virtual ICollection<Payment> Payment { get; set; }
        public virtual ICollection<Reports> Reports { get; set; }
        public virtual ICollection<Reservation> Reservation { get; set; }
    }
}
