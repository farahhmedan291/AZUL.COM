using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace AZUL.COM.Models
{
    public partial class AttendanceReport
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public string Note { get; set; }
        public int? EmployeeId { get; set; }
        public DateTime? EnterHour { get; set; }
        public DateTime? ExitHour { get; set; }

        public int? numberOfHour { get; set; }
        public virtual Employee Employee { get; set; }
    }
}
