using System;

namespace UnitTesting101
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }


    public class SimpleMath
    {
        public double ConvertToCelsius(double f)
        {
            var result = (f - 32) * 5 / 9;
            return result;
        }
        

        public int GetAreaOfRoom(int length, int width)
        {
            return length * width;
        }  

        public bool IsOldEnoughToDrink(int age)
        {
            if (age >= 21)
            {
                return true;
            }

            return false;
        }
    }
}
