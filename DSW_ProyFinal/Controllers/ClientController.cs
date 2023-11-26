using Microsoft.AspNetCore.Mvc;
using DSW_ProyFinal.Models;
using DSW_ProyFinal.Repositories;
using System.Reflection.Metadata.Ecma335;

namespace DSW_ProyFinal.Controllers
{
    [ApiController]
    [Route("api/v1/[controller]")]
    public class ClientController : ControllerBase
    {
        private readonly IClientRepository clientRepository;
        public ClientController(IClientRepository clientRepository)
        {
            this.clientRepository = clientRepository;
        }

        [HttpGet]
        [Route("/GetClients")]
        public async Task<ActionResult<IEnumerable<Client>>> GetClients()
        {
            return StatusCode(StatusCodes.Status200OK, await clientRepository.GetClients());
        }

        [HttpGet]
        [Route("/GetClients/page/{page}/size/{size}")]
        public async Task<ActionResult<IEnumerable<Client>>> GetCliens(int page, int size)
        {
            return StatusCode(StatusCodes.Status200OK, await clientRepository.GetClients(page, size));
        }

        [HttpPost]
        [Route("/CreateClient")]
        public async Task<ActionResult<Client>> CreateClient(Client client)
        {
            return StatusCode(StatusCodes.Status201Created, await clientRepository.CreateClient(client));
        }

        [HttpGet]
        [Route("/GetClientById/{id}")]
        public async Task<ActionResult<Client>> GetClientById(int id)
        {
            return StatusCode(StatusCodes.Status200OK, await clientRepository.GetClientById(id));
        }

        [HttpPut]
        [Route("/UpdateClient")]
        public async Task<ActionResult<Client>> UpdateClient(Client client)
        {
            return StatusCode(StatusCodes.Status200OK, await clientRepository.UpdateClient(client));
        }

        [HttpDelete]
        [Route("/DeleteClient")]
        public async Task<ActionResult<Client>> DeleteClient(int id)
        {
            return StatusCode(StatusCodes.Status200OK, await clientRepository.DeleteClient(id));
        }
    }
}
