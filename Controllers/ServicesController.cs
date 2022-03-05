using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using AZUL.COM.Models;
using System.IO;
using Microsoft.AspNetCore.Hosting;

namespace first_project.Controllers
{
    public class ServicesController : Controller
    {
        private readonly AZULContext _context;
        private readonly IWebHostEnvironment hostEnvironment;

        public ServicesController(AZULContext context, IWebHostEnvironment hostEnvironment)
        {
            _context = context;
            this.hostEnvironment = hostEnvironment;

        }

        // GET: Services
        public async Task<IActionResult> Index()
        {
            ViewData["ServiceName"] = new SelectList(_context.Service, "Id", "Type");
            return View(await _context.Service.ToListAsync());
        }

        public async Task<IActionResult> Show()
        {
            ViewData["ServiceName"] = new SelectList(_context.Service, "Id", "Type");
            return View(await _context.Service.ToListAsync());

        }
        
        //public IActionResult MakeOrder()
        //{
        //    CustomerServices obj = new CustomerServices();

        //    return View();
        //}

        // GET: Services/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var service = await _context.Service
                .FirstOrDefaultAsync(m => m.Id == id);
            if (service == null)
            {
                return NotFound();
            }

            return View(service);
        }

        // GET: Services/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Services/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Name,Price,ImageName,ImageFile")] Service service)
        {
            if (ModelState.IsValid)
            {
                if (service.ImageFile != null)
                {
                    string root = hostEnvironment.WebRootPath;
                    string filename = Guid.NewGuid().ToString() + "_" + service.ImageFile.FileName;
                    string path = Path.Combine(root + "/img/" + filename);
                    using (var fileStream = new FileStream(path, FileMode.Create))
                    {
                        await service.ImageFile.CopyToAsync(fileStream);
                    }
                    service.ImageName = filename;
                }
                _context.Add(service);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(service);
        }

        // GET: Services/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var service = await _context.Service.FindAsync(id);
            if (service == null)
            {
                return NotFound();
            }
            return View(service);
        }

        // POST: Services/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Name,Price,ImageName,ImageFile")] Service service)
        {
            if (id != service.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    if (service.ImageFile != null)
                    {
                        string root = hostEnvironment.WebRootPath;
                        string filename = Guid.NewGuid().ToString() + "_" + service.ImageFile.FileName;
                        string path = Path.Combine(root + "/img/" + filename);
                        using (var fileStream = new FileStream(path, FileMode.Create))
                        {
                            await service.ImageFile.CopyToAsync(fileStream);
                        }
                        service.ImageName = filename;
                    }
                    _context.Update(service);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ServiceExists(service.Id))
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
            return View(service);
        }

        // GET: Services/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var service = await _context.Service
                .FirstOrDefaultAsync(m => m.Id == id);
            if (service == null)
            {
                return NotFound();
            }

            return View(service);
        }

        // POST: Services/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var service = await _context.Service.FindAsync(id);
            _context.Service.Remove(service);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ServiceExists(int id)
        {
            return _context.Service.Any(e => e.Id == id);
        }
    }
}
