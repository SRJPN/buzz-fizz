using System;
using FizzBuzz.Interface;

namespace FizzBuzz.Classes
{
    public class Fizz : IFizzBuzzHandler
    {
        private readonly IFizzBuzzHandler _fizzBuzzHandler;

        public Fizz(IFizzBuzzHandler fizzBuzzHandler)
        {
            _fizzBuzzHandler = fizzBuzzHandler;
        }

        public string Handle(int number)
        {
            if (number % 3 == 0)
                return "Fizz";
           return _fizzBuzzHandler.Handle(number);
        }
    }
}
