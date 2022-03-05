using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using AZUL.COM.Models;

namespace first_project.Controllers
{
    public class CustomerServicesController : Controller
    {
        private readonly AZULContext _context;

        public CustomerServicesController(AZULContext context)
        {
            _context = context;
        }

        // GET: CustomerServices
        public async Task<IActionResult> Index()
        {
            var aZULContext = _context.CustomerServices.Include(c => c.Customer).Include(c => c.Service);
            return View(await aZULContext.ToListAsync());
        }

        public async Task<IActionResult> AllServices()
        {
            var aZULContext = _context.CustomerServices.Include(c => c.Customer).Include(c => c.Service);
            return View(await aZULContext.ToListAsync());
        }
        public async Task<IActionResult> MyServices()
        {
            var id = Convert.ToInt32(TempData["id"]);
            var aZULContext = _context.CustomerServices.Include(c => c.Customer).Where(x => x.CustomerId == id).Include(c => c.Service);
            return View(await aZULContext.ToListAsync());
        }
        // GET: CustomerServices/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var customerServices = await _context.CustomerServices
                .Include(c => c.Customer)
                .Include(c => c.Service)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (customerServices == null)
            {
                return NotFound();
            }

            return View(customerServices);
        }

        // GET: CustomerServices/Create
        public IActionResult Create()
        {
            ViewData["CustomerId"] = new SelectList(_context.Customer, "Id", "FName");
            ViewData["ServiceId"] = new SelectList(_context.Service, "Id", "Name");
            return View();
        }

        // POST: CustomerServices/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,CustomerId,ServiceId,Date")] CustomerServices customerServices)
        {
            if (ModelState.IsValid)
            {
                int id = Convert.ToInt32(@TempData["id"]);
                customerServices.CustomerId = id;
                _context.Add(customerServices);
                var price = _context.Service.Where(x => x.Id == customerServices.ServiceId).Select(x => x.Price).FirstOrDefault();
                var payemnt = _context.Payment.Where(x => x.CustomerId == id).FirstOrDefault();
                if (payemnt != null)
                {
                    var AmountMoney = _context.Payment.Where(x => x.CustomerId == id).Select(x => x.AmountOfMoney).FirstOrDefault();
                    payemnt.AmountOfMoney = AmountMoney - price;
                    _context.Payment.Update(payemnt);
                }
                await _context.SaveChangesAsync();
                return RedirectToAction("Show", "Services");
            }
            ViewData["CustomerId"] = new SelectList(_context.Customer, "Id", "FName", customerServices.CustomerId);
            ViewData["ServiceId"] = new SelectList(_context.Service, "Id", "Name", customerServices.ServiceId);
            return View(customerServices);
        }

        // GET: CustomerServices/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var customerServices = await _context.CustomerServices.FindAsync(id);
            if (customerServices == null)
            {
                return NotFound();
            }
            ViewData["CustomerId"] = new SelectList(_context.Customer, "Id", "FName", customerServices.CustomerId);
            ViewData["ServiceId"] = new SelectList(_context.Service, "Id", "Name", customerServices.ServiceId);
            return View(customerServices);
        }

        // POST: CustomerServices/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,CustomerId,ServiceId,date")] CustomerServices customerServices)
        {
            if (id != customerServices.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(customerServices);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CustomerServicesExists(customerServices.Id))
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
            ViewData["CustomerId"] = new SelectList(_context.Customer, "Id", "FName", customerServices.CustomerId);
            ViewData["ServiceId"] = new SelectList(_context.Service, "Id", "Name", customerServices.ServiceId);
            return View(customerServices);
        }

        // GET: CustomerServices/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var customerServices = await _context.CustomerServices
                .Include(c => c.Customer)
                .Include(c => c.Service)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (customerServices == null)
            {
                return NotFound();
            }

            return View(customerServices);
        }

        // POST: CustomerServices/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var customerServices = await _context.CustomerServices.FindAsync(id);
            _context.CustomerServices.Remove(customerServices);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CustomerServicesExists(int id)
        {
            return _context.CustomerServices.Any(e => e.Id == id);
        }
    }
}
