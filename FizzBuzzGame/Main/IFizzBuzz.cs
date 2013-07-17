using System.Collections.Generic;

namespace FizzBuzzGame.Main
{
    public interface IFizzBuzz
    {
        void Execute(IEnumerable<int> intList);
    }
}
