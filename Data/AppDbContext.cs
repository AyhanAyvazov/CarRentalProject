using Cars.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace Cars.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
           
            
        }

        public DbSet<Car> Cars { get; set; }
    }
}
