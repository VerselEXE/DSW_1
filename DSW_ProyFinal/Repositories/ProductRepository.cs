using DSW_ProyFinal.Models;
using DSW_ProyFinal.DbContexts;
using DSW_ProyFinal.Exceptions;
using Microsoft.EntityFrameworkCore;

namespace DSW_ProyFinal.Repositories
{
    public class ProductRepository : IProductRepository
    {
        private readonly AppDbContext dbContext;
        //Inyeccion dependencias
        public ProductRepository(AppDbContext dbcontext)
        {
            this.dbContext = dbcontext;
        }
        //Metodos
        public async Task<Product> CreateProduct(Product product)
        {
            dbContext.Products.Add(product);
            await dbContext.SaveChangesAsync();
            return product;
        }

        public async Task<bool> DeleteProduct(int id)
        {
            var product = await dbContext.Products.FirstOrDefaultAsync(p => p.prodId==id);
            if (product == null)
                return false;
            dbContext.Products.Remove(product);
            await dbContext.SaveChangesAsync();
            return true;
        }

        public async Task<Product> GetProductById(int id)
        {
            var product = await dbContext.Products.FirstOrDefaultAsync(p => p.prodId == id);
            if (product == null)
            {
                throw new NotFoundException($"Product not found with id {id}");
            }
            return product;
        }

        public async Task<IEnumerable<Product>> GetProducts()
        {
            return await dbContext.Products.ToListAsync();

        }

        public async Task<IEnumerable<Product>> GetProducts(int page, int size)
        {
            var result = await dbContext.Products
                .Skip(page*size)
                .Take(size)
                .ToListAsync();

            if (result == null)
            {
                throw new Exception();
            }
            else if (result.Count == 0)
            {
                throw new NotFoundException("Product List is Empty");
            }
            return result;
        }

        public async Task<Product> UpdateProduct(Product product)
        {
            dbContext.Products.Update(product);
            await dbContext.SaveChangesAsync();
            return product;
        }
    }
}
