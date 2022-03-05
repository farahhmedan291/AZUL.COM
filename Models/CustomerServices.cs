using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace AZUL.COM.Models
{
    public partial class CustomerServices
    {
        public CustomerServices()
        {
            Reports = new HashSet<Reports>();
        }

        public int Id { get; set; }
        public int? CustomerId { get; set; }
        public int? ServiceId { get; set; }
        public DateTime Date { get; set; }
        public string ImageName { get; set; }

        public virtual Customer Customer { get; set; }
        public virtual Service Service { get; set; }
        public virtual ICollection<Reports> Reports { get; set; }
    }
}
