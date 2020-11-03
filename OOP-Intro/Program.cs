using System;
using System.Collections.Generic;

namespace OOP_Intro
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");


            // CREATING an instance OF Animal into memory, or INSTANTIATING and OBJECT into MEMORY!
            var animalOne = new Animal(1, "Coco");
            var annimalTwo = new Animal(2, "Barny");

            // GETTING the property values in our Instance object
            Console.WriteLine(animalOne.GetNameAndAge());
            Console.WriteLine(animalOne.GetNameAndAgeMinusFive());
            var animalAge = animalOne.Age;
        }
    }


    // Classes are BLUE PRINT that DESCRIBE how your OBJECT will look and behave
    public class Animal 
    {

        // A FIELD is a PRIVATE Member or Variable that Exists inside the class level.
        private int _age;

        // A Constructor is a METHOD that is called when you Instantiate an object into memory.
        public Animal(int age, string name)
        {
            Name = name;
            Age = age;
        }

        // This is what the DEFAULT constructor looks like, all classes HAVE ONE, if you do NOT define one, 
        //// this is what you get
        //public Animal()
        //{

        //}


        // A property is a PUBLICLY exposed DATA that lives as a MEMBER in an INSANTIATED object.  
        // public meaning, classes OUTSIDE of this class will have ACCESS to it

        // this is an AUTO PROPERTY
        public string Name { get; set; }



        // This is a regular ol' Property
        public int Age 
        {
            get
            {
                return _age;
            }
            
            set
            {
                _age = value;
            }
        }

        // A METHOD is a FUNCTION that exists as a MEMBER inside of a class
        // this is a PUBLIC method which means we can access said member (method)
        // outside of this class.
        public string GetNameAndAge()
        {
            var nameAndAge = $"Animals Age: {Age}, Animals Name: {Name}";

            return nameAndAge;
        }

        public string GetNameAndAgeMinusFive()
        {
            var nameAndAge = $"Animal Age Minus Five: {GetAgeMinusFive()}, Animals Name: {Name}";
            return nameAndAge;
        }
        
        // PRIVATE Members (method in this case) can ONLY be accessed by members within it's own class
        private int GetAgeMinusFive() 
        {
            return Age - 5;
        }
     }

    public class HotDog
    {
        public bool IsTastey { get; set; }
        public List<string> Condiments { get; set; }


        public void Eat() 
        {
            // some code that reflects eating said hot dog
        }

        public void Throw()
        {
            // ccode to describe throwing
        }

        public void AddCondiment(string comdiment)
        {
            Condiments.Add(comdiment);
        }
    }


    public class PeanutButterJar
    {
        public string Material { get; set; }
        public string LidColor { get; set; }
        public bool HasContent { get; set; }

        public void OpenLid() 
        {
            // some code to open lid
        }

        public void CloseLid()
        {
            // code to handle lid
        }

        public void Throw()
        {
            // some code to handle throwing peanut butter jar
        }
    }



    public class Frog
    {
        public string Color { get; set; }
        public bool IsPoisonous { get; set; }
        public int PoisinSeverity { get; set; }
        public int Size { get; set; }


        public bool WillThisKillYou()
        {
            // logic to figure out if the poison level in this frog will kill you or not
            return true;
        }
    }

    public class SanitaryWipes
    {
        public string Brand { get; set; }
        public string Type { get; set; }
        public string Color { get; set; }
        public uint Count { get; set; }

        public int RemoveWipe()
        {
            Count--;
            return 1;
        }
    }

    public class ComputerChair
    {
        public string Color { get; set; }
        public int WheelCount { get; set; }
        public bool HasArms { get; set; }
        public int AdjustmentHeight { get; set; }

        public void SetAdjustHeight(int height) 
        {
            AdjustmentHeight = height; 
        }

        public void Sit()
        {
            // some sort of code to describe sitting in a chair
        }
     }
}
