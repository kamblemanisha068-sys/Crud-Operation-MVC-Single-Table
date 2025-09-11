using AddmissionForm.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace AddmissionForm.Controllers
{
    public class AdmissionFormController : Controller
    {
        private readonly AdmissionFormDBContext _Db;

        public AdmissionFormController(AdmissionFormDBContext context)
        {
            this._Db = context;
        }
        public async Task <IActionResult> Index()
        {
            var admissionform = await _Db.AdmissionForms.ToListAsync();
            return View(admissionform);
        }
        [HttpGet]
        public async Task<IActionResult> Create()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Create(AdmissionForm obj )
        {
            if (ModelState.IsValid)
            {
                _Db.Add(obj);
                await _Db.SaveChangesAsync();
                TempData["SuccessMessage"] = "Form Submitted Successfully";
                return RedirectToAction("Index");
            }
            return View(obj);
        }
        [HttpGet]
        public async Task<IActionResult> Edit(int id)
        {
            var admissionform = await _Db.AdmissionForms.FindAsync(id);
            if (admissionform == null)
            {
                return NotFound();
            }
            return View(admissionform);
        }
        [HttpPost]
        public async Task<IActionResult> Edit(int id, AdmissionForm obj)
        {
            if (id != obj.ID)
            {
                return NotFound();
            }
            if (ModelState.IsValid)
            {
                _Db.Update(obj);
                await _Db.SaveChangesAsync();
                TempData["SuccessMessage"] = "Form Updated Successfully";
                return RedirectToAction("Index");
            }
            return View(obj);
        }
        public async Task<IActionResult> Details(int id)
        {
            var admissionform = await _Db.AdmissionForms.FindAsync(id);
            
                if (admissionform == null)
                {
                   return NotFound();
                }
            
            return View(admissionform);
        }
        public async Task<IActionResult> Delete(int id)
        {
            var admissionform = await _Db.AdmissionForms.FindAsync(id);
            if (admissionform != null)
            {
                _Db.AdmissionForms.Remove(admissionform);
                await _Db.SaveChangesAsync();
                TempData["SuccessMessage"] = "Form Deleted Successfully";
            }
            else
            {
                TempData["ErrorMessage"] = "Form Not Found";
            }
            return RedirectToAction("Index");
        }
    }
}
