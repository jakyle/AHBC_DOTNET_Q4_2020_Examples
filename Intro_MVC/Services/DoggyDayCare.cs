using System.Collections.Generic;

namespace Intro_MVC.Services
{
    public class DoggyDayCare : IDoggyDayCare
    {
        public List<Dog> Dogs { get; } = new List<Dog>();

        public bool CanPlayWithOtherDogs(Dog dog)
        {
            return true;
        }
    }
}
