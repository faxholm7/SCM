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
        #region "No promotions - one cart item"

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
        public void No_promotion_two_A()
        {
            //Arrange
            var priceListServiceStub = Helpers.GetBasicPriceListServiceFake();
            var calculator = new PromotionCalculator(priceListServiceStub);

            var inputCartItems = new List<CartItem>() { new CartItem() { SKUId = "A", Amount = 2 } };

            var expectedOutputPrice = 100;

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
        public void No_promotion_two_B()
        {
            //Arrange
            var priceListServiceStub = Helpers.GetBasicPriceListServiceFake();
            var calculator = new PromotionCalculator(priceListServiceStub);

            var inputCartItems = new List<CartItem>() { new CartItem() { SKUId = "B", Amount = 2 } };

            var expectedOutputPrice = 60;

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
        public void No_promotion_two_C()
        {
            //Arrange
            var priceListServiceStub = Helpers.GetBasicPriceListServiceFake();
            var calculator = new PromotionCalculator(priceListServiceStub);

            var inputCartItems = new List<CartItem>() { new CartItem() { SKUId = "C", Amount = 2 } };

            var expectedOutputPrice = 40;

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

        [Fact]
        public void No_promotion_two_D()
        {
            //Arrange
            var priceListServiceStub = Helpers.GetBasicPriceListServiceFake();
            var calculator = new PromotionCalculator(priceListServiceStub);

            var inputCartItems = new List<CartItem>() { new CartItem() { SKUId = "D", Amount = 2 } };

            var expectedOutputPrice = 30;

            //Act
            var output = calculator.CalculatePrice(inputCartItems);

            //Asset
            Assert.Equal(expectedOutputPrice, output);
        }

        #endregion

        #region "No promotions - multiple cart items"
        
        [Fact]
        public void No_promotion_one_A_one_C()
        {
            //Arrange
            var priceListServiceStub = Helpers.GetBasicPriceListServiceFake();
            var calculator = new PromotionCalculator(priceListServiceStub);

            var inputCartItems = new List<CartItem>() 
            { 
                new CartItem() { SKUId = "A", Amount = 1 },
                new CartItem() { SKUId = "C", Amount = 1 }
            };

            var expectedOutputPrice = 70;

            //Act
            var output = calculator.CalculatePrice(inputCartItems);

            //Asset
            Assert.Equal(expectedOutputPrice, output);
        }

        [Fact]
        public void No_promotion_one_A_one_B_one_C()
        {
            //Arrange
            var priceListServiceStub = Helpers.GetBasicPriceListServiceFake();
            var calculator = new PromotionCalculator(priceListServiceStub);

            var inputCartItems = new List<CartItem>()
            {
                new CartItem() { SKUId = "A", Amount = 1 },
                new CartItem() { SKUId = "B", Amount = 1 },
                new CartItem() { SKUId = "C", Amount = 1 }
            };

            var expectedOutputPrice = 100;

            //Act
            var output = calculator.CalculatePrice(inputCartItems);

            //Asset
            Assert.Equal(expectedOutputPrice, output);
        }

        [Fact]
        public void No_promotion_one_A_one_B_one_C_one_D()
        {
            //Arrange
            var priceListServiceStub = Helpers.GetBasicPriceListServiceFake();
            var calculator = new PromotionCalculator(priceListServiceStub);

            var inputCartItems = new List<CartItem>()
            {
                new CartItem() { SKUId = "A", Amount = 1 },
                new CartItem() { SKUId = "B", Amount = 1 },
                new CartItem() { SKUId = "C", Amount = 1 },
                new CartItem() { SKUId = "D", Amount = 1 }
            };

            var expectedOutputPrice = 115;

            //Act
            var output = calculator.CalculatePrice(inputCartItems);

            //Asset
            Assert.Equal(expectedOutputPrice, output);
        }

        [Fact]
        public void No_promotion_two_A_two_C_three_D()
        {
            //Arrange
            var priceListServiceStub = Helpers.GetBasicPriceListServiceFake();
            var calculator = new PromotionCalculator(priceListServiceStub);

            var inputCartItems = new List<CartItem>()
            {
                new CartItem() { SKUId = "A", Amount = 2 },
                new CartItem() { SKUId = "C", Amount = 2 },
                new CartItem() { SKUId = "D", Amount = 3 }
            };

            var expectedOutputPrice = 185;

            //Act
            var output = calculator.CalculatePrice(inputCartItems);

            //Asset
            Assert.Equal(expectedOutputPrice, output);
        }

        #endregion

        #region "Single promotion 'n' items"
        
        [Fact]
        public void NItems_Promotion_Three_A()
        {
            //Arrange
            var priceListServiceStub = Helpers.GetBasicPriceListServiceFake();
            var calculator = new PromotionCalculator(priceListServiceStub);

            var inputCartItems = new List<CartItem>()
            {
                new CartItem() { SKUId = "A", Amount = 3 },
            };

            var expectedOutputPrice = 130;

            //Act
            var output = calculator.CalculatePrice(inputCartItems);

            //Asset
            Assert.Equal(expectedOutputPrice, output);
        }

        [Fact]
        public void NItems_Promotion_Four_A()
        {
            //Arrange
            var priceListServiceStub = Helpers.GetBasicPriceListServiceFake();
            var calculator = new PromotionCalculator(priceListServiceStub);

            var inputCartItems = new List<CartItem>()
            {
                new CartItem() { SKUId = "A", Amount = 4 },
            };

            var expectedOutputPrice = 180;

            //Act
            var output = calculator.CalculatePrice(inputCartItems);

            //Asset
            Assert.Equal(expectedOutputPrice, output);
        }

        [Fact]
        public void NItems_Promotion_Six_A()
        {
            //Arrange
            var priceListServiceStub = Helpers.GetBasicPriceListServiceFake();
            var calculator = new PromotionCalculator(priceListServiceStub);

            var inputCartItems = new List<CartItem>()
            {
                new CartItem() { SKUId = "A", Amount = 6 },
            };

            var expectedOutputPrice = 260;

            //Act
            var output = calculator.CalculatePrice(inputCartItems);

            //Asset
            Assert.Equal(expectedOutputPrice, output);
        }



        #endregion

        #region "Single promotion fixed price"

        #endregion

        #region "Two promotions 'n' items and fixed price"

        #endregion

        #region "Scenario's"

        #endregion

        //Add:
        //Empty cart list
        //One cart item, no amount
        //One cart item, no sku id
        //One cart item, non existing ID

    }
}
