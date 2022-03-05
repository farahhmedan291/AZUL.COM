using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace AZUL.COM.Models
{
    public partial class SharedPage
    {
        public int Id { get; set; }
        public string HotelName { get; set; }
        public string FooterHeader { get; set; }
        public string FooterParagraph { get; set; }
        public string FooterCopyRight { get; set; }
    }
}
