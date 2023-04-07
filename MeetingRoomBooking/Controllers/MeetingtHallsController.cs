using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using MeetingRoomBooking.Models;

namespace MeetingRoomBooking.Controllers
{
    public class MeetingtHallsController : Controller
    {
        private readonly HallBookingContext _context;

        public MeetingtHallsController(HallBookingContext context)
        {
            _context = context;
        }

        // GET: MeetingtHalls
        public async Task<IActionResult> Index()
        {
              return _context.MeetingtHalls != null ? 
                          View(await _context.MeetingtHalls.ToListAsync()) :
                          Problem("Entity set 'HallBookingContext.MeetingtHall'  is null.");
        }

        // GET: MeetingtHalls/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.MeetingtHalls == null)
            {
                return NotFound();
            }

            var meetingtHall = await _context.MeetingtHalls
                .FirstOrDefaultAsync(m => m.RowId == id);
            if (meetingtHall == null)
            {
                return NotFound();
            }

            return View(meetingtHall);
        }

        // GET: MeetingtHalls/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: MeetingtHalls/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("RowId,HallName,IsActive")] MeetingtHall meetingtHall)
        {
            if (ModelState.IsValid)
            {
                _context.Add(meetingtHall);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(meetingtHall);
        }

        // GET: MeetingtHalls/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.MeetingtHalls == null)
            {
                return NotFound();
            }

            var meetingtHall = await _context.MeetingtHalls.FindAsync(id);
            if (meetingtHall == null)
            {
                return NotFound();
            }
            return View(meetingtHall);
        }

        // POST: MeetingtHalls/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("RowId,HallName,IsActive")] MeetingtHall meetingtHall)
        {
            if (id != meetingtHall.RowId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(meetingtHall);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!MeetingtHallExists(meetingtHall.RowId))
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
            return View(meetingtHall);
        }

        // GET: MeetingtHalls/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.MeetingtHalls == null)
            {
                return NotFound();
            }

            var meetingtHall = await _context.MeetingtHalls
                .FirstOrDefaultAsync(m => m.RowId == id);
            if (meetingtHall == null)
            {
                return NotFound();
            }

            return View(meetingtHall);
        }

        // POST: MeetingtHalls/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.MeetingtHalls == null)
            {
                return Problem("Entity set 'HallBookingContext.MeetingtHalls'  is null.");
            }
            var meetingtHall = await _context.MeetingtHalls.FindAsync(id);
            if (meetingtHall != null)
            {
                _context.MeetingtHalls.Remove(meetingtHall);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool MeetingtHallExists(int id)
        {
          return (_context.MeetingtHalls?.Any(e => e.RowId == id)).GetValueOrDefault();
        }
    }
}
