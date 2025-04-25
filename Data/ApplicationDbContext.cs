using Microsoft.EntityFrameworkCore;
using LineWebApp1.Models;

namespace LineWebApp1.Data
{
    public class ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
    : DbContext(options)
    {
        public DbSet<ExceptionReport> ExceptionReports { get; set; }
    }
}
