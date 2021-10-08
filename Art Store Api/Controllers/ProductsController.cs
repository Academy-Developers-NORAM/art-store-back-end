using ArtStoreBackend.Models;
using ArtStoreBackend.Repositories;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ArtStoreBackend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [EnableCors("localhost")]
    public class ProductsController : ControllerBase
    {
        private readonly IProductRepository productRepository;
        public ProductsController(IProductRepository productRepository)
        {
            this.productRepository = productRepository;
        }


        [HttpGet]
        public ActionResult<List<Product>> GetAllProducts()
        {
            return Ok(productRepository.getAllProducts());
        }
    }
}
