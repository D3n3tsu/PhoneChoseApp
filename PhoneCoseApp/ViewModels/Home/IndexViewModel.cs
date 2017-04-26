using PhoneCoseApp.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PhoneCoseApp.ViewModels.Home
{
    public class IndexViewModel
    {
        public string Discount { get; set; }
        public IEnumerable<Phone> Phones { get; set; }
    }
}
