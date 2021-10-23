using PromotionEngine;
using PromotionEngine.Models;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace PromotionEngineTests.PromotionCalculatorTests
{

    public class CalculatePrice
    {
        #region "No promotions"

        [Fact]
        public void No_promotion_one_A()
        {
            //Arrange
            var priceListServiceStub = Helpers.GetBasicPriceListServiceFake();
            var calculator = new PromotionCalculator(priceListServiceStub);

            var inputCartItems = new List<CartItem>() { new CartItem() { SKUId = "A", Amount = 1 } };

            var expectedOutputPrice = 50;

            //Act
            var output = calculator.CalculatePrice(inputCartItems);

            //Asset
            Assert.Equal(expectedOutputPrice, output);
        }

        [Fact]
        public void No_promotion_one_B()
        {
            //Arrange
            var priceListServiceStub = Helpers.GetBasicPriceListServiceFake();
            var calculator = new PromotionCalculator(priceListServiceStub);

            var inputCartItems = new List<CartItem>() { new CartItem() { SKUId = "B", Amount = 1 } };

            var expectedOutputPrice = 30;

            //Act
            var output = calculator.CalculatePrice(inputCartItems);

            //Asset
            Assert.Equal(expectedOutputPrice, output);
        }

        [Fact]
        public void No_promotion_one_C()
        {
            //Arrange
            var priceListServiceStub = Helpers.GetBasicPriceListServiceFake();
            var calculator = new PromotionCalculator(priceListServiceStub);

            var inputCartItems = new List<CartItem>() { new CartItem() { SKUId = "C", Amount = 1 } };

            var expectedOutputPrice = 20;

            //Act
            var output = calculator.CalculatePrice(inputCartItems);

            //Asset
            Assert.Equal(expectedOutputPrice, output);
        }

        [Fact]
        public void No_promotion_one_D()
        {
            //Arrange
            var priceListServiceStub = Helpers.GetBasicPriceListServiceFake();
            var calculator = new PromotionCalculator(priceListServiceStub);

            var inputCartItems = new List<CartItem>() { new CartItem() { SKUId = "D", Amount = 1 } };

            var expectedOutputPrice = 15;

            //Act
            var output = calculator.CalculatePrice(inputCartItems);

            //Asset
            Assert.Equal(expectedOutputPrice, output);
        }

        //Add:
        //Empty cart list
        //One cart item, no amount
        //One cart item, no sku id
        //One cart item, non existing ID

        #endregion

    }
}
