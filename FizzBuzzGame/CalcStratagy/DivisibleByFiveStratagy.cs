namespace FizzBuzzGame.CalcStratagy
{
    public class DivisibleByFiveStratagy : CalculationStratagy
    {
        public override bool CanHandle(int value)
        {
            return value % 5 == 0;
        }

        public override string Handle()
        {
            return "Buzz";
        }
    }
}
