using Microsoft.EntityFrameworkCore;
using SampleWebAPI.NET6.Models.Entities;

namespace SampleWebAPI.NET6.Models.Services.Infrastructure;

public partial class SampleWebApiDbContext : DbContext
{
    public SampleWebApiDbContext(DbContextOptions<SampleWebApiDbContext> options)
    : base(options)
    {
    }

    public virtual DbSet<Person> People { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.Entity<Person>(entity =>
        {
            entity.ToTable("People");
            entity.HasKey(person => person.Id);
        });
    }
}