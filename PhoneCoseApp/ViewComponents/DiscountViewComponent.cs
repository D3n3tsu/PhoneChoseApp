using Microsoft.AspNetCore.Mvc;
using PhoneCoseApp.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PhoneCoseApp.ViewComponents
{
    public class DiscountViewComponent : ViewComponent
    {
        private IDiscountChecker _discountChecker;

        public DiscountViewComponent(IDiscountChecker discountChecker)
        {
            _discountChecker = discountChecker;
        }

        public Task<IViewComponentResult> InvokeAsync()
        {
            var model = _discountChecker.GetDiscount();
            return Task.FromResult<IViewComponentResult>(View("Default", model));
        }
    }
}
