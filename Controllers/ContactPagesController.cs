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
    public class ContactPagesController : Controller
    {
        private readonly AZULContext _context;

        public ContactPagesController(AZULContext context)
        {
            _context = context;
        }

        // GET: ContactPages
        public async Task<IActionResult> Index()
        {
            return View(await _context.ContactPage.ToListAsync());
        }

        // GET: ContactPages/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var contactPage = await _context.ContactPage
                .FirstOrDefaultAsync(m => m.Id == id);
            if (contactPage == null)
            {
                return NotFound();
            }

            return View(contactPage);
        }

        // GET: ContactPages/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: ContactPages/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,HeaderImage,PlaceHeader1,PlaceHeader2,PlaceHeader3,PlaceParagraph1,PlaceParagraph2,PlaceParagraph3,PlaceAddress1,PlaceAddress2,PlaceAddress3,PlacePhone1,PlacePhone2,PlacePhone3,PlaceEmail1,PlaceEmail2,PlaceEmail3")] ContactPage contactPage)
        {
            if (ModelState.IsValid)
            {
                _context.Add(contactPage);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(contactPage);
        }

        // GET: ContactPages/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var contactPage = await _context.ContactPage.FindAsync(id);
            if (contactPage == null)
            {
                return NotFound();
            }
            return View(contactPage);
        }

        // POST: ContactPages/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,HeaderImage,PlaceHeader1,PlaceHeader2,PlaceHeader3,PlaceParagraph1,PlaceParagraph2,PlaceParagraph3,PlaceAddress1,PlaceAddress2,PlaceAddress3,PlacePhone1,PlacePhone2,PlacePhone3,PlaceEmail1,PlaceEmail2,PlaceEmail3")] ContactPage contactPage)
        {
            if (id != contactPage.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(contactPage);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ContactPageExists(contactPage.Id))
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
            return View(contactPage);
        }

        // GET: ContactPages/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var contactPage = await _context.ContactPage
                .FirstOrDefaultAsync(m => m.Id == id);
            if (contactPage == null)
            {
                return NotFound();
            }

            return View(contactPage);
        }

        // POST: ContactPages/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var contactPage = await _context.ContactPage.FindAsync(id);
            _context.ContactPage.Remove(contactPage);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ContactPageExists(int id)
        {
            return _context.ContactPage.Any(e => e.Id == id);
        }
    }
}
