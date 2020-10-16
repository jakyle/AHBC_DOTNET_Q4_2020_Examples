using System;

namespace For_Loop
{
    class Program
    {
        static void Main(string[] args)
        {
            bool isTrue = true;

            int number = 11;

            while (number < 10)
            {
                // do some thing I guess (￣ ‘i ￣;)

                // isTrue = false;

                number--;
            }

            // An alternate way to take in user input for Yes or No
            Console.WriteLine("Do you want to do the thing? [y/n]");

            ConsoleKey inputKey = Console.ReadKey().Key;

            if (inputKey == ConsoleKey.Y)
            {
                Console.WriteLine("Okay, I will do the thing");
            }
            else if (inputKey == ConsoleKey.N)
            {
                Console.WriteLine("okay, we won't do the thing");
            }
            else
            {
                Console.WriteLine("invalid input!");
            }


            // FOR LOOPS!!!  (please be patient with yourself on this one... it is the only way)

            // 1. Declare our index variable (do this only once)
            // -- start loop --
            // 2. check our boolean expression (ie. if this is true or false)
            //
            // IF TRUE 
            //  proceed to step 3.
            // IF FALSE 
            //   proceed to step 6.
            //
            // 3. run the code in the body of the for loop
            // 4. we either increment or decrement
            // 5. repeat step 2
            // 6. -- End loop --
            for (int i = 0; i < 10; i++) 
            {
                Console.WriteLine($"we are currently @ index: {i}");

                // you could have more code here.. etc. etc.
            }

            //
            // index          0123456789...  15       
            string letters = "abcdefghijklmnop";  // 
            // Length         123456789...   16
            for (int i = letters.Length - 1; i >= 0; i--)
            {
                char letter = letters[i];
                Console.WriteLine($"your current letter is: { letter }");
            }

            for (int i = 0; i < 10; i++)
            {
                if (i != 0 && i % 2 == 0)
                {
                    Console.WriteLine($"even number: {i}");
                } else if (i % 2 != 0) //
                {
                    Console.WriteLine($"odd number: {i}");
                }
                else
                {
                    Console.WriteLine("Youuuu might be a zero");
                }
            }

        }
    }
}
