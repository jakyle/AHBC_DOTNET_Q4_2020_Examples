using Intro_MVC.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Intro_MVC.Models.DoggyDayCare
{
    public class UpdateDogViewModel
    {
        public Dog OldDog { get; set; }
        public Dog NewDog { get; set; }
    }
}
