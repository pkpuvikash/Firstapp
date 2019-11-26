using Microsoft.EntityFrameworkCore;

namespace firstapp.api.Model
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) {}

        public DbSet<value> Values { get; set; }
        
    }
}