using ArtStoreBackend.Models;
using ArtStoreBackend.Repositories;
using NUnit.Framework;
using System.Collections.Generic;

namespace ArtStoreBackendTests
{
    public class ProductsRepositoryTests
    {
        private ProductsRepository productsRepository;
        [SetUp]
        public void Setup()
        {
            productsRepository = new ProductsRepository();
        }

        [Test]
        public void Should_ReturnAllProducts_When_GetAllProductsInvoked()
        {
            List<Product> productsList = productsRepository.getAllProducts();
            Assert.AreEqual(6, productsList.Count);
        }
        [Test]
        public void Should_AddProduct_When_AddProductInvoked()
        {
            List<Product> productsList = productsRepository.getAllProducts();
            Product productSeven = new Product(id: 7, title: "Seventh", price: 0.99, description: "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry\'s standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book.", image: "", inStock: false);

            Assert.IsFalse(productsList.Contains(productSeven));

            productsList.Add(productSeven);

            Assert.Contains(productSeven, productsList);
        }
    }
}