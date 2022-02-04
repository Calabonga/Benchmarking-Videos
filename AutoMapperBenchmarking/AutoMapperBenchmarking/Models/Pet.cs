namespace AutoMapperBenchmarking.Models;

public class Pet
{
    public Guid Id { get; set; }
    public string Name { get; set; } = null!;
    public string? Description { get; set; }
}