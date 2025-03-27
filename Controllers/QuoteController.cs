using Microsoft.AspNetCore.Mvc;
using EmployeeDashboard.Models;

namespace EmployeeDashboard.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class QuoteController : ControllerBase
    {
        // Tillfällig lista med hårdkodade citat
        private static readonly List<Quote> Quotes = new()
        {
            new Quote { Id = 1, Text = "The wound is the place where the Light enters you.", Author = "Rumi", Category = "poetry" },
            new Quote { Id = 2, Text = "He who has a why to live can bear almost any how.", Author = "Nietzsche", Category = "philosophy" },
            new Quote { Id = 3, Text = "You have power over your mind – not outside events.", Author = "Marcus Aurelius", Category = "stoicism" }
        };

        // GET: /api/quote
        [HttpGet]
        public ActionResult<Quote> GetRandomQuote()
        {
            var random = new Random();
            var quote = Quotes[random.Next(Quotes.Count)];
            return Ok(quote);
        }

        // GET: /api/quote?category=poetry
        [HttpGet("search")]
        public ActionResult<Quote> GetByCategory([FromQuery] string category)
        {
            var filtered = Quotes.Where(q => q.Category?.ToLower() == category.ToLower()).ToList();
            if (!filtered.Any())
                return NotFound($"No quotes found in category '{category}'");

            var random = new Random();
            return Ok(filtered[random.Next(filtered.Count)]);
        }
    }
}
