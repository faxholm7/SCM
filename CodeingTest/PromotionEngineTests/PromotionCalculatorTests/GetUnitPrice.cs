using PromotionEngine;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace PromotionEngineTests.PromotionCalculatorTests
{
    public class GetUnitPrice
    {
        [Fact]
        public void Get_A_Price()
        {
            //Arrange
            var calculator = new PromotionCalculator();
            var inputSkuId = "A";

            var expectedOutput = 50;

            //Act
            var output = calculator.GetUnitPrice(inputSkuId);

            //Assert
            Assert.Equal(expectedOutput, output);
        }

        [Fact]
        public void Get_B_Price()
        {
            //Arrange
            var calculator = new PromotionCalculator();
            var inputSkuId = "B";

            var expectedOutput = 30;

            //Act
            var output = calculator.GetUnitPrice(inputSkuId);

            //Assert
            Assert.Equal(expectedOutput, output);
        }

        [Fact]
        public void Get_C_Price()
        {
            //Arrange
            var calculator = new PromotionCalculator();
            var inputSkuId = "C";

            var expectedOutput = 20;

            //Act
            var output = calculator.GetUnitPrice(inputSkuId);

            //Assert
            Assert.Equal(expectedOutput, output);
        }

        [Fact]
        public void Get_D_Price()
        {
            //Arrange
            var calculator = new PromotionCalculator();
            var inputSkuId = "D";

            var expectedOutput = 15;

            //Act
            var output = calculator.GetUnitPrice(inputSkuId);

            //Assert
            Assert.Equal(expectedOutput, output);
        }

        [Fact]
        public void Non_existing_SKU_ID()
        {
            //Arrange
            var calculator = new PromotionCalculator();
            var inputSkuId = "E";

            var expectedErrorMessage = "Non existing SKU ID.";
            var errorMessage = string.Empty;

            //Act
            try
            {
                var output = calculator.GetUnitPrice(inputSkuId);
            }
            catch (Exception e)
            {
                errorMessage = e.Message;
            }

            //Assert
            Assert.Equal(expectedErrorMessage, errorMessage);
        }

        [Fact]
        public void With_Empty_SKU_ID()
        {
            //Arrange
            var calculator = new PromotionCalculator();
            var inputSkuId = "E";

            var expectedErrorMessage = "Empty SKU ID.";
            var errorMessage = string.Empty;

            //Act
            try
            {
                var output = calculator.GetUnitPrice(inputSkuId);
            }
            catch (Exception e)
            {
                errorMessage = e.Message;
            }

            //Assert
            Assert.Equal(expectedErrorMessage, errorMessage);
        }
    }
}
