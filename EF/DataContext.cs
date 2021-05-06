using Microsoft.EntityFrameworkCore;
using Model;


namespace EF
{
    public class DataContext:DbContext
    {
        public DbSet<Employee> Employee { get; set; }

        public DataContext()
        {
            Database.EnsureCreated();
        }
        
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=localhost\\SQLEXPRESS;Database=Arch;Trusted_Connection=True;");
        }
    }
}
