using System;
using Xunit;

namespace fizzBuzz.Tests
{
    public class fizzBuzzTests
    {
        [Fact]
        public void Get_Returns_1_for_1()
        {
            var fizzBuzz = new FizzBuzz();

            var result = fizzBuzz.Get(1);

            Assert.Equal("1", result);
        }
      
        [Fact]
        public void Get_Returns_2_for_2()
        {
            var fizzBuzz = new FizzBuzz();

            var result = fizzBuzz.Get(2);

            Assert.Equal("2", result);
        }

    }
}
