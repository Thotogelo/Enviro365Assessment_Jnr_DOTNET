using Enviro365Assessment_Jnr_DOTNET.Model;
using Microsoft.EntityFrameworkCore;

namespace Enviro365Assessment_Jnr_DOTNET.Data;

public class DataContext : DbContext
{
    private readonly IConfiguration _configuration;
    public DbSet<EnvFile> EnvironmentData { get; set; }

    protected DataContext()
    {
    }

    public DataContext(DbContextOptions options, IConfiguration configuration) : base(options)
    {
        _configuration = configuration;
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        base.OnConfiguring(optionsBuilder.UseNpgsql(_configuration.GetConnectionString("DefaultConnection")));
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<EnvFile>(entity =>
        {
            entity.ToTable("EnvFileEnvData")
                .HasKey(e => e.Id);
            entity.Property(e => e.Id).HasColumnName("EnvDataId").IsRequired();

            entity.Property(e => e.FileName).HasColumnName("File_name").IsRequired();

            entity.Property(e => e.UploadDate).HasColumnName("Upload_Date").IsRequired();

            entity.Property(e => e.ProcessedData).HasColumnName("Processed_Data").IsRequired();
        });
    }
}