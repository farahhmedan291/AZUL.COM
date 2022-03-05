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
    public class SharedPagesController : Controller
    {
        private readonly AZULContext _context;

        public SharedPagesController(AZULContext context)
        {
            _context = context;
        }

        // GET: SharedPages
        public async Task<IActionResult> Index()
        {
          
            return View(await _context.SharedPage.ToListAsync());
        }

        // GET: SharedPages/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var sharedPage = await _context.SharedPage
                .FirstOrDefaultAsync(m => m.Id == id);
            if (sharedPage == null)
            {
                return NotFound();
            }

            return View(sharedPage);
        }

        // GET: SharedPages/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: SharedPages/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,HotelName,FooterHeader,FooterParagraph,FooterCopyRight")] SharedPage sharedPage)
        {
            if (ModelState.IsValid)
            {
                _context.Add(sharedPage);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(sharedPage);
        }

        // GET: SharedPages/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var sharedPage = await _context.SharedPage.FindAsync(id);
            if (sharedPage == null)
            {
                return NotFound();
            }
            return View(sharedPage);
        }

        // POST: SharedPages/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,HotelName,FooterHeader,FooterParagraph,FooterCopyRight")] SharedPage sharedPage)
        {
            if (id != sharedPage.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(sharedPage);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!SharedPageExists(sharedPage.Id))
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
            return View(sharedPage);
        }

        // GET: SharedPages/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var sharedPage = await _context.SharedPage
                .FirstOrDefaultAsync(m => m.Id == id);
            if (sharedPage == null)
            {
                return NotFound();
            }

            return View(sharedPage);
        }

        // POST: SharedPages/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var sharedPage = await _context.SharedPage.FindAsync(id);
            _context.SharedPage.Remove(sharedPage);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool SharedPageExists(int id)
        {
            return _context.SharedPage.Any(e => e.Id == id);
        }
    }
}
