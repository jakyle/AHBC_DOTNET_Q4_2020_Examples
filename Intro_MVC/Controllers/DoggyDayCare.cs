﻿using Intro_MVC.DALModels;
using Intro_MVC.Models.DoggyDayCare;
using Intro_MVC.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace Intro_MVC.Controllers
{
    [Authorize]
    public class DoggyDayCareController : Controller
    {
        private readonly UserManager<IdentityUser> _userManager;
        private readonly IDoggyDayCare _doggyDayCare;
        private readonly DoggyDayCareContext _doggyDayCareContext;


        //        @inject SignInManager<IdentityUser> SignInManager
        //@inject UserManager<IdentityUser> UserManager

        public DoggyDayCareController(
            IDoggyDayCare doggyDayCare, 
            DoggyDayCareContext doggyDayCareContext, 
            UserManager<IdentityUser> userManager)
        {
            _userManager = userManager;
            _doggyDayCare = doggyDayCare;
            _doggyDayCareContext = doggyDayCareContext;
        }

        // localhost:5001/DoggyDayCare/Form
        public IActionResult AddDog() 
        {

            var userName = _userManager.GetUserName(User);

            return View();
        }
        
        public IActionResult FormResult(FormViewModel model)
        {

            var errors = ModelState.Select(kvp => kvp.Value.Errors).ToList();

            if (ModelState.IsValid)
            {
                var dog = new DogDAL();
                dog.Name = model.DogName;
                dog.DayOfTheWeek = model.DayOfTheWeek;

                _doggyDayCareContext.Dogs.Add(dog);
                _doggyDayCareContext.SaveChanges();

                // _doggyDayCare.Dogs.Add(dog);

                return FormResultView();
            }

            return View("Error");
        }

        [AllowAnonymous]
        public IActionResult UpdateDog(int id)
        {
            var dog = GetDogWhereIdIsFirstOrDefault(id);

            var model = new UpdateDogViewModel();
            model.OldDog = dog;

            return View(model);
        }

        public IActionResult UpdateResult(UpdateDogViewModel model, int id)
        {
            var dog = GetDogWhereIdIsFirstOrDefault(id);

            var dogDAL = _doggyDayCareContext
                .Dogs
                .FirstOrDefault(dogDal => dogDal.DogID == dog.ID);

            dogDAL.Name = model.NewDog.Name;
            dogDAL.DayOfTheWeek = model.NewDog.DayOfTheWeek;

            _doggyDayCareContext.SaveChanges();

            return FormResultView();
        }

        public IActionResult DeleteDog(int id)
        {
            var dog = GetDogWhereIdIsFirstOrDefault(id);

            var dogDAL = _doggyDayCareContext
               .Dogs
               .FirstOrDefault(dogDal => dogDal.DogID == dog.ID);

            _doggyDayCareContext.Dogs.Remove(dogDAL);

            _doggyDayCareContext.SaveChanges();

            return FormResultView();
        }

        private DogViewModel GetDogWhereIdIsFirstOrDefault(int id)
        {
            DogDAL dogDAL = _doggyDayCareContext.Dogs
                .Where(dog => dog.DogID == id)
                .FirstOrDefault();

            // will create error page later
            //if (dogDAL != null)
            //{

            //}

            var dog = new DogViewModel();
            dog.ID = dogDAL.DogID;
            dog.Name = dogDAL.Name;
            dog.DayOfTheWeek = dogDAL.DayOfTheWeek;
            return dog;
        }

        private IActionResult FormResultView()
        {
            //  Dog View           DogDAL
            // View Layer <====> Data Acess Layer

            var viewModel = new FormResultViewModel();

            var dogs = _doggyDayCareContext.Dogs.ToList();
            
            // Mapping DogDAL to dog View
            var dogsViewModelList = dogs
                .Select(dogDal => new DogViewModel() { Name = dogDal.Name, DayOfTheWeek = dogDal.DayOfTheWeek, ID = dogDal.DogID })
                .ToList();

            viewModel.Dogs = dogsViewModelList;

            return View("FormResult", viewModel);
        }
    }
}
