using DSW_ProyFinal.DbContexts;
using DSW_ProyFinal.Models;

namespace DSW_ProyFinal.Repositories
{
    public class CartRepository:ICartRepository
    {
        private readonly AppDbContext dbcontext;
        public CartRepository(AppDbContext dbcontext)
        {
            this.dbcontext = dbcontext;
        }

        public async Task<bool> PlaceOrder(Order order)
        {
            try
            {
                dbcontext.Add(order);
                await dbcontext.SaveChangesAsync();
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }
    }
}
