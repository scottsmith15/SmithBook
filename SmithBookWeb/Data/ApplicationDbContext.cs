using Microsoft.EntityFrameworkCore;
using SmithBookWeb.Models;

namespace SmithBookWeb.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) 
        {
        }

        public DbSet<Category> Categories { get; set; }
    }
}
