using System;
using System.Collections.Generic;

namespace OOP_Composition
{
    class Program
    {
        static void Main(string[] args)
        {
            var motors = new List<IMotor>();

            motors.Add(new Car());
            motors.Add(new LawnMower());

            foreach (var motor in motors)
            {
                Console.WriteLine(motor.Cylinders);
            }


            // back to oop for a second


            // Point Example
            var point = new Point();

            // using the DOT notation, this allows you to access public members outside of your object.
            // so in this case, we are saying point.x, this is like reaching into our point object, and,
            // accessing the X property.
            point.X = 2;
            point.Y = 5;

            Console.WriteLine(point);


            // POLYMORPHSIM

            // Inheritance chain.. Dog <== Animal <== Object
            var dog = new Dog();



            // Inheritance chain.. Cat <== Animal <== Object
            var cat = new Cat();
            cat.Name = "Oreo";

            var poodle = new Poodle();
            poodle.Name = "Poods";

            // We are able to add a our dog, cat, and poodle into this list of Animals because of PolyMorphism.
            // PolyMorphism meaning many shapes, allows us to LOOK at our classes as a DIFFERENT CLASS within
            // it's INHERITENCE chain.  ie. because a Dog INHERITS from ANIMAL, we can look at a DOG as an ANIMAL.
            // because POODLE Inherits from DOG, and DOG INHERITS from ANIMAL, POODLE  is part of the SAME INHERTENCE
            // chain as ANIMAL, and therefore, we can look at a POODLE as an ANIMAL.
            var vetAnimals = new List<Animal>();
            vetAnimals.Add(cat);
            vetAnimals.Add(dog);
            vetAnimals.Add(poodle);

            foreach (var animal in vetAnimals)
            {
                Console.WriteLine(animal.Name);

                // This is Polymorphism Validation. we are asking "is our animal a dog?"
                // and IF IT IS, we then store our animal variable into a dogAnimal variable.
                // then in our if statement, we can then access dog propertys.  this is a 
                // safe way to CAST DOWN into your type.
                if (animal is Dog dogAnimal)
                {
                    Console.WriteLine(dogAnimal.IsAGoodDog);
                }

                Console.WriteLine(animal.MakeNoise());
            }

            Console.WriteLine(dog.IsAGoodDog);

            // Inheritance chain.. Dog <== Animal <== Object
            var dogOne = new Dog();

            // Inheritance chain.. Dog <== Animal <== Object
            var dogTwo = new Dog();

            // Inheritance chain.. Dog <== Animal <== Object
            var dogThree = new Dog();

            var animalsTwo = new List<Animal>();

            animalsTwo.Add(dogOne);
            animalsTwo.Add(dogTwo);
            animalsTwo.Add(dogThree);

            foreach (Animal animal in animalsTwo)
            {
                // Because our compile can see that Dog Inherits from Animal, we can 
                // explicitly CAST our Animal into a Dog.  
                // WARNING!!! AVOID DOING THIS IF YOU ARE NOT 100% SURE!!!
                Dog actuallyADog = (Dog)animal;
                Console.WriteLine(actuallyADog.IsAGoodDog);
            }


            // PolyMorphism Logging example
            var loggers = new List<LoggerBase>();
            loggers.Add(new EmailLogger());
            loggers.Add(new ConsoleLogger());
            loggers.Add(new TextMessageLogger());
            loggers.Add(new DatabaseLogger());

            foreach (var logger in loggers)
            {
                logger.Log("logging my message");
            }

        }

        public static string GetMessage()
        {
            return "message";
        }
    }

    // Inheritance chain .. Student <== Object
    public class Student
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string City { get; set; }
    }

    // Inheritance chain .. AfterHoursStudent <== Object
    public class AfterHoursStudent : Student
    {

    }

    public class Animal
    {
        public int Age { get; set; }
        public string Name { get; set; }

        public virtual string MakeNoise() 
        {
            return "uRgghhhhlaalsdkfj lk o;jas";
        }
    }


    // Inheritance chain.. Dog <== Animal <== Object
    public class Dog : Animal
    {
        public bool IsAGoodDog { get; set; }


        public override string MakeNoise()
        {
            return "Bark!";
        }
    }

    // Inheritance chain....  Cat <== Animal <== Object
    public class Cat : Animal
    {
        public bool IsAddictedToCatNip { get; set; }

        public override string MakeNoise()
        {
            return "Meow!";
        }
    }


    // Inheritance chain... Poodle <== Dog <== Animal <== Object
    public class Poodle : Dog { }


    public class Room
    {
        public int Length { get; set; }

        public int Width { get; set; }

        public int Height { get; set; }

        public double Peremiter => 2 * (Width + Length);

        public double Area => Length * Width;

        public double Volume => Area * Height;

        public string GetVolumeWithMessage(string message)
        {                                                                                                                                                                           
            return $"Volume: {Volume}, Message: {message}";
        }

    }
        
    public interface IMotor
    {
        string Cylinders { get; set; }
    }

    public interface ITransmission
    {
        bool IsManual { get; set; }
    }

    public class Car : IMotor, ITransmission
    {
        public string Cylinders { get; set; }
        public bool IsManual { get; set; }
    }

    public class LawnMower : IMotor
    {
        public string Cylinders { get; set; }
    }


    public class Point
    {
        public int X { get; set; }
        public int Y { get; set; }


        public override string ToString() => $"X: {X}, Y: {Y}";
    }


    public abstract class LoggerBase
    {
        public abstract void Log(string message);
    }

    public class ConsoleLogger : LoggerBase
    {
        public override void Log(string message)
        {
            Console.WriteLine(message);
        }
    }

    public class EmailLogger : LoggerBase
    {
        public override void Log(string message)
        {
            // Send an email to log your stuff
        }
    }

    public class TextMessageLogger : LoggerBase
    {
        public override void Log(string message)
        {
            // Send a text message
        }
    }

    public class DatabaseLogger : LoggerBase
    {
        public override void Log(string message)
        {
            // Send a log to a database
        }
    }
}
