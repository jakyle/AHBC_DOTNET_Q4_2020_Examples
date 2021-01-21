using Intro_MVC.Models.DoggyDayCare;
using Intro_MVC.Services;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace Intro_MVC.Controllers
{
    public class DoggyDayCareController : Controller
    {
        private readonly IDoggyDayCare _doggyDayCare;

        public DoggyDayCareController(IDoggyDayCare doggyDayCare)
        {
            _doggyDayCare = doggyDayCare;
        }

        // localhost:5001/DoggyDayCare/Form
        public IActionResult AddDog() 
        {
            return View();
        }
        
        public IActionResult FormResult(FormViewModel model)
        {
            var dog = new Dog();
            dog.Name = model.DogName;
            dog.DayOfTheWeek = model.DayOfTheWeek;

            _doggyDayCare.Dogs.Add(dog);

            var viewModel = new FormResultViewModel();
            viewModel.Dogs = _doggyDayCare.Dogs;
            // do some math and shit 
            return View(viewModel);
        }

        public IActionResult UpdateDog(string name)
        {
            var dog = _doggyDayCare.Dogs
                .Where(dog => dog.Name == name)
                .FirstOrDefault();

            var model = new UpdateDogViewModel();
            model.OldDog = dog;

            return View(model);
        }

        public IActionResult UpdateResult(UpdateDogViewModel model, string name)
        {
            var dog = _doggyDayCare.Dogs
                .Where(dog => dog.Name == name)
                .FirstOrDefault();

            dog.Name = model.NewDog.Name;
            dog.DayOfTheWeek = model.NewDog.DayOfTheWeek;

            var viewModel = new FormResultViewModel();
            viewModel.Dogs = _doggyDayCare.Dogs;

            return View("FormResult", viewModel);
        }

        public IActionResult DeleteDog(string name)
        {
            var dog = _doggyDayCare.Dogs
                .Where(dog => dog.Name == name)
                .FirstOrDefault();

            _doggyDayCare.Dogs.Remove(dog);

            var viewModel = new FormResultViewModel();
            viewModel.Dogs = _doggyDayCare.Dogs;

            return View("FormResult", viewModel);
        }
    }
}
