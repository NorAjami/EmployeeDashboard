namespace EmployeeDashboard.Models
{
    public class Quote
    {
        public int Id { get; set; } // Unik identifierare
        public string Text { get; set; } = string.Empty; // Själva citatet
        public string Author { get; set; } = string.Empty; // Vem som sa det
        public string? Category { get; set; } // T.ex. "philosophy", "poetry"
    }
}
