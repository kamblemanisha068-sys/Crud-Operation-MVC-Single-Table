using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MillatryCrud.Models;

namespace MillatryCrud.Controllers
{
    public class SoldierController : Controller
    {
        private readonly SoldierDBContext db;

        public SoldierController(SoldierDBContext context)
        {
            this.db = context;
            
        }
        public async Task< IActionResult> Index()
        {
            var soldier = await db.Soldiers.ToListAsync();
            return View(soldier);
        }
        [HttpGet]
        public async Task<IActionResult> Create()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Create(Soldier obj)
        {
            if(ModelState.IsValid)
            {
                db.Add(obj);
                await db.SaveChangesAsync();
                TempData["SuccessMessage"] = "Soldier Added Successfully";
                return RedirectToAction("Index");
            }
            return View(obj);
        }
        [HttpGet]
        public async Task<IActionResult> Edit(int id)
        {
            var soldier = await db.Soldiers.FindAsync(id);
            if(soldier == null)
            {
                return NotFound();
            }
            return View(soldier);
        }
        [HttpPost]
        public async Task<IActionResult> Edit(int id, Soldier obj)
        {
            if(id != obj.ID)
            {
                return NotFound();
            }
            if(ModelState.IsValid)
            {
                db.Update(obj);
                await db.SaveChangesAsync();
                TempData["SuccessMessage"] = "Soldier Updated Successfully";
                return RedirectToAction("Index");
            }
            return View(obj);
        }
        [HttpGet]
        public async Task<IActionResult> Details(int id)
        {
            var soldier = await db.Soldiers.FindAsync(id);
            if(soldier == null)
            {
                return NotFound();
            }
            return View(soldier);
        }
        public async Task<IActionResult> Delete(int id)
        {
            var soldier = await db.Soldiers.FindAsync(id);
            if(soldier != null)
            {
                db.Soldiers.Remove(soldier);
                await db.SaveChangesAsync();
                TempData["SuccessMessage"] = "Soldier Deleted Successfully";
            }
            else
            {
                TempData["ErrorMessage"] = "Soldier Not Found";

            }
            return RedirectToAction("Index");
        }
    }
}
