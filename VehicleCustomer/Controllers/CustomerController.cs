using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using VehicleCustomer.Models;

namespace VehicleCustomer.Controllers
{
    public class CustomerController : Controller
    {
        private readonly CustomerDBContext db;

        public CustomerController(CustomerDBContext context)
        {
            this.db = context;
        }
        public async Task<IActionResult> Index()
        {
            var customer = await db.Customers.ToListAsync();
            if( customer == null)
            {
                return NotFound();
            }
            return View(customer);
        }
        [HttpGet]
        public async Task<IActionResult> Create()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Create(Customer obj)
        {
            if(ModelState.IsValid)
            {
                db.Customers.Add(obj);
                await db.SaveChangesAsync();
                TempData["SuccessMessage"] = "Customer Added Successfully";
                return RedirectToAction("Index");
            }
            return View(obj);
        }
        [HttpGet]
        public async Task<IActionResult> Edit(int id)
        {
            var customer = await db.Customers.FindAsync(id);
            if(customer == null)
            {
                return NotFound();
            }
            return View(customer);
        }
        [HttpPost]
        public async Task<IActionResult> Edit(int id, Customer obj)
        {
            if( id != obj.Customer_ID)
            {
                return NotFound();
            }
            if(ModelState.IsValid)
            {
                db.Customers.Update(obj);
                await db.SaveChangesAsync();
                TempData["SuccessMessage"] = "Customer Updated Successfully";
                return RedirectToAction("Index");   
            }
            return View(obj);
        }
        [HttpGet]
        public async Task<IActionResult> Details(int id)
        {
            var customer = await db.Customers.FindAsync(id);
            if (customer == null)
            {
                return NotFound();
            }
            return View(customer);
        }
        public async Task<IActionResult> Delete(int id)
        {
            var customer = await db.Customers.FindAsync(id);
            if( customer != null)
            {
                db.Customers.Remove(customer);
                await db.SaveChangesAsync();
                TempData["SuccessMessage"] = "Customer Deleted SuccessFully";

            }
            else
            {
                TempData["ErrorMessage"] = "Customer Not Found";
            }
            return RedirectToAction("Index");
        }
    }
}
