using Xunit;

namespace test
{
    public class FizzBuzzTest
    {
        [Fact]
        public void Handle_ShouldFizzBuzz_WhenGivenNumberIsDivisibleByBoth3And5()
        {
            var fizzBuzzHandler = new FizzBuzz.Classes.FizzBuzz();

            Assert.Equal("FizzBuzz", fizzBuzzHandler.Handle(15));
        }

        [Fact]
        public void Handle_ShouldInputValueAsString_WhenGivenNumberIsNotDivisibleByBoth3And5()
        {
            const int input = 5;
            var fizzBuzzHandler = new FizzBuzz.Classes.FizzBuzz();

            Assert.Equal("5", fizzBuzzHandler.Handle(input));
        }
    }
}