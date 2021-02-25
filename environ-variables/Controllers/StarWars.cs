using environ_variables.Models.ViewModels;
using environ_variables.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace environ_variables.Controllers
{
    public class StarWars : Controller
    {
        private readonly SWAPIClient _swapiClient;

        public StarWars(SWAPIClient swapiClient)
        {
            _swapiClient = swapiClient;
        }

        public IActionResult ChooseUser() => View();
        
        public async Task<IActionResult> Person(ChooseUserViewModel model)
        {
            var response = await _swapiClient.GetSinglePerson(model.Id);

            var viewModel = new PersonViewModel();
            viewModel.Name = response.name;
            viewModel.Height = response.height;
            viewModel.Gender = response.gender;

            return View(viewModel);
        }
    }
}
