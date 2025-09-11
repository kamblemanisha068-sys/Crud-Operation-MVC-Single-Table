using FruitCrudOperation.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Reflection.Metadata.Ecma335;

namespace FruitCrudOperation.Controllers
{
    public class FruitController : Controller
    {
        private readonly FruitDBContext _Db;

        public FruitController(FruitDBContext context)
        {
            this._Db = context;
        }
        public async Task<IActionResult> Index()
        {
            var fruit = await _Db.Fruits.ToListAsync();
            return View(fruit);
        }
        [HttpGet]

        public async Task <IActionResult> Create()
        {
            return View();
        }
        [HttpPost]

        public async Task<IActionResult> Create(Fruit obj)
        {
            if (ModelState.IsValid)
            {
                _Db.Add(obj);
                await _Db.SaveChangesAsync();
                TempData["SuccessMessage"] = "Fruit Added Successfully";
                return RedirectToAction("Index");
                
            }
            return View(obj);
        }
        [HttpGet]
        public async Task<IActionResult> Edit(int id)
        {
            var fruit = await _Db.Fruits.FindAsync(id);
            if (fruit == null)
            {
                return NotFound();
            }

            return View(fruit);
        }
        [HttpPost]

        public async Task<IActionResult> Edit(int id, Fruit obj)
        {
            if (id != obj.ID)
            {
                return NotFound();
            }
            if (ModelState.IsValid)
            {
                _Db.Update(obj);
                await _Db.SaveChangesAsync();
                TempData["SuccessMessage"] = "Fruit Updated SuccessFully";
                return RedirectToAction("Index");

            }
            return View(obj);

        }
        public async Task<IActionResult> Details(int id)
        {
            var fruit = await _Db.Fruits.FindAsync(id);
            if (fruit == null)
            {
                return NotFound();
            }
            return View(fruit);
        }
        public async Task<IActionResult> Delete(int id)
        {
            var fruit = await _Db.Fruits.FindAsync(id);
            if (fruit != null)
            {
                _Db.Fruits.Remove(fruit);
                await _Db.SaveChangesAsync();
                TempData["SuccessMessage"] = "Fruit Deleted Successfully";
            }
            else
            {
                TempData["ErrorMessage"] = "Fruit Not Found";
            }
            return RedirectToAction("Index");


    }   }   
}
