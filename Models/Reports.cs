using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace AZUL.COM.Models
{
    public partial class Reports
    {
        public int Id { get; set; }
        public string PaymentType { get; set; }
        public int? PaymentId { get; set; }
        public int? CustomerserviceId { get; set; }
        public int? ReservationId { get; set; }
        public int? ChargeId { get; set; }
        public int? OrdersId { get; set; }
        public int? CustomerId { get; set; }

        public virtual Charge Charge { get; set; }
        public virtual Customer Customer { get; set; }
        public virtual CustomerServices Customerservice { get; set; }
        public virtual Orders Orders { get; set; }
        public virtual Reservation Reservation { get; set; }
    }
}
