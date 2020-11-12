using System;
using System.Collections.Generic;

namespace Enums_File_IO
{
    class Program
    {
        static void Main(string[] args)
        {

            // ENUMS example                                                 0    1
            Console.WriteLine("Enter the Name and Genre of your movie, [ex: ET,SciFi]");

            Movie movie = new Movie(Console.ReadLine().Split(","));

            int one = 1;
            int two = 2;
            int sum = one + two;

            Console.WriteLine($"{one.ToString()} + {two}  = {sum}");

            Console.WriteLine(movie);
        }
    }

    public class Movie
    {
        public Movie(string[] movieInput)
        {
            Title = movieInput[0];
            if (Enum.TryParse<Genre>(movieInput[1], out Genre genre)) 
            {
                Genre = genre;
            }
        }

        public Movie(string title, Genre genre) 
        {
            Title = title;
            Genre = genre;
        }

        public string Title { get; set; }
        public Genre Genre { get; set; }

        public override string ToString()
        {
            switch (Genre)
            {
                case Genre.Horror: return "OOOO Spoooky!";
                case Genre.Comedy: return "lulz";
                case Genre.Drama: return "oh my!";
                case Genre.Action: return "daaaym";
                case Genre.Romance: return ";)";
                case Genre.Thriller: return "*gasp*";
                case Genre.SciFi: return "pew pew!";
                default: return "whatever C#";
            }
        }
    }

    public enum Genre
    {
        Drama = 2,
        Horror = 0, 
        Comedy = 1,
        Action = 3,
        Romance = 4,
        Thriller = 5,
        SciFi = 6
    }


    public enum Food
    {
        Grain,
        Vegetables,
        Dairy, 
        Protien,
        Fruit
    }
}
