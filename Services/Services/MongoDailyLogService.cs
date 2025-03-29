using EmployeeDashboard.Models;
using Microsoft.Extensions.Options;
using MongoDB.Driver;

namespace EmployeeDashboard.Services
{
    public class MongoDailyLogService
    {
        private readonly IMongoCollection<DailyLog> _collection;

        public MongoDailyLogService(IOptions<MongoDbSettings> settings)
        {
            var config = settings.Value;
            var client = new MongoClient(config.ConnectionString);
            var database = client.GetDatabase(config.DatabaseName);
            _collection = database.GetCollection<DailyLog>(config.CollectionName);
        }

        public async Task<List<DailyLog>> GetAllAsync()
        {
            return await _collection.Find(_ => true).ToListAsync();
        }

        public async Task<DailyLog?> GetByIdAsync(string id)
        {
            return await _collection.Find(log => log.Id == Guid.Parse(id)).FirstOrDefaultAsync();
        }

        public async Task AddAsync(DailyLog log)
        {
            await _collection.InsertOneAsync(log);
        }

        public async Task DeleteAsync(string id)
        {
            await _collection.DeleteOneAsync(log => log.Id == Guid.Parse(id));
        }
    }
}
