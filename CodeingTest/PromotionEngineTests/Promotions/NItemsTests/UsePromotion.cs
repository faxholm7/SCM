using PromotionEngine.Exceptions;
using PromotionEngine.Models;
using PromotionEngine.Promotions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xunit;

namespace PromotionEngineTests.Promotions.NItemsTests
{
    public class UsePromotion
    {
        [Fact]
        public void No_cart_items()
        {
            //Arrange
            var skuId = "A";
            var noOfItems = 3;
            var price = (double)130;
            var nItemsPromotion = new NItems(skuId, noOfItems, price);

            var inputCartItems = new List<CartItem>();

            var expectedOutput = 0;

            //Act
            var output = nItemsPromotion.UsePromotion(inputCartItems);

            //Assert
            Assert.Equal(expectedOutput, output);
        }

        [Fact]
        public void No_SKU_Id()
        {
            //Arrange
            var skuId = "A";
            var noOfItems = 3;
            var price = (double)130;
            var nItemsPromotion = new NItems(skuId, noOfItems, price);

            var inputCartItems = new List<CartItem>()
            {
                new CartItem() { Amount = 10}
            };

            var errorMessage = string.Empty;
            var expectedErrorMessage = "Empty SKU ID.";

            //Act
            try
            {
                nItemsPromotion.UsePromotion(inputCartItems);
            }
            catch (EmptyIdException e)
            {
                errorMessage = e.Message;
            }

            //Assert
            Assert.Equal(expectedErrorMessage, errorMessage);
        }

        [Fact]
        public void No_amount()
        {
            //Arrange
            var skuId = "A";
            var noOfItems = 3;
            var price = (double)130;
            var nItemsPromotion = new NItems(skuId, noOfItems, price);

            var inputCartItems = new List<CartItem>()
            {
                new CartItem() { SKUId = "A" }
            };

            var expectedOutput = 0;

            //Act
            var output = nItemsPromotion.UsePromotion(inputCartItems);

            //Assert
            Assert.Equal(expectedOutput, output);
        }

        [Fact]
        public void Too_low_amount()
        {
            //Arrange
            var skuId = "A";
            var noOfItems = 3;
            var price = (double)130;
            var nItemsPromotion = new NItems(skuId, noOfItems, price);

            var inputCartItems = new List<CartItem>()
            {
                new CartItem() { SKUId = "A", Amount = 2 }
            };

            var expectedOutput = 0;
            var expectedAmount = 2;

            //Act
            var output = nItemsPromotion.UsePromotion(inputCartItems);

            //Assert
            Assert.Equal(expectedOutput, output);
            Assert.Equal(expectedAmount, inputCartItems.First().Amount);
        }

        [Fact]
        public void Higher_amount()
        {
            //Arrange
            var skuId = "A";
            var noOfItems = 3;
            var price = (double)130;
            var nItemsPromotion = new NItems(skuId, noOfItems, price);

            var inputCartItems = new List<CartItem>()
            {
                new CartItem() { SKUId = "A", Amount = 4 }
            };

            var expectedOutput = 130;
            var expectedAmount = 1;

            //Act
            var output = nItemsPromotion.UsePromotion(inputCartItems);

            //Assert
            Assert.Equal(expectedOutput, output);
            Assert.Equal(expectedAmount, inputCartItems.First().Amount);
        }
    }
}
