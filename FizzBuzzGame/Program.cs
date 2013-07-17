using System;
using System.Collections.Generic;
using System.Linq;
using FizzBuzzGame.Main;

namespace FizzBuzzGame
{
    class Program
    {
        static void Main(string[] args)
        {
            IEnumerable<int> intList = Enumerable.Range(1, 100).Select(x => x);

            IFizzBuzz fizzBuzz = new FizzBuzz();
            fizzBuzz.Execute(intList);

            Console.ReadLine();
        }
    }
}
