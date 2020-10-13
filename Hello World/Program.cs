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

            double answer = (2 * 3) + 2*(5 * 12) / 2;

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

        }
    }
}
