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
    public class AccountantController : Controller
    {
        private readonly AZULContext _context;
        private readonly IWebHostEnvironment hostEnvironment;

        public AccountantController(AZULContext _context, IWebHostEnvironment hostEnvironment)
        {
            this._context = _context;
            this.hostEnvironment = hostEnvironment;
        }
        string id = "id";
        public IActionResult Index()
        {
            ViewBag.serNumber = _context.Service.Count();
            ViewBag.customrNumber = _context.Customer.Count();
            ViewBag.roomNumber = _context.Room.Count();
            ViewBag.Salary = _context.Employee.Select(x => x.Salary).Sum();
            var books = _context.Reservation.Select(x => x.TotalPrice).Sum();
            var orders = _context.Orders.Select(x => x.TotalPrice).Sum();
            var services = _context.CustomerServices.ToList();
            var sum = 0.0;
            var servicePrice = 0.0;
            foreach (var item in services)
            {
                servicePrice = Convert.ToDouble(_context.Service.Where(x => x.Id == item.Id).Select(x => x.Price).FirstOrDefault());
                sum += servicePrice;

            }
            ViewBag.books = sum + books + orders;
            var sumofSalary = _context.Employee.Select(x => x.Salary).Sum();
            ViewBag.NetProfit = (sum + books + orders) - sumofSalary;

            int id1 = Convert.ToInt32(HttpContext.Session.GetInt32(id));
            var name = _context.Employee.Where(x => x.Id == id1).Select(x => x.Name).FirstOrDefault();
            ViewBag.name = name;
            ViewBag.id = id1;
            TempData["id"] = id1;
            return View();
        }

        public IActionResult SalarySlip()
        {

            int id1 = Convert.ToInt32(HttpContext.Session.GetInt32(id));
            var name = _context.Employee.Where(x => x.Id == id1).Select(x => x.Name).FirstOrDefault();


            ViewBag.name = name;
            ViewBag.id = id1;


            var info = _context.Employee.Find(id1);
            return View(info);
        }
        public IActionResult Profile()
        {
            int id1 = Convert.ToInt32(HttpContext.Session.GetInt32(id));
            var name = _context.Employee.Where(x => x.Id == id1).Select(x => x.Name).FirstOrDefault();
            var userName = _context.Login.Where(x => x.EmployeeId == id1).Select(x => x.UserName).FirstOrDefault();

            ViewBag.name = name;
            ViewBag.id = id1;
            ViewBag.userName = userName;


            var info = _context.Employee.Find(id1);
            return View(info);
        }



        public async Task<IActionResult> EditProfile(int? id)
        {

            if (id == null)
            {
                return NotFound();
            }

            var employee = await _context.Employee.FindAsync(id);
            if (employee == null)
            {
                return NotFound();
            }
            ViewData["DeptType"] = new SelectList(_context.DepartmentType, "Id", "Name", employee.DeptType);
            return View(employee);
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> EditProfile(int id, [Bind("Id,Name,Email,NationalNumber,BirthDate,PhoneNumber,Salary,DeptType,Profits,Losses,ImageName,ImageFile")] Employee employee)
        {
            if (id != employee.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {

                try
                {
                    if (employee.ImageFile != null)
                    {

                        string root = hostEnvironment.WebRootPath;
                        string filename = employee.ImageFile.FileName;
                        string path = Path.Combine(root + "/img/" + filename);
                        using (var fileStream = new FileStream(path, FileMode.Create))
                        {
                            await employee.ImageFile.CopyToAsync(fileStream);
                        }
                        employee.ImageName = filename;
                    }



                    _context.Update(employee);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!EmployeeExists(employee.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction("Profile", "Accountant");
            }
            ViewData["DeptType"] = new SelectList(_context.DepartmentType, "Id", "Name", employee.DeptType);
            return View(employee);
        }

        private bool EmployeeExists(int id)
        {
            throw new NotImplementedException();
        }


    }
}
