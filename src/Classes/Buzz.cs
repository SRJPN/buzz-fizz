using FizzBuzz.Interface;

namespace FizzBuzz.Classes
{
    public class Buzz : IFizzBuzzHandler
    {
        public string Handle(int number)
        {
            return "Buzz";
        }

        public bool IsDivisible(int number)
        {
            return number % 5 == 0;
        }
    }
}
