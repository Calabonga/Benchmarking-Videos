using AutoMapper;
using AutoMapperBenchmarking.Models;
using BenchmarkDotNet.Attributes;

namespace AutoMapperBenchmarking.ViewModels;

[MemoryDiagnoser]
public class AutoMapperBenchmarks
{
    private readonly Person _person;
    private readonly IMapper _mapper;

    public AutoMapperBenchmarks()
    {
        _person = new Person
        {
            Id = Guid.Parse("e642c6b0-d507-0b80-4e4f-9468e04f77e0"),
            BirthDate = new DateOnly(2000, 02, 22),
            FirstName = "Дормидонт",
            MiddleName = "Евлампьевич",
            LastName = "Тихобздеев",
            Addresses = AddressFactory.GetAddresses(),
            Pets = PetFactory.GetPets()
        };

        var mapperConfig = new MapperConfiguration(configure: x =>
        {
            x.CreateMap<Person, PersonViewModel>();
        });
        _mapper = mapperConfig.CreateMapper();
    }

    [Benchmark]
    public PersonViewModel PersonManual()
    {
        return new PersonViewModel
        {
            Id = _person.Id,
            BirthDate = _person.BirthDate,
            FirstName = _person.FirstName,
            LastName = _person.LastName,
            MiddleName = _person.MiddleName,
            TotalAddresses = _person.Addresses!.Count,
            TotalPets = _person.Pets!.Count
        };
    }

    [Benchmark]
    public PersonViewModel PersonAutoMapper()
    {
        return _mapper.Map<PersonViewModel>(_person);
    }
}