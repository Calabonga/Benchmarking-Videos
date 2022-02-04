namespace AutoMapperBenchmarking.ViewModels;

public class PetWithPersonViewModel
{
    private Guid PersonId { get; set; }
    public string LastName { get; set; } = null!;
    public string FirstName { get; set; } = null!;
    public string MiddleName { get; set; } = null!;
    public Guid Id { get; set; }
    public string Name { get; set; } = null!;
    public string? Description { get; set; }
}