using L6_Generics;
using L6_Generics.Classwork;
using L6_Generics.EFCore;

//Result<string> result = GetUsername();

//var value = result.GetValue();

Console.WriteLine(EnumHelper.ConcatEnumValues<FaberliqueProducts>());

_ =
"""
Написать интерфейс IBuilding с параметром типа TMaterial.
TMaterial должен быть классом и наследоваться от класса Material.
Создать класс Material, который содержит название строй материала.
""";

ConcreteMaterial material = new ConcreteMaterial();

IBuilding<ConcreteMaterial> building = new AsylTash(material);

Console.WriteLine(building.Material.Name);

var playerService = new EntityService<Player>();

var player = playerService.GetById(228);

// ниже локальные функции
Result<string> GetUsername()
{
    var username = Console.ReadLine();

    if (string.IsNullOrWhiteSpace(username))
    {
        return new Result<string>() { Error = "Username cannot be empty." };
    }

    return new Result<string>() { Value = username };
}

Result<int> GetAge()
{
    var age = Console.ReadLine();

    int.TryParse(age, out int ageResult);

    if (ageResult <= 0)
    {
        return new Result<int>() { Error = "Age cannot be zero." };
    }

    if (ageResult < 18)
    {
        return new Result<int>() { Error = "Age cannot less than 18." };
    }

    return new Result<int>() { Value = ageResult };
}