using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Intro_MVC.Services
{
    public interface IDoggyDayCare
    {
        bool CanPlayWithOtherDogs(DogViewModel dog);
        List<DogViewModel> Dogs { get; }
    }
}
