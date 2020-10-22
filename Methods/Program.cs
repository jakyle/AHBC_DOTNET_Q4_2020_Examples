using System;
using System.Text.RegularExpressions;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            ExampleMathFunctions();

            // Validation Method
            AskValidatePhoneNumber();
        }

        private static void ExampleMathFunctions()
        {
            int a = AddNumbers(3, 5, 2);

            int b = AddNumbers(8, 3);

            int c = AddNumbers(a, b);

            int d = AddNumbers(a, b) + AddAndMultiplyNumber(3, 5, out int multipliedNumber);

            bool isPoitiveNumbers = TryAddPositiveNumbers(5, 2, out int x);

            bool isNotPositive = TryAddPositiveNumbers(-5, 2, out int y);

            Console.WriteLine($"positive value: {x}, default value: {y}");

            SayHelloToConsole();

            Console.WriteLine($"your total number is... a:{a}, b:{b}, c:{c}");
        }

        private static void AskValidatePhoneNumber()
        {
            bool correctPhoneNumber = false;
            do
            {

                Console.WriteLine("Hello user, can you please give me your phone number?");
                string userInput = Console.ReadLine();

                if (ValidatePhoneNumber(userInput))
                {
                    Console.WriteLine("Hey, thats one valid phone number guy! :D");
                    correctPhoneNumber = false;
                }
                else
                {
                    Console.WriteLine("Hey user... this is an invalid phone number ___*( ￣皿￣)/#____");
                    correctPhoneNumber = true;
                }
            } while (correctPhoneNumber);
        }

        static void AskToValidatePhoneNumber()
        {

        }


        static bool ValidatePhoneNumber(string phoneNumber) 
        {
            Regex pattern = new Regex(@"^((\(\d{3}\) )|(\d{3}-))\d{3}-\d{4}$");

            return pattern.IsMatch(phoneNumber);
        }


        static int AddNumbers(int x, int y, int z)
        {
            int total = x + y + z;
            return total;
        }

        static int AddNumbers(int x, int y)
        {
            return x + y;
        }

        static int MultiplyNumbers(int w, int x, int y)
        {
            return w * x * y;
        }


        static int AddNumbers(double ello, double gov, double nuh)
        {
            double total = ello + gov + nuh;
            return (int)total;
        }


        static bool TryAddPositiveNumbers(int x, int y, out int z)
        {
            if (x > 0 && y > 0)
            {
                z = x + y;
                return true;
            }

            z = default;
            return false;
        }



        static int AddAndMultiplyNumber(int x, int y, out int z)
        {
            z = x * y;
            return x + y;
        }

        static void SayHelloToConsole()
        {
            Console.WriteLine("Hello console tee hee ;)");
        }

    }
}
