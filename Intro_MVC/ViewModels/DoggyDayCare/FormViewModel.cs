using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Intro_MVC.Models.DoggyDayCare
{
    public class FormViewModel
    {
        public string DogName { get; set; }

        public int Age { get; set; }

        public string DayOfTheWeek { get; set; }

        public string DogNameWithY => $"{DogName}y";
    }
}




// View -> Controller -> DAl (Data Access Layer)

// View + 2 props,        Business, -1, +5,       +- 0
// MVC ->          <->   Business Layer  <-> (Data Access Layer)https://pbs.twimg.com/media/EsTH5sUW8AIdB6j.jpg-:large