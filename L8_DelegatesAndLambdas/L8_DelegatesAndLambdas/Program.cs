
using L8_DelegatesAndLambdas;

List<string> names = new List<string>()
{
    "Саша", "Паша", "Айгуль", "Дима", "Дима", "Дима", "Дима", "Бакыт"
};

var dimas = ListHelper.MyWhere(names, Filter);

foreach (var name in dimas)
{
    Console.WriteLine(name);
}

bool Filter(string name)
{
    return name == "Дима";
}



////string setting = "pineapple";
//string setting = "watermelon";

//MyDelegate? predicate = null;

//if (setting == "pineapple")
//    predicate = FruitHelper.IsPineapple;
//else if (setting == "watermelon")
//    predicate = FruitHelper.IsWatermelon;

//var fruit = Console.ReadLine() ?? string.Empty;

//var result = predicate?.Invoke(fruit) ?? false;

//if (!result) Console.WriteLine("Неверный фрукт!");

//Func<string, bool> isPineapple = FruitHelper.IsPineapple;
//Action<string> helloWorld = Console.WriteLine;



//MyDelegate? isPineapple = FruitHelper.IsWatermelon;
//MyDelegate2? helloWorld = Console.WriteLine;

//isPineapple("pineapple");

//isPineapple.Invoke("pineapple");

//helloWorld();