using PromotionEngine.Exceptions;
using PromotionEngine.Models;
using PromotionEngine.Promotions;
using PromotionEngineTests.Fakes.Services;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace PromotionEngineTests.Promotions.PercentageTests
{
    public class UsePromotion
    {
        [Fact]
        public void One_item()
        {
            //Arrange
            var priceListServiceStub = new PriceListServiceFake();
            priceListServiceStub.SKUItems.Add(new SKUItem() { SKUId = "C", Price = 20 });
            var percentagePromotion = new Percentage(priceListServiceStub, "C", 50);

            var inputCartItems = new List<CartItem>()
            {
                new CartItem() {SKUId = "C", Amount = 1}
            };

            var expectedOutput = 10;

            //Act
            var output = percentagePromotion.UsePromotion(inputCartItems);

            //Assert
            Assert.Equal(expectedOutput, output);
        }

        [Fact]
        public void Two_items()
        {
            //Arrange
            var priceListServiceStub = new PriceListServiceFake();
            priceListServiceStub.SKUItems.Add(new SKUItem() { SKUId = "C", Price = 20 });
            var percentagePromotion = new Percentage(priceListServiceStub, "C", 50);

            var inputCartItems = new List<CartItem>()
            {
                new CartItem() {SKUId = "C", Amount = 2}
            };

            var expectedOutput = 20;

            //Act
            var output = percentagePromotion.UsePromotion(inputCartItems);

            //Assert
            Assert.Equal(expectedOutput, output);
        }

        [Fact]
        public void Missing_unit_price()
        {
            //Arrange
            var priceListServiceStub = new PriceListServiceFake();
            var percentagePromotion = new Percentage(priceListServiceStub, "C", 50);

            var inputCartItems = new List<CartItem>()
            {
                new CartItem() {SKUId = "C", Amount = 1}
            };

            var errorMessage = string.Empty;
            var expectedErrorMessage = "Missing unit price";

            //Act
            try
            {
                percentagePromotion.UsePromotion(inputCartItems);
            }
            catch (MissingItemException e)
            {
                errorMessage = e.Message;
            }

            //Assert
            Assert.Equal(expectedErrorMessage, errorMessage);
        }

        [Fact]
        public void No_SKU_Id()
        {
            //Arrange
            var priceListServiceStub = new PriceListServiceFake();
            var percentagePromotion = new Percentage(priceListServiceStub, "C", 50);

            var inputCartItems = new List<CartItem>()
            {
                new CartItem() { Amount = 1}
            };

            var errorMessage = string.Empty;
            var expectedErrorMessage = "Empty SKU ID.";

            //Act
            try
            {
                percentagePromotion.UsePromotion(inputCartItems);
            }
            catch (EmptyIdException e)
            {
                errorMessage = e.Message;
            }

            //Assert
            Assert.Equal(expectedErrorMessage, errorMessage);
        }


    }
}
