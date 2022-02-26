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
    public class SuspectsController : Controller
    {
        private readonly RACU11Context _context;

        public SuspectsController(RACU11Context context)
        {
            _context = context;
        }

        // GET: Suspects
        public async Task<IActionResult> Index()
        {
            return View(await _context.Suspect.ToListAsync());
        }

        // GET: Suspects/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var suspect = await _context.Suspect
                .FirstOrDefaultAsync(m => m.Id == id);
            if (suspect == null)
            {
                return NotFound();
            }

            return View(suspect);
        }

        // GET: Suspects/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Suspects/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,FamilyName,FirstName,MiddleName,Qualifier,Nickname,Nationality,Sex,CivilStatus,DOB,Age,HomePhone,MobilePhone,CurrentAddress,CurrentVillage,CurrentBarangay,CurrentCity,CurrentProvince,OtherAddress,OtherVillage,OtherBarangay,OtherCity,OtherProvince,HighestEducation,Occupation,WorkAddress,RelationToVictim,EmailAddress,AfpPersonnelRank,UnitAssignment,GroupAffiliation,WasWithPreviousCase,StatusOfPreviousCase,Height,Weight,ColorOfEyes,DescriptionOfEyes,ColorOfHair,DescriptionOfHair,UnderInfluenceOfDrugs,UnderInfluenceOfLiquors,UnderInfluenceOfOthers")] Suspect suspect)
        {
            if (ModelState.IsValid)
            {
                _context.Add(suspect);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(suspect);
        }

        // GET: Suspects/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var suspect = await _context.Suspect.FindAsync(id);
            if (suspect == null)
            {
                return NotFound();
            }
            return View(suspect);
        }

        // POST: Suspects/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,FamilyName,FirstName,MiddleName,Qualifier,Nickname,Nationality,Sex,CivilStatus,DOB,Age,HomePhone,MobilePhone,CurrentAddress,CurrentVillage,CurrentBarangay,CurrentCity,CurrentProvince,OtherAddress,OtherVillage,OtherBarangay,OtherCity,OtherProvince,HighestEducation,Occupation,WorkAddress,RelationToVictim,EmailAddress,AfpPersonnelRank,UnitAssignment,GroupAffiliation,WasWithPreviousCase,StatusOfPreviousCase,Height,Weight,ColorOfEyes,DescriptionOfEyes,ColorOfHair,DescriptionOfHair,UnderInfluenceOfDrugs,UnderInfluenceOfLiquors,UnderInfluenceOfOthers")] Suspect suspect)
        {
            if (id != suspect.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(suspect);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!SuspectExists(suspect.Id))
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
            return View(suspect);
        }

        // GET: Suspects/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var suspect = await _context.Suspect
                .FirstOrDefaultAsync(m => m.Id == id);
            if (suspect == null)
            {
                return NotFound();
            }

            return View(suspect);
        }

        // POST: Suspects/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var suspect = await _context.Suspect.FindAsync(id);
            _context.Suspect.Remove(suspect);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool SuspectExists(int id)
        {
            return _context.Suspect.Any(e => e.Id == id);
        }
    }
}
