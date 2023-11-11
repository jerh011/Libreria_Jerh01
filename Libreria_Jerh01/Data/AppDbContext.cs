using Libreria_Jerh01.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace Libreria_Jerh01.Data
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options):base(options) {
        
        }
        public DbSet<Books> Books { get; set; }
    }
}
