using FizzBuzz.Classes;
using FizzBuzz.Interface;
using Moq;
using Xunit;

namespace test
{
    public class FizzTest
    {
        [Fact]
        public void Handle_ShouldFizz_WhenGivenNumberIsDivisibleBy3()
        {
            var mock = new Mock<IFizzBuzzHandler>();
            var fizzHandler = new Fizz(mock.Object);

            Assert.Equal("Fizz", fizzHandler.Handle(3));
        }

        [Fact]
        public void Handle_ShouldPassTheInputToNextFizzHandler()
        {
            const int input = 5;
            var mock = new Mock<IFizzBuzzHandler>();
            mock.Setup(x => x.Handle(It.IsAny<int>())).Returns("FizzBuzzHandler-Answer");
            var fizzHandler = new Fizz(mock.Object);

            Assert.Equal("FizzBuzzHandler-Answer", fizzHandler.Handle(input));
            mock.Verify(x => x.Handle(It.Is<int>(number => number == input)));
        }
    }
}