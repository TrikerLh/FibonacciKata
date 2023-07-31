using FluentAssertions;

namespace FibonacciKata.Tests {
    public class FibonacciShould {
        [TestCase(0, 0)]
        [TestCase(1, 1)]
        [TestCase(6, 8)]
        [TestCase(17, 1597)]
        public void Return_fibonacci(int number, int expected)
        {
            var result = Fibonacci.Get(number);

            result.Should().Be(expected);
        }
    }
}