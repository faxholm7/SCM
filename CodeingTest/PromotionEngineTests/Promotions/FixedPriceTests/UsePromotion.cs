using PromotionEngine.Exceptions;
using PromotionEngine.Models;
using PromotionEngine.Promotions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xunit;

namespace PromotionEngineTests.Promotions.FixedPriceTests
{
    public class UsePromotion
    {
        [Fact]
        public void One_item()
        {
            //Arrange
            var promotionSKUIds = new List<string>() { "A", "B" };
            var promotionPrice = 70;
            var fixedPricePromotion = new FixedPrice(promotionSKUIds, promotionPrice);

            var inputCartItems = new List<CartItem>()
            {
                new CartItem() { SKUId = "A", Amount = 1 }
            };

            var expectedOutput = 0;

            //Act
            var ouput = fixedPricePromotion.UsePromotion(inputCartItems);

            //Assert
            Assert.Equal(expectedOutput, ouput);
        }

        [Fact]
        public void No_amount_both()
        {
            //Arrange
            var promotionSKUIds = new List<string>() { "A", "B" };
            var promotionPrice = 70;
            var fixedPricePromotion = new FixedPrice(promotionSKUIds, promotionPrice);

            var inputCartItems = new List<CartItem>()
            {
                new CartItem() { SKUId = "A" },
                new CartItem() { SKUId = "B" }
            };

            var expectedOutput = 0;

            //Act
            var ouput = fixedPricePromotion.UsePromotion(inputCartItems);

            //Assert
            Assert.Equal(expectedOutput, ouput);
        }

        [Fact]
        public void No_amount_one()
        {
            //Arrange
            var promotionSKUIds = new List<string>() { "A", "B" };
            var promotionPrice = 70;
            var fixedPricePromotion = new FixedPrice(promotionSKUIds, promotionPrice);

            var inputCartItems = new List<CartItem>()
            {
                new CartItem() { SKUId = "A", Amount = 1 },
                new CartItem() { SKUId = "B" }
            };

            var expectedOutput = 0;

            //Act
            var ouput = fixedPricePromotion.UsePromotion(inputCartItems);

            //Assert
            Assert.Equal(expectedOutput, ouput);
        }

        [Fact]
        public void No_SKU_Id_both()
        {
            //Arrange
            var promotionSKUIds = new List<string>() { "A", "B" };
            var promotionPrice = 70;
            var fixedPricePromotion = new FixedPrice(promotionSKUIds, promotionPrice);

            var inputCartItems = new List<CartItem>()
            {
                new CartItem() { Amount = 1 },
                new CartItem() { Amount = 1 }
            };

            var errorMessage = string.Empty;
            var expectedErrorMessage = "Empty SKU ID.";

            //Act
            try
            {
                fixedPricePromotion.UsePromotion(inputCartItems);
            }
            catch (EmptyIdException e)
            {
                errorMessage = e.Message;
            }

            //Assert
            Assert.Equal(expectedErrorMessage, errorMessage);
        }

        [Fact]
        public void No_SKU_Id_one()
        {
            //Arrange
            var promotionSKUIds = new List<string>() { "A", "B" };
            var promotionPrice = 70;
            var fixedPricePromotion = new FixedPrice(promotionSKUIds, promotionPrice);

            var inputCartItems = new List<CartItem>()
            {
                new CartItem() { SKUId = "A", Amount = 1 },
                new CartItem() { Amount = 1 }
            };

            var errorMessage = string.Empty;
            var expectedErrorMessage = "Empty SKU ID.";

            //Act
            try
            {
                fixedPricePromotion.UsePromotion(inputCartItems);
            }
            catch (EmptyIdException e)
            {
                errorMessage = e.Message;
            }

            //Assert
            Assert.Equal(expectedErrorMessage, errorMessage);
        }

        [Fact]
        public void Extra_amount_for_one()
        {
            //Arrange
            var promotionSKUIds = new List<string>() { "A", "B" };
            var promotionPrice = 70;
            var fixedPricePromotion = new FixedPrice(promotionSKUIds, promotionPrice);

            var inputCartItems = new List<CartItem>()
            {
                new CartItem() { SKUId = "A", Amount = 2 },
                new CartItem() { SKUId = "B", Amount = 1 }
            };

            var expectedOutput = 70;
            var expectedAmountForA = 1;

            //Act
            var ouput = fixedPricePromotion.UsePromotion(inputCartItems);

            //Assert
            Assert.Equal(expectedOutput, ouput);
            Assert.Equal(expectedAmountForA, inputCartItems.Single(x => x.SKUId == "A").Amount);
        }

        [Fact]
        public void Extra_amount_for_two()
        {
            //Arrange
            var promotionSKUIds = new List<string>() { "A", "B" };
            var promotionPrice = 70;
            var fixedPricePromotion = new FixedPrice(promotionSKUIds, promotionPrice);

            var inputCartItems = new List<CartItem>()
            {
                new CartItem() { SKUId = "A", Amount = 2 },
                new CartItem() { SKUId = "B", Amount = 2 }
            };

            var expectedOutput = 140;
            var expectedAmountForA = 0;
            var expectedAmountForB = 0;

            //Act
            var ouput = fixedPricePromotion.UsePromotion(inputCartItems);

            //Assert
            Assert.Equal(expectedOutput, ouput);
            Assert.Equal(expectedAmountForA, inputCartItems.Single(x => x.SKUId == "A").Amount);
            Assert.Equal(expectedAmountForB, inputCartItems.Single(x => x.SKUId == "B").Amount);
        }
    }
}
