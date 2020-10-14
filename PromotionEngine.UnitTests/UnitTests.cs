using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PromotionEngine.Service.BusinessLogic;
using PromotionEngine.Service.Interfaces;
using PromotionEngine.Service.Models;

namespace PromotionEngine.UnitTests
{
    [TestClass]
    public class UnitTests
    {
        private readonly List<ProductDTO> _products;
        private readonly ICostCalculationService _costCalculationService;
        private readonly IEnumerable<IPromotion> _promotions;

        public UnitTests()
        {
            _costCalculationService = new CostCalculationService();

            // Mocking data for initial preparation with the values from A - D.
            var promA = new ProductDTO("A", 50);
            var promB = new ProductDTO("B", 30);
            var promC = new ProductDTO("C", 20);
            var promD = new ProductDTO("D", 15);

            _products = new List<ProductDTO>
            {
                promA,
                promB,
                promC,
                promD
            };
            // promotions fixed as of now.
            _promotions = new List<IPromotion>
            {
                new PromotionBulkService(new PromotionBulk("A", 3, 130)),
                new PromotionBulkService(new PromotionBulk("B", 2, 45)),
                new PromotionDuoService(new PromotionDuo(new List<string>{"C","D"}, 30))
            };
        }
        
        // Test case for selecting 0 items in all and or not selecting any items
        [TestMethod]
        public void NoSelectedItemsTest()
        {
            // Arrange
            var items = new List<Item>()
            {
                new Item(_products[0], 0),
                new Item(_products[1], 0),
                new Item(_products[2], 0),
                new Item(_products[3], 0)
            };

            // Act
            var total = _costCalculationService.FetchTotal(items, _promotions);

            // Assert
            Assert.AreEqual(0, total);
        }

        // SCENARIO : A
        // Test case for not selecting any promotions and default with single item each of A, B, C
        [TestMethod]
        public void NoPromotionsSelectedTest()
        {
            // Arrange
            var items = new List<Item>()
            {
                 new Item(_products[0], 1),
                 new Item(_products[1], 1),
                 new Item(_products[2], 1),
            };

            // Act
            var total = _costCalculationService.FetchTotal(items, _promotions);

            // Assert
            Assert.AreEqual(100, total);
        }

        // SCENARIO B
        [TestMethod]
        public void BulkPromotionTest()
        {
            // Arrange
            var items = new List<Item>()
            {
               new Item(_products[0], 5),
               new Item(_products[1], 5),
               new Item(_products[2], 1),
            };

            // Act
            var total = _costCalculationService.FetchTotal(items, _promotions);

            // Assert
            Assert.AreEqual(370, total);
        }

        // SCENARIO C
        [TestMethod]
        public void DuoPromotionTest()
        {
            // Arrange
            var items = new List<Item>()
            {
               new Item(_products[0], 3),
               new Item(_products[1], 5),
               new Item(_products[2], 1),
               new Item(_products[3], 1),
            };

            // Act
            var total = _costCalculationService.FetchTotal(items, _promotions);

            // Assert
            Assert.AreEqual(280, total);
        }
    }
}
