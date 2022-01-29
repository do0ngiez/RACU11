using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using RACU11.Models;

namespace RACU11.Controllers
{
    public class IRFController : Controller
    {
        private readonly RACU11Context _context;

        public IRFController(RACU11Context context)
        {
            _context = context;
        }

        // GET: IRF
        public async Task<IActionResult> Index()
        {
            return View(await _context.IRF.ToListAsync());
        }

        // GET: IRF/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var iRF = await _context.IRF
                .FirstOrDefaultAsync(m => m.Id == id);
            if (iRF == null)
            {
                return NotFound();
            }

            return View(iRF);
        }

        // GET: IRF/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: IRF/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,BlotterEntryNumber,TypeOfIncident,ReportingTimeAndDateOfReport,ReportingTimeAndDateOfIncident,IsThereSuspect,IsThereMoreThanOneSuspect")] IRF iRF)
        {
            if (ModelState.IsValid)
            {
                _context.Add(iRF);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(iRF);
        }

        // GET: IRF/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var iRF = await _context.IRF.FindAsync(id);
            if (iRF == null)
            {
                return NotFound();
            }
            return View(iRF);
        }

        // POST: IRF/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,BlotterEntryNumber,TypeOfIncident,ReportingTimeAndDateOfReport,ReportingTimeAndDateOfIncident,IsThereSuspect,IsThereMoreThanOneSuspect")] IRF iRF)
        {
            if (id != iRF.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(iRF);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!IRFExists(iRF.Id))
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
            return View(iRF);
        }

        // GET: IRF/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var iRF = await _context.IRF
                .FirstOrDefaultAsync(m => m.Id == id);
            if (iRF == null)
            {
                return NotFound();
            }

            return View(iRF);
        }

        // POST: IRF/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var iRF = await _context.IRF.FindAsync(id);
            _context.IRF.Remove(iRF);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool IRFExists(int id)
        {
            return _context.IRF.Any(e => e.Id == id);
        }
    }
}
