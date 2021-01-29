using System.Collections.Generic;

namespace Intro_MVC.Services
{
    public class DoggyDayCare : IDoggyDayCare
    {
        public List<DogViewModel> Dogs { get; } = new List<DogViewModel>();

        public bool CanPlayWithOtherDogs(DogViewModel dog)
        {
            return true;
        }
    }
}
