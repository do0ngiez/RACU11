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
    public class ReportingPersonsController : Controller
    {
        private readonly RACU11Context _context;

        public ReportingPersonsController(RACU11Context context)
        {
            _context = context;
        }

        // GET: ReportingPersons
        public async Task<IActionResult> Index()
        {
            return View(await _context.ReportingPeople.ToListAsync());
        }

        // GET: ReportingPersons/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var reportingPerson = await _context.ReportingPeople
                .FirstOrDefaultAsync(m => m.Id == id);
            if (reportingPerson == null)
            {
                return NotFound();
            }

            return View(reportingPerson);
        }

        // GET: ReportingPersons/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: ReportingPersons/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,FamilyName,FirstName,MiddleName,Qualifier,Nickname,Nationality,Sex,CivilStatus,DOB,Age,POB,HomePhone,MobilePhone,CurrentAddress,CurrentVillage,CurrentBarangay,CurrentCity,CurrentProvince,OtherAddress,OtherVillage,OtherBarangay,OtherCity,OtherProvince,HighestEducational,Occupation,IDCard,EmailAddress")] ReportingPerson reportingPerson)
        {
            if (ModelState.IsValid)
            {
                _context.Add(reportingPerson);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(reportingPerson);
        }

        // GET: ReportingPersons/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var reportingPerson = await _context.ReportingPeople.FindAsync(id);
            if (reportingPerson == null)
            {
                return NotFound();
            }
            return View(reportingPerson);
        }

        // POST: ReportingPersons/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,FamilyName,FirstName,MiddleName,Qualifier,Nickname,Nationality,Sex,CivilStatus,DOB,Age,POB,HomePhone,MobilePhone,CurrentAddress,CurrentVillage,CurrentBarangay,CurrentCity,CurrentProvince,OtherAddress,OtherVillage,OtherBarangay,OtherCity,OtherProvince,HighestEducational,Occupation,IDCard,EmailAddress")] ReportingPerson reportingPerson)
        {
            if (id != reportingPerson.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(reportingPerson);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ReportingPersonExists(reportingPerson.Id))
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
            return View(reportingPerson);
        }

        // GET: ReportingPersons/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var reportingPerson = await _context.ReportingPeople
                .FirstOrDefaultAsync(m => m.Id == id);
            if (reportingPerson == null)
            {
                return NotFound();
            }

            return View(reportingPerson);
        }

        // POST: ReportingPersons/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var reportingPerson = await _context.ReportingPeople.FindAsync(id);
            _context.ReportingPeople.Remove(reportingPerson);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ReportingPersonExists(int id)
        {
            return _context.ReportingPeople.Any(e => e.Id == id);
        }
    }
}
