using FizzBuzz.Interface;

namespace FizzBuzz.Classes
{
    public class Fizz : IFizzBuzzHandler
    {
        public string Handle(int number)
        {
            return "Fizz";
        }

        public bool IsDivisible(int number)
        {
            return number % 3 == 0;
        }
    }
}
