using DSW_ProyFinal.Models;

namespace DSW_ProyFinal.Repositories
{
    public interface IClientRepository
    {
        Task<IEnumerable<Client>> GetClients();
        Task<IEnumerable<Client>> GetClients(int page, int size); //paginacion
        Task<Client> GetClientById(int id);
        Task<Client> CreateClient(Client client);
        Task<Client> UpdateClient(Client client);
        Task<bool> DeleteClient(int id);
    }
}
