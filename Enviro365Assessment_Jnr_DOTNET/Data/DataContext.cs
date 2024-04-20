using Enviro365Assessment_Jnr_DOTNET.Model;
using Microsoft.EntityFrameworkCore;

namespace Enviro365Assessment_Jnr_DOTNET.Data;

public class DataContext : DbContext
{
    public DbSet<EnvironmentData> EnvironmentData { get; set; }

    protected DataContext()
    {
    }

    public DataContext(DbContextOptions options) : base(options)
    {
    }

    protected void OnConfiguring(DbContextOptionsBuilder optionsBuilder, IConfiguration configuration)
    {
        base.OnConfiguring(optionsBuilder.UseNpgsql(configuration.GetConnectionString("DefaultConnection")));
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<EnvironmentData>().ToTable("EnvironmentData");
        modelBuilder.Entity<EnvironmentData>().HasKey("Id");
        modelBuilder.Entity<EnvironmentData>().Property("Id").HasColumnName("EnvironmentDataId").IsRequired();
        modelBuilder.Entity<EnvironmentData>().Property("FileName").HasColumnName("File_name").IsRequired();
        modelBuilder.Entity<EnvironmentData>().Property("UploadDate").HasColumnName("Upload_Date").IsRequired();
        modelBuilder.Entity<EnvironmentData>().Property("ProcessedData").HasColumnName("Processed_Data").IsRequired();
    }
}