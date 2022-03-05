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
    public class HomePagesController : Controller
    {
        private readonly AZULContext _context;

        public HomePagesController(AZULContext context)
        {
            _context = context;
        }

        // GET: HomePages
        public async Task<IActionResult> Index()
        {
            
            return View(await _context.HomePage.ToListAsync());
        }

        // GET: HomePages/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var homePage = await _context.HomePage
                .FirstOrDefaultAsync(m => m.Id == id);
            if (homePage == null)
            {
                return NotFound();
            }

            return View(homePage);
        }

        // GET: HomePages/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: HomePages/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,SlideImage1,SlideImage2,SlideImage3,SlideHeader1,SlideHeader2,SlideHeader3,SlideParagraph1,SlideParagraph2,SlideParagraph3,DescImage1,DescImage2,DescImage3,DescHeader,DescParagraph,DescPoint1,DescPoint2,PoolImage,PoolHeader,PoolParagraph,RoomHeader,RoomParagraph,RoomImage1,RoomImage2,RoomImage3,RoomPrice1,RoomPrice2,RoomPrice3,RoomImageHeader1,RoomImageHeader2,RoomImageHeader3,RoomImageParagraph1,RoomImageParagraph2,RoomImageParagraph3,ContactHeader,ContactParagraph,ContactAddress,ContactPhone,ContactEmail")] HomePage homePage)
        {
            if (ModelState.IsValid)
            {
                _context.Add(homePage);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(homePage);
        }

        // GET: HomePages/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var homePage = await _context.HomePage.FindAsync(id);
            if (homePage == null)
            {
                return NotFound();
            }
            return View(homePage);
        }

        // POST: HomePages/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,SlideImage1,SlideImage2,SlideImage3,SlideHeader1,SlideHeader2,SlideHeader3,SlideParagraph1,SlideParagraph2,SlideParagraph3,DescImage1,DescImage2,DescImage3,DescHeader,DescParagraph,DescPoint1,DescPoint2,PoolImage,PoolHeader,PoolParagraph,RoomHeader,RoomParagraph,RoomImage1,RoomImage2,RoomImage3,RoomPrice1,RoomPrice2,RoomPrice3,RoomImageHeader1,RoomImageHeader2,RoomImageHeader3,RoomImageParagraph1,RoomImageParagraph2,RoomImageParagraph3,ContactHeader,ContactParagraph,ContactAddress,ContactPhone,ContactEmail")] HomePage homePage)
        {
            if (id != homePage.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(homePage);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!HomePageExists(homePage.Id))
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
            return View(homePage);
        }

        // GET: HomePages/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var homePage = await _context.HomePage
                .FirstOrDefaultAsync(m => m.Id == id);
            if (homePage == null)
            {
                return NotFound();
            }

            return View(homePage);
        }

        // POST: HomePages/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var homePage = await _context.HomePage.FindAsync(id);
            _context.HomePage.Remove(homePage);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool HomePageExists(int id)
        {
            return _context.HomePage.Any(e => e.Id == id);
        }
    }
}
