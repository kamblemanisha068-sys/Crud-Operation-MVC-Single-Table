using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client;
using ScholarshipFormPortal.Models;
using System.Reflection.Metadata.Ecma335;

namespace ScholarshipFormPortal.Controllers
{
    public class ScholarshipFormController : Controller
    {
        private readonly ScholarshipFormDBContext _Db;

        public ScholarshipFormController(ScholarshipFormDBContext context)
        {
            this._Db = context;
        }





        public async Task <IActionResult> Index()
        {
            var scholarshipform = await _Db.ScholarshipForms.ToListAsync();
            return View(scholarshipform);
        }
        [HttpGet]
        public async Task<IActionResult> Create()
        {
            ViewData["Title"] = "Create New Applicant";
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Create(ScholarshipForm obj)
        {
            if (ModelState.IsValid)
            {
                _Db.Add(obj);
                await _Db.SaveChangesAsync();
                TempData["SuccessMessage"] = "Applicant Added Succcessfully";
                return RedirectToAction("Index");
            }
            return View(obj);
        }
        [HttpGet]

        public async Task<IActionResult> Edit(int id)
        {
            var scholarshipform = await _Db.ScholarshipForms.FindAsync(id);
            ViewBag.FormStatus = "Editing Student details";
            if (scholarshipform == null)
            {
                return NotFound();
            }
            return View(scholarshipform);
        }
        [HttpPost]
        public async Task<IActionResult> Edit(int id, ScholarshipForm obj)
        {
            if (id != obj.Applicant_ID)
            {
                return NotFound();
            }
            if (ModelState.IsValid)
            {
                _Db.Update(obj);
                await _Db.SaveChangesAsync();
                TempData["SuccessMessage"] = "Applicant Updated Successfully";
                return RedirectToAction("Index");
            }
            return View(obj);

            
        }
        public async Task<IActionResult> Details(int id)
        {
            var scholarshipform = await _Db.ScholarshipForms.FindAsync(id);
            ViewBag.FormStatus = "Viewing details";

            if (scholarshipform == null)
            {
                return NotFound();
            }
            return View(scholarshipform);
        }
        public async Task<IActionResult> Delete(int id)
        {
            var scholarshipform = await _Db.ScholarshipForms.FindAsync(id);
            if (scholarshipform != null)
            {
                _Db.ScholarshipForms.Remove(scholarshipform);
                await _Db.SaveChangesAsync();
                TempData["SuccessMessage"] = "Applicant Deleted Successfully";

            }

            else
            {
                TempData["ErrorMessage"] = "Applicant Not Found";
            }


                return RedirectToAction("Index");
        }
    }
}
