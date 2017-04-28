using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PhoneCoseApp.Entities
{

    public enum Colors
    {
        None,
        White,
        Black,
        Silver,
        Gold,
        Red,
    }


    public class Phone
    {
        public int Id { get; set; }

        [Display(Name="Phone name")]
        public string Name { get; set; }
        public Colors Color { get; set; }
    }
}
