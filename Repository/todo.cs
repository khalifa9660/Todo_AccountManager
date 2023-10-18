using Microsoft.AspNetCore.Mvc;

namespace Todo_AccountManager.Repository
{
    public class todoRepository : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
