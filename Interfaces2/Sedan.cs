using System;

namespace Interfaces2.Cars
{
    // "HAS A" relationship describes a class "HAVING SAID FEATURES'
    // Not a POCO, just a class that describes Behavior, typically you will
    // this is where you will see interfaces get implemented.
    public class Sedan : VehicleBase, ITransmission, IMotor, IConvertible
    {
        private int _currentGear = 1;
        private bool _isTopDown = false;
        private bool _isEngineRunning = false;



        public int ChangeGear(int gear)
        {
            if (gear >= 1 && gear <= 3)
            {
                _currentGear = gear;
            }
            else
            {
                Console.WriteLine($"entered {nameof(gear)}: {gear}, is an invalid gear number, please enter shift to a gear between 1 - 3");
            }

            return _currentGear;
        }

        public void ChangeOil()
        {
            Console.WriteLine("Engine Started!");
        }

        public override void OpenDoor()
        {
            Console.WriteLine("Door opened!");
        }

        public void PutTopDown()
        {
            _isTopDown = !_isTopDown;
        }

        public bool StartEngine()
        {
            _isEngineRunning = !_isEngineRunning;
            return _isEngineRunning;
        }
    }

}

