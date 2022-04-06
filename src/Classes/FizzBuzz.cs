using FizzBuzz.Interface;
using System;

namespace FizzBuzz.Classes
{
    public class FizzBuzz : IFizzBuzzHandler
    {
        public string Handle(int number)
        {
            return "FizzBuzz";
        }

        public bool IsDivisible(int number)
        {
            return number % 3 == 0 && number % 5 == 0;
        }
    }
}
