using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HelloAspNetCore.Dtos;
using HelloAspNetCore.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace HelloAspNetCore.Controllers
{
    [ApiController]
    [Route("clientes")]
    public class ClientesController: ControllerBase
    {
        private readonly IClientesRepository clientesRepository;
        public ClientesController(IClientesRepository clientesRepository)
        {
            this.clientesRepository = clientesRepository;
        }

        [HttpGet]
        public async Task<IEnumerable<ClienteDto>> GetAsync()
        {
            var clientes = (await clientesRepository.GetAllAsync())
                        .Select(cliente => cliente.AsDto());
            return clientes;
        }
    }
}