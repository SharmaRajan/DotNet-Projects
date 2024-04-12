using System;
using ConsoleToWebApp.Models;
using ConsoleToWebApp.Repository;
using Microsoft.AspNetCore.Mvc;

namespace ConsoleToWebApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
	{
        // old way
        //private readonly ProductRepository _prodRepo;

        // new way
        private readonly IProductRepo _productRepo;

        public ProductController(IProductRepo productRepo)
        {
            _productRepo = productRepo;
        }

        [HttpPost("")]
        public IActionResult AddProduct([FromBody] ProductModel product)
        {
            _productRepo.AddProduct(product);
            var products = _productRepo.GetAllProducts();
            return Ok(products);
        }
	}
}

