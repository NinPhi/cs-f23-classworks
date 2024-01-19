using L10_LINQ;
using L10_LINQ.Entities;
using System;
using System.Collections.Generic;
using System.Linq;

//"Vinogradov".Replace("Vinograd", "Melnik");

List<Employee> list = new List<Employee>
{
    new Employee(1, "John", "Doe", "Manager", 5, false),
    new Employee(2, "Jane", "Smith", "Developer", 3, false),
    new Employee(3, "Bob", "Johnson", "Designer", 8, false),
    new Employee(4, "Alice", "Williams", "Manager", 2, false),
    new Employee(5, "Charlie", "Brown", "QA Engineer", 6, true), // On vacation
    new Employee(6, "David", "Davis", "Developer", 4, false),
    new Employee(7, "Eva", "Jones", "Analyst", 7, false),
    new Employee(8, "Frank", "Miller", "Designer", 1, false),
    new Employee(9, "Grace", "Wilson", "Sales", 9, false),
    new Employee(10, "Henry", "Moore", "Manager", 5, false),
    new Employee(11, "Ivy", "Taylor", "Support", 2, false),
    new Employee(12, "Jack", "Hill", "Marketing", 3, true), // On vacation
    new Employee(13, "Kate", "Clark", "Developer", 6, true), // On vacation
    new Employee(14, "Leo", "White", "Manager", 4, false),
    new Employee(15, "Mia", "Anderson", "QA Engineer", 8, false),
    new Employee(16, "Nathan", "Young", "Sales", 1, false),
    new Employee(17, "Olivia", "Lee", "Designer", 7, false),
    new Employee(18, "Paul", "Martin", "Manager", 9, false),
    new Employee(19, "Quinn", "Smith", "Developer", 2, false),
    new Employee(20, "Ryan", "Taylor", "Support", 5, true), // On vacation
    new Employee(21, "Sophia", "Brown", "Marketing", 4, false),
    new Employee(22, "Thomas", "Jones", "QA Engineer", 3, false),
    new Employee(23, "Uma", "Miller", "Developer", 7, false),
    new Employee(24, "Vincent", "Clark", "Designer", 1, false),
    new Employee(25, "Wendy", "Hill", "Manager", 6, false),
    new Employee(26, "Xavier", "Moore", "Sales", 8, false),
    new Employee(27, "Yara", "Williams", "Analyst", 4, false),
    new Employee(28, "Zack", "Anderson", "Developer", 2, false),
    new Employee(29, "Ella", "White", "Manager", 5, false),
    new Employee(30, "Felix", "Young", "QA Engineer", 3, false)
};

//var where = list.Where((Employee e) => e.Position == "Manager");
IEnumerable<Employee> where = list.Where(e => e.IsOnVacation);
Employee first = list.First(Methods.IsBrown);
Employee? firstOrDefault = list.FirstOrDefault(Methods.IsBrown);
Employee last = list.Last(e => e.LastName == "Young");
Employee? lastOrDefault = list.LastOrDefault(e => e.LastName == "Vinogradov");

IEnumerable<string> select = list.Select(e => e.FirstName);
IEnumerable<Employee> orderBy = list.OrderBy(e => e.Experience);
IEnumerable<Employee> orderByDescending = list.OrderByDescending(e => e.Experience);

IEnumerable<IGrouping<string, Employee>> groupBy = list.GroupBy(e => e.Position);

int experienceSum = list.Sum(e => e.Experience);
double experienceAvg = list.Average(e => e.Experience);

bool any = list.Any(e => e.IsOnVacation);
bool all = list.All(e => e.IsOnVacation);
bool contains = list.Contains(list[0]);

//foreach (var emp in where)
//{
//    Console.WriteLine($"Id: {emp.Id}, FullName: {emp.FirstName} {emp.LastName}, Position: {emp.Position}");
//}

foreach (var emp in orderBy)
{
    Console.WriteLine($"Id: {emp.Id}, FullName: {emp.FirstName} {emp.LastName}, Position: {emp.Position}, Experience: {emp.Experience}");
}

//foreach (var name in select)
//{
//    Console.Write(name + ", ");
//}

//foreach (var pet in select2.Where(p => p != null))
//{
//    Console.Write(pet.Name + ", ");
//}

//Console.WriteLine($"Id: {first.Id}, FullName: {first.FirstName} {first.LastName}, Position: {first.Position}");
//Console.WriteLine($"Id: {firstOrDefault?.Id}, FullName: {firstOrDefault?.FirstName} {firstOrDefault?.LastName}, Position: {firstOrDefault?.Position}");
//Console.WriteLine($"Id: {last.Id}, FullName: {last.FirstName} {last.LastName}, Position: {last.Position}");
//Console.WriteLine($"Id: {lastOrDefault?.Id}, FullName: {lastOrDefault?.FirstName} {lastOrDefault?.LastName}, Position: {lastOrDefault?.Position}");
