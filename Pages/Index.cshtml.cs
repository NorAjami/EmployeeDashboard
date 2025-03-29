using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using EmployeeDashboard.Models;
using EmployeeDashboard.Services;

namespace EmployeeDashboard.Pages
{
    public class IndexModel : PageModel
    {
        private readonly MongoDailyLogService _service;

        public IndexModel(MongoDailyLogService service)
        {
            _service = service;
        }

        [BindProperty]
        public string Author { get; set; } = "";

        [BindProperty]
        public string ContentText { get; set; } = "";

        public List<DailyLog> Logs { get; set; } = new();

        public async Task OnGetAsync()
        {
            Logs = await _service.GetAllAsync();
        }

        public async Task<IActionResult> OnPostAsync()
        {
            var newLog = new DailyLog
            {
                Author = Author,
                Content = ContentText,
                Date = DateTime.UtcNow
            };

            await _service.AddAsync(newLog);
            return RedirectToPage();
        }
    }
}
