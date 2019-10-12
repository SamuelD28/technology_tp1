using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using technology_tp1.Extension;
using technology_tp1.Models;
using Microsoft.Extensions.Localization;
using Microsoft.AspNetCore.Http;
using technology_tp1.Services;

namespace technology_tp1.Controllers
{
    public class OrdersController : Controller
    {
        private readonly ICartService _cart;
        private readonly AppDbContext _context;
        private readonly HttpContext _httpContext;

        public OrdersController(AppDbContext context, IHttpContextAccessor httpContextAccessor, ICartService cart)
        {
            _cart = cart;
            _context = context;
            _httpContext = httpContextAccessor.HttpContext;
        }

        // GET: Commandes
        public async Task<IActionResult> Index()
        {
            return View(await _context.Orders.ToListAsync());
        }

        // GET: Commandes
        public IActionResult OrderForm()
        {
            return PartialView();
        }

        // GET: Commandes/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var commande = await _context.Orders
                .Include(c => c.OrdersItems)
                .FirstOrDefaultAsync(c => c.Id == id);
            if (commande == null)
            {
                return NotFound();
            }

            return View(commande);
        }

        // GET: Commandes/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Commandes/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Order order)
        {
            order.CreatedAt = DateTime.Now;
            order.OrdersItems = _cart.Items.Select(i => new OrdersItems() { MenuItem = i.MenuItem, Quantity = i.Quantity, Order = order }).ToArray();
            if (ModelState.IsValid)
            {
                _context.Add(order);
                await _context.SaveChangesAsync();
                _cart.Clear();
                _cart.Save();
                return RedirectToAction(nameof(Index));
            }
            return View(order);
        }

        // GET: Commandes/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var commande = await _context.Orders.FindAsync(id);
            if (commande == null)
            {
                return NotFound();
            }
            return View(commande);
        }

        // POST: Commandes/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("")] Order commande)
        {
            if (id != commande.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(commande);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!MenuItemExists(commande.Id))
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
            return View(commande);
        }

        // GET: Commandes/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var commande = await _context.Orders
                .Include(c => c.OrdersItems)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (commande == null)
            {
                return NotFound();
            }

            return View(commande);
        }

        // POST: Commandes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var commande = await _context.Orders.FindAsync(id);
            _context.Orders.Remove(commande);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool MenuItemExists(int id)
        {
            return _context.Orders.Any(e => e.Id == id);
        }
    }
}
