using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspDotnetMVCTask2.Controllers
{
    public class CalculatorController : Controller
    {
        // GET: CalculatorController
        public ActionResult Index()
        {
            return View();
        }

        // GET: CalculatorController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: CalculatorController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: CalculatorController/Create
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

        // GET: CalculatorController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: CalculatorController/Edit/5
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

        // GET: CalculatorController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: CalculatorController/Delete/5
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

        public IActionResult AddSubtract()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Add()
        {
            try
            {
                int num1 = Convert.ToInt32(HttpContext.Request.Form["Text1"].ToString());
                int num2 = Convert.ToInt32(HttpContext.Request.Form["Text2"].ToString());
                ViewBag.Result = (num1 + num2).ToString();
            }
            catch (Exception)
            {
                ViewBag.Result = "Wrong Input Provided.";
            }
            return View("AddSubtract");
        }

        [HttpPost]
        public IActionResult Minus()
        {
            try
            {
                int num1 = Convert.ToInt32(HttpContext.Request.Form["Text1"].ToString());
                int num2 = Convert.ToInt32(HttpContext.Request.Form["Text2"].ToString());
                ViewBag.Result = (num1 - num2).ToString();
            }
            catch (Exception)
            {
                ViewBag.Result = "Wrong Input Provided.";
            }
            return View("AddSubtract");
        }
    }
}
