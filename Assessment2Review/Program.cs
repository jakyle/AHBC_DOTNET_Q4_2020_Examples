using System;
using System.Collections.Generic;

namespace Assessment2Review
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                var numbers = new List<int>();
                numbers.Add(1);
                numbers.Add(2);
                numbers.Add(5);
                var totalOdds = GetTotalOdds(numbers);

            }
            catch (IndexOutOfRangeException e)
            {

            }
            catch (Exception)
            {

                throw;
            }



            Console.WriteLine("Hello World!");
        }

        static int GetTotalOdds(List<int> numbers)
        {
            var total = 0;

            foreach (var digit in numbers)
            {
                if (digit % 2 != 0)
                {
                    total++;
                }
            }

            return total;
        }

        static int GetTotalOdds(int[] numbers) 
        {
            var total = 0;

            foreach (var digit in numbers)
            {
                if (digit % 2 != 0)
                {
                    total++;
                }
            }

            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    int digit = numbers[i];
            //    if (digit % 2 != 0)
            //    {
            //        total++;
            //    }
            //}

            return total;
        }


        public static bool CheckName(string userName)
        {
            try
            {
                if (userName.Equals("James", StringComparison.OrdinalIgnoreCase))
                {
                    return true;
                }
                else
                {
                    throw new ArgumentOutOfRangeException(nameof(userName) ,"This is not James!!!");
                }
            }
            catch (ArgumentOutOfRangeException exception)
            {

                Console.WriteLine(exception.Message);
            }
        }
    }
}
