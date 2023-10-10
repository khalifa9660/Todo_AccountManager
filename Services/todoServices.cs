using Microsoft.AspNetCore.Mvc;

namespace Todo_AccountManager.Services
{
    public class todoServices : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
