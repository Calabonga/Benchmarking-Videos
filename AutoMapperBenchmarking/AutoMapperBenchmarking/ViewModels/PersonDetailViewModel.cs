namespace AutoMapperBenchmarking;

public class PersonDetailViewModel
{
    public Guid Id { get; set; }
    public DateOnly BirthDate { get; set; }
    public string LastName { get; set; } = null!;
    public string FirstName { get; set; } = null!;
    public string MiddleName { get; set; } = null!;
    public virtual List<AddressViewModel>? Addresses { get; set; }
    public virtual List<PetViewModel>? Pets { get; set; }
}