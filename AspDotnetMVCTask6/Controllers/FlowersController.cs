using AspDotnetMVCTask6.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspDotnetMVCTask6.Controllers
{
    public class FlowersController : Controller
    {

        private FlowersViewModel flowers = null;
        public void GetFlowersData()
        {
            string host = HttpContext.Request.Host.Value; //localhost:55012
            string flowerImageUrl = String.Format($"http://{host}/images");
            flowers = new FlowersViewModel();
            flowers.flowersList = new List<FlowersItemViewModel>();
            flowers.flowersList.Add(new FlowersItemViewModel { Id = 1,Name = "Rose flower", ImageUrl = String.Format($"{flowerImageUrl}/roseflower.png") });
            flowers.flowersList.Add(new FlowersItemViewModel { Id = 2, Name = "Lily flower", ImageUrl = String.Format($"{flowerImageUrl}/lilyflower.png") });
            flowers.flowersList.Add(new FlowersItemViewModel { Id = 3, Name = "Marigold flower", ImageUrl = String.Format($"{flowerImageUrl}/marigoldflower.png") });
            flowers.flowersList.Add(new FlowersItemViewModel { Id = 4, Name = "Sun flower", ImageUrl = String.Format($"{flowerImageUrl}/sunflower.png") });
            flowers.flowersList.Add(new FlowersItemViewModel { Id = 5, Name = "Chrysanthemum flower", ImageUrl = String.Format($"{flowerImageUrl}/chrysanthemumflower.png") });
        }


        // GET: FlowersController
        public ActionResult Index()
        {
            GetFlowersData();
            return View(flowers);
        }

        // GET: FlowersController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: FlowersController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: FlowersController/Create
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

        // GET: FlowersController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: FlowersController/Edit/5
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

        // GET: FlowersController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: FlowersController/Delete/5
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
