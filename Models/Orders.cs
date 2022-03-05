using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace AZUL.COM.Models
{
    public partial class Orders
    {
        public Orders()
        {
            Reports = new HashSet<Reports>();
        }

        public int Id { get; set; }
        public DateTime Date { get; set; }
        public double? TotalPrice { get; set; }
        public string Arrive { get; set; }
        public string ImageName { get; set; }
        public int? MealId { get; set; }
        public int? CustomerId { get; set; }

        public virtual Customer Customer { get; set; }
        public virtual Meal Meal { get; set; }
        public virtual ICollection<Reports> Reports { get; set; }
    }
}
