using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PatientHospitalDetails.Models;

namespace PatientHospitalDetails.Controllers
{
    public class PatientController : Controller

    {
        private readonly PatientDBContext _Db;

        public PatientController(PatientDBContext context)
        {
            this._Db = context;
        }



        public async Task<IActionResult> Index()

        {
            var patient = await _Db.Patients.ToListAsync();
            return View(patient);
        }
        [HttpGet]
        public async Task<IActionResult> Create()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Create(Patient Obj)
        {
            if (ModelState.IsValid)
            {
                _Db.Add(Obj);
                await _Db.SaveChangesAsync();
                TempData["SuccessMessage"] = "Patient Added Successfully";
                return RedirectToAction("Index");

            }
            return View(Obj);
        }
        [HttpGet]
        public async Task<IActionResult> Edit(int id)
        {
            var patient = await _Db.Patients.FindAsync(id);
            if (patient == null)
            {
                return NotFound();

            }
            return View(patient);
        }
        [HttpPost]
        public async Task<IActionResult> Edit(int id, Patient obj)
        {
            if (id !=obj.ID)
                {
                return NotFound();
            }
            if (ModelState.IsValid)
            {
                _Db.Update(obj);
                await _Db.SaveChangesAsync();
                TempData["SuccessMessage"] = "Patient Updated Successfully";
                return RedirectToAction("Index");
            }
            return View(obj);
        }
        public async Task<IActionResult> Details(int id)
        {
            var patient = await _Db.Patients.FindAsync(id);
            if (patient == null)
            {
                return NotFound();
            }
            return View(patient);
                
        }
        public async Task<IActionResult> Delete(int id)
        {
            var patient = await _Db.Patients.FindAsync(id);
            if (patient != null)
            {
                _Db.Patients.Remove(patient);
                await _Db.SaveChangesAsync();
                TempData["SuccessMessage"] = "Patient Deleted Successfully";
            }
            else
            {
                TempData["ErrorMessage"] = "Patient Not Found";

            }
            return RedirectToAction("Index");
        }

    }
}
