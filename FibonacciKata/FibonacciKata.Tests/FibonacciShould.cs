using FluentAssertions;

namespace FibonacciKata.Tests {
    public class FibonacciShould {
        [Test]
        public void Return_0()
        {
            var result = Fibonacci.Get(0);

            result.Should().Be(0);
        }

        [Test]
        public void Return_1() {
            var result = Fibonacci.Get(1);

            result.Should().Be(1);
        }

        [Test]
        public void Return_8() {
            var result = Fibonacci.Get(6);

            result.Should().Be(8);
        }
    }
}