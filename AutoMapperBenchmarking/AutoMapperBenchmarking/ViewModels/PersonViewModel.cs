namespace AutoMapperBenchmarking;

public class PersonViewModel
{
    public Guid Id { get; set; }
    public DateOnly BirthDate { get; set; }
    public string LastName { get; set; } = null!;
    public string FirstName { get; set; } = null!;
    public string MiddleName { get; set; } = null!;
    public int TotalAddresses { get; set; }
    public int TotalPets { get; set; }
}