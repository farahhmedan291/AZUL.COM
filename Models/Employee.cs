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
    public partial class Employee
    {
        public Employee()
        {
            AttendanceReport = new HashSet<AttendanceReport>();
            Login = new HashSet<Login>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public int? NationalNumber { get; set; }
        public DateTime BirthDate { get; set; }
        public string PhoneNumber { get; set; }
        public double? Salary { get; set; }
        public double? Profits { get; set; }
        public int? DeptType { get; set; }
        public double? Losses { get; set; }
        public string ImageName { get; set; }
        [NotMapped]
        [DisplayName("Uplode File")]
        public IFormFile ImageFile { get; set; }
        public virtual DepartmentType DeptTypeNavigation { get; set; }
        public virtual ICollection<AttendanceReport> AttendanceReport { get; set; }
        public virtual ICollection<Login> Login { get; set; }
    }
}
