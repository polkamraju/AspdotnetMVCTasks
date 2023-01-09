using AspDotnetMVCTask4.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspDotnetMVCTask4.Controllers
{
    public class NumberController : Controller
    {
        private int result;

        public IActionResult Index()
        {
            return View();
        }
        public ActionResult Validate()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Validate(UserNumber _usernumber)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    string result = FormatNumber(_usernumber.InputNumber);
                    ViewBag.Result = result;
                }
                return View();
            }
            catch
            {
                return View();
            }
        }

        private string FormatNumber(string inputNumber)
        {
           string resultString = string.Empty;
            if (int.TryParse(inputNumber, out result))
            {
                if (result > 0)
                { 
                for (int i = 0; i < inputNumber.Length; i++)
                {
                    if (!resultString.Contains(inputNumber[i]))
                    {
                        resultString += inputNumber[i];
                    }
                }
            }
            }
            return resultString;
        }
    }
}
