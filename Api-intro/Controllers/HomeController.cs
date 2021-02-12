using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Api_intro.Models;
using Api_intro.Models.ViewModels;

namespace Api_intro.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly FinalSpaceClient _finalSpaceClient;

        public HomeController(ILogger<HomeController> logger, FinalSpaceClient finalSpaceClient)
        {
            _logger = logger;
            _finalSpaceClient = finalSpaceClient;
        }

        public IActionResult Index()
        {
            return View();
        }

        public async Task<IActionResult> Privacy()
        {
            var response = await _finalSpaceClient.GetAllQuotes();

            var viewModel = new PrivacyViewModel();
            viewModel.Quotes = response
                .Select(response =>  new QuoteVM() { Quote = response.quote, ImageUrl = response.image} )
                .ToList();

            return View(viewModel);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        public async Task<IActionResult> Episodes()
        {
            var response = await _finalSpaceClient.GetAllEpisodes();

            var viewModel = new EpisodesViewModel();
            viewModel.Episodes = response
                .Select(response => new EpisodeVM() { Name = response.name, AirDate = response.air_date, Characters = response.characters, ImageUrl = response.img_url })
                .ToList();


            return View(viewModel);
        }

        public async Task<IActionResult> Character(string id)
        {
            var response = await _finalSpaceClient.GetSingleCharacter(id);

            var viewModel = new CharacterViewModel();
            viewModel.Abilities = response.abilities;
            viewModel.Id = response.id;
            viewModel.Species = response.species;
            viewModel.Status = response.status;
            viewModel.ImageUrl = response.img_url;
            viewModel.Name = response.name;

            return View(viewModel);
        }


    }
}
