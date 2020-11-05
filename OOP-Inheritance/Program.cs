using System;

namespace OOP_Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            // var animal = new AnimalBase();

            // CANNOT access because this is private!
            // animal._cells = new string[] { "help me class.." };

            var dog = new Dog();
            var otherDog = new Dog(2, "Rex");

            dog.Name = "Coco";
            dog.Age = 1;
            dog.Owner = "James";
            dog.Breed = "Lab";

            var husky = new Husky();

            // Husky CANNOT call ANY of these members because it is TRYING to inherit from Dog but
            //
            // CANNOT becuase DOG is a sealed class!
            // husky.Age = 2;
            // husky.Name = "Huskell";
            // var barkMessage = husky.Bark();
            // husky.Owner = "Mike";
            // husky.Breed = "Husky";

            var cat = new Cat();
            cat.Name = "Oreo";
            cat.Age = 8;

            // This is inaccassible because it's NOT PUBLIC
            // dog._dna = new string[] { "ABBDCSS" };

            // animal.Breed = "Tiger";

            Console.WriteLine(dog.Bark());
            Console.ReadLine();
        }
    }

    // Abstract CLASSES are classes that CANNOT insantiate an OBJECT INTO MEMORY!
    public abstract class AnimalBase
    {
        private string[] _cells;

        // the PROTECTED modifier allows a class to INHERIT this member Pravitly.  this 
        // means that OUTSIDE the inhertince chain, you will NOT be able to access this member.
        protected string[] _dna; 

        // Contructor Member is just a METHOD that gets called when you 
        // construct your object into memory
        public AnimalBase(int age, string name)
        {
            Age = age;
            Name = name;
        }

        public AnimalBase() 
        {
            
        }

        public int Age { get; set; }
        public string Name { get; set; }
    }

    public class Cat: AnimalBase 
    {
        public bool LovesOwner { get; set; }

    }

    // Dog is INHERITING from AnimalBase, by INHERITING from a Base class, Dog has
    // Access to ALL NON Private members!
    // ie, a Dog instance will BE ABLE to CALL Age and Name.
    // Dog is also Sealed! a sealed class CANNOT be inherited from
    public sealed class Dog : AnimalBase
    {

        // Classes DO NOT Directly Inherit constructors, a child class has to EXPLICITLY 
        // INHERIT the constructor using this syntax below.  by calling your Constructor
        // floowed by ':' then base(), you are CALLING the base classes CONSTRUCTOR!
        // in this case, we are calling the Animal Constructor that takes in age and name
        // as it's arguments/parameters.
        public Dog(int age, string name) 
            : base(age, name)
        {

        }

        public Dog()
        {

        }

        public string Owner { get; set; }
        public string Breed { get; set; }

        public string Bark()
        {
            // We are able to access this field within DOG because _dna has the PROTECTED access modifier, 
            // which allows a class to privately acccess a field WITHIN the inheritence chain.
            var dna = _dna;


            // this 'this' keyword points this SPECIFIC INSTANCE of a dog in memory.
            // this means this CANNOT access any OTHER instance of a dog, the dog in queustion.
            // using dot notation, you can access any member of 'this' instance just like you would
            // when accessing an instance variable object outside of this class.
            return $"Bork Bark, I love my owner {this.Owner}... bark";
        }
    }


    // this class CANNOT inherit from the dog class because the Dog class is SEALED.  a SEALED class CANNOT be 
    // inherited from!
    public class Husky /*:  Dog */
    {
        public int HairLength { get; set; }
    }


    // a Super class CAN inherit from husky, nothing stopping this
    // as a warning though, TRY to avoid anything MORE than two level inheritence, 
    // it starts to create harder to maintain code!
    public class SuperHusky : Husky
    {
        ///
    }
}
