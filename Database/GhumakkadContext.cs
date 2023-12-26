using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace GhumakkadAPI.Database;

public partial class GhumakkadContext : DbContext
{
    public GhumakkadContext()
    {
    }

    public GhumakkadContext(DbContextOptions<GhumakkadContext> options)
        : base(options)
    {
    }
    

    public virtual DbSet<Article> Articles { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)

{
    if (!optionsBuilder.IsConfigured)
        {
            IConfigurationRoot configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();
            var connectionString = configuration.GetConnectionString("ConnectionStrings");
            optionsBuilder.UseSqlServer(connectionString);
        }
}
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Article>(entity =>
        {
            entity.HasKey(e => e.ArticleId).HasName("PK__Articles__9C6270E82F57226E");

            entity.Property(e => e.CreatedDate).HasColumnType("date");
            entity.Property(e => e.Description).HasColumnType("text");
            entity.Property(e => e.Title).IsUnicode(false);
            entity.Property(e => e.UpdatedDate).HasColumnType("date");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
