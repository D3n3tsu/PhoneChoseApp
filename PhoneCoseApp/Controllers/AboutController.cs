using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

/// <summary>
/// this controller was made just to test attribute controled routes
/// </summary>
namespace PhoneCoseApp.Controllers
{
    [Route("[controller]")]
    public class AboutController
    {
        [Route("{index}")]
        public string Index()
        {
            return "about index";
        }
        [Route("[action]")]
        public string Bout()
        {
            return " about bout";
        }
    }
}
