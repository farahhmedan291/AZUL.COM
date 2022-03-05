using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using AZUL.COM.Models;

namespace AZUL.COM.Controllers
{
    public class ServicesPagesController : Controller
    {
        private readonly AZULContext _context;

        public ServicesPagesController(AZULContext context)
        {
            _context = context;
        }

        // GET: ServicesPages
        public async Task<IActionResult> Index()
        {
            return View(await _context.ServicesPage.ToListAsync());
        }

        // GET: ServicesPages/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var servicesPage = await _context.ServicesPage
                .FirstOrDefaultAsync(m => m.Id == id);
            if (servicesPage == null)
            {
                return NotFound();
            }

            return View(servicesPage);
        }

        // GET: ServicesPages/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: ServicesPages/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,HeaderImage,DescHeader,DescParagraph,DescImage1,DescImage2,DescImage3,DescSubHeader1,DescSubHeader2,DescSubHeader3,DescSubParagraph1,DescSubParagraph2,DescSubParagraph3,ServicesHeader1,ServicesHeader2,ServicesHeader3,ServicesHeader4,ServicesHeader5,ServicesHeader6,ServicesParagraph1,ServicesParagraph2,ServicesParagraph3,ServicesParagraph4,ServicesParagraph5,ServicesParagraph6")] ServicesPage servicesPage)
        {
            if (ModelState.IsValid)
            {
                _context.Add(servicesPage);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(servicesPage);
        }

        // GET: ServicesPages/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var servicesPage = await _context.ServicesPage.FindAsync(id);
            if (servicesPage == null)
            {
                return NotFound();
            }
            return View(servicesPage);
        }

        // POST: ServicesPages/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,HeaderImage,DescHeader,DescParagraph,DescImage1,DescImage2,DescImage3,DescSubHeader1,DescSubHeader2,DescSubHeader3,DescSubParagraph1,DescSubParagraph2,DescSubParagraph3,ServicesHeader1,ServicesHeader2,ServicesHeader3,ServicesHeader4,ServicesHeader5,ServicesHeader6,ServicesParagraph1,ServicesParagraph2,ServicesParagraph3,ServicesParagraph4,ServicesParagraph5,ServicesParagraph6")] ServicesPage servicesPage)
        {
            if (id != servicesPage.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(servicesPage);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ServicesPageExists(servicesPage.Id))
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
            return View(servicesPage);
        }

        // GET: ServicesPages/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var servicesPage = await _context.ServicesPage
                .FirstOrDefaultAsync(m => m.Id == id);
            if (servicesPage == null)
            {
                return NotFound();
            }

            return View(servicesPage);
        }

        // POST: ServicesPages/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var servicesPage = await _context.ServicesPage.FindAsync(id);
            _context.ServicesPage.Remove(servicesPage);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ServicesPageExists(int id)
        {
            return _context.ServicesPage.Any(e => e.Id == id);
        }
    }
}
