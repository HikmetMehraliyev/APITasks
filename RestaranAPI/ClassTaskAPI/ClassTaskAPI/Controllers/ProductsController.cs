using AutoMapper;
using ClassTaskAPI.Models;
using ClassTaskAPI.Services.Interfaces.ProductService;
using ClassTaskAPI.Utilities.Exceptions;
using ClassTaskAPI.Utilities.ResponseMessages;
using Microsoft.AspNetCore.Mvc;

namespace ClassTaskAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly IProductService _productService;
        private readonly IMapper _mapper;

        public ProductsController(IProductService productService, IMapper mapper)
        {
            _productService = productService;
            _mapper = mapper;
        }

        [HttpGet("Product")]
        public async Task<ResponseMessage> GetProduct()
        {
            return await _productService.GetALL();
        }

        [HttpGet("Product/{Id}")]
        public Product GetProductById(int id)
        {
            return _productService.GetById(id);
        }

        [HttpPost("CreateProduct")]
        public void CreateProduct(Product createProduct) 
        {
            Product product = _mapper.Map<Product>(createProduct);
            if (createProduct == null) 
            {
                throw new NotFoundDataException("Don't Send All Info");
            }
            _productService.Create(createProduct);
        }

        [HttpPut("UpdateProduct")]
        public Product UpdateProduct(Product updateProduct) 
        {
            return _productService.Update(updateProduct);
        }

        [HttpDelete("DeleteProduct")]
        public void DeleteProduct(Product deleteProduct)
        {
            _productService.Delete(deleteProduct);
        }
    }
}
