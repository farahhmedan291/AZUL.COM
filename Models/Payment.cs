using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace AZUL.COM.Models
{
    public partial class Payment
    {
        public int Id { get; set; }
        public double? AmountOfMoney { get; set; }
        public int? CustomerId { get; set; }
        public int? CardNumber { get; set; }
        public DateTime ExpDate { get; set; }

        public virtual Customer Customer { get; set; }
    }
}
