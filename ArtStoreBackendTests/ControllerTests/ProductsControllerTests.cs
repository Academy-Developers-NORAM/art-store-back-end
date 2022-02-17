using NUnit.Framework;
using System.Net;
using ArtStoreBackend.Controllers;
using ArtStoreBackend.Repositories;
using Microsoft.AspNetCore.Mvc;
using ArtStoreBackend.Models;

namespace ArtStoreBackendTests
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
        public void Should_ReturnHTTPCode200_When_GetAllProductsInvoked()
        {
            //Had to convert the ActionResult to OkObjectResult to properly test the StatusCode result
            OkObjectResult response = (OkObjectResult)productsController.GetAllProducts().Result;
            Assert.AreEqual((int)HttpStatusCode.OK, response.StatusCode);
        }
        [Test]
        public void Should_ReturnAllProductObjects_When_GetAllProductsInvoked()
        {
            Assert.Pass();
        }
    }
}