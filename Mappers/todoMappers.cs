using Microsoft.AspNetCore.Mvc;

namespace Todo_AccountManager.Mappers
{
    public class todoMappers : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
