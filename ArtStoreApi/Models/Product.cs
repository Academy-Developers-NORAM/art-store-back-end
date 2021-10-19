using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;



namespace ArtStoreBackend.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public double Price { get; set; }
        public string Description { get; set; }
        public string Image { get; set; }
        public bool InStock { get; set; }



        public Product(int id, string title, double price, string description, string image, bool inStock)
        {
            Id = id;
            Title = title;
            Price = price;
            Description = description;
            Image = image;
            InStock = inStock;
        }



        internal bool isInvalid()
        {
            return !isInvalid();
        }
    }
}