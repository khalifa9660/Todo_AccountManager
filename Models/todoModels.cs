using Microsoft.AspNetCore.Mvc;

namespace Todo_AccountManager.Models
{
    public class todoModels : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
