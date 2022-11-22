using System;
using Xunit;
using dotnet2;
using System.ComponentModel.DataAnnotations;

namespace dotnet2Test
{
    public class UnitTest1
    {
        //[Fact]
        [Theory]
        [InlineData("")]
        [InlineData("123")]
        [InlineData("123456789010")]
        public void findStringLength(string str)

        {
            //LengthHelper length = new LengthHelper();
            //Arrange
            // string str = "123";
            //Act

            int l = 0;
            foreach (char chr in str)
            {
                l += 1;

            }
            int len = LengthHelper.FindLength(str);
            // var expected = l;
            Assert.Equal(l, len );
            

        }
        //[Theory]
        [Fact]
        public void findLengthForNullString()
        {
            string strl = null;
            var ex = Assert.Throws<InvalidOperationException>(() => LengthHelper.FindLength(strl));
            Assert.Equal("Invalid number", ex.Message);
        }
    }
}