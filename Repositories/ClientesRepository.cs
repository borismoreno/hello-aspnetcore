using System.Collections.Generic;
using System.Threading.Tasks;
using HelloAspNetCore.Entities;
using MongoDB.Driver;

namespace HelloAspNetCore.Repositories
{
    public class ClientesRepository : IClientesRepository
    {
        private const string collectionName = "clientes";
        private readonly IMongoCollection<Cliente> dbCollection;
        private readonly FilterDefinitionBuilder<Cliente> filterDefinitionBuilder = Builders<Cliente>.Filter;

        public ClientesRepository(IMongoDatabase database)
        {
            dbCollection = database.GetCollection<Cliente>(collectionName);
        }

        public async Task<IReadOnlyCollection<Cliente>> GetAllAsync()
        {
            return await dbCollection.Find(filterDefinitionBuilder.Empty).ToListAsync();
        }
    }
}