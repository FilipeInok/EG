using Microsoft.EntityFrameworkCore;
using UFCD10792.Models;

namespace UFCD10792.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
            
        }

        public DbSet<UFCD> UFCD { get; set; }
    }
}
