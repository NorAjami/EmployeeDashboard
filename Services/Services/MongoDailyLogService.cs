using EmployeeDashboard.Models;
using Microsoft.Extensions.Options;
using MongoDB.Driver;

namespace EmployeeDashboard.Services
{
    public class MongoDailyLogService
    {
        private readonly IMongoCollection<DailyLog> _collection;

        public MongoDailyLogService(IConfiguration config)
        {
            // Läser från appsettings + secrets
            var connectionString = config["MongoDB:ConnectionString"];
            var dbName = config["MongoDB:DatabaseName"];
            var collectionName = config["MongoDB:CollectionName"];

            var client = new MongoClient(connectionString);
            var database = client.GetDatabase(dbName);
            _collection = database.GetCollection<DailyLog>(collectionName);
        }

        public async Task<List<DailyLog>> GetAllAsync()
        {
            return await _collection.Find(_ => true).ToListAsync();
        }

        public async Task<DailyLog?> GetByIdAsync(Guid id)
        {
            return await _collection.Find(l => l.Id == id).FirstOrDefaultAsync();
        }

        public async Task AddAsync(DailyLog log)
        {
            await _collection.InsertOneAsync(log);
        }
    }
}
