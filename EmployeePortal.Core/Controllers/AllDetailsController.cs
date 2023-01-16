using CRUDOPERATION.Data;
using Microsoft.AspNetCore.Mvc;

namespace CRUDOPERATION.Controllers
{
    public class AllDetailsController : Controller
    {
        private readonly ApplicationContext context;

        public AllDetailsController(ApplicationContext context)
        {
            this.context = context;
        }
        public IActionResult Index()
        {
            var result = context.Employees.ToList(); // to show thw details on view
            return View(result);
        }

        
        
    }
}
