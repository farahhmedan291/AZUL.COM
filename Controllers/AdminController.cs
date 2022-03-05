using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AZUL.COM.Models;

namespace first_project.Controllers
{

    public class AdminController : Controller
    {
        private readonly AZULContext _context;
        public AdminController(AZULContext _context)
        {
            this._context = _context;
        }
        string id = "id";
        public IActionResult Index()
        {
            ViewBag.resNumber = _context.Reservation.Count();
            ViewBag.serNumber = _context.Service.Count();
            ViewBag.customrNumber = _context.Customer.Count();
            ViewBag.roomNumber = _context.Room.Count();
            ViewBag.Salary = _context.Employee.Select(x => x.Salary).Sum();
            var books = _context.Reservation.Select(x => x.TotalPrice).Sum();
            var orders= _context.Orders.Select(x => x.TotalPrice).Sum();
            var services =_context.CustomerServices.ToList();
            var sum = 0.0;
            var servicePrice=0.0;
            foreach (var item in services)
            {
                servicePrice =Convert.ToDouble( _context.Service.Where(x => x.Id == item.Id).Select(x => x.Price).FirstOrDefault());
                sum += servicePrice;

            }
            ViewBag.books = sum+books+orders;

            int id1 = Convert.ToInt32(HttpContext.Session.GetInt32(id));
            var name = _context.Employee.Where(x => x.Id == id1).Select(x => x.Name).FirstOrDefault();
            ViewBag.name = name;
            return View();
        }
    }
}
