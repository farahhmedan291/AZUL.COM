using AZUL.COM.Models;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace first_project.Controllers
{
    public class CustomerController : Controller
    {
        private readonly AZULContext _context;
        private readonly IWebHostEnvironment hostEnvironment;
       
        public CustomerController(AZULContext _context, IWebHostEnvironment hostEnvironment)
        {
            this._context = _context;
            this.hostEnvironment = hostEnvironment;
        }
        string id = "id";
        public async Task<IActionResult> Index()
        {
            
            int id1 = Convert.ToInt32(HttpContext.Session.GetInt32(id));
            ViewBag.id = id1;
            TempData["id"] = id1;
            var order = _context.Orders.Where(x => x.CustomerId == id1).Count();
            var Reservation = _context.Reservation.Where(x => x.CustomerId == id1).Count();
            var card = _context.Payment.Where(x => x.CustomerId == id1).Count();

            var name1 = _context.Customer.Where(x=>x.Id==id1).Select(x=>x.FName).FirstOrDefault();
            var name2 = _context.Customer.Where(x => x.Id == id1).Select(x => x.LName).FirstOrDefault();
            var fullName = name1 + " " + name2;
            ViewBag.name = fullName;
            ViewBag.order = order;
            ViewBag.Reservation = Reservation;
            ViewBag.card = card;
            await _context.SaveChangesAsync();
            return View();
        }
        public IActionResult GetById()
        {
            int id1 = Convert.ToInt32(HttpContext.Session.GetInt32(id));
            var item = _context.Customer.Find(id1);
            return View(item);
        }
        public async Task<IActionResult> CheckOut()
        {
            int id1 = Convert.ToInt32(HttpContext.Session.GetInt32(id));
            var room = _context.Reservation.Where(x =>x.CustomerId==id1).FirstOrDefault();
            var roomout = _context.Room.Where(x => x.Id == room.RoomId).FirstOrDefault();
            roomout.State = "a";
            //if you want to delete this reservation from table un comment the line
            //_context.Reservation.Remove(room);
            await _context.SaveChangesAsync();
            return View();
        }

        public IActionResult Profile()
        {
            int id1 = Convert.ToInt32(HttpContext.Session.GetInt32(id));
            var name1 = _context.Customer.Where(x => x.Id == id1).Select(x => x.FName).FirstOrDefault();
            var name2 = _context.Customer.Where(x => x.Id == id1).Select(x => x.LName).FirstOrDefault();
           var birthday= _context.Customer.Where(x => x.Id == id1).Select(x => x.BirthDate).FirstOrDefault();
            var userName = _context.Login.Where(x => x.CustomerId == id1).Select(x => x.UserName).FirstOrDefault();
            var fullName = name1 + " " + name2;
            ViewBag.name = fullName;
            ViewBag.id = id1;
            ViewBag.userName = userName;
            var info = _context.Customer.Find(id1);
            return View(info);
        }
        public async Task<IActionResult> EditProfile(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var customer = await _context.Customer.FindAsync(id);
            if (customer == null)
            {
                return NotFound();
            }
            return View(customer);
        }

      
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> EditProfile(int id, [Bind("Id,FName,LName,Email,NationalNumber,BirthDate,PhoneNumber,ImageName,ImageFile")] Customer customer)
        {
            if (id != customer.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try

                {

                    if (customer.ImageFile != null)
                    {
                        string root = hostEnvironment.WebRootPath;
                        string filename = customer.ImageFile.FileName;
                        string path = Path.Combine(root + "/img/" + filename);
                        using (var fileStream = new FileStream(path, FileMode.Create))
                        {
                            await customer.ImageFile.CopyToAsync(fileStream);
                        }
                        customer.ImageName = filename;
                    }
                    _context.Update(customer);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CustomerExists(customer.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction("Profile", "Customer");
            }
            return View(customer);
        }
        
       
        
        private bool CustomerExists(int id)
        {
            return _context.Customer.Any(e => e.Id == id);
        }

    }
}
