using FizzBuzz.Classes;
using Xunit;

namespace test
{
    public class BuzzTest
    {
        [Fact]
        public void Handle_ShouldBuzz_WhenGivenNumberIsDivisibleBy5()
        {
            var buzz = new Buzz();

            Assert.Equal("Buzz", buzz.Handle(5));
        }

        [Fact]
        public void Handle_ShouldReturnGivenNumberAsString_WhenGivenNumberIsNotDivisibleBy5()
        {
            var buzz = new Buzz();

            Assert.Equal("3", buzz.Handle(3));
        }
    }
}