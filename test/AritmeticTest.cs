using System;
using dotnetcore.operations;
using Xunit;

namespace test
{
    public class AritmeticTest
    {
        [Fact]
        public void Sum_Pass_ReturnEqual()
        {
            float a = 1;
            float b = 2;
            float sum = 3;

            float sumTest = Aritmetic.Sum(a, b);

            Assert.Equal(sum, sumTest);
        }

        [Fact]
        public void Sum_ReurnNotEqual()
        {
            float a = 1;
            float b = 2;
            float sum = 4;

            float sumTest = Aritmetic.Sum(a, b);

            Assert.NotEqual(sum, sumTest);
        }

        [Theory]
        [InlineData(60)]
        [InlineData(46)]
        [InlineData(94)]
        public void IsPair_ReturnTrue(int value){

            bool isPair = Aritmetic.IsPair(value);

            Assert.True(isPair);
        }

        [Theory]
        [InlineData(45)]
        [InlineData(13)]
        [InlineData(11)]
        public void IsPair_ReturnFalse(int value){

            bool isPair = Aritmetic.IsPair(value);

            Assert.False(isPair);
        }
    }
}
