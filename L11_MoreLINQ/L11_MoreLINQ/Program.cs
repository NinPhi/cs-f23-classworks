
using L11_MoreLINQ.Example1;
using L11_MoreLINQ.Example2;

//Холодильник холодильник = new Холодильник();

//_ = """
//Открыть холодильник.
//Найти все неиспорченные продукты.
//Найти все овощи.
//Посчитать каждый вид овоща.
//Получить среднее число порций.
//Закрыть холодильник.
//""";

//double среднееЧислоПорцийСалата =
//    холодильник.Продукты
//    .Where(продукт => !продукт.Испорчен)
//    .Where(продукт => продукт.Название is "Помидор" or "Киндза" or "Огурец" or "Перец")
//    .GroupBy(продукт => продукт.Название)
//    .Select(группа =>
//    {
//        if (группа.Key == "Огурец")
//            return группа.Count() / 2d;

//        if (группа.Key == "Киндза")
//            return группа.Count() * 2;

//        return группа.Count();
//    })
//    .Average();

//Console.WriteLine($"{среднееЧислоПорцийСалата:0.00}");

DataSource source = new DataSource();

var planets1 = source.Planets.Take(30);
var planets2 = source.Planets.Skip(30).Take(25);

var planets3 = planets1.Concat(planets2);

var planets = source.Planets
    .OrderBy(p => p.Radius)
    .GroupBy(p => p.Type)
    .SelectMany(p => p)
    .OrderBy(p => p.Name);

_ = """
    Из списка планет
    возьми все планеты с радиусом более 0.9
    отсортируй планеты по типу в обратном порядке
    создай список из строки ToString каждой планеты
    выбери строки длиной менее 69
    сконвертируй IEnumerable<string> в List<string>
    и затем используй метод ForEach()
    и внутри него выведи каждую строку в консоль.
    """;

var result =
    (
        from planet in source.Planets
        where planet.Radius > 0.9
        orderby planet.Type descending
        select planet.ToString()
    )
    .Where(str => str.Length < 69);

result.ToList().ForEach(Console.WriteLine);