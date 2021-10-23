using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace PromotionEngineTests.Promotions.PercentageTests
{
    public class UsePromotion
    {
        [Fact]
        public void Happy_path()
        {
            //Arrange

            var expectedOutput = 20;

            //Act
            var output = 0;

            //Assert
            Assert.Equal(expectedOutput, output);
        }

        [Fact]
        public void Missing_unit_price()
        {
            //Arrange

            //Act

            //Assert
            Assert.True(false);
        }

        [Fact]
        public void No_percentage()
        {
            //Arrange

            //Act

            //Assert
            Assert.True(false);
        }

        [Fact]
        public void No_SKU_Id()
        {
            //Arrange

            //Act

            //Assert
            Assert.True(false);
        }

        [Fact]
        public void Two_items()
        {
            //Arrange

            //Act

            //Assert
            Assert.True(false);
        }

    }
}
