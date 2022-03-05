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
    public partial class Room
    {
        public Room()
        {
            Reservation = new HashSet<Reservation>();
        }

        public int Id { get; set; }
        public string State { get; set; }
        public int FloorNumber { get; set; }
        public double Price { get; set; }
        public string SpecialDetails { get; set; }
        public int RoomTypeId { get; set; }
        public string ImageName { get; set; }
        [NotMapped]
        [DisplayName("Uplode File")]
        public IFormFile ImageFile { get; set; }
        public virtual RoomType RoomType { get; set; }
        public virtual ICollection<Reservation> Reservation { get; set; }
    }
}
