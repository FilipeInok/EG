using Microsoft.EntityFrameworkCore;
using Vinhos.Models;

namespace Vinhos.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
                
        }

        public DbSet<Regioes> Regioes { get; set; }
    }
}
