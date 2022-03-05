using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using AZUL.COM.Models;
using Microsoft.AspNetCore.Http;
using System.IO;
using Microsoft.AspNetCore.Hosting;

namespace first_project.Controllers
{
    public class CustomersController : Controller
    {
        private readonly AZULContext _context;
        private readonly IWebHostEnvironment hostEnvironment;

        public CustomersController(AZULContext context, IWebHostEnvironment hostEnvironment)
        {
            _context = context;
            this.hostEnvironment = hostEnvironment;

        }

        // GET: Customers


        public async Task<IActionResult> Index()
        {
            
            return View(await _context.Customer.ToListAsync());
        }

        public async Task<IActionResult> CustomersInfo()
        {

            return View(await _context.Customer.ToListAsync());
        }

        // GET: Customers/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var customer = await _context.Customer
                .FirstOrDefaultAsync(m => m.Id == id);
            if (customer == null)
            {
                return NotFound();
            }

            return View(customer);
        }

        // GET: Customers/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Customers/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,FName,LName,Email,NationalNumber,BirthDate,PhoneNumber,imageName,ImageFile")] Customer customer,string username, string password)
        {
            if (ModelState.IsValid)
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
                _context.Add(customer);
                await _context.SaveChangesAsync();
                Login login1 = new Login();
                login1.UserName = username;
                login1.Password = password;
                login1.DeptType = 4;
                var lastId = _context.Customer.OrderByDescending(p => p.Id).FirstOrDefault().Id;
                login1.CustomerId = lastId;
                _context.Login.Add(login1);
                await _context.SaveChangesAsync();
                //View,contro
                return RedirectToAction("Login", "Logins");
            }
            return View(customer);
        }

        // GET: Customers/Edit/5
        public async Task<IActionResult> Edit(int? id)
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

        // POST: Customers/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,FName,LName,Email,NationalNumber,BirthDate,PhoneNumber,imageName,ImageFile")] Customer customer)
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
                return RedirectToAction(nameof(Index));
            }
            return View(customer);
        }

        // GET: Customers/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var customer = await _context.Customer
                .FirstOrDefaultAsync(m => m.Id == id);
            if (customer == null)
            {
                return NotFound();
            }

            return View(customer);
        }

        // POST: Customers/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var customer = await _context.Customer.FindAsync(id);
            _context.Customer.Remove(customer);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CustomerExists(int id)
        {
            return _context.Customer.Any(e => e.Id == id);
        }
    }
}
