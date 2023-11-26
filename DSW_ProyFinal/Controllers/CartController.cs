using DSW_ProyFinal.Models;
using DSW_ProyFinal.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace DSW_ProyFinal.Controllers
{
    [ApiController]
    [Route("api/v1/[controller]")]
    public class CartController:ControllerBase
    {
        private readonly ICartRepository cartRepository;
        public CartController(ICartRepository cartRepository)
        {
            this.cartRepository = cartRepository;
        }

        [HttpPost]
        [Route("/PlaceOrder")]
        public async Task<ActionResult<bool>> PlaceOrder(Order order)
        {
            return StatusCode(StatusCodes.Status200OK, await cartRepository.PlaceOrder(order));
        }
    }
}
