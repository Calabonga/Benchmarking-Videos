namespace AutoMapperBenchmarking.Models;

public class Person
{
    public Guid Id { get; set; }
    public DateOnly BirthDate { get; set; }
    public string LastName { get; set; } = null!;
    public string FirstName { get; set; } = null!;
    public string MiddleName { get; set; } = null!;
    public virtual ICollection<Address>? Addresses { get; set; }
    public virtual ICollection<Pet>? Pets { get; set; }
}