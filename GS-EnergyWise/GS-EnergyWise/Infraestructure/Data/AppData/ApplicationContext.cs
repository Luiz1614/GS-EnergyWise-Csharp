using GS_EnergyWise.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace GS_EnergyWise.Infraestructure.Data.AppData;

public class ApplicationContext : DbContext
{
    public DbSet<ComunidadeEntity> Comunidades { get; set; }

    public ApplicationContext(DbContextOptions<ApplicationContext> options) : base(options){}

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<ComunidadeEntity>().ToTable("GS1_Comunidade");
    }
}
