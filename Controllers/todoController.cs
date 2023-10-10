using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Todo_AccountManager.Controllers
{
    public class todoController : Controller
    {
        // GET: todoController
        public ActionResult Index()
        {
            return View();
        }

        // GET: todoController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: todoController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: todoController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: todoController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: todoController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: todoController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: todoController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
