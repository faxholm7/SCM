using PromotionEngine;
using PromotionEngine.Exceptions;
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
            var promotionServiceStub = Helpers.GetPromotionServiceFake();
            var calculator = new PromotionCalculator(priceListServiceStub, promotionServiceStub);

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
            var promotionServiceStub = Helpers.GetPromotionServiceFake();
            var calculator = new PromotionCalculator(priceListServiceStub, promotionServiceStub);

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
            var promotionServiceStub = Helpers.GetPromotionServiceFake();
            var calculator = new PromotionCalculator(priceListServiceStub, promotionServiceStub);

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
            var promotionServiceStub = Helpers.GetPromotionServiceFake();
            var calculator = new PromotionCalculator(priceListServiceStub, promotionServiceStub);

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
            var promotionServiceStub = Helpers.GetPromotionServiceFake();
            var calculator = new PromotionCalculator(priceListServiceStub, promotionServiceStub);

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
            var promotionServiceStub = Helpers.GetPromotionServiceFake();
            var calculator = new PromotionCalculator(priceListServiceStub, promotionServiceStub);

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
            var promotionServiceStub = Helpers.GetPromotionServiceFake();
            var calculator = new PromotionCalculator(priceListServiceStub, promotionServiceStub);

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
            var promotionServiceStub = Helpers.GetPromotionServiceFake();
            var calculator = new PromotionCalculator(priceListServiceStub, promotionServiceStub);

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
            var promotionServiceStub = Helpers.GetPromotionServiceFake();
            var calculator = new PromotionCalculator(priceListServiceStub, promotionServiceStub);

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
            var promotionServiceStub = Helpers.GetPromotionServiceFake();
            var calculator = new PromotionCalculator(priceListServiceStub, promotionServiceStub);

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
            var promotionServiceStub = Helpers.GetPromotionServiceFake();
            var calculator = new PromotionCalculator(priceListServiceStub, promotionServiceStub);

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
            var promotionServiceStub = Helpers.GetPromotionServiceFake();
            var calculator = new PromotionCalculator(priceListServiceStub, promotionServiceStub);

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
        public void NItems_promotion_Three_A()
        {
            //Arrange
            var priceListServiceStub = Helpers.GetBasicPriceListServiceFake();
            var promotionServiceStub = Helpers.GetPromotionServiceFake(nItemsA: true);
            var calculator = new PromotionCalculator(priceListServiceStub, promotionServiceStub);

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
        public void NItems_promotion_Four_A()
        {
            //Arrange
            var priceListServiceStub = Helpers.GetBasicPriceListServiceFake();
            var promotionServiceStub = Helpers.GetPromotionServiceFake(nItemsA: true);
            var calculator = new PromotionCalculator(priceListServiceStub, promotionServiceStub);

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
        public void NItems_promotion_Six_A()
        {
            //Arrange
            var priceListServiceStub = Helpers.GetBasicPriceListServiceFake();
            var promotionServiceStub = Helpers.GetPromotionServiceFake(nItemsA: true);
            var calculator = new PromotionCalculator(priceListServiceStub, promotionServiceStub);

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

        [Fact]
        public void NItems_promotion_Two_B()
        {
            //Arrange
            var priceListServiceStub = Helpers.GetBasicPriceListServiceFake();
            var promotionServiceStub = Helpers.GetPromotionServiceFake(nItemsB: true);
            var calculator = new PromotionCalculator(priceListServiceStub, promotionServiceStub);

            var inputCartItems = new List<CartItem>()
            {
                new CartItem() { SKUId = "B", Amount = 2 },
            };

            var expectedOutputPrice = 45;

            //Act
            var output = calculator.CalculatePrice(inputCartItems);

            //Asset
            Assert.Equal(expectedOutputPrice, output);
        }

        [Fact]
        public void NItems_promotion_Four_B()
        {
            //Arrange
            var priceListServiceStub = Helpers.GetBasicPriceListServiceFake();
            var promotionServiceStub = Helpers.GetPromotionServiceFake(nItemsB: true);
            var calculator = new PromotionCalculator(priceListServiceStub, promotionServiceStub);

            var inputCartItems = new List<CartItem>()
            {
                new CartItem() { SKUId = "B", Amount = 4 },
            };

            var expectedOutputPrice = 90;

            //Act
            var output = calculator.CalculatePrice(inputCartItems);

            //Asset
            Assert.Equal(expectedOutputPrice, output);
        }

        [Fact]
        public void NItems_promotion_Five_B()
        {
            //Arrange
            var priceListServiceStub = Helpers.GetBasicPriceListServiceFake();
            var promotionServiceStub = Helpers.GetPromotionServiceFake(nItemsB: true);
            var calculator = new PromotionCalculator(priceListServiceStub, promotionServiceStub);

            var inputCartItems = new List<CartItem>()
            {
                new CartItem() { SKUId = "B", Amount = 5 }
            };

            var expectedOutputPrice = 120;

            //Act
            var output = calculator.CalculatePrice(inputCartItems);

            //Asset
            Assert.Equal(expectedOutputPrice, output);
        }

        #endregion

        #region "Single promotion fixed price"

        [Fact]
        public void Fixed_price_one_C_one_D()
        {
            //Arrange
            var priceListServiceStub = Helpers.GetBasicPriceListServiceFake();
            var promotionServiceStub = Helpers.GetPromotionServiceFake(cdFixed: true);
            var calculator = new PromotionCalculator(priceListServiceStub, promotionServiceStub);

            var inputCartItems = new List<CartItem>()
            {
                new CartItem() { SKUId = "C", Amount = 1 },
                new CartItem() { SKUId = "D", Amount = 1 }
            };

            var expectedOutputPrice = 30;

            //Act
            var output = calculator.CalculatePrice(inputCartItems);

            //Asset
            Assert.Equal(expectedOutputPrice, output);
        }

        [Fact]
        public void Fixed_price_two_C_one_D()
        {
            //Arrange
            var priceListServiceStub = Helpers.GetBasicPriceListServiceFake();
            var promotionServiceStub = Helpers.GetPromotionServiceFake(cdFixed: true);
            var calculator = new PromotionCalculator(priceListServiceStub, promotionServiceStub);

            var inputCartItems = new List<CartItem>()
            {
                new CartItem() { SKUId = "C", Amount = 2 },
                new CartItem() { SKUId = "D", Amount = 1 }
            };

            var expectedOutputPrice = 50;

            //Act
            var output = calculator.CalculatePrice(inputCartItems);

            //Asset
            Assert.Equal(expectedOutputPrice, output);
        }

        [Fact]
        public void Fixed_price_two_C_two_D()
        {
            //Arrangem
            var priceListServiceStub = Helpers.GetBasicPriceListServiceFake();
            var promotionServiceStub = Helpers.GetPromotionServiceFake(cdFixed: true);
            var calculator = new PromotionCalculator(priceListServiceStub, promotionServiceStub);

            var inputCartItems = new List<CartItem>()
            {
                new CartItem() { SKUId = "C", Amount = 2 },
                new CartItem() { SKUId = "D", Amount = 2 }
            };

            var expectedOutputPrice = 60;

            //Act
            var output = calculator.CalculatePrice(inputCartItems);

            //Asset
            Assert.Equal(expectedOutputPrice, output);
        }

        [Fact]
        public void Fixed_price_three_C_five_D()
        {
            //Arrange
            var priceListServiceStub = Helpers.GetBasicPriceListServiceFake();
            var promotionServiceStub = Helpers.GetPromotionServiceFake(cdFixed: true);
            var calculator = new PromotionCalculator(priceListServiceStub, promotionServiceStub);

            var inputCartItems = new List<CartItem>()
            {
                new CartItem() { SKUId = "C", Amount = 3 },
                new CartItem() { SKUId = "D", Amount = 5 }
            };

            var expectedOutputPrice = 120;

            //Act
            var output = calculator.CalculatePrice(inputCartItems);

            //Asset
            Assert.Equal(expectedOutputPrice, output);
        }

        #endregion

        #region "Scenario's"
        
        [Fact]
        public void Scenario_A()
        {
            //Arrange
            var priceListServiceStub = Helpers.GetBasicPriceListServiceFake();
            var promotionServiceStub = Helpers.GetPromotionServiceFake(nItemsA: true, nItemsB: true, cdFixed: true);
            var calculator = new PromotionCalculator(priceListServiceStub, promotionServiceStub);

            var inputCartItems = new List<CartItem>()
            {
                new CartItem() { SKUId = "A", Amount = 1},
                new CartItem() { SKUId = "B", Amount = 1},
                new CartItem() { SKUId = "C", Amount = 1}
            };

            var expectedOutputPrice = 100;

            //Act
            var output = calculator.CalculatePrice(inputCartItems);

            //Asset
            Assert.Equal(expectedOutputPrice, output);
        }

        [Fact]
        public void Scenario_B()
        {
            //Arrange
            var priceListServiceStub = Helpers.GetBasicPriceListServiceFake();
            var promotionServiceStub = Helpers.GetPromotionServiceFake(nItemsA: true, nItemsB: true, cdFixed: true);
            var calculator = new PromotionCalculator(priceListServiceStub, promotionServiceStub);

            var inputCartItems = new List<CartItem>()
            {
                new CartItem() { SKUId = "A", Amount = 5},
                new CartItem() { SKUId = "B", Amount = 5},
                new CartItem() { SKUId = "C", Amount = 1}
            };

            var expectedOutputPrice = 370;

            //Act
            var output = calculator.CalculatePrice(inputCartItems);

            //Asset
            Assert.Equal(expectedOutputPrice, output);
        }

        [Fact]
        public void Scenario_C()
        {
            //Arrange
            var priceListServiceStub = Helpers.GetBasicPriceListServiceFake();
            var promotionServiceStub = Helpers.GetPromotionServiceFake(nItemsA: true, nItemsB: true, cdFixed: true);
            var calculator = new PromotionCalculator(priceListServiceStub, promotionServiceStub);

            var inputCartItems = new List<CartItem>()
            {
                new CartItem() { SKUId = "A", Amount = 3},
                new CartItem() { SKUId = "B", Amount = 5},
                new CartItem() { SKUId = "C", Amount = 1},
                new CartItem() { SKUId = "D", Amount = 1}
            };

            var expectedOutputPrice = 280;

            //Act
            var output = calculator.CalculatePrice(inputCartItems);

            //Asset
            Assert.Equal(expectedOutputPrice, output);
        }

        #endregion

        #region "Outliers"

        [Fact]
        public void Empty_cart_list()
        {
            //Arrange
            var priceListServiceStub = Helpers.GetBasicPriceListServiceFake();
            var promotionServiceStub = Helpers.GetPromotionServiceFake(nItemsA: true, nItemsB: true, cdFixed: true);
            var calculator = new PromotionCalculator(priceListServiceStub, promotionServiceStub);

            var inputCartItems = new List<CartItem>();

            var expectedOutputPrice = 0;

            //Act
            var output = calculator.CalculatePrice(inputCartItems);

            //Asset
            Assert.Equal(expectedOutputPrice, output);
        }

        [Fact]
        public void Cart_item_missing_amount()
        {
            //Arrange
            var priceListServiceStub = Helpers.GetBasicPriceListServiceFake();
            var promotionServiceStub = Helpers.GetPromotionServiceFake(nItemsA: true, nItemsB: true, cdFixed: true);
            var calculator = new PromotionCalculator(priceListServiceStub, promotionServiceStub);

            var inputCartItems = new List<CartItem>()
            {
                new CartItem() { SKUId = "A" }
            };

            var expectedOutputPrice = 0;

            //Act
            var output = calculator.CalculatePrice(inputCartItems);

            //Asset
            Assert.Equal(expectedOutputPrice, output);
        }

        [Fact]
        public void Cart_item_missing_SKU_Id()
        {
            //Arrange
            var priceListServiceStub = Helpers.GetBasicPriceListServiceFake();
            var promotionServiceStub = Helpers.GetPromotionServiceFake(nItemsA: true, nItemsB: true, cdFixed: true);
            var calculator = new PromotionCalculator(priceListServiceStub, promotionServiceStub);

            var inputCartItems = new List<CartItem>()
            {
                new CartItem() {SKUId = "", Amount = 1 }
            };

            var expectedErrorMessage = "Empty SKU ID.";
            var errorMessage = string.Empty;

            //Act
            try
            {
                var output = calculator.CalculatePrice(inputCartItems);
            }
            catch(EmptyIdException e)
            {
                errorMessage = e.Message;
            }

            //Asset
            Assert.Equal(expectedErrorMessage, errorMessage);
        }

        [Fact]
        public void Cart_item_non_existing_SKU_Id()
        {
            //Arrange
            var priceListServiceStub = Helpers.GetBasicPriceListServiceFake();
            var promotionServiceStub = Helpers.GetPromotionServiceFake(nItemsA: true, nItemsB: true, cdFixed: true);
            var calculator = new PromotionCalculator(priceListServiceStub, promotionServiceStub);

            var inputCartItems = new List<CartItem>()
            {
                new CartItem() {SKUId = "E", Amount = 1 }
            };

            var expectedErrorMessage = "Non existing SKU ID.";
            var errorMessage = string.Empty;

            //Act
            try
            {
                var output = calculator.CalculatePrice(inputCartItems);
            }
            catch (MissingItemException e)
            {
                errorMessage = e.Message;
            }

            //Asset
            Assert.Equal(expectedErrorMessage, errorMessage);
        }

        #endregion
    }
}
