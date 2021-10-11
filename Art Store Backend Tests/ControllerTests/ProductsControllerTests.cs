using NUnit.Framework;
using System.Net;
using ArtStoreBackend.Controllers;
using ArtStoreBackend.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace Art_Store_Backend_Tests
{
    public class ProductsControllerTests
    {
        private ProductsController productsController;
        private ProductsRepository productsRepository;
        [SetUp]
        public void Setup()
        {
            productsRepository = new ProductsRepository();
            productsController = new ProductsController(productsRepository);
            
        }

        [Test]
        public void Should_ReturnHTTPCode200_From_GetAllProductsMethod()
        {
            ActionResult response = productsController.GetAllProducts().Result;
            Assert.AreEqual(response, HttpStatusCode.OK);
        }
        [Test]
        public void Should_ReturnAllProductObjects_From_GetAllProductsMethod()
        {
            Assert.Pass();
        }
        [Test]
        public void Should_x_When_x()
        {
            Assert.Pass();
        }
    }
}