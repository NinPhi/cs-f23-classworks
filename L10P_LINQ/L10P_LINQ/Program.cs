
using LP10_LINQ.Entities;

var employees = new List<Employee>()
{
    new Employee(1, "John Doe", "Manager", 5),
    new Employee(2, "Jane Smith", "Developer", 3),
    new Employee(3, "Bob Johnson", "Designer", 7, true),  // On vacation
    new Employee(4, "Alice Brown", "Manager", 8),
    new Employee(5, "Charlie Davis", "Developer", 2),
    new Employee(6, "Eva White", "Designer", 6),
    new Employee(7, "Frank Wilson", "Accountant", 4),
    new Employee(8, "Grace Taylor", "IT Specialist", 5, true), // On vacation
    new Employee(9, "Harry Moore", "HR Specialist", 3),
    new Employee(10, "Ivy Lee", "Manager", 6),
    new Employee(11, "Jack Harris", "Developer", 7),
    new Employee(12, "Karen Turner", "Designer", 2),
    new Employee(13, "Leo Miller", "Manager", 9),
    new Employee(14, "Mia Clark", "Marketing Specialist", 4),
    new Employee(15, "Noah Hall", "Designer", 5),
    new Employee(16, "Olivia Green", "Manager", 3, true), // On vacation
    new Employee(17, "Paul Adams", "Developer", 6),
    new Employee(18, "Quinn Martin", "Finance Analyst", 8),
    new Employee(19, "Ryan Walker", "Manager", 2),
    new Employee(20, "Sara Martinez", "Developer", 4),
    new Employee(21, "Tom Turner", "Designer", 7),
    new Employee(22, "Uma Garcia", "Manager", 5),
    new Employee(23, "Victor Brown", "Developer", 3),
    new Employee(24, "Wendy Moore", "Designer", 6),
    new Employee(25, "Xander Reed", "Manager", 4, true),  // On vacation
    new Employee(26, "Yara Patel", "IT Specialist", 7),
    new Employee(27, "Zane Mitchell", "HR Specialist", 5),
    new Employee(28, "Emma Stewart", "Manager", 6),
    new Employee(29, "Liam Wilson", "Developer", 4),
    new Employee(30, "Ava Lewis", "Marketing Specialist", 3),
};

var where = employees.Where(e => e.Position == "Developer");
Employee first = employees.First(e => e.Experience == 4);
Employee? firstOrDefault = employees.FirstOrDefault(e => e.Experience == 17);
Employee last = employees.Last(e => e.Experience == 4);

//foreach (var e in devs)
//{
//    Console.WriteLine($"Id: {e.Id} Name: {e.FullName} Pos: {e.Position}");
//}

Console.WriteLine($"Id: {first.Id} Name: {first.FullName} Pos: {first.Position}");
Console.WriteLine($"Id: {firstOrDefault.Id} Name: {firstOrDefault.FullName} Pos: {firstOrDefault.Position}");
Console.WriteLine($"Id: {last.Id} Name: {last.FullName} Pos: {last.Position}");
