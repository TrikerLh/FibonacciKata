using FluentAssertions;

namespace FibonacciKata.Tests {
    public class FibonacciShould {
        [Test]
        public void Return_0()
        {
            var result = Fibonacci.Get(0);

            result.Should().Be(0);
        }
    }
}