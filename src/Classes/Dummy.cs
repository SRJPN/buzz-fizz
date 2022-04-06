using FizzBuzz.Interface;

namespace src.Classes
{
    public class Dummy : IFizzBuzzHandler
    {
        public string Handle(int number)
        {
            return number.ToString();
        }

        public bool IsDivisible(int number)
        {
            return true;
        }
    }
}