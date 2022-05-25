using System;
using TheNumberOfKatasJohnAndAnnDo.App;
using Xunit;

namespace TheNumberOfKatasJohnAndAnnDo.Test
{
    public class NumberOfKatasJohnAndAnnDidTests
    {
        [Fact]
        public void NumberOfKatasPerDayForJohn()
        {
            //Arrange
            INumberOfKatasJohnAndAnnDid theNumberOfKatasJohnAndAnnDo = new NumberOfKatasJohnAndAnnDid();
            long days = 11;
            var expected = "[0, 0, 1, 2, 2, 3, 4, 4, 5, 6, 6]";

            //Act
            var value = theNumberOfKatasJohnAndAnnDo.John(days);
            var actual = "[" + string.Join(", ", value) + "]";


            //Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void NumberOfKatasPerDayForAnn()
        {
            //Arrange
            INumberOfKatasJohnAndAnnDid theNumberOfKatasJohnAndAnnDo = new NumberOfKatasJohnAndAnnDid(); 
            long days = 6;
            var expected = "[1, 1, 2, 2, 3, 3]";

            //Act
            var value = theNumberOfKatasJohnAndAnnDo.Ann(days);
            var actual = "[" + string.Join(", ", value) + "]";


            //Assert
            Assert.Equal(expected, actual);

        }

        [Fact]
        public void TotalNumberOfKatasJohnDid()
        {
            //Arrange
            INumberOfKatasJohnAndAnnDid theNumberOfKatasJohnAndAnnDo = new NumberOfKatasJohnAndAnnDid(); 
            long day = 75;
            var expected = 1720;

            //Act
            var actual = theNumberOfKatasJohnAndAnnDo.SumJohn(day);

            //Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void TotalNumberOfKatasAnnDid()
        {
            //Arrange
            INumberOfKatasJohnAndAnnDid theNumberOfKatasJohnAndAnnDo = new NumberOfKatasJohnAndAnnDid(); 
            long day = 115;
            var expected = 4070;

            //Act
            var actual = theNumberOfKatasJohnAndAnnDo.SumAnn(day);

            //Assert
            Assert.Equal(expected, actual);
        }


    }
}

