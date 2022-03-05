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
    public class ReservationsController : Controller
    {
        private readonly AZULContext _context;

        public ReservationsController(AZULContext context)
        {
            _context = context;
        }

        // GET: Reservations
        public async Task<IActionResult> Index()
        {
            
            var aZULContext = _context.Reservation.Include(r => r.Customer).Include(r => r.Room);
            return View(await aZULContext.ToListAsync());
        }
        public async Task<IActionResult> MyReservation()
        {
            var id = Convert.ToInt32(TempData["id"]);
            var aZULContext = _context.Reservation.Where(x=>x.CustomerId==id).Include(r => r.Customer).Include(r => r.Room);
            return View(await aZULContext.ToListAsync());
        }

        public IActionResult SearchByDate(DateTime from, DateTime to )
        {
            
            AZULContext rest = new AZULContext();
            var search = _context.Reservation.Where(x => x.CheckInDate >=from && x.CheckInDate<=to).Include(r => r.Customer).Include(r => r.Room).ToList();
            
            return View(search);
        }

        public IActionResult PrintReports(DateTime from, DateTime to)
        {

            AZULContext rest = new AZULContext();
            var search = _context.Reservation.Where(x => x.CheckInDate >= from && x.CheckInDate <= to).Include(r => r.Customer).Include(r => r.Room).ToList();

            return View(search);
        }

        // GET: Reservations/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var reservation = await _context.Reservation
                .Include(r => r.Customer)
                .Include(r => r.Room)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (reservation == null)
            {
                return NotFound();
            }

            return View(reservation);
        }

        // GET: Reservations/Create
        public IActionResult Create()
        {
            ViewData["CustomerId"] = new SelectList(_context.Customer, "Id", "Id");
            ViewData["CustomerFName"] = new SelectList(_context.Customer, "Id", "FName");
            ViewData["CustomerLName"] = new SelectList(_context.Customer, "Id", "LName");
            ViewData["RoomId"] = new SelectList(_context.Room.Where(x=>x.State=="a"), "Id", "Id");
            return View();
        }

        // POST: Reservations/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,RoomId,CustomerId,ResDate,CheckInDate,CheckOutDate,FName,LName,totalPrice,numberOfDayes,ReservationsPrice")] Reservation reservation, Room room,DateTime indate, DateTime outdate)
        {
            if (ModelState.IsValid)
            {
                int id =Convert.ToInt32( @TempData["id"]);
                reservation.ResDate = DateTime.Now;
                reservation.CustomerId = id;
                reservation.CheckInDate = indate;
                reservation.CheckOutDate = outdate;
                    var roomPrice = _context.Room.Where(x => x.Id == reservation.RoomId).Select(x => x.Price).FirstOrDefault();
                    TimeSpan dayDifference = (TimeSpan)(reservation.CheckOutDate - reservation.CheckInDate);
                    var totalDays = dayDifference.TotalDays;
                reservation.numberOfDayes =Convert.ToInt32( totalDays);

                Double TotalPrice= totalDays * roomPrice;
                reservation.ReservationsPrice = TotalPrice;
                _context.Add(reservation);

                reservation.TotalPrice = TotalPrice;
                    var payemnt = _context.Payment.Where(x => x.CustomerId == id).FirstOrDefault();
                    var AmountMoney = _context.Payment.Where(x => x.CustomerId == id).Select(x => x.AmountOfMoney).FirstOrDefault();
                    payemnt.AmountOfMoney = AmountMoney - TotalPrice;
                    _context.Payment.Update(payemnt);
                    await _context.SaveChangesAsync();
                    var room1 = _context.Room.Where(x => x.Id == reservation.RoomId).FirstOrDefault();
                    room1.State = "u";
                    await _context.SaveChangesAsync();
                    return RedirectToAction("Book", "Rooms", room);
            }
            ViewData["CustomerId"] = new SelectList(_context.Customer, "Id", "Id", reservation.CustomerId);
            ViewData["RoomId"] = new SelectList(_context.Room.Where(x => x.State == "a"), "Id", "Id", reservation.RoomId);
            ViewData["CustomerFName"] = new SelectList(_context.Customer, "Id", "FName", reservation.FName);
            ViewData["CustomerLName"] = new SelectList(_context.Customer, "Id", "LName", reservation.LName);
            return View(reservation);
        }

        // GET: Reservations/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var reservation = await _context.Reservation.FindAsync(id);
            if (reservation == null)
            {
                return NotFound();
            }
            ViewData["CustomerId"] = new SelectList(_context.Customer, "Id", "FName", reservation.CustomerId);
            ViewData["RoomId"] = new SelectList(_context.Room, "Id", "State", reservation.RoomId);
            return View(reservation);
        }

        // POST: Reservations/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,RoomId,CustomerId,ResDate,CheckInDate,CheckOutDate,totalPrice")] Reservation reservation)
        {
            if (id != reservation.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(reservation);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ReservationExists(reservation.Id))
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
            ViewData["CustomerId"] = new SelectList(_context.Customer, "Id", "FName", reservation.CustomerId);
            ViewData["RoomId"] = new SelectList(_context.Room, "Id", "State", reservation.RoomId);
            return View(reservation);
        }

        // GET: Reservations/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var reservation = await _context.Reservation
                .Include(r => r.Customer)
                .Include(r => r.Room)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (reservation == null)
            {
                return NotFound();
            }

            return View(reservation);
        }

        // POST: Reservations/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var reservation = await _context.Reservation.FindAsync(id);
            _context.Reservation.Remove(reservation);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ReservationExists(int id)
        {
            return _context.Reservation.Any(e => e.Id == id);
        }
    }
}
