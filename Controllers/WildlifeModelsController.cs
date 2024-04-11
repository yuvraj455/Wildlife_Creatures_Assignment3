using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using WildlifeCreatures_Assignment3.Data;
using WildlifeCreatures_Assignment3.Models;

namespace WildlifeCreatures_Assignment3.Controllers
{
    public class WildlifeModelsController : Controller
    {
        private readonly WildlifeCreatures_Assignment3Context _context;

        // Constructor to initialize the controller with the database context
        public WildlifeModelsController(WildlifeCreatures_Assignment3Context context)
        {
            _context = context;
        }

        // GET: WildlifeModels/Index
        // Displays a list of wildlife creatures
        public async Task<IActionResult> Index()
        {
            return View(await _context.WildlifeModel.ToListAsync());
        }

        // GET: WildlifeModels/Details/{id}
        // Displays details of a specific wildlife creature
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var wildlifeModel = await _context.WildlifeModel
                .FirstOrDefaultAsync(m => m.Id == id);
            if (wildlifeModel == null)
            {
                return NotFound();
            }

            return View(wildlifeModel);
        }

        // GET: WildlifeModels/Create
        // Displays the form to create a new wildlife creature
        public IActionResult Create()
        {
            return View();
        }

        public IActionResult AboutUs()
        {
            return View();
        }

        // POST: WildlifeModels/Create
        // Creates a new wildlife creature
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id")] WildlifeModel wildlifeModel)
        {
            if (ModelState.IsValid)
            {
                _context.Add(wildlifeModel);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(wildlifeModel);
        }

        // GET: WildlifeModels/Edit/{id}
        // Displays the form to edit a specific wildlife creature
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var wildlifeModel = await _context.WildlifeModel.FindAsync(id);
            if (wildlifeModel == null)
            {
                return NotFound();
            }
            return View(wildlifeModel);
        }

        // POST: WildlifeModels/Edit/{id}
        // Edits a specific wildlife creature
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id")] WildlifeModel wildlifeModel)
        {
            if (id != wildlifeModel.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(wildlifeModel);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!WildlifeModelExists(wildlifeModel.Id))
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
            return View(wildlifeModel);
        }

        // GET: WildlifeModels/Delete/{id}
        // Displays the confirmation page to delete a specific wildlife creature
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var wildlifeModel = await _context.WildlifeModel
                .FirstOrDefaultAsync(m => m.Id == id);
            if (wildlifeModel == null)
            {
                return NotFound();
            }

            return View(wildlifeModel);
        }

        // POST: WildlifeModels/DeleteConfirmed/{id}
        // Deletes a specific wildlife creature
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var wildlifeModel = await _context.WildlifeModel.FindAsync(id);
            if (wildlifeModel != null)
            {
                _context.WildlifeModel.Remove(wildlifeModel);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        // Checks if a wildlife creature with the given id exists
        private bool WildlifeModelExists(int id)
        {
            return _context.WildlifeModel.Any(e => e.Id == id);
        }
    }
}
