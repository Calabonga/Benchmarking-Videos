using AutoMapperBenchmarking.Models;

namespace AutoMapperBenchmarking;

public static class PetFactory
{
    public static List<Pet> GetPets() =>
        new List<Pet>
        {
            new()
            {
                Id = Guid.Parse("7bbb48ca-4d73-e7ba-4503-b13fd0ff976c"),
                Name = "Шарик",
                Description = "Пограничный пёс"
            },
            new()
            {
                Id = Guid.Parse("aca35f1e-d32a-74b4-4c35-8122635ce4e4"),
                Name = "Титаник",
                Description = "Боевая рыбка"
            }
        };
}