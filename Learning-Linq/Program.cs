using System;
using System.Collections.Generic;
using System.Linq;

namespace Learning_Linq
{
    class Program
    {
        static void Main(string[] args)
        {
            var movies = new List<Movie>();
            movies.Add(new Movie() { Id = 1, Name = "Spider-Man", Genre = "Action" });
            movies.Add(new Movie() { Id = 2, Name = "Super Troopers", Genre = "Comedy" });
            movies.Add(new Movie() { Id = 3, Name = "Titanic", Genre = "Romance" });
            movies.Add(new Movie() { Id = 4, Name = "Inception", Genre = "Action" });
            movies.Add(new Movie() { Id = 5, Name = "Insidious", Genre = "Horror" });

            var movieDetails = new List<MovieDetails>();
            movieDetails.Add(new MovieDetails() { MovieId = 1, Rating = 7.3, Director = "Sam Raimi" });
            movieDetails.Add(new MovieDetails() { MovieId = 2, Rating = 7.1, Director = "Jay Chandrasekhar" });
            movieDetails.Add(new MovieDetails() { MovieId = 3, Rating = 7.8, Director = "James Cameron" });
            movieDetails.Add(new MovieDetails() { MovieId = 4, Rating = 8.8, Director = "Christopher Nolan" });
            movieDetails.Add(new MovieDetails() { MovieId = 5, Rating = 6.8, Director = "James Wan" });

            // loop and filter by a condition
            var actionMovies = new List<Movie>();
            foreach (var movie in movies)
            {
                if (IsActionMovie(movie))
                {
                    actionMovies.Add(movie);
                }
            }

            actionMovies = movies
                //     VVV- Parameter  VVV-> Body of the function
                .Where(movie => movie.Genre == "Action")
                .ToList();


            // Mapping one list of type A to type B
            var movieTitles = new List<MovieInfo>();
            foreach (var movie in movies)
            {
                movieTitles.Add(new MovieInfo() 
                { 
                    MovieName = movie.Name, 
                    Genre = movie.Genre 
                });
            }

            movieTitles = movies
                .Select(movie => new MovieInfo() {   MovieName = movie.Name, Genre = movie.Genre })
                .ToList();

            // combining Where and Select with order
            var actionMovieInfos = movies
                .Where(movie => movie.Genre == "Action")
                .Select(movie => new MovieInfo() { MovieName = movie.Name, Genre = movie.Genre })
                .OrderBy(movie => movie.MovieName)
                .ToList();

            // any checks if there are any elements in the array
            if (actionMovieInfos.Any()) 
            {
                // ... some logic if you do have elements
            }

            // sum of all movie ratings using aggregate or "reduce"
            // [ 7.3, 7.1, 7.8, 8.8, 6.8 ]  => 0 ->  0.0 + 7.3 = 7.3, 1 =>  7.3 + 7.1 = , 2 => 14.4 + 7.8 = 22.2, 3 => 22.2 + 8.8 = 31, 4 =>  31 + 6.8 = 37.8
            var sumOfAllRatings = movieDetails.Aggregate(0.0, (acc, movieDetails) => movieDetails.Rating + acc);


            var movieDictionary = movies.Aggregate(new Dictionary<string, Movie>(), (dict, movie) => 
            { 
                dict.Add(movie.Name, movie);
                return dict;
            });


            var otherMovieDictionary = movies.ToDictionary(movie => movie.Name, movie => movie.Genre);

            //
            var groupedGenreMovies = movies.GroupBy(movie => movie.Genre).ToList();

            Console.WriteLine("Hello World!");
        }


        static private bool IsActionMovie(Movie movie) => movie.Genre == "Action";
        
    }
    
    
    public class MovieDetails
    {
        public int MovieId { get; set; }
        public double Rating { get; set; }
        public string Director { get; set; }
    }

    public class Movie
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Genre { get; set; }
    }

    // SELECT [Name] as MovieName, Genre FROM MOVIE

    public class MovieInfo
    {
        public string MovieName { get; set; }
        public string Genre { get; set; }
    }
}
