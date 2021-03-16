using LinqHomeWork.Blanks;
using Microsoft.EntityFrameworkCore;

namespace LinqHomeWork.DataAccess
{
    public class LibraryContext:DbContext
    {
        public LibraryContext()
        {
            Database.EnsureCreated();
        }

        public DbSet<Hdd> Hdds { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server = Desktop-9ep80dv; DataBase = LinqShop;Trusted_Connection = true");
        }
    }
}
