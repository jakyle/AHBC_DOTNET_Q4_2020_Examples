using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Intro_MVC.Services
{
    public interface IDoggyDayCare
    {
        bool CanPlayWithOtherDogs(Dog dog);
        List<Dog> Dogs { get; }
    }
}
