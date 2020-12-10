using System;

namespace SOLID_Design_Patterns
{
    class Program
    {
        static void Main(string[] args)
        {
            ICleaningService cleaningService = new ReallyGoodCleaning();
            ICleaningService mollyMaid = new MollyMaid();

            var hotel = new HiltonHotel(cleaningService);
        }
    }

    public class Engine
    {

    }

    // SOLID
    public class Car : ITurbo
    {
        public Engine Engine { get; set; }

        public void Accelerate(double speed)
        {
           // accelrate car...
        }

        public void Accelerate(double speed, bool isTurbo)
        {
            if (isTurbo)
            {
                // activate turbo
            }
            else
            {
                Accelerate(speed);
            }
        }

        public void Brake()
        {
            // some logic to slow down your car and stop
        }
    }

    public interface IBrake
    {
        void Brake();
    }

    public interface ITireLockBrake
    {
        void TireLockBrake();
    }

    public class ChevySonic : IBrake
    {
        public void Brake()
        {
            // Brake 
        }

        public void TireLockBrake()
        {
            // TireLock Brake
        }
    }

    public interface ITurbo
    {
        void Accelerate(double speed, bool isTurbo);
    }

    public interface IGPS
    {
        string GetDirection();
    }

    public class GPS : IGPS
    {
        public string GetDirection()
        {
            // Get directions to some sort of destination

            return string.Empty;
        }
    }


    public class Animal
    {
        public virtual string MakeNoise()
        {
            return "growl!";
        }
    }

    public class Dog : Animal
    {
        public override string MakeNoise()
        {
            // DON'T DO THIS
            // return "Dog age: 2, Dog Name: Rex";
            // log to a data base
            // create a cat class
            // return the name and age of this dog
            return "Bark!";
        }
    }

    public class Employee
    {
        public string Name { get; set; }
        public double Salary { get; set; }
    }

    public interface IPayEmployee
    {
        void PayEmployee(Employee employee);
    }

    public class HR : IPayEmployee
    {
        public void PayEmployee(Employee employee)
        {
            var payRate = employee.Salary / 52;
            // logic to then pay that payrate
        }
    }



    // Dependency Inversion 

    // high level module
    public class HiltonHotel
    {
        private ICleaningService _cleaningService; 

        public HiltonHotel(ICleaningService cleaningService)
        {
            _cleaningService = cleaningService;
        }
    }


    public interface ICleaningService
    {
        void Clean();
    }

    // low level module
    public class MollyMaid : ICleaningService
    {
        public void Clean()
        {
            // eh, okay cheap cleaning
        }
    }

    public class ReallyGoodCleaning : ICleaningService
    {
        public void Clean()
        {
            // clean REALLY REALLY GOOD
        }
    }







    public class Cat : Animal
    {

    }

    public class Mouse : Animal
    {

    }


    public interface ICreate<T>
    {
        T Create(string input);
    }

    // DESIGN Patterns
    // the factory pattern decides which objects needs to be created for us!
    public class AnimalFactory : ICreate<Animal>
    {
        public Animal Create(string input)
        {
            switch (input)
            {
                case "dog": return new Dog();
                case "cat": return new Cat();
                case "mouse": return new Mouse();
                default: throw new ArgumentOutOfRangeException("invalid animal!");
            }
        }
    }
}
