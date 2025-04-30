using Hafta10.Models;
using Microsoft.EntityFrameworkCore;

namespace Hafta10.Data
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> o):base(o)
        {
            
        }

        public DbSet<Ogrenci> Ogrenci { get; set; }
        public DbSet<Not> Not { get; set; }
    }
}
