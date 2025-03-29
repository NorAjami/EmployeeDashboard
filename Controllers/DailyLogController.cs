using Microsoft.AspNetCore.Mvc;
using EmployeeDashboard.Models;
using EmployeeDashboard.Services;
using EmployeeDashboard.Controllers;


namespace EmployeeDashboard.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class DailyLogController : ControllerBase
    {

        private readonly MongoDailyLogService _service;

        // Tillfällig in-memory lista
        private static readonly List<DailyLog> Logs = new();

        [HttpPost]
        public async Task<IActionResult> Add([FromBody] DailyLog log)
        {
           
            await _service.AddAsync(log);
            return Ok(log); // 👈 enklare tills vi har GetById 
        }


        // POST: /api/dailylog
        [HttpPost]
        public ActionResult<DailyLog> AddLog(DailyLog log)
        {
            Logs.Add(log);
            return CreatedAtAction(nameof(GetLogById), new { id = log.Id }, log);
        }

        // GET: /api/dailylog
        [HttpGet]
        public ActionResult<IEnumerable<DailyLog>> GetAllLogs()
        {
            return Ok(Logs.OrderByDescending(l => l.Date));
        }

        // GET: /api/dailylog/{id}
        [HttpGet("{id}")]
        public ActionResult<DailyLog> GetLogById(Guid id)
        {
            var log = Logs.FirstOrDefault(l => l.Id == id);
            if (log == null)
                return NotFound($"No log found with id: {id}");

            return Ok(log);
        }
    }
}
