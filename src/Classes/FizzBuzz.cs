using FizzBuzz.Interface;

namespace FizzBuzz.Classes
{
    public class FizzBuzz : IFizzBuzzHandler
    {
        private readonly IFizzBuzzHandler fizzBuzzHandler;

        public FizzBuzz(IFizzBuzzHandler fizzBuzzHandler)
        {
            this.fizzBuzzHandler = fizzBuzzHandler;
        }

        public string Handle(int number)
        {
            if (number % 3 == 0 && number % 5 == 0)
                return "FizzBuzz";
            return fizzBuzzHandler.Handle(number);
        }
    }
}
