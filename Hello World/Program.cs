using System;

namespace Hello_World
{
    class Program
    {
        static void Main(string[] args)
        {


            // Your compiler will totally ignore this line of code!
            Console.WriteLine("Hello World!");


            const double PIE = 3.14;

            string adam = "Adam";



            // string userInput = Console.ReadLine();

            Console.WriteLine("you typed in: {{{userInput}}}");

            // Value types

            // integer types or "whole" numbers
            int a = 11; // whole numbers, most popular
            long b = 22; // double the potential size of an integer.

            // decimal types
            float c = 11.1f;
            double d = 22.2d; // most popular
            decimal e = 22.23m;

            // misc scalr types
            bool isAFact = true;
            bool isNotAFact = false;

            // Referency Types... that will make sense later
            string otherName = "Benny";

            Console.WriteLine($"Original Value of variable a: {a}");

            a = 23;

            Console.WriteLine($"new value for variable a: {a}");

            // Math and stuff

            double answer = (2 * 3) + 2 * (5 * 12) / 2;

            Console.WriteLine($"our answer is: {answer}");


            // operators

            double addition = 1 + 1;
            double subtraction = 2 - 1;
            double multiplication = 2 * 2;
            double division = 12 / 4;

            int modulus = 12 % 5;


            // assignment
            double additionalAssignment = 5;

            // long form
            additionalAssignment = additionalAssignment + addition;

            // short form
            additionalAssignment += addition;
            additionalAssignment -= subtraction;
            additionalAssignment *= multiplication;
            additionalAssignment /= division;
            additionalAssignment %= modulus;

            Console.ReadLine();

            // implicit Casting

            int castingExample = 22;
            double iJustCastedYou = castingExample;

            // explicit casting
            double doubleToInt = 22.4;
            int castedDouble = (int)doubleToInt;

            string castNumber = "22";
            int castedFromString = int.Parse(castNumber);

            // Intro to Conditionals, relational operators

            int age = 21;

            bool canDrink = age == 21;
            bool canDrinkLessThan = age < 20;
            bool canDrinkGreaterThan = age > 20;
            bool canDrinkLessThanEqual = age <= 20; // < =
            bool canDrinkGreaterThanEail = age >= 20; // > =
            bool cannotDrink = age != 21;

            // Logical Operators

            bool hasLicense = true;

            bool hasLicenseAndCanDrink = canDrink && hasLicense;
            bool hasLIcenseOrCanDrink = canDrinkLessThan || hasLicense;
            bool hasNoLicenseNotOfAge = !hasLicenseAndCanDrink;

            // if statement

            if (age == 21)
            {
                string onlyInThisScope = "I don't live very long :(";
                Console.WriteLine(hasLicense);
                Console.WriteLine("what do you want to drink my dude!");
            }
            else if (hasLIcenseOrCanDrink)
            {
                // Console.WriteLine(onlyInThisScope);
                Console.WriteLine("eh, good enough, I guess, come on in.. drink, I don't care");
            }
            else if (hasNoLicenseNotOfAge)
            {
                //hin 
            }
            else // run code IF above is false
            {
                Console.WriteLine("You are not old enough to drink, scram kid!");
            }

            if (hasNoLicenseNotOfAge)
            {
                // do the things
            }

        }
    }
}
