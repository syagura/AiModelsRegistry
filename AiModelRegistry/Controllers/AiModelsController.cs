using AiModelRegistry.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace AiModelRegistry.Controllers
{
    public class AiModelsController : Controller
    {
        private readonly AppDbContext _context;

        public AiModelsController(AppDbContext context)
        {
            _context = context;
        }

        // GET: AiModels
        public async Task<IActionResult> Index()
        {
            return View(await _context.AiModels.ToListAsync());
        }

        // GET: AiModels/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null) return NotFound();
            var aiModel = await _context.AiModels.FirstOrDefaultAsync(m => m.Id == id);
            if (aiModel == null) return NotFound();
            return View(aiModel);
        }

        // GET: AiModels/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: AiModels/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,ModelName,Version,Algorithm,Accuracy,Status,Description,CreatedDate")] AiModel aiModel)
        {
            if (ModelState.IsValid)
            {
                _context.Add(aiModel);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(aiModel);
        }

        // GET: AiModels/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null) return NotFound();
            var aiModel = await _context.AiModels.FindAsync(id);
            if (aiModel == null) return NotFound();
            return View(aiModel);
        }

        // POST: AiModels/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,ModelName,Version,Algorithm,Accuracy,Status,Description,CreatedDate")] AiModel aiModel)
        {
            if (id != aiModel.Id) return NotFound();
            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(aiModel);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!_context.AiModels.Any(e => e.Id == aiModel.Id)) return NotFound();
                    else throw;
                }
                return RedirectToAction(nameof(Index));
            }
            return View(aiModel);
        }

        // GET: AiModels/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null) return NotFound();
            var aiModel = await _context.AiModels.FirstOrDefaultAsync(m => m.Id == id);
            if (aiModel == null) return NotFound();
            return View(aiModel);
        }

        // POST: AiModels/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var aiModel = await _context.AiModels.FindAsync(id);
            if (aiModel != null) _context.AiModels.Remove(aiModel);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
    }
}