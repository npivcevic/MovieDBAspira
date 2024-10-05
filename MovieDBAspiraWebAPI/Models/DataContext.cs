using Microsoft.EntityFrameworkCore;

namespace MovieDBAspiraWebAPI.Models
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
        }

        public DbSet<Movie> Movies { get; set; }
    }
}
