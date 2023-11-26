using DSW_ProyFinal.Models;
using DSW_ProyFinal.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace DSW_ProyFinal.Controllers
{
    [ApiController]
    [Route("api/v1/[controller]")]
    public class ProductController : ControllerBase
    {
        private readonly IProductRepository productRepository;
        public ProductController(IProductRepository productRepository)
        {
            this.productRepository = productRepository;
        }

        [HttpGet]
        [Route("/GetProducts")]
        public async Task<ActionResult<IEnumerable<Product>>> GetProducts()
        {
            return StatusCode(StatusCodes.Status200OK, await productRepository.GetProducts());
        }

        [HttpGet]
        [Route("/GetProducts/page/{page}/size/{size}")]
        public async Task<ActionResult<IEnumerable<Product>>> GetProducts(int page, int size)
        {
            return StatusCode(StatusCodes.Status200OK, await productRepository.GetProducts(page, size));
        }

        [HttpGet]
        [Route("/GetProductById/{id}")]
        public async Task<ActionResult<Product>> GetProductById(int id)
        {
            return StatusCode(StatusCodes.Status200OK, await productRepository.GetProductById(id));
        }

        [HttpPost]
        [Route("/CreateProduct")]
        public async Task<ActionResult<Product>> CreateProduct(Product product)
        {
            return StatusCode(StatusCodes.Status201Created, await productRepository.CreateProduct(product));
        }

        [HttpPut]
        [Route("/UpdateProduct")]
        public async Task<ActionResult<Product>> UpdateProduct(Product product)
        {
            return StatusCode(StatusCodes.Status200OK, await productRepository.UpdateProduct(product));
        }

        [HttpDelete]
        [Route("/DeleteProduct")]
        public async Task<ActionResult<bool>> DeleteProduct(int id)
        {
            return StatusCode(StatusCodes.Status200OK, await productRepository.DeleteProduct(id));
        }
    }
}
