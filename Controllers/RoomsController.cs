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
    public class RoomsController : Controller
    {
        private readonly AZULContext _context;
        private readonly IWebHostEnvironment hostEnvironment;

        public RoomsController(AZULContext context, IWebHostEnvironment hostEnvironment)
        {
            _context = context;
            this.hostEnvironment = hostEnvironment;
        }

        // GET: Rooms
        public async Task<IActionResult> Index()
        {
            var aZULContext = _context.Room.Include(r => r.RoomType);
            return View(await aZULContext.ToListAsync());
        }
        public IActionResult AddRoom()
        {
            AZULContext hotel = new AZULContext();


            var list = _context.Room.Include(r => r.RoomType).ToList();
            return View(list);
        }

        // GET: Rooms/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var room = await _context.Room
                .Include(r => r.RoomType)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (room == null)
            {
                return NotFound();
            }

            return View(room);
        }

        // GET: Rooms/Create
        public IActionResult Create()
        {
            ViewData["RoomTypeId"] = new SelectList(_context.RoomType, "Id", "Type");
            return View();
        }

        // POST: Rooms/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,State,FloorNumber,Price,SpecialDetails,RoomTypeId,ImageName,ImageFile")] Room room)
        {
            if (ModelState.IsValid)
            {
                if (room.ImageFile != null)
                {
                    string root = hostEnvironment.WebRootPath;
                    string filename = Guid.NewGuid().ToString() + "_" + room.ImageFile.FileName;
                    string path = Path.Combine(root + "/img/" + filename);
                    using (var fileStream = new FileStream(path, FileMode.Create))
                    {
                        await room.ImageFile.CopyToAsync(fileStream);
                    }
                    room.ImageName = filename;
                }
                _context.Add(room);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(AddRoom));
            }
            ViewData["RoomTypeId"] = new SelectList(_context.RoomType, "Id", "Type", room.RoomTypeId);
            return View(room);
        }

        public async Task<IActionResult> Book()
        {
           
            AZULContext rest = new AZULContext();
            var aZULContext = _context.Room.Include(r => r.RoomType).Where(x => x.State == "a");
            return View(await aZULContext.ToListAsync());

            
        }

        // GET: Rooms/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var room = await _context.Room.FindAsync(id);
            if (room == null)
            {
                return NotFound();
            }
            ViewData["RoomTypeId"] = new SelectList(_context.RoomType, "Id", "Type", room.RoomTypeId);
            return View(room);
        }

        // POST: Rooms/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,State,FloorNumber,Price,SpecialDetails,RoomTypeId,ImageName,ImageFile")] Room room)
        {
            if (id != room.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    if (room.ImageFile != null)
                    {
                        string root = hostEnvironment.WebRootPath;
                        string filename = Guid.NewGuid().ToString() + "_" + room.ImageFile.FileName;
                        string path = Path.Combine(root + "/img/" + filename);
                        using (var fileStream = new FileStream(path, FileMode.Create))
                        {
                            await room.ImageFile.CopyToAsync(fileStream);
                        }
                        room.ImageName = filename;
                    }
                    _context.Update(room);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!RoomExists(room.Id))
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
            ViewData["RoomTypeId"] = new SelectList(_context.RoomType, "Id", "Type", room.RoomTypeId);
            return View(room);
        }

        // GET: Rooms/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var room = await _context.Room
                .Include(r => r.RoomType)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (room == null)
            {
                return NotFound();
            }

            return View(room);
        }

        // POST: Rooms/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var room = await _context.Room.FindAsync(id);
            _context.Room.Remove(room);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool RoomExists(int id)
        {
            return _context.Room.Any(e => e.Id == id);
        }
    }
}
