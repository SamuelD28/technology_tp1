using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using technology_tp1.Models;
using System.Drawing;
using System.Drawing.Imaging;
using static technology_tp1.Models.ItemImage;

namespace technology_tp1.Controllers
{
    public class ImagesController : Controller
    {
        private readonly AppDbContext _context;

        public ImagesController(AppDbContext context)
        {
            _context = context;
        }

        // GET: Images
        public async Task<IActionResult> Index()
        {
            return View(await _context.ItemImages.ToListAsync());
        }

        // GET: Images/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var image = await _context
                .ItemImages
                .FirstOrDefaultAsync(m => m.Id == id);
            if (image == null)
            {
                return NotFound();
            }

            return View(image);
        }

        // GET: Images/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Images/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Name")] ItemImage itemImage, IFormFile file)
        {
            // Limit maximum file size to 1mb.
            if(file.Length > MAXIMUM_FILE_SIZE)
            {
                ModelState.AddModelError(
                    "Full", 
                    $"File exceed the maximum allowed of {MAXIMUM_FILE_SIZE} bytes"
                );
                return View();
            }

            try
            {
                itemImage.FullBlob = ParseImage(file);
                itemImage.MediumBlob = ScaleImage(itemImage.FullBlob, 500, 500);
                itemImage.SmallBlob = ScaleImage(itemImage.FullBlob, 250, 250);

                _context.Add(itemImage);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            catch (IOException)
            {
                return View(new ErrorViewModel() { RequestId = "Upload image file" });
            }
        }


        // GET: Images/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var image = await _context.ItemImages.FindAsync(id);
            if (image == null)
            {
                return NotFound();
            }
            return View(image);
        }

        // POST: Images/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id, Name")] ItemImage imageData)
        {
            if (id != imageData.Id || !ImageExists(imageData.Id))
            {
                return NotFound();
            }

            try
            {
                ItemImage updatedImage = _context
                    .ItemImages
                    .Where(img => img.Id == imageData.Id)
                    .First();
                updatedImage.Name = imageData.Name;

                _context.Update(updatedImage);
                await _context.SaveChangesAsync();

                return RedirectToAction(nameof(Index));
            }
            catch (Exception)
            {
                return Redirect("/");
            }
        }

        // GET: Images/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var image = await _context.ItemImages
                .FirstOrDefaultAsync(m => m.Id == id);
            if (image == null)
            {
                return NotFound();
            }

            return View(image);
        }

        // POST: Images/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var image = await _context.ItemImages.FindAsync(id);
            _context.ItemImages.Remove(image);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ImageExists(int id)
        {
            return _context.ItemImages.Any(e => e.Id == id);
        }
    }
}
