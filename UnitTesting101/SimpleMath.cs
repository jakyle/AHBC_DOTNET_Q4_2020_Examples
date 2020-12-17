namespace UnitTesting101
{
    public class SimpleMath
    {
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
