using Microsoft.EntityFrameworkCore;

namespace GardenPlanner.Models
{
    public class ApplicationContext : DbContext
    {
        public ApplicationContext(DbContextOptions<ApplicationContext> options) : base(options)
        {

        }
        public DbSet<Plant> Plants { get; set; }
    }
}
