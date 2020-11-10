using System;

namespace Interfaces2.Cars
{

    // Truck is IMPLEMENTING ITransmission and IMotor, which means a Truck needs to DEFINE the behavior for any MEMBERS
    // that exist inside of said interfaces.
    public class Truck : VehicleBase, ITransmission, IMotor
    {
        private int _currentGear;


        // This method is described as a Member of ITransmission.  This Member (Method in this case) HAS to
        // exist inside of this class in order to compile because we are declaring that Truck Implements
        // ITransmission
        public int ChangeGear(int gear)
        {
            if (gear >= 1 && gear <= 4)
            {
                _currentGear = gear;
            }
            else
            {
                Console.WriteLine($"entered {nameof(gear)}: {gear}, is an invalid gear number, please enter shift to a gear between 1 - 4");
            }

            return _currentGear;
        }

        public void ChangeOil()
        {
            throw new NotImplementedException();
        }

        public override void OpenDoor()
        {
            throw new NotImplementedException();
        }

        public bool StartEngine()
        {
            throw new NotImplementedException();
        }
    }
}

