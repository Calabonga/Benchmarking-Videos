namespace AutoMapperBenchmarking;

public class AddressViewModel
{
    public Guid Id { get; set; }
    public bool IsDefault { get; set; }
    public string Name { get; set; } = null!;
    public string City { get; set; } = null!;
    public string Street { get; set; } = null!;
    public string Building { get; set; } = null!;
    public string Flat { get; set; } = null!;
}