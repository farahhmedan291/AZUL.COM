using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace AZUL.COM.Models
{
    public partial class Reservation
    {
        public Reservation()
        {
            Reports = new HashSet<Reports>();
        }

        public int Id { get; set; }
        public int? RoomId { get; set; }
        public int? CustomerId { get; set; }
        public DateTime ResDate { get; set; }
        public DateTime CheckInDate { get; set; }
        public DateTime CheckOutDate { get; set; }
        public double? TotalPrice { get; set; }
        

        public int? numberOfDayes { get; set; }
    

        public double? ReservationsPrice { get; set; }
        [NotMapped]
        public string FName { get; set; }
        [NotMapped]
        public string LName { get; set; }
        public virtual Customer Customer { get; set; }
        public virtual Room Room { get; set; }
        public virtual ICollection<Reports> Reports { get; set; }
    }
}
