using CRUDOPERATION.Data;
using CRUDOPERATION.Models;
using Microsoft.AspNetCore.Mvc;

namespace CRUDOPERATION.Controllers
{
    public class EmployeeController : Controller
    {
        private readonly ApplicationContext context;
        public EmployeeController(ApplicationContext context) // To Create Instance to access
        {
            this.context = context;
        }
        //Show Deatis in table
        public IActionResult Index()
        {
            var result = context.Employees.ToList(); // to show thw details on view
            return View(result);
        }
        //Create 
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Employee model)
        {
            if(ModelState.IsValid)
            {
                var emp = new Employee()
                {
                    Name = model.Name,
                    City = model.City,
                    State = model.State,
                    Salary = model.Salary,
                };
                context.Employees.Add(emp);
                context.SaveChanges();
                TempData["error"] = "Record Added Successfully";
                return RedirectToAction("Index");
            }   
            else
            {
                TempData["Error"] = "Enter All Details"; 
                return View(model);
            }
            
        }
        public IActionResult Delete(int id)
        {
            var emp = context.Employees.SingleOrDefault(e =>e.ID == id);
            context.Employees.Remove(emp);
            context.SaveChanges();
            TempData["Error"] = "Record Deleted Successfully";
            return RedirectToAction("Index");

        }
        public IActionResult Edit(int id)
        {
            var emp = context.Employees.SingleOrDefault(e => e.ID == id);
            var result = new Employee()
            {
                Name = emp.Name,
                City = emp.City,
                State = emp.State,
                Salary = emp.Salary,
            };
            return View(result);
        }
        [HttpPost]
        public IActionResult Edit(Employee model)
        {
            var emp = new Employee()
            {
                ID = model.ID,
                Name = model.Name,
                City = model.City,
                State = model.State,
                Salary = model.Salary,

            };
            context.Employees.Update(emp);
            context.SaveChanges();
            TempData["Error"] = "Record Updated Successfully";
            return RedirectToAction("Index");
            
        }
    }
}
