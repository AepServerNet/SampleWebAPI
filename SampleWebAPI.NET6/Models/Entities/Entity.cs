namespace SampleWebAPI.NET6.Models.Entities;

public abstract class Entity<TPrimaryKey>
{
    public TPrimaryKey Id { get; set; }
}
