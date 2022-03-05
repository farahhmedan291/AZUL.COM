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
    public class AttendanceReportsController : Controller
    {
        private readonly AZULContext _context;

        public AttendanceReportsController(AZULContext context)
        {
            _context = context;
        }

        // GET: AttendanceReports
        public async Task<IActionResult> Index()
        {
            var aZULContext = _context.AttendanceReport.Include(a => a.Employee);
            return View(await aZULContext.ToListAsync());
        }
        public async Task<IActionResult> AllEmployeesAttend()
        {
            var aZULContext = _context.AttendanceReport.Include(a => a.Employee);
            return View(await aZULContext.ToListAsync());
        }

        public async Task<IActionResult> MyAttend()
        {
            var id = Convert.ToInt32(TempData["id"]);
            var attendDay = _context.AttendanceReport.Where(x => x.EmployeeId == id).Count();
            ViewBag.attendDay = attendDay;
            var aZULContext = _context.AttendanceReport.Include(a => a.Employee).Where(x=>x.EmployeeId==id);
            return View(await aZULContext.ToListAsync());
        }

        public async Task<IActionResult> MyAttend1()
        {
            var id = Convert.ToInt32(TempData["id"]);
            var attendDay = _context.AttendanceReport.Where(x => x.EmployeeId == id).Count();
            ViewBag.attendDay = attendDay;
            var aZULContext = _context.AttendanceReport.Include(a => a.Employee).Where(x => x.EmployeeId == id);
            return View(await aZULContext.ToListAsync());
        }

        // GET: AttendanceReports/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var attendanceReport = await _context.AttendanceReport
                .Include(a => a.Employee)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (attendanceReport == null)
            {
                return NotFound();
            }

            return View(attendanceReport);
        }
        public async Task<IActionResult> CheckIn()
        {
            int id =Convert.ToInt32(@TempData["id"]);
            var check = _context.AttendanceReport.Where(x => x.EmployeeId == id && x.Date == DateTime.Today).FirstOrDefault();
            if(check == null) {
                AttendanceReport tody = new AttendanceReport();
                tody.EmployeeId = id;
                tody.Date = DateTime.Today;
                tody.EnterHour = DateTime.Now;
                _context.AttendanceReport.Add(tody);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction("Index","Waiter");
        }
        public async Task<IActionResult> CheckOut()
        {
            int id = Convert.ToInt32(@TempData["id"]);
            var tody = _context.AttendanceReport.OrderByDescending(p => p.Id).Where(x => x.EmployeeId == id && x.Date == DateTime.Today).FirstOrDefault();
            tody.ExitHour=DateTime.Now;
            TimeSpan hourDifference = (TimeSpan)(tody.ExitHour - tody.EnterHour);
            tody.numberOfHour = Convert.ToInt32(hourDifference.TotalHours);
            await _context.SaveChangesAsync();
            return RedirectToAction("Index", "Waiter");
        }

        public async Task<IActionResult> CheckIn1()
        {
            int id = Convert.ToInt32(@TempData["id"]);
            var check = _context.AttendanceReport.Where(x => x.EmployeeId == id && x.Date == DateTime.Today).FirstOrDefault();
            if (check == null)
            {
                AttendanceReport tody = new AttendanceReport();
                tody.EmployeeId = id;
                tody.Date = DateTime.Today;
                tody.EnterHour = DateTime.Now;
                _context.AttendanceReport.Add(tody);
            }
          
            await _context.SaveChangesAsync();
            return RedirectToAction("Index", "Accountant");
        }
        public async Task<IActionResult> CheckOut1()
        {
            int id = Convert.ToInt32(@TempData["id"]);
            var tody = _context.AttendanceReport.OrderByDescending(p => p.Id).Where(x => x.EmployeeId == id && x.Date == DateTime.Today).FirstOrDefault();
            tody.ExitHour = DateTime.Now;
            TimeSpan hourDifference = (TimeSpan)(tody.ExitHour - tody.EnterHour);
            tody.numberOfHour =Convert.ToInt32( hourDifference.TotalHours);
            
            await _context.SaveChangesAsync();
            return RedirectToAction("Index", "Accountant");
        }

        // GET: AttendanceReports/Create
        public IActionResult Create()
        {
            ViewData["EmployeeId"] = new SelectList(_context.Employee, "Id", "Name");
            return View();
        }

        // POST: AttendanceReports/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Date,EnterHour,ExitHour,Note,EmployeeId,numberOfHour")] AttendanceReport attendanceReport)
        {
            if (ModelState.IsValid)
            {
                _context.Add(attendanceReport);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["EmployeeId"] = new SelectList(_context.Employee, "Id", "Name", attendanceReport.EmployeeId);
            return View(attendanceReport);
        }

        // GET: AttendanceReports/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var attendanceReport = await _context.AttendanceReport.FindAsync(id);
            if (attendanceReport == null)
            {
                return NotFound();
            }
            ViewData["EmployeeId"] = new SelectList(_context.Employee, "Id", "Name", attendanceReport.EmployeeId);
            return View(attendanceReport);
        }

        // POST: AttendanceReports/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Date,EnterHour,ExitHour,Note,EmployeeId,numberOfHour")] AttendanceReport attendanceReport)
        {
            if (id != attendanceReport.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(attendanceReport);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!AttendanceReportExists(attendanceReport.Id))
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
            ViewData["EmployeeId"] = new SelectList(_context.Employee, "Id", "Name", attendanceReport.EmployeeId);
            return View(attendanceReport);
        }

        // GET: AttendanceReports/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var attendanceReport = await _context.AttendanceReport
                .Include(a => a.Employee)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (attendanceReport == null)
            {
                return NotFound();
            }

            return View(attendanceReport);
        }

        // POST: AttendanceReports/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var attendanceReport = await _context.AttendanceReport.FindAsync(id);
            _context.AttendanceReport.Remove(attendanceReport);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool AttendanceReportExists(int id)
        {
            return _context.AttendanceReport.Any(e => e.Id == id);
        }
    }
}
