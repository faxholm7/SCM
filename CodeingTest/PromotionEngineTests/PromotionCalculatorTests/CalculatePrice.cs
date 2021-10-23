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
        [Fact]
        public void NoPromotionOneA()
        {
            //Arrange
            var calculator = new PromotionCalculator(null);
            var inputCartItems = new List<CartItem>() { new CartItem() { SKUId = "A", Amount = 1 } };

            var expectedOutputPrice = 50;

            //Act
            var output = calculator.CalculatePrice(inputCartItems);

            //Asset
            Assert.Equal(expectedOutputPrice, output);
        }

        [Fact]
        public void NoPromotionOneB()
        {
            //Arrange
            var calculator = new PromotionCalculator(null);

            var inputCartItems = new List<CartItem>() { new CartItem() { SKUId = "B", Amount = 1 } };

            var expectedOutputPrice = 30;

            //Act
            var output = calculator.CalculatePrice(inputCartItems);

            //Asset
            Assert.Equal(expectedOutputPrice, output);
        }

        [Fact]
        public void NoPromotionOneC()
        {
            //Arrange
            var calculator = new PromotionCalculator(null);
            var inputCartItems = new List<CartItem>() { new CartItem() { SKUId = "C", Amount = 1 } };

            var expectedOutputPrice = 20;

            //Act
            var output = calculator.CalculatePrice(inputCartItems);

            //Asset
            Assert.Equal(expectedOutputPrice, output);
        }

        [Fact]
        public void NoPromotionOneD()
        {
            //Arrange
            var calculator = new PromotionCalculator(null);
            var inputCartItems = new List<CartItem>() { new CartItem() { SKUId = "D", Amount = 1 } };

            var expectedOutputPrice = 15;

            //Act
            var output = calculator.CalculatePrice(inputCartItems);

            //Asset
            Assert.Equal(expectedOutputPrice, output);
        }
    }
}
