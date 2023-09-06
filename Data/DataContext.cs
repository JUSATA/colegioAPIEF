global using Microsoft.EntityFrameworkCore;
global using colegioAPIEF.Models;

namespace colegioAPIEF.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder); 
            optionsBuilder.UseSqlServer("Server=DESKTOP-6VTD3TF\\SQLEXPRESS; Database=StudentAssignmt; Trusted_Connection=True;TrustServerCertificate=true;");
        }

        public DbSet<Estudiante> Students { get; set; }
    }
}