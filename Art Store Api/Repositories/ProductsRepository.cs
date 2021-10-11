using ArtStoreBackend.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ArtStoreBackend.Repositories
{
    public interface IProductsRepository
    {
        List<Product> getAllProducts();
        void add(Product product);
    }

    public class ProductsRepository : IProductsRepository
    {
        private List<Product> listOfProducts = new List<Product>();

        public ProductsRepository()
        {
            listOfProducts.Add(new Product(id: 1, title: "First", price: 37.99, description: "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry\'s standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book.", image: "firstImg", inStock: true));
            listOfProducts.Add(new Product(id: 2, title: "Second", price: 37.99, description: "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry\'s standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book.", image: "firstImg", inStock: true));
            listOfProducts.Add(new Product(id: 3, title: "Third", price: 37.99, description: "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry\'s standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book.", image: "firstImg", inStock: false));
            listOfProducts.Add(new Product(id: 4, title: "Fourth", price: 37.99, description: "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry\'s standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book.", image: "firstImg", inStock: true));
            listOfProducts.Add(new Product(id: 5, title: "Fifth", price: 37.99, description: "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry\'s standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book.", image: "firstImg", inStock: true));
            listOfProducts.Add(new Product(id: 6, title: "Sixth", price: 37.99, description: "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry\'s standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book.", image: "firstImg", inStock: true));
        }

        public ProductsRepository(List<Product> products)
        {
            listOfProducts = products;
        }
        public void add(Product product)
        {
            if (product.isInvalid())
            {
                throw new Exception("Invalid Product");
            }
            else
            {
                listOfProducts.Add(product);
            }

        }

        public List<Product> getAllProducts()
        {
            return listOfProducts;
        }
    }


}
