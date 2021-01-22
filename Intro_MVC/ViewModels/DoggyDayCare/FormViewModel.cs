using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Intro_MVC.Models.DoggyDayCare
{
    public class FormViewModel
    {
        public string DogName { get; set; }
        public string DayOfTheWeek { get; set; }

        public string DogNameWithY => $"{DogName}y";
    }
}




// View -> Controller -> DAl (Data Access Layer)

// View + 2 props,        Business, -1, +5,       +- 0
// MVC ->          <->   Business Layer  <-> (Data Access Layer)