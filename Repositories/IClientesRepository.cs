using System.Collections.Generic;
using System.Threading.Tasks;
using HelloAspNetCore.Entities;

namespace HelloAspNetCore.Repositories
{
    public interface IClientesRepository
    {
        Task<IReadOnlyCollection<Cliente>> GetAllAsync();
    }
}