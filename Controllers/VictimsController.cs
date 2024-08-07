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
    public class VictimsController : Controller
    {
        private readonly RACU11Context _context;

        public VictimsController(RACU11Context context)
        {
            _context = context;
        }

        // GET: Victims
        public async Task<IActionResult> Index()
        {
            return View(await _context.Victim.ToListAsync());
        }

        // GET: Victims/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var victim = await _context.Victim
                .FirstOrDefaultAsync(m => m.Id == id);
            if (victim == null)
            {
                return NotFound();
            }

            return View(victim);
        }

        // GET: Victims/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Victims/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,IfReportingPersonIsVictim,IfTwoOrMoreVictims,FamilyName,FirstName,MiddleName,Qualifier,Nickname,CurrentAddress,CurrentVillage,CurrentBarangay,CurrentCity,CurrentProvince,OtherAddress,OtherVillage,OtherBarangay,OtherCity,OtherProvince,HighestEducation,Occupation,WorkAddress,EmailAddress")] Victim victim)
        {
            if (ModelState.IsValid)
            {
                _context.Add(victim);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(victim);
        }

        // GET: Victims/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var victim = await _context.Victim.FindAsync(id);
            if (victim == null)
            {
                return NotFound();
            }
            return View(victim);
        }

        // POST: Victims/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,IfReportingPersonIsVictim,IfTwoOrMoreVictims,FamilyName,FirstName,MiddleName,Qualifier,Nickname,CurrentAddress,CurrentVillage,CurrentBarangay,CurrentCity,CurrentProvince,OtherAddress,OtherVillage,OtherBarangay,OtherCity,OtherProvince,HighestEducation,Occupation,WorkAddress,EmailAddress")] Victim victim)
        {
            if (id != victim.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(victim);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!VictimExists(victim.Id))
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
            return View(victim);
        }

        // GET: Victims/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var victim = await _context.Victim
                .FirstOrDefaultAsync(m => m.Id == id);
            if (victim == null)
            {
                return NotFound();
            }

            return View(victim);
        }

        // POST: Victims/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var victim = await _context.Victim.FindAsync(id);
            _context.Victim.Remove(victim);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool VictimExists(int id)
        {
            return _context.Victim.Any(e => e.Id == id);
        }
    }
}
