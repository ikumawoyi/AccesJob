using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using AccessJob.Data;
using AccessJob.Models;

namespace AccessJob.Controllers
{
    public class AppliesController : Controller
    {
        private readonly ApplicationDbContext _context;

        public AppliesController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Applies
        public async Task<IActionResult> Index()
        {
            return View(await _context.Apply.ToListAsync());
        }

        // GET: Applies/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var apply = await _context.Apply
                .FirstOrDefaultAsync(m => m.Id == id);
            if (apply == null)
            {
                return NotFound();
            }

            return View(apply);
        }

        // GET: Applies/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Applies/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Title,FirstName,LastName,ContactAddress,Email,PositionApplyingFor,CanYouWorkInTheUK,MobileNumber,PostalCode,YearsOfExperience,PIN,PINExpiryDate,NIN,DateOfBirth,NextOfKinNames,NextOfKinRelationship,NextOfKinAddress,NextOfKinPhoneNumber,FirstEmploymentCompanyName,FirstEmploymentCompanyAddress,FirstEmploymentPosition,FirstEmploymentResponsibilities,FirstEmploymentReasonForLeaving,FirstEmploymentDateFrom,FirstEmploymentDateTo,SecondEmploymentCompanyName,SecondEmploymentCompanyAddress,SecondEmploymentPosition,SecondEmploymentResponsibilities,SecondEmploymentReasonForLeaving,SecondEmploymentDateFrom,SecondEmploymentDateTo,ThirdEmploymentCompanyName,ThirdEmploymentCompanyAddress,ThirdEmploymentPosition,ThirdEmploymentResponsibilities,ThirdEmploymentReasonForLeaving,ThirdEmploymentDateFrom,ThirdEmploymentDateTo,FirstQualification,FirstAwardingInstitution,FirstDateAwarded,SecondQualification,SecondAwardingInstitution,SecondDateAwarded,ThirdQualification,ThirdAwardingInstitution,ThirdDateAwarded,ImmunizationName,DateAdministered,Convicted,TypeOfCrime,Disabled,TypeOfDisability,RegisteredWithOtherAgents,NameOfAgent,FirstRefereeNames,SecondRefereeNames,HowDidYouKnowAboutUs")] Apply apply)
        {
            if (ModelState.IsValid)
            {
				_context.Add(apply);
                await _context.SaveChangesAsync();
                return RedirectToAction("Index", "DocumentUpload");
            }
            return View(apply);
        }

        // GET: Applies/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var apply = await _context.Apply.FindAsync(id);
            if (apply == null)
            {
                return NotFound();
            }
            return View(apply);
        }

        // POST: Applies/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Title,FirstName,LastName,ContactAddress,Email,PositionApplyingFor,CanYouWorkInTheUK,MobileNumber,PostalCode,YearsOfExperience,PIN,PINExpiryDate,NIN,DateOfBirth,NextOfKinNames,NextOfKinRelationship,NextOfKinAddress,NextOfKinPhoneNumber,FirstEmploymentCompanyName,FirstEmploymentCompanyAddress,FirstEmploymentPosition,FirstEmploymentResponsibilities,FirstEmploymentReasonForLeaving,FirstEmploymentDateFrom,FirstEmploymentDateTo,SecondEmploymentCompanyName,SecondEmploymentCompanyAddress,SecondEmploymentPosition,SecondEmploymentResponsibilities,SecondEmploymentReasonForLeaving,SecondEmploymentDateFrom,SecondEmploymentDateTo,ThirdEmploymentCompanyName,ThirdEmploymentCompanyAddress,ThirdEmploymentPosition,ThirdEmploymentResponsibilities,ThirdEmploymentReasonForLeaving,ThirdEmploymentDateFrom,ThirdEmploymentDateTo,FirstQualification,FirstAwardingInstitution,FirstDateAwarded,SecondQualification,SecondAwardingInstitution,SecondDateAwarded,ThirdQualification,ThirdAwardingInstitution,ThirdDateAwarded,ImmunizationName,DateAdministered,Convicted,TypeOfCrime,Disabled,TypeOfDisability,RegisteredWithOtherAgents,NameOfAgent,FirstRefereeNames,SecondRefereeNames,HowDidYouKnowAboutUs")] Apply apply)
        {
            if (id != apply.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(apply);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ApplyExists(apply.Id))
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
            return View(apply);
        }

        // GET: Applies/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var apply = await _context.Apply
                .FirstOrDefaultAsync(m => m.Id == id);
            if (apply == null)
            {
                return NotFound();
            }

            return View(apply);
        }

        // POST: Applies/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var apply = await _context.Apply.FindAsync(id);
            _context.Apply.Remove(apply);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ApplyExists(int id)
        {
            return _context.Apply.Any(e => e.Id == id);
        }
    }
}
