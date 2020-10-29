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



            // Reference Types

            int[] refExample = new int[3] { 1, 2, 3 };

            int[] otherRef = refExample;

            int[] copyArray = new int[3];
            for (int i = 0; i < refExample.Length; i++)
            {
                copyArray[i] = refExample[i];
            }


            otherRef[1] = 5;

            Console.WriteLine(refExample[1]);

            // two-dimensional arrays
            // rectangular 2d array
            int[,] matrix = new int[2,2];

            int acc = 0;
            for (int y = 0; y < matrix.GetLength(0); y++)
            {
                for (int x = 0; x < matrix.GetLength(1); x++)
                {
                    Console.WriteLine($"x: {x}, y: {y}");
                    matrix[x, y] = acc;
                    acc++;  
                }
            }


            int[][] jaggedArray = new int[][]
            {
                new int[3] { 1, 2, 3},
                new int[2] { 4, 5 },
                new int[5] { 7, 8, 9, 10, 11}
            };

            acc = 0;
            for (int i = 0; i < jaggedArray.Length; i++)
            {
                for (int j = 0; j < jaggedArray[i].Length; j++)
                {
                    Console.WriteLine($"i: {i}, j: {j}");
                    jaggedArray[i][j] = acc;
                    acc++;
                }
            }


            // FOR EACH LOO,< WTF!!!
            string[] subjects = new string[] { "math", "english", "gym", "biology"};

            foreach (string subject in subjects) 
            {
                Console.WriteLine(subject);
            }

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
