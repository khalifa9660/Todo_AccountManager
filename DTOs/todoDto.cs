using Microsoft.AspNetCore.Mvc;

namespace Todo_AccountManager.DTOs
{
    public class todoDto : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
