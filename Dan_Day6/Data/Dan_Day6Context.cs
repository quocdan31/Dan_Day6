using Microsoft.EntityFrameworkCore;
using Dan_Day6.Models;

namespace Dan_Day6.Data
{
    public class Dan_Day6Context : DbContext
    {
        public Dan_Day6Context(DbContextOptions<Dan_Day6Context> options)
            : base(options)
        {
        }

        public DbSet<Product> Product { get; set; } = default!;
        public DbSet<Movie> Movie { get; set; } = default!;
    }
}
