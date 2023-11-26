using DSW_ProyFinal.DbContexts;
using DSW_ProyFinal.Exceptions;
using DSW_ProyFinal.Models;
using Microsoft.EntityFrameworkCore;

namespace DSW_ProyFinal.Repositories
{
    public class ClientRepository : IClientRepository
    {
        private readonly AppDbContext dbContext;

        public ClientRepository(AppDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public async Task<Client> CreateClient(Client client)
        {
            dbContext.Clients.Add(client);
            await dbContext.SaveChangesAsync();
            return client;
        }

        public async Task<bool> DeleteClient(int id)
        {
            var client = await dbContext.Clients.FirstOrDefaultAsync(c => c.clientId==id);
            if (client == null)
                return false;
            dbContext.Clients.Remove(client);
            await dbContext.SaveChangesAsync();
            return true;
        }

        public async Task<Client> GetClientById(int id)
        {
            var client = await dbContext.Clients.FirstOrDefaultAsync(c => c.clientId==id);
            if (client == null)
                throw new NotFoundException($"Client not found with id {id}");
            return client;
        }

        public async Task<IEnumerable<Client>> GetClients()
        {
            return await dbContext.Clients.ToListAsync();
        }

        public async Task<IEnumerable<Client>> GetClients(int page, int size)
        {
            var result = await dbContext.Clients.Skip(page*size).Take(size).ToListAsync();
            if (result == null)
            {
                throw new Exception();
            }
            else if (result.Count == 0)
            {
                throw new NotFoundException("Client List is Empty");
            }
            return result;
        }

        public async Task<Client> UpdateClient(Client client)
        {
            dbContext.Clients.Update(client);
            await dbContext.SaveChangesAsync();
            return client;
        }
    }
}
