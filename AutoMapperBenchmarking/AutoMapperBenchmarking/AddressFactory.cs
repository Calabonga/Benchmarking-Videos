using AutoMapperBenchmarking.Models;

namespace AutoMapperBenchmarking;

public static class AddressFactory
{
    public static List<Address> GetAddresses() => new List<Address>
    {
        new()
        {
            IsDefault = true,
            Building = "3",
            City = "Гваделупинск",
            Flat = "10",
            Id = Guid.Parse("733691be-dff4-d49e-46a2-274d04e324be"),
            Name = "Основной адрес",
            Street = "Зеленая"
        },
        new()
        {
            IsDefault = false,
            Building = "110",
            City = "Светосранск",
            Flat = "71",
            Id = Guid.Parse("dabfc720-4817-73b2-4c2a-f477363820d6"),
            Name = "Дополнительный адрес",
            Street = "Зеленая"
        }
    };
}