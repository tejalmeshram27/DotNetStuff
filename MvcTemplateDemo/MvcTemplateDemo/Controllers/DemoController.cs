using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MvcTemplateDemo.Models;

namespace MvcTemplateDemo.Controllers
{
    public class DemoController : Controller
    {
        // GET: DemoController
        public ActionResult Index()
        {
            var model = from m in _demo
                        orderby m.Id
                        select m;

            return View(model);


        }

        // GET: DemoController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: DemoController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: DemoController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Demo demo)
        {
            try
            {
                _demo.Add(demo);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: DemoController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: DemoController/Edit/5
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

        // GET: DemoController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: DemoController/Delete/5
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

        static List<Demo> _demo = new List<Demo> ()
        {
            new Demo
            {
                Id = 1,
            }
        };

    }
}
