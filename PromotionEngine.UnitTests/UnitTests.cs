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

            _costCalculationService = new CostCalculationService();

            _promotions = new List<IPromotion>
            {
                new PromotionBulkService(new PromotionBulk("A", 3, 130)),
                new PromotionBulkService(new PromotionBulk("B", 2, 45)),
                new PromotionDuoService(new PromotionDuo(new List<string>{"C","D"}, 30))
            };
        }

        [TestMethod]
        public void NoPromotionsSelectedTest()
        {
            //Arrange
            var items = new List<Item>()
            {
                new Item(_products[2], 1)
            };

            //Act

            //Assert
        }

        public void WithoutPromotionsTest()
        {
            //Arrange
            var items = new List<Item>()
            {
                new Item(_products[2], 1)
            };

            //Act

            //Assert

        }

        public void BulkPromotionTest()
        {
            //Arrange
            var items = new List<Item>()
            {
                new Item(_products[2], 1)
            };

            //Act

            //Assert
        }

        public void DuoPromotionTest()
        {
            //Arrange
            var items = new List<Item>()
            {
                new Item(_products[2], 1)
            };

            //Act

            //Assert
        }
    }
}
