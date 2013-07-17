namespace FizzBuzzGame.CalcStratagy
{
    public abstract class CalculationStratagy
    {
        public abstract bool CanHandle(int value);
        public abstract string Handle();
    }
}
