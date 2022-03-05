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
    public class OrdersController : Controller
    {
        private readonly AZULContext _context;

        public OrdersController(AZULContext context)
        {
            _context = context;
        }

        // GET: Orders
        public async Task<IActionResult> Index()
        {
           
            var aZULContext = _context.Orders.Include(o => o.Customer).Include(o => o.Meal);
            return View(await aZULContext.ToListAsync());
        }

        public async Task<IActionResult> CustomerOrders()
        {
            var id =Convert.ToInt32( TempData["id"]);
            var totalPrice = _context.Orders.Where(x => x.CustomerId == id).Select(x=>x.TotalPrice).Sum();
            ViewBag.totalPrice = totalPrice;
            var aZULContext = _context.Orders.Include(o => o.Customer).Where(x=>x.CustomerId==id).Include(o => o.Meal);
            return View(await aZULContext.ToListAsync());
        }

        // un arrived orders
        public async Task<IActionResult> AllCustomersOrder()
        {
           
            
            var aZULContext = _context.Orders.Where(x=>x.Arrive=="f").Include(o => o.Customer).Include(o => o.Meal);
            return View(await aZULContext.ToListAsync());
        }
        //all orders

        public async Task<IActionResult> AllOrders()
        {


            var aZULContext = _context.Orders.Include(o => o.Customer).Include(o => o.Meal);
            return View(await aZULContext.ToListAsync());
        }

        public async Task<IActionResult> arrived(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            
            var orderarrived = _context.Orders.Where(x => x.Id == id).FirstOrDefault();
            orderarrived.Arrive = "t";
            await _context.SaveChangesAsync();
            return RedirectToAction("AllCustomersOrder", "Orders");
        }


        // GET: Orders/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var orders = await _context.Orders
                .Include(o => o.Customer)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (orders == null)
            {
                return NotFound();
            }

            return View(orders);
        }

        // GET: Orders/Create
        public IActionResult Create()
        {
            ViewData["CustomerId"] = new SelectList(_context.Customer, "Id", "FName");
            ViewData["MealId"] = new SelectList(_context.Meal, "Id", "Name");
            return View();
        }

        // POST: Orders/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Date,TotalPrice,CustomerId,MealId,arrive,")] Orders orders)
        {
            if (ModelState.IsValid)
            {
                var id=Convert.ToInt32(TempData["id"]);
                orders.CustomerId = id;
                orders.Date = DateTime.Now;
                var mealPrice = _context.Meal.Where(x => x.Id == orders.MealId).Select(x => x.Price).FirstOrDefault();
                orders.TotalPrice = mealPrice;
                orders.Arrive = "f";
                var payemnt = _context.Payment.Where(x => x.CustomerId == id).FirstOrDefault();
                if(payemnt != null) { 
                var AmountMoney = _context.Payment.Where(x => x.CustomerId == id).Select(x => x.AmountOfMoney).FirstOrDefault();
                payemnt.AmountOfMoney = AmountMoney - mealPrice;
                _context.Payment.Update(payemnt);
                }
                _context.Add(orders);
                await _context.SaveChangesAsync();
                return RedirectToAction("Menu","Meals");
            }
            ViewData["CustomerId"] = new SelectList(_context.Customer, "Id", "FName", orders.CustomerId);
            ViewData["MealId"] = new SelectList(_context.Meal, "Id", "Name", orders.MealId);
            return View(orders);
        }

        // GET: Orders/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var orders = await _context.Orders.FindAsync(id);
            if (orders == null)
            {
                return NotFound();
            }
            ViewData["CustomerId"] = new SelectList(_context.Customer, "Id", "FName", orders.CustomerId);
            return View(orders);
        }

        // POST: Orders/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Date,TotalPrice,CustomerId,MealId,arrive")] Orders orders)
        {
            if (id != orders.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(orders);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!OrdersExists(orders.Id))
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
            ViewData["CustomerId"] = new SelectList(_context.Customer, "Id", "FName", orders.CustomerId);
            return View(orders);
        }

        // GET: Orders/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var orders = await _context.Orders
                .Include(o => o.Customer)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (orders == null)
            {
                return NotFound();
            }

            return View(orders);
        }

        // POST: Orders/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var orders = await _context.Orders.FindAsync(id);
            _context.Orders.Remove(orders);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool OrdersExists(int id)
        {
            return _context.Orders.Any(e => e.Id == id);
        }
    }
}
