namespace AutoMapperBenchmarking.ViewModels;

public class AddressWithPersonViewModel
{
    private Guid PersonId { get; set; }
    public string LastName { get; set; } = null!;
    public string FirstName { get; set; } = null!;
    public string MiddleName { get; set; } = null!;
    public Guid Id { get; set; }
    public bool IsDefault { get; set; }
    public string Name { get; set; } = null!;
    public string City { get; set; } = null!;
    public string Street { get; set; } = null!;
    public string Building { get; set; } = null!;
    public string Flat { get; set; } = null!;
}