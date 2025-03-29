using MongoDB.Bson;
using MongoDB.Driver;
using EmployeeDashboard.Models;

namespace EmployeeDashboard.Services
{
    public class MongoDailyLogService
    {
        private readonly IMongoCollection<DailyLog> _collection;

        public MongoDailyLogService(IConfiguration config)
        {
            var connectionString = config["MongoDB:ConnectionString"];
            var dbName = config["MongoDB:DatabaseName"];
            var collectionName = config["MongoDB:CollectionName"];
           
            var client = new MongoClient(connectionString); // ✅ Inget extra behövs!
            var database = client.GetDatabase(dbName);
            _collection = database.GetCollection<DailyLog>(collectionName);
        }

        public async Task<List<DailyLog>> GetAllAsync()
        {
            return await _collection.Find(_ => true).ToListAsync();
        }

        public async Task<DailyLog?> GetByIdAsync(Guid id)
        {
            return await _collection.Find(x => x.Id == id).FirstOrDefaultAsync();
        }

        public async Task AddAsync(DailyLog log)
        {
            Console.WriteLine("👉 AddAsync körs – försöker spara i MongoDB...");
            await _collection.InsertOneAsync(log);
        }

    }
}