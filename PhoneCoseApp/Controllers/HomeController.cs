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

        public HomeController(IPhonesData phonesData, IDiscountChecker discountChecker)
        {
            _phonesData = phonesData;
            _discountChecker = discountChecker;
        }

        public IActionResult Index()
        {
            var testModel = new IndexViewModel()
            {
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

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(CreateViewModel createVM)
        {
            if (ModelState.IsValid)
            {
                var newPhone = new Phone()
                {
                    Name = createVM.Name,
                    Color = createVM.Color
                };

                newPhone = _phonesData.Add(newPhone);

                return RedirectToAction("Details", new { Id = newPhone.Id });
            }
            return View();
        }
    }
}
