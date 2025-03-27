using EmployeeDashboard.Models;
using EmployeeDashboard.Services;
using Microsoft.AspNetCore.Mvc;

namespace EmployeeDashboard.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class DailyLogController : ControllerBase
    {
        private readonly MongoDailyLogService _logService;

        public DailyLogController(MongoDailyLogService logService)
        {
            _logService = logService;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<DailyLog>>> GetAll()
        {
            var logs = await _logService.GetAllAsync();
            return Ok(logs);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<DailyLog>> GetById(Guid id)
        {
            var log = await _logService.GetByIdAsync(id);
            return log is null ? NotFound() : Ok(log);
        }

        [HttpPost]
        public async Task<ActionResult<DailyLog>> Add(DailyLog log)
        {
            await _logService.AddAsync(log);
            return CreatedAtAction(nameof(GetById), new { id = log.Id }, log);
        }
    }
}
