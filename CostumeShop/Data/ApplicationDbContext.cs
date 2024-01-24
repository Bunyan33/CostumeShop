using CostumeShop.Models;
using Microsoft.EntityFrameworkCore;

namespace CostumeShop.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        public DbSet<Brand> Brand { get; set; }
    }
}
