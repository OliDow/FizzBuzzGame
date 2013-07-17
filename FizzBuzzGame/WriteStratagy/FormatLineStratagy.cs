using System;
using FizzBuzzGame.CalcStratagy;

namespace FizzBuzzGame.WriteStratagy
{
    public class FormatLineStratagy : IFormatLineStratagy
    {
        #region Constructor
        public FormatLineStratagy()
        {
            _divisibleByThreeStratagy = new DivisibleByThreeStratagy();
            _divisibleByFiveStratagy = new DivisibleByFiveStratagy();
        }
        #endregion

        #region Methods
        
        public string FormatLine(int i)
        {
            bool isDivisibleByThree = _divisibleByThreeStratagy.CanHandle(i);
            bool isDivisibleByFive = _divisibleByFiveStratagy.CanHandle(i);

            string result = string.Empty;

            if (isDivisibleByThree)
                result += _divisibleByThreeStratagy.Handle();

            if (isDivisibleByFive)
                result += _divisibleByFiveStratagy.Handle();

            if (!isDivisibleByThree && !isDivisibleByFive)
                result += i;

            //if(i != 100)

            return result;


            //return isDivisibleByThree ? _divisibleByThreeStratagy.Handle() : i.ToString();
        }

        #endregion

        #region Properties

        private readonly CalculationStratagy _divisibleByThreeStratagy;
        private readonly CalculationStratagy _divisibleByFiveStratagy;

        #endregion
    }
}
