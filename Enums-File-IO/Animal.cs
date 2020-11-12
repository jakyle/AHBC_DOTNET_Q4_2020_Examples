using System;

namespace Enums_File_IO
{
    public class Animal : LifeBase
    {
        public override void Breathe()
        {
            Console.WriteLine("I got lungs duuuuude!");
        }

        public virtual string MakeNoise()
        {
            return "ASDKFAJSDLFK";
        }
    }
}
