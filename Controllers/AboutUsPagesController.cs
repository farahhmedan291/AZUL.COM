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
    public class AboutUsPagesController : Controller
    {
        private readonly AZULContext _context;

        public AboutUsPagesController(AZULContext context)
        {
            _context = context;
        }

        // GET: AboutUsPages
        public async Task<IActionResult> Index()
        {
            return View(await _context.AboutUsPage.ToListAsync());
        }

        // GET: AboutUsPages/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var aboutUsPage = await _context.AboutUsPage
                .FirstOrDefaultAsync(m => m.Id == id);
            if (aboutUsPage == null)
            {
                return NotFound();
            }

            return View(aboutUsPage);
        }

        // GET: AboutUsPages/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: AboutUsPages/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,HeaderImage,DescImage,DescHeader,DescParagraph,DescImage2,DescHeader2,DescParagraph2,FeaturesImage1,FeaturesImage2,FeaturesImage3,FeaturesHeader,FeaturesImagePoint1,FeaturesImagePoint2,FeaturesImagePoint3,FeaturesImagePoint4,FeaturesImagePoint5,FeaturesImagePoint6,FeaturesImagePoint7,FeaturesImagePoint8,FeaturesImagePoint9,RateHeader,RateParagraph1,RateParagraph2,RateName1,RateName2,RateImage1,RateImage2")] AboutUsPage aboutUsPage)
        {
            if (ModelState.IsValid)
            {
                _context.Add(aboutUsPage);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(aboutUsPage);
        }

        // GET: AboutUsPages/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var aboutUsPage = await _context.AboutUsPage.FindAsync(id);
            if (aboutUsPage == null)
            {
                return NotFound();
            }
            return View(aboutUsPage);
        }

        // POST: AboutUsPages/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,HeaderImage,DescImage,DescHeader,DescParagraph,DescImage2,DescHeader2,DescParagraph2,FeaturesImage1,FeaturesImage2,FeaturesImage3,FeaturesHeader,FeaturesImagePoint1,FeaturesImagePoint2,FeaturesImagePoint3,FeaturesImagePoint4,FeaturesImagePoint5,FeaturesImagePoint6,FeaturesImagePoint7,FeaturesImagePoint8,FeaturesImagePoint9,RateHeader,RateParagraph1,RateParagraph2,RateName1,RateName2,RateImage1,RateImage2")] AboutUsPage aboutUsPage)
        {
            if (id != aboutUsPage.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(aboutUsPage);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!AboutUsPageExists(aboutUsPage.Id))
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
            return View(aboutUsPage);
        }

        // GET: AboutUsPages/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var aboutUsPage = await _context.AboutUsPage
                .FirstOrDefaultAsync(m => m.Id == id);
            if (aboutUsPage == null)
            {
                return NotFound();
            }

            return View(aboutUsPage);
        }

        // POST: AboutUsPages/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var aboutUsPage = await _context.AboutUsPage.FindAsync(id);
            _context.AboutUsPage.Remove(aboutUsPage);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool AboutUsPageExists(int id)
        {
            return _context.AboutUsPage.Any(e => e.Id == id);
        }
    }
}
