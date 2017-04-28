using PhoneCoseApp.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PhoneCoseApp.ViewModels.Home
{
    public class CreateViewModel
    {
        [Required, MaxLength(80)]
        public string Name { get; set; }
        public Colors Color { get; set; }
    }
}
