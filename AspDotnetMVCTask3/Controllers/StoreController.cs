using AspDotnetMVCTask3.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspDotnetMVCTask3.Controllers
{
    public class StoreController : Controller
    {
        private List<StoreItem> storeItems = null;

        public void GetStoreItemsData()
        {
            string host = HttpContext.Request.Host.Value; //localhost:37314
            string imageUrl = String.Format($"http://{host}/images");
            storeItems = new List<StoreItem>();
            storeItems.Add(new StoreItem { Id = 1, Name = "Fan", Cost = 1200.00, ImageUrl = String.Format($"{imageUrl}/Fan.png") });
            storeItems.Add(new StoreItem { Id = 2, Name = "Laptop", Cost = 70000.00, ImageUrl = String.Format($"{imageUrl}/Laptop.png") });
            storeItems.Add(new StoreItem { Id = 3, Name = "Mobile", Cost = 15000.00, ImageUrl = String.Format($"{imageUrl}/Mobile.png") });
            storeItems.Add(new StoreItem { Id = 4, Name = "Skybag", Cost = 1800.00, ImageUrl = String.Format($"{imageUrl}/Skybag.png") });
            storeItems.Add(new StoreItem { Id = 5, Name = "Table", Cost = 1900.00, ImageUrl = String.Format($"{imageUrl}/Table.png") });
        }

  
        // GET: StoreController
        public ActionResult Index()
        {
            GetStoreItemsData();
            return View(storeItems);
        }

        // GET: StoreController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: StoreController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: StoreController/Create
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

        // GET: StoreController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: StoreController/Edit/5
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

        // GET: StoreController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: StoreController/Delete/5
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
