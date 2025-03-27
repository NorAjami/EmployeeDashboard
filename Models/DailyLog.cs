namespace EmployeeDashboard.Models
{
    public class DailyLog
    {
        public Guid Id { get; set; } = Guid.NewGuid(); // Unik logg-ID
        public DateTime Date { get; set; } = DateTime.Today; // Loggens datum
        public string Author { get; set; } = string.Empty; // Vem skrev loggen?
        public string Content { get; set; } = string.Empty; // Vad gjorde personen?
    }
}
