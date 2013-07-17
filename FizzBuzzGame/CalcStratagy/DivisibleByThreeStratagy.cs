namespace FizzBuzzGame.CalcStratagy
{
    public class DivisibleByThreeStratagy : CalculationStratagy
    {
        public override bool CanHandle(int value)
        {
            return value % 3 == 0;
        }

        public override string Handle()
        {
            return "Fizz";
        }
    }
}
