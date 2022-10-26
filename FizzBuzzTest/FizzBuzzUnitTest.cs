using FizzBuzz;
using Moq;
using Xunit;

namespace FizzBuzzTest
{
    public class FizzBuzzUnitTest
    {
        [Fact]
        public void Should_return_number_what_given()
        {
            //given
            FizzBuzz.FizzBuzz class1 = new FizzBuzz.FizzBuzz();
            int i = 1;
            //when
            string result = class1.GetString(i);
            //then
            Assert.Equal(1.ToString(), result);
        }

        [Fact]
        public void Should_return_Fizz_when_number_multiple_of_3()
        {
            //given
            FizzBuzz.FizzBuzz class1 = new FizzBuzz.FizzBuzz();
            int i = 3;
            //when
            string result = class1.GetString(i);
            //then
            Assert.Equal("Fizz", result);
        }

        [Fact]
        public void Should_return_Fizz_when_number_multiple_of_5()
        {
            //given
            FizzBuzz.FizzBuzz class1 = new FizzBuzz.FizzBuzz();
            int i = 5;
            //when
            string result = class1.GetString(i);
            //then
            Assert.Equal("Buzz", result);
        }


        [Fact]
        public void Should_return_Fizz_when_number_multiple_of_7()
        {
            //given
            FizzBuzz.FizzBuzz class1 = new FizzBuzz.FizzBuzz();
            int i = 7;
            //when
            string result = class1.GetString(i);
            //then
            Assert.Equal("Whizz", result);
        }
    }
}