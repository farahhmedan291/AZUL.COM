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
    public class MealsController : Controller
    {
        private readonly AZULContext _context;
        private readonly IWebHostEnvironment hostEnvironment;
        public MealsController(AZULContext context, IWebHostEnvironment hostEnvironment)
        {
            _context = context;
            this.hostEnvironment = hostEnvironment;
        }

        // GET: Meals
        public async Task<IActionResult> Index()
        {
            var aZULContext = _context.Meal.Include(m => m.Category);
            return View(await aZULContext.ToListAsync());
        }

        public async Task<IActionResult> Menu()
        {
            var aZULContext = _context.Meal.Include(m => m.Category);
            return View(await aZULContext.ToListAsync());
        }

        // GET: Meals/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var meal = await _context.Meal
                .Include(m => m.Category)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (meal == null)
            {
                return NotFound();
            }

            return View(meal);
        }

        // GET: Meals/Create
        public IActionResult Create()
        {
            ViewData["CategoryId"] = new SelectList(_context.Category, "Id", "Name");
            return View();
        }

        // POST: Meals/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Name,Price,ImageName,CategoryId,IngredientId,,ImageFile")] Meal meal)
        {
            if (ModelState.IsValid)
            {
                if (meal.ImageFile != null)
                {
                    string root = hostEnvironment.WebRootPath;
                    string filename = Guid.NewGuid().ToString() + "_" + meal.ImageFile.FileName;
                    string path = Path.Combine(root + "/img/" + filename);
                    using (var fileStream = new FileStream(path, FileMode.Create))
                    {
                        await meal.ImageFile.CopyToAsync(fileStream);
                    }
                    meal.ImageName = filename;
                }
                _context.Add(meal);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["CategoryId"] = new SelectList(_context.Category, "Id", "Name", meal.CategoryId);
            return View(meal);
        }

        // GET: Meals/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var meal = await _context.Meal.FindAsync(id);
            if (meal == null)
            {
                return NotFound();
            }
            ViewData["CategoryId"] = new SelectList(_context.Category, "Id", "Name", meal.CategoryId);
            return View(meal);
        }

        // POST: Meals/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Name,Price,ImageName,CategoryId,IngredientId,,ImageFile")] Meal meal)
        {
            if (id != meal.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    if (meal.ImageFile != null)
                    {
                        string root = hostEnvironment.WebRootPath;
                        string filename = Guid.NewGuid().ToString() + "_" + meal.ImageFile.FileName;
                        string path = Path.Combine(root + "/img/" + filename);
                        using (var fileStream = new FileStream(path, FileMode.Create))
                        {
                            await meal.ImageFile.CopyToAsync(fileStream);
                        }
                        meal.ImageName = filename;
                    }
                    _context.Update(meal);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!MealExists(meal.Id))
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
            ViewData["CategoryId"] = new SelectList(_context.Category, "Id", "Name", meal.CategoryId);
            return View(meal);
        }

        // GET: Meals/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var meal = await _context.Meal
                .Include(m => m.Category)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (meal == null)
            {
                return NotFound();
            }

            return View(meal);
        }

        // POST: Meals/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var meal = await _context.Meal.FindAsync(id);
            _context.Meal.Remove(meal);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool MealExists(int id)
        {
            return _context.Meal.Any(e => e.Id == id);
        }
    }
}
