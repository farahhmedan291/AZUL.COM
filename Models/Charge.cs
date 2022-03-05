using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace AZUL.COM.Models
{
    public partial class Charge
    {
        public Charge()
        {
            Reports = new HashSet<Reports>();
        }

        public int Id { get; set; }
        public DateTime? ChargeDate { get; set; }
        public double? Amount { get; set; }
        public int? CustomerId { get; set; }

        public virtual Customer Customer { get; set; }
        public virtual ICollection<Reports> Reports { get; set; }
    }
}
