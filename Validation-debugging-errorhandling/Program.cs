using System;
using System.Globalization;
using System.Text.RegularExpressions;

namespace Validation_debugging_errorhandling
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Hello World!");


                // intro
                Intro();
                // body

                IntParseExample();

                DateTimeParseExample();

                ExceptionHandlingExample();
                // 012 
                string errorexample = "123";
                
                if (errorexample.Length > 2)
                {
                    throw new IndexOutOfRangeException($"error occured when user tried to input of length: {errorexample.Length}. var name: {nameof(errorexample)}");
                }

                char letter = errorexample[8];

                bool notHotDog = IsSandwhich("hotdog");

                // conclusion

                // logic recap
            }
            catch (FormatException e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine(e.StackTrace);
            }
            catch (IndexOutOfRangeException e) 
            {
                Console.WriteLine(e.Message);
                Console.WriteLine(e.StackTrace);
            }
            catch (HotDogException e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine(e.StackTrace);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine(e.StackTrace);
            }
            finally
            {
                Console.WriteLine("Application is closing...3...2...1...boom 😍");
                Console.ReadLine();
            }

        }

        private static void ExceptionHandlingExample()
        {
            int x = int.Parse(Console.ReadLine());
        }

        static void DateTimeParseExample()
        {
            Console.WriteLine("what is your birth date?");
            string userInput = Console.ReadLine();

            // 2011-29-01
            if (DateTime.TryParse(userInput, 
                "yyyy-dd-MM", 
                CultureInfo.InvariantCulture, 
                DateTimeStyles.None, 
                out DateTime birthDate)
            )
            {
                Console.WriteLine($"oh cool....{birthDate}");
            }
            else
            {
                Console.WriteLine("This is an invlalid date");
            }

        }
        
        static string GetSSN()
        {
            do
            {
                Console.WriteLine("Please provide a social security number (～￣▽￣)～");
                string ssn = Console.ReadLine();

                if (SsnIsValid(ssn))
                {
                    return ssn;
                }
                else
                {
                    Console.WriteLine("Invalid input try again!");
                }

            } while (true);
        }

        static bool SsnIsValid(string ssn) => Regex.IsMatch(ssn, @"^\d{3}(-| )\d{2}(-| )\d{4}$");


        static void Intro()
        {
            Console.WriteLine("all sorts of intro stuff");
        }

        static void IntParseExample()
        {
            Console.WriteLine("how old are you????????????????");
            string ageInput = Console.ReadLine();  //"22" ->  22

            if (int.TryParse(ageInput, out int age))
            {
                if (IsOldEnoughToDrink(age))
                {
                    Console.WriteLine("you are old enough to drink... sorry it's my first day... what do you want?");
                }
                else
                {
                    Console.WriteLine("you are not old enough to drink");
                }
            }
            else
            {
                Console.WriteLine("invalid number, please provide a valid age");
            }

        }

        static bool IsNegativeNumbers(int x, int y) =>  x < 0 && y < 0;

        static bool IsOldEnoughToDrink(int age) => age >= 21;

        static bool IsOldEnoughToDrink(int ageOne, int ageTwo)
        {
            return ageOne >= 21 && ageTwo >= 21;
        }

        static void PrintMessage(string message) => Console.WriteLine(message);


        static bool IsSandwhich(string sandwich)
        {
            if (sandwich.Equals("hotdog", StringComparison.OrdinalIgnoreCase))
            {
                throw new HotDogException("Hot dogs... are not sandwiches...");
            }

            return true;
        }

    }


    public class HotDogException : Exception 
    {
        public HotDogException(string message) : base(message) { }
    }

}
