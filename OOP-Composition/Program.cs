using System;
using System.Collections.Generic;

namespace OOP_Composition
{
    class Program
    {
        static void Main(string[] args)
        {
            var motors = new List<IMotor>();

            motors.Add(new Car());
            motors.Add(new LawnMower());

            foreach (var motor in motors)
            {
                Console.WriteLine(motor.Cylinders);
            }


            // back to oop for a second
        }
    }


    public class Room
    {
        public int Length { get; set; }

        public int Width { get; set; }

        public int Height { get; set; }

        public double Peremiter => 2 * (Width + Length);

        public double Area => Length * Width;

        public double Volume => Area * Height;

        public string GetVolumeWithMessage(string message)
        {                                                                                                                                                                           
            return $"Volume: {Volume}, Message: {message}";
        }

    }
        
    public interface IMotor
    {
        string Cylinders { get; set; }
    }

    public interface ITransmission
    {
        bool IsManual { get; set; }
    }

    public class Car : IMotor, ITransmission
    {
        public string Cylinders { get; set; }
        public bool IsManual { get; set; }
    }

    public class LawnMower : IMotor
    {
        public string Cylinders { get; set; }
    }
}
