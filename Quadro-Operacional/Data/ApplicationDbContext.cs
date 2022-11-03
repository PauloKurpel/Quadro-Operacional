using Quadro_Operacional.Models;
using Microsoft.EntityFrameworkCore;

namespace Quadro_Operacional.Data
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Quadro> QUADRO_OPERACIONAL { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=10.0.0.6;Database=PRO_MIS_AMIL;User ID=Control_Desk;Password=123456;Integrated Security=False");
        }
    }
}
