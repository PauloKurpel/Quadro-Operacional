using Quadro_Operacional.Models;
using Microsoft.EntityFrameworkCore;

namespace Quadro_Operacional.Data
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Quadro> QUADRO_OPERACIONAL { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=local;Database=baseLocal;User ID=admin;Password=123456;Integrated Security=False");
        }
    }
}
