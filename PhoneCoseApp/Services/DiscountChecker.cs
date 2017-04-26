using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PhoneCoseApp.Services
{
    public interface IDiscountChecker
    {
        string GetDiscount();
    }

    public class DiscountChecker : IDiscountChecker
    {
        private IConfiguration _configuration;

        public DiscountChecker(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public string GetDiscount()
        {
            return _configuration["Discount"];
        }
    }
}
