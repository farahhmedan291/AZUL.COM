using AZUL.COM.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;


namespace first_project.Controllers
{
    public class HomeController : Controller
    { 
        private readonly AZULContext _context;
    
        private readonly ILogger<HomeController> _logger;

        
        public HomeController(ILogger<HomeController> logger, AZULContext _context)
        {
            _logger = logger;
            this._context = _context;
        }

        public IActionResult Index()
        {
            var home = _context.HomePage.OrderByDescending(x=>x.Id).FirstOrDefault();
            ViewBag.SlideImage1 = home.SlideImage1;
            ViewBag.SlideImage2 = home.SlideImage2;
            ViewBag.SlideImage3 = home.SlideImage3;
            ViewBag.SlideHader1 = home.SlideHeader1;
            ViewBag.SlideHader2 = home.SlideHeader2;
            ViewBag.SlideHader3 = home.SlideHeader3;
            ViewBag.SlideParagraph1 = home.SlideParagraph1;
            ViewBag.SlideParagraph2 = home.SlideParagraph2;
            ViewBag.SlideParagraph3 = home.SlideParagraph3;
            ViewBag.DescImage1 = home.DescImage1;
            ViewBag.DescImage2 = home.DescImage2;
            ViewBag.DescImage3 = home.DescImage3;
            ViewBag.DescHeader = home.DescHeader;
            ViewBag.DescParagraph = home.DescParagraph;
            ViewBag.DescPoint1 = home.DescPoint1;
            ViewBag.DescPoint2 = home.DescPoint2;
            ViewBag.PoolImage = home.PoolImage;
            ViewBag.PoolHeader = home.PoolHeader;
            ViewBag.PoolParagraph = home.PoolParagraph;
            ViewBag.RoomHeader = home.RoomHeader;
            ViewBag.RoomParagraph = home.RoomParagraph;
            ViewBag.RoomImage1 = home.RoomImage1;
            ViewBag.RoomImage2 = home.RoomImage2;
            ViewBag.RoomImage3 = home.RoomImage3;
            ViewBag.RoomPrice1 = home.RoomPrice1;
            ViewBag.RoomPrice2 = home.RoomPrice2;
            ViewBag.RoomPrice3 = home.RoomPrice3;
            ViewBag.RoomImageHeader1 = home.RoomImageHeader1;
            ViewBag.RoomImageHeader2 = home.RoomImageHeader2;
            ViewBag.RoomImageHeader3 = home.RoomImageHeader3;
            ViewBag.RoomImageParagraph1 = home.RoomImageParagraph1;
            ViewBag.RoomImageParagraph2 = home.RoomImageParagraph2;
            ViewBag.RoomImageParagraph3 = home.RoomImageParagraph3;
            ViewBag.ContactHeader = home.ContactHeader;
            ViewBag.ContactParagraph = home.ContactParagraph;
            ViewBag.ContactAddress = home.ContactAddress;
            ViewBag.ContactPhone = home.ContactPhone;
            ViewBag.ContactEmail = home.ContactEmail;
            var shared = _context.SharedPage.OrderByDescending(x => x.Id).FirstOrDefault();
            ViewBag.name = shared.HotelName;
            ViewBag.footerHeader = shared.FooterHeader;
            ViewBag.footerPara = shared.FooterParagraph;
            return View();
        }
         public IActionResult AboutUs()
        {
            var about = _context.AboutUsPage.OrderByDescending(x => x.Id).FirstOrDefault();
            ViewBag.HeaderImage = about.HeaderImage;
            ViewBag.DescImage = about.DescImage;
            ViewBag.DescHeader = about.DescHeader;
            ViewBag.DescParagraph = about.DescParagraph;
            ViewBag.DescImage2 = about.DescImage2;
            ViewBag.DescHeader2 = about.DescHeader2;
            ViewBag.DescParagraph2 = about.DescParagraph2;
            ViewBag.FeaturesImage1 = about.FeaturesImage1;
            ViewBag.FeaturesImage2 = about.FeaturesImage2;
            ViewBag.FeaturesImage3 = about.FeaturesImage3;
            ViewBag.FeaturesHeader = about.FeaturesHeader;
            ViewBag.FeaturesImagePoint1 = about.FeaturesImagePoint1;
            ViewBag.FeaturesImagePoint2 = about.FeaturesImagePoint2;
            ViewBag.FeaturesImagePoint3 = about.FeaturesImagePoint3;
            ViewBag.FeaturesImagePoint4 = about.FeaturesImagePoint4;
            ViewBag.FeaturesImagePoint5 = about.FeaturesImagePoint5;
            ViewBag.FeaturesImagePoint6 = about.FeaturesImagePoint6;
            ViewBag.FeaturesImagePoint7 = about.FeaturesImagePoint7;
            ViewBag.FeaturesImagePoint8 = about.FeaturesImagePoint8;
            ViewBag.FeaturesImagePoint9 = about.FeaturesImagePoint9;
            ViewBag.RateHeader = about.RateHeader;
            ViewBag.RateParagraph1 = about.RateParagraph1;
            ViewBag.RateParagraph2 = about.RateParagraph2;
            ViewBag.RateName1 = about.RateName1;
            ViewBag.RateName2 = about.RateName2;
            ViewBag.RateImage1 = about.RateImage1;
            ViewBag.RateImage2 = about.RateImage2;




            var shared = _context.SharedPage.OrderByDescending(x => x.Id).FirstOrDefault();
            ViewBag.name = shared.HotelName;
            ViewBag.footerHeader = shared.FooterHeader;
            ViewBag.footerPara = shared.FooterParagraph;
            return View();
        }
        public IActionResult Services()
        {
            var service = _context.ServicesPage.OrderByDescending(x => x.Id).FirstOrDefault();
            ViewBag.HeaderImage=service.HeaderImage;
            ViewBag.DescImage1 = service.DescImage1;
            ViewBag.DescImage2 = service.DescImage2;
            ViewBag.DescImage3 = service.DescImage3;
            ViewBag.DescHeader = service.DescHeader;
            ViewBag.DescParagraph = service.DescParagraph;
            ViewBag.DescSubHeader1 = service.DescSubHeader1;
            ViewBag.DescSubHeader2 = service.DescSubHeader2;
            ViewBag.DescSubHeader3 = service.DescSubHeader3;
            ViewBag.DescSubParagraph1 = service.DescSubParagraph1;
            ViewBag.DescSubParagraph2 = service.DescSubParagraph2;
            ViewBag.DescSubParagraph3 = service.DescSubParagraph3;
            ViewBag.ServicesHeader1 = service.ServicesHeader1;
            ViewBag.ServicesHeader2 = service.ServicesHeader2;
            ViewBag.ServicesHeader3 = service.ServicesHeader3;
            ViewBag.ServicesHeader4 = service.ServicesHeader4;
            ViewBag.ServicesHeader5 = service.ServicesHeader5;
            ViewBag.ServicesHeader6 = service.ServicesHeader6;
            ViewBag.ServicesParagraph1 = service.ServicesParagraph1;
            ViewBag.ServicesParagraph2 = service.ServicesParagraph2;
            ViewBag.ServicesParagraph3 = service.ServicesParagraph3;
            ViewBag.ServicesParagraph4 = service.ServicesParagraph4;
            ViewBag.ServicesParagraph5 = service.ServicesParagraph5;
            ViewBag.ServicesParagraph6 = service.ServicesParagraph6;

            var shared = _context.SharedPage.OrderByDescending(x => x.Id).FirstOrDefault();
            ViewBag.name = shared.HotelName;
            ViewBag.footerHeader = shared.FooterHeader;
            ViewBag.footerPara = shared.FooterParagraph;
            return View();
        }
        public IActionResult Contact()
        {
            var contact = _context.ContactPage.OrderByDescending(x => x.Id).FirstOrDefault();
            ViewBag.HeaderImage = contact.HeaderImage;
            ViewBag.PlaceHeader1 = contact.PlaceHeader1;
            ViewBag.PlaceHeader2 = contact.PlaceHeader2;
            ViewBag.PlaceHeader3 = contact.PlaceHeader3;
            ViewBag.PlaceParagraph1 = contact.PlaceParagraph1;
            ViewBag.PlaceParagraph2 = contact.PlaceParagraph2;
            ViewBag.PlaceParagraph3 = contact.PlaceParagraph3;
            ViewBag.PlaceAddress1 = contact.PlaceAddress1;
            ViewBag.PlaceAddress2 = contact.PlaceAddress2;
            ViewBag.PlaceAddress3 = contact.PlaceAddress3;
            ViewBag.PlacePhone1 = contact.PlacePhone1;
            ViewBag.PlacePhone2 = contact.PlacePhone2;
            ViewBag.PlacePhone3 = contact.PlacePhone3;
            ViewBag.PlaceEmail1 = contact.PlaceEmail1;
            ViewBag.PlaceEmail2 = contact.PlaceEmail2;
            ViewBag.PlaceEmail3 = contact.PlaceEmail3;
            var shared = _context.SharedPage.OrderByDescending(x => x.Id).FirstOrDefault();
            ViewBag.name = shared.HotelName;
            ViewBag.footerHeader = shared.FooterHeader;
            ViewBag.footerPara = shared.FooterParagraph;
            return View();
        }
       
       
        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
