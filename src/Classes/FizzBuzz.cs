using FizzBuzz.Interface;
using System;

namespace FizzBuzz.Classes
{
    public class FizzBuzz : IFizzBuzzHandler
    {
        public string Handle(int number)
        {
            if (number % 3 == 0 && number % 5 == 0)
                return "FizzBuzz";
            return number.ToString();
        }
    }
}
