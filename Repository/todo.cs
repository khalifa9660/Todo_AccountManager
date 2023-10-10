using Microsoft.AspNetCore.Mvc;

namespace Todo_AccountManager.Repository
{
    public class todo : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
