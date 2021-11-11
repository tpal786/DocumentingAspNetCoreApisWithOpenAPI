using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Library.API.Controllers
{
    // [ApiConventionType(typeof(DefaultApiConventions))]
    [ApiConventionType(typeof(CustomConventions))]
    public class ConventionTests : Controller
    {
        // GET: ConventionTests
        public ActionResult Index()
        {
            return View();
        }

        // GET: ConventionTests/Details/5
        // [ApiConventionMethod(typeof(DefaultApiConventions), nameof(DefaultApiConventions.Get))]
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: ConventionTests/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ConventionTests/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        //[ApiConventionMethod(typeof(DefaultApiConventions), nameof(DefaultApiConventions.Create))]
        [ApiConventionMethod(typeof(CustomConventions), nameof(CustomConventions.Insert))]
        public ActionResult Insert(IFormCollection collection)
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

        // GET: ConventionTests/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: ConventionTests/Edit/5
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

        // GET: ConventionTests/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: ConventionTests/Delete/5
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
