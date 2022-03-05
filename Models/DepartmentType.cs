using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace AZUL.COM.Models
{
    public partial class DepartmentType
    {
        public DepartmentType()
        {
            Employee = new HashSet<Employee>();
            Login = new HashSet<Login>();
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<Employee> Employee { get; set; }
        public virtual ICollection<Login> Login { get; set; }
    }
}
