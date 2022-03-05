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
    public partial class Service
    {
        public Service()
        {
            CustomerServices = new HashSet<CustomerServices>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public double? Price { get; set; }
        public string ImageName { get; set; }
    
        [NotMapped]
        [DisplayName("Uplode File")]
        public IFormFile ImageFile { get; set; }
        public virtual ICollection<CustomerServices> CustomerServices { get; set; }
    }
}
