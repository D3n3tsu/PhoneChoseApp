using Microsoft.AspNetCore.Mvc;
using PhoneCoseApp.Services;
using PhoneCoseApp.ViewModels.Home;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PhoneCoseApp.Entities;

namespace PhoneCoseApp.Controllers
{
    public class HomeController : Controller
    {
        private IPhonesData _phonesData;
        private IDiscountChecker _discountChecker;

        public HomeController(IPhonesData phonesData,IDiscountChecker discountChecker)
        {
            _phonesData = phonesData;
            _discountChecker = discountChecker;
        }

        public IActionResult Index()
        {
            var testModel = new IndexViewModel() {
                Discount = _discountChecker.GetDiscount(),
                Phones = _phonesData.GetAllPhones()
            };

            return View(testModel);
        }

        public IActionResult Details(int Id)
        {
            var model = _phonesData.GetPhoneById(Id);

            if (model == null)
            {
                return RedirectToAction(nameof(Index));
            }

            return View(model);
        }

        public IActionResult Create()
        {
            return View();
        }
    }
}
