namespace FizzBuzz.Interface
{
    public interface IFizzBuzzHandler
    {
        public bool IsDivisible(int number);
        string Handle(int number);
    }
}
