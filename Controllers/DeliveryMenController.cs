using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using technology_tp1.Models;

namespace technology_tp1.Controllers
{
    public class DeliveryMenController : Controller
    {
        private readonly AppDbContext _context;

        public DeliveryMenController(AppDbContext context)
        {
            _context = context;
        }

        // GET: DeliveryMen
        public async Task<IActionResult> Index()
        {
            return View(await _context.DeliveryMen.ToListAsync());
        }

        // GET: DeliveryMen/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var deliveryMan = await _context.DeliveryMen
                .FirstOrDefaultAsync(m => m.Id == id);
            if (deliveryMan == null)
            {
                return NotFound();
            }

            return View(deliveryMan);
        }

        // GET: DeliveryMen/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: DeliveryMen/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Name,Phone,IsEmployed")] DeliveryMan deliveryMan)
        {
            if (ModelState.IsValid)
            {
                _context.Add(deliveryMan);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(deliveryMan);
        }

        // GET: DeliveryMen/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var deliveryMan = await _context.DeliveryMen.FindAsync(id);
            if (deliveryMan == null)
            {
                return NotFound();
            }
            return View(deliveryMan);
        }

        // POST: DeliveryMen/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Name,Phone,IsEmployed,IsDeactivated")] DeliveryMan deliveryMan)
        {
            if (id != deliveryMan.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(deliveryMan);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!DeliveryManExists(deliveryMan.Id))
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
            return View(deliveryMan);
        }

        // GET: DeliveryMen/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var deliveryMan = await _context.DeliveryMen
                .FirstOrDefaultAsync(m => m.Id == id);
            if (deliveryMan == null)
            {
                return NotFound();
            }

            return View(deliveryMan);
        }

        // POST: DeliveryMen/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var deliveryMan = await _context.DeliveryMen.FindAsync(id);
            _context.DeliveryMen.Remove(deliveryMan);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool DeliveryManExists(int id)
        {
            return _context.DeliveryMen.Any(e => e.Id == id);
        }
    }
}
