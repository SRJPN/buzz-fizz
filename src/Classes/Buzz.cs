using FizzBuzz.Interface;
using System;

namespace FizzBuzz.Classes
{
    public class Buzz : IFizzBuzzHandler
    {
        public string Handle(int number)
        {
            if (number % 5 == 0)
                return "Buzz";
            return number.ToString();
        }
    }
}
