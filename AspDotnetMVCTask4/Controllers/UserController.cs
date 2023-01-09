using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AspDotnetMVCTask4.Models;

namespace AspDotnetMVCTask4.Controllers
{
    public class UserController : Controller
    {
        // GET: UserController
        public ActionResult Index()
        {
            #region ViewBag
            List<SelectListItem> myCreditCards = new List<SelectListItem>()
            {
                new SelectListItem{ Text="Visa", Value = "1" },
                    new SelectListItem{ Text="MasterCard", Value = "2" },
                    new SelectListItem{ Text="Amex", Value = "3" },
                    new SelectListItem{ Text="Diners", Value = "4" },
                    new SelectListItem{ Text="Unknown", Value = "5" },
            };
            ViewBag.MyCreditCards = myCreditCards;
            #endregion
            return View();
        }


        // GET: UserController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: UserController/Create
        public ActionResult Create()
        {
            #region ViewBag
            List<SelectListItem> myCreditCards = new List<SelectListItem>()
            {
                new SelectListItem{ Text="Visa", Value = "1" },
                    new SelectListItem{ Text="MasterCard", Value = "2" },
                    new SelectListItem{ Text="Amex", Value = "3" },
                    new SelectListItem{ Text="Diners", Value = "4" },
                    new SelectListItem{ Text="Unknown", Value = "5" },
            };
            ViewBag.MyCreditCards = myCreditCards;
            return View();
        }

        //// POST: UserController/Create
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public ActionResult Create(IFormCollection collection)
        //{
           
        //    try
        //    {
        //        return RedirectToAction(nameof(Index));
        //    }
        //    catch
        //    {
        //        return View();
        //    }
        //}

        // POST: UserController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(UserModel _user)
        {
            ViewBag.Success = false;
            #endregion
            try
            {
                if (ModelState.IsValid)
                {
                    ViewBag.Success = true;
                    ViewBag.Result = "Successfully Validated";
                    return View();
                }
                else { return View(); }
                
            }
            catch
            {
                return View();
            }
        }

        // GET: UserController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: UserController/Edit/5
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

        // GET: UserController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: UserController/Delete/5
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
