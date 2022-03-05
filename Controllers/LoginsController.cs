using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using AZUL.COM.Models;
using Microsoft.AspNetCore.Http;

namespace first_project.Controllers
{
    public class LoginsController : Controller
    {
        private readonly AZULContext _context;
        const string id = "id";
        public LoginsController(AZULContext context)
        {
            _context = context;
        }

        // GET: Logins
        
        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Login(string username, string password)
        {
            
            var Authentication = _context.Login.Where(x => x.UserName == username && x.Password == password).FirstOrDefault();
            if (Authentication != null)
            {
                
                    switch (Authentication.DeptType)
                    {
                    case 1:
                        HttpContext.Session.SetInt32(id, Authentication.EmployeeId.Value);
                        return RedirectToAction("Index", "Admin"); 
                    case 2:
                        HttpContext.Session.SetInt32(id, Authentication.EmployeeId.Value);
                        return RedirectToAction("Index", "Waiter");
                    case 3:
                        HttpContext.Session.SetInt32(id, Authentication.EmployeeId.Value);
                        return RedirectToAction("Index", "Accountant");
                    case 4:
                        HttpContext.Session.SetInt32(id, Authentication.CustomerId.Value);
                        return RedirectToAction("Index", "Customer");
                  
                        

                    }


            }
            else { }
            return View();
        }
        
        public async Task<IActionResult> Index()
        {
            var aZULContext = _context.Login.Include(l => l.Customer).Include(l => l.DeptTypeNavigation).Include(l => l.Employee);
            return View(await aZULContext.ToListAsync());
        }

        // GET: Logins/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var login = await _context.Login
                .Include(l => l.Customer)
                .Include(l => l.DeptTypeNavigation)
                .Include(l => l.Employee)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (login == null)
            {
                return NotFound();
            }

            return View(login);
        }

        // GET: Logins/Create
        public IActionResult Create()
        {
            ViewData["CustomerId"] = new SelectList(_context.Customer, "Id", "FName");
            ViewData["DeptType"] = new SelectList(_context.DepartmentType, "Id", "Name");
            ViewData["EmployeeId"] = new SelectList(_context.Employee, "Id", "Name");
            return View();
        }

        // POST: Logins/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,UserName,Password,DeptType,CustomerId,EmployeeId")] Login login)
        {
            if (ModelState.IsValid)
            {
                _context.Add(login);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["CustomerId"] = new SelectList(_context.Customer, "Id", "FName", login.CustomerId);
            ViewData["DeptType"] = new SelectList(_context.DepartmentType, "Id", "Name", login.DeptType);
            ViewData["EmployeeId"] = new SelectList(_context.Employee, "Id", "Name", login.EmployeeId);
            return View(login);
        }

        // GET: Logins/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var login = await _context.Login.FindAsync(id);
            if (login == null)
            {
                return NotFound();
            }
            ViewData["CustomerId"] = new SelectList(_context.Customer, "Id", "FName", login.CustomerId);
            ViewData["DeptType"] = new SelectList(_context.DepartmentType, "Id", "Name", login.DeptType);
            ViewData["EmployeeId"] = new SelectList(_context.Employee, "Id", "Name", login.EmployeeId);
            return View(login);
        }

        // POST: Logins/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,UserName,Password,DeptType,CustomerId,EmployeeId")] Login login)
        {
            if (id != login.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(login);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!LoginExists(login.Id))
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
            ViewData["CustomerId"] = new SelectList(_context.Customer, "Id", "FName", login.CustomerId);
            ViewData["DeptType"] = new SelectList(_context.DepartmentType, "Id", "Name", login.DeptType);
            ViewData["EmployeeId"] = new SelectList(_context.Employee, "Id", "Name", login.EmployeeId);
            return View(login);
        }



      





        // GET: Logins/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var login = await _context.Login
                .Include(l => l.Customer)
                .Include(l => l.DeptTypeNavigation)
                .Include(l => l.Employee)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (login == null)
            {
                return NotFound();
            }

            return View(login);
        }

        // POST: Logins/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var login = await _context.Login.FindAsync(id);
            _context.Login.Remove(login);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool LoginExists(int id)
        {
            return _context.Login.Any(e => e.Id == id);
        }
    }
}
