using Microsoft.AspNetCore.Mvc;
using PhoneCoseApp.Models;
using PhoneCoseApp.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PhoneCoseApp.Controllers
{
    public class HomeController : Controller
    {
        private IPhonesData _phonesData;

        public HomeController(IPhonesData phonesData)
        {
            _phonesData = phonesData;
        }

        public IActionResult Index()
        {
            var testModel = _phonesData.GetAllPhones();

            return View(testModel);
        }
    }
}
