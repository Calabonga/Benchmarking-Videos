namespace AutoMapperBenchmarking.ViewModels;

public class PetViewModel
{
    public Guid Id { get; set; }
    public string Name { get; set; } = null!;
    public string? Description { get; set; }
}