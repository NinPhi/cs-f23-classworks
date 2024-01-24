
using L11P_MoreLINQ;

//DataSource source = new DataSource();

//_ =
//"""
//Из списка планет возьми все планеты с Id больше 20,
//отсортируй их по названию звезды и верни первую планету
//из отсортированного списка, иначе верни null.
//""";

//var planet = (
//    from p in source.Planets
//    where p.Id > 20
//    orderby p.Star
//    select p
//    ).FirstOrDefault();

//var planet2 = source.Planets
//    .Where(p => p.Id > 20)
//    .OrderBy(p => p.Star)
//    .FirstOrDefault();

//source.Planets.ToList().ForEach(Console.WriteLine);

Холодильник холодильник = new Холодильник();

double среднееЧислоПорций = холодильник.Продукты
    .Where(продукт => продукт.Испорчено == false)
    .Where(продукт => продукт.Название is "Помидор" or "Огурец" or "Перец")
    .GroupBy(продукт => продукт.Название)
    .Select(группа =>
    {
        if (группа.Key is "Огурец")
            return группа.Count() / 2d;

        if (группа.Key is "Киндза")
            return группа.Count() * 2d;

        return группа.Count();
    })
    .Average();

Console.WriteLine($"{среднееЧислоПорций:0.00}");