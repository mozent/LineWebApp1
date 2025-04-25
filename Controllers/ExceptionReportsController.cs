using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using LineWebApp1.Models;
using LineWebApp1.Data;
namespace LineWebApp1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ExceptionReportsController(ApplicationDbContext context) : ControllerBase
    {
        [HttpPost]
        public async Task<IActionResult> Post(ExceptionReport report)
        {
            context.ExceptionReports.Add(report);
            await context.SaveChangesAsync();
            return CreatedAtAction(nameof(Get), new { id = report.Id }, report);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<ExceptionReport>> Get(string id)
        {
            var report = await context.ExceptionReports.FindAsync(id);
            return report is null ? NotFound() : report;
        }
    }
}
