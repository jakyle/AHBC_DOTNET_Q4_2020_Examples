public class Batter : ISwing
{
    public bool SwingBat(BaseBall ball)
    {
        if (ball.Speed < 90.52)
        {
            return true;
        }

        return false;
    }
}