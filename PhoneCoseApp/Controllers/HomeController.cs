using Microsoft.AspNetCore.Mvc;
using PhoneCoseApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PhoneCoseApp.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            var testModel = new Phone() { Id = 1, Name = "Nokla" };

            return new ObjectResult(testModel);
        }
    }
}
