using EntityFramework.Entity;
using Microsoft.EntityFrameworkCore;

namespace EntityFramework
{
    public class PryanikyDBContext: DbContext
    {
        public DbSet<Product> Products { get; set; }
        public DbSet<Order> Orders { get; set; }

        public PryanikyDBContext(DbContextOptions<PryanikyDBContext> options)
            :base(options)
        {
        }
    }
}