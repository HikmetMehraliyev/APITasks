using ClassTaskAPI.DAL;
using ClassTaskAPI.Models;
using ClassTaskAPI.Models.Dtos.Product;
using ClassTaskAPI.Services.Interfaces.ProductService;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace ClassTaskAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly IProductService _productService;
        public ProductsController(IProductService productService)
        {
            _productService = productService;
        }
    }
}
