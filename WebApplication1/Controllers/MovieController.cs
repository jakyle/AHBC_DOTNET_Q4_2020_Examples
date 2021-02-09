using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;
using WebApplication1.Services;

namespace WebApplication1.Controllers
{
    public class MovieController : Controller
    {
        private readonly MovieDbContext _movieDbContext;

        public MovieController(MovieDbContext movieDbContext)
        {
            _movieDbContext = movieDbContext;
        }

        public IActionResult AddMovie()
        {
            return View();
        }

        public IActionResult AddMovieResult(AddMovieViewModel model)
        {
            var dbModel = new MovieDAL();

            dbModel.MovieName = model.Movie.MovieName;
            dbModel.MovieGenre = model.Movie.MovieGenre;
            dbModel.UniqueId = Guid.NewGuid().ToString();

            _movieDbContext.Movies.Add(dbModel);
            _movieDbContext.SaveChanges();

            var movieList = _movieDbContext.Movies
                .Select(movieDal => new MovieVM() { MovieName = movieDal.MovieName, MovieGenre = movieDal.MovieGenre})
                .ToList();

            var viewModel = new AddMovieResultViewModel();
            viewModel.Movies = movieList;

            return View(viewModel);
        }
    }
}
