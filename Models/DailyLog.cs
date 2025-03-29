using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace EmployeeDashboard.Models
{
    public class DailyLog
    {
        [BsonId]
        [BsonRepresentation(BsonType.String)] // 👈 Tvingar Mongo att lagra Guid som sträng
        public Guid Id { get; set; } = Guid.NewGuid();

        public string Author { get; set; } = string.Empty;
        public string Content { get; set; } = string.Empty;
        public DateTime Date { get; set; } = DateTime.UtcNow;
    }
}
