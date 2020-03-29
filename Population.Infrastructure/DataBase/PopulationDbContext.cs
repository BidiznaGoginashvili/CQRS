using Microsoft.EntityFrameworkCore;

namespace Population.Infrastructure.DataBase
{
    public class PopulationDbContext : DbContext
    {
        protected override void OnConfiguring(
           DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=DESKTOP-OKIRIV8; Database=Population; Trusted_Connection=True");
        }

        public DbSet<Domain.Population.Population> Population { get; set; }
    }
}
