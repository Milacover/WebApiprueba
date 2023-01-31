using APIService.IServices;
using Entities.Entities;
using Microsoft.AspNetCore.Mvc;

namespace APIService.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProductController : ControllerBase
    {
        private readonly ILogger<ProductController> _logger;
        private readonly IProductService _productService;
        public ProductController(ILogger<ProductController> logger, IProductService productService)
        {
            _logger = logger;
            _productService = productService;
        }

        [HttpPost(Name = "InsertProduct")]
        public int Post([FromBody] ProductItem productItem)
        {
            return _productService.InsertProduct(productItem);
        }

        [HttpPatch(Name = "PatchProduct")]
        public int Put([FromBody] ProductItem productItem)
        {
            return _productService.PatchProduct(productItem);
        }


        [HttpGet(Name = "GetProduct")]
        //nombreSitio.com/nombreController/id
        public List<ProductItem> Get()
        {
            return _productService.GetProduct();
        }


        [HttpDelete(Name = "DeleteProduct")]
        public void DeleteById(int id)
        {
            _productService.DeleteProductById(id);
        }
    }
}