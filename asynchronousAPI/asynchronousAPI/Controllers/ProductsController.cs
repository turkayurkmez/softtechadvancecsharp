using asynchronousAPI.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace asynchronousAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly ProductService productService;

        public ProductsController(ProductService productService)
        {
            this.productService = productService;
        }
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var products = await productService.GetProductsAsync();
            return Ok(products);
        }
    }
}
