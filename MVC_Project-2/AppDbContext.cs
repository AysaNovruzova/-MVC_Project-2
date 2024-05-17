using Microsoft.EntityFrameworkCore;

namespace MVC_Project_2
{
    internal class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }
    }
}