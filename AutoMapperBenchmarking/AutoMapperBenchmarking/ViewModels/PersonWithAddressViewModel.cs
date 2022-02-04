namespace AutoMapperBenchmarking;

public class PersonWithAddressViewModel
{
    public Guid Id { get; set; }
    public DateOnly BirthDate { get; set; }
    public string LastName { get; set; } = null!;
    public string FirstName { get; set; } = null!;
    public string MiddleName { get; set; } = null!;
    public Guid AddressId { get; set; }
    public string City { get; set; } = null!;
    public string Street { get; set; } = null!;
    public string Building { get; set; } = null!;
    public string Flat { get; set; } = null!;
}