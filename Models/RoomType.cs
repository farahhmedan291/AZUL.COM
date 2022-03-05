using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace AZUL.COM.Models
{
    public partial class RoomType
    {
        public RoomType()
        {
            Room = new HashSet<Room>();
        }

        public int Id { get; set; }
        public string Type { get; set; }
        public string Details { get; set; }
        public string ImageName { get; set; }

        public virtual ICollection<Room> Room { get; set; }
    }
}
