using System;
using System.Collections.Generic;
using System.Linq;
using FizzBuzzGame.WriteStratagy;

namespace FizzBuzzGame.Main
{
    public class FizzBuzz : IFizzBuzz
    {

        #region Constructor
        public FizzBuzz()
        {
            _formatLineStratagy = new FormatLineStratagy();
        }
        #endregion

        public void Execute(IEnumerable<int> intList)
        {
            foreach (int i in intList)
            {
                Console.Write(_formatLineStratagy.FormatLine(i));

                if (i != intList.Last())
                    Console.Write(", ");
            }
        }

        #region Properties
        private FormatLineStratagy _formatLineStratagy;
        #endregion
    }
}
