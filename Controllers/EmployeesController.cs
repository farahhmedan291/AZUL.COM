using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using AZUL.COM.Models;
using Microsoft.AspNetCore.Hosting;
using System.IO;

namespace first_project.Controllers
{
    public class EmployeesController : Controller
    {
        private readonly AZULContext _context;
        private readonly IWebHostEnvironment hostEnvironment;
        public EmployeesController(AZULContext context, IWebHostEnvironment hostEnvironment)
        {
            _context = context;
            this.hostEnvironment = hostEnvironment;
        }

        // GET: Employees
   
        public async Task<IActionResult> Index()
        {
            var aZULContext = _context.Employee.Include(e => e.DeptTypeNavigation);
           
            return View(await aZULContext.ToListAsync());
        }

        public async Task<IActionResult> EmpInfo()
        {
            var aZULContext = _context.Employee.Include(e => e.DeptTypeNavigation);

            return View(await aZULContext.ToListAsync());
        }

        // GET: Employees/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var employee = await _context.Employee
                .Include(e => e.DeptTypeNavigation)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (employee == null)
            {
                return NotFound();
            }

            return View(employee);
        }

        // GET: Employees/Create
        public IActionResult Create()
        {
            ViewData["DeptType"] = new SelectList(_context.DepartmentType, "Id", "Name");
            return View();
        }
        public IActionResult FinancialReports()
        {

            AZULContext hotel = new AZULContext();


            var list = _context.Employee.ToList();
            return View(list);
            
        }
        public IActionResult AddEmp()
        {

            AZULContext hotel = new AZULContext();
            var list = _context.Employee.ToList();
            return View(list);

        }
       


        // POST: Employees/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Name,Email,NationalNumber,BirthDate,PhoneNumber,Salary,DeptType,Profits,Losses,imageName,ImageFile")] Employee employee, string username, string password)
        {
            if (ModelState.IsValid)
            {
                if (employee.ImageFile != null)
                {
                    string root = hostEnvironment.WebRootPath;
                    string filename =employee.ImageFile.FileName;
                    string path = Path.Combine(root + "/img/" + filename);
                    using (var fileStream = new FileStream(path, FileMode.Create))
                    {
                        await employee.ImageFile.CopyToAsync(fileStream);
                    }
                    employee.ImageName = filename;
                }
                employee.Profits = 0;
                employee.Losses = 0;
                _context.Add(employee);
                await _context.SaveChangesAsync();
                Login login1 = new Login();
                login1.UserName = username;
                login1.Password = password;
                login1.DeptType = employee.DeptType;
                var lastId = _context.Employee.OrderByDescending(p => p.Id).FirstOrDefault().Id;
                login1.EmployeeId = lastId;
                _context.Login.Add(login1);
                await _context.SaveChangesAsync();
               
                return RedirectToAction(nameof(AddEmp));
            }
            ViewData["DeptType"] = new SelectList(_context.DepartmentType, "Id", "Name", employee.DeptType);
            return View(employee);
        }

        // GET: Employees/Edit/5
        public async Task<IActionResult> Edit(int? id)
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

        // POST: Employees/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Name,Email,NationalNumber,BirthDate,PhoneNumber,Salary,DeptType,Profits,Losses,ImageName,ImageFile")] Employee employee)
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
                return RedirectToAction(nameof(AddEmp));
            }
            ViewData["DeptType"] = new SelectList(_context.DepartmentType, "Id", "Name", employee.DeptType);
            return View(employee);
        }

        // GET: Employees/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var employee = await _context.Employee
                .Include(e => e.DeptTypeNavigation)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (employee == null)
            {
                return NotFound();
            }

            return View(employee);
        }

        // POST: Employees/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var employee = await _context.Employee.FindAsync(id);
            _context.Employee.Remove(employee);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(AddEmp));
        }

        private bool EmployeeExists(int id)
        {
            return _context.Employee.Any(e => e.Id == id);
        }
    }
}
