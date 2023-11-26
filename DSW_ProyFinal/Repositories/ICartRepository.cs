using DSW_ProyFinal.Models;
namespace DSW_ProyFinal.Repositories
{
    public interface ICartRepository
    {
        public Task<bool> PlaceOrder(Order order);
    }
}
