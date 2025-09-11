using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Microsoft.Identity.Client;
using Studentportal.web.Models;
using System.Threading.Tasks;

namespace Studentportal.web.Controllers
{
    public class StudentsController : Controller
    {
        private readonly ApplicationDbContext _Db;

        public StudentsController(ApplicationDbContext context)
        {
            this._Db = context;
        }
        [HttpGet]
        public async Task<IActionResult> Index()
        {
            return View(await _Db.Students.ToListAsync());
        }
        [HttpGet]
        public async Task<IActionResult> Add()
        {
            var student = await _Db.Students.ToListAsync();
            return View();
        }
        [HttpPost]

        public async Task<IActionResult> Add(Student obj)
        {
            if (ModelState.IsValid)
            {
                _Db.Add(obj);
                await _Db.SaveChangesAsync();
                TempData["SuccessMessage"] = "Student Added Successfully";
                return RedirectToAction("Index");
            }
            return View(obj);
        }
        [HttpGet]
        public async Task<IActionResult> Edit(int id)
        {
            var student = await _Db.Students.FindAsync(id);
            if (student == null)
            {
                return NotFound();
            }
            return View(student);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(int id, Student obj)
        {
            if (id != obj.ID)
            {
                return NotFound();
            }
            if (ModelState.IsValid)
            {
                _Db.Update(obj);
                await _Db.SaveChangesAsync();
                TempData["SuccessMessage"] = "Student Updated Successfully";
                return RedirectToAction("Index");

                
            }
            return View(obj);

        }
        public async Task<IActionResult> Details(int id)
        {
            var student = await _Db.Students.FindAsync(id);
            if (student == null)
            {
                return NotFound();
            }
            return View(student);
        }
        public async Task<IActionResult> Delete(int id)
        {
            var student = await _Db.Students.FindAsync(id);
            if (student != null)
            {
                _Db.Students.Remove(student);
                await _Db.SaveChangesAsync();
                TempData["SuccessMessage"] = "Student Deleted Successfully";
            }
            else
            {
                TempData["ErrorMessage"] = "Student Not Found";
            }
                return RedirectToAction("Index");
        }


    }
}    


