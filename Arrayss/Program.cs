using System;

namespace Arrayss
{
    class Program
    {
        static void Main(string[] args)
        {

            // Debugging
            Console.WriteLine("Hello World!");

            string name = "James";

            if (IsJames(name))
            {
                Console.WriteLine("Hello, you are James!");
            }
            else
            {
                Console.WriteLine("You are not James!");
            }

            // Arrays dude!
            int[] numbers = new int[2];

            string[] names = new string[] { "Candace", "Jason", "Sam"};

            char[] letters = new[] { 'a', 'b', 'c', 'd' };

            // getting, setting data in an array!
            int firstNumber = numbers[0];

            numbers[1] = 5;

            Console.WriteLine($"this is our first number {firstNumber}!");

            Console.WriteLine($"this is our second value { numbers[1] }");

            Console.WriteLine($"names with length greater than 4: { GetNamesGreaterThanLength(names, 4) }");

            // Assessment Review
            int age = 13;
            bool isOldEnoughToDrink = IsOldEnoughToDrink(age);

            Console.ReadLine();
        }
    

        static int GetNamesGreaterThanLength(string[] names, int numberOfLetters)
        {
            int acc = 0;
            for (int i = 0; i < names.Length; i++)
            {
                string name = names[i];
                if (names[i].Length > numberOfLetters)
                {
                    acc++;
                }
            }

            return acc;
        }

        static int GetNamesGreaterThanLength(string[] names)
        {
            return GetNamesGreaterThanLength(names, 4);
        }

        static bool IsJames(string name)
        {
            if (name.Equals("james", StringComparison.OrdinalIgnoreCase))
            {
                return true;
            }

            return false;
        }

        static string GetOutitType(int orderNumber)
        {
            if (orderNumber == 2) 
            {
                return "Jacket";
            }
            else
            {
                return "shirt";
            }
        }

        static bool IsOldEnoughToDrink(int age) 
        {
            if (age >= 21) 
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        // static bool IsOldEnoughToDrink(int age) => age >= 21;
    }
}
