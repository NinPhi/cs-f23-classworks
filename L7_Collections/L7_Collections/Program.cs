
//int[] numbers = new int[] { 1, 2, 3, 4, 5 };

//IEnumerable<int> numbers2 = numbers;

//foreach (var n in numbers)
//{
//    Console.WriteLine(n);
//}

using L7_Collections;
using System;
using System.Collections;
using System.Collections.Generic;

//var names = new Names();

//IList c;

//var i = 0;

//foreach (var name in names)
//{
//    Console.WriteLine(name);
//}

//Console.WriteLine(100);

//List<int> list = new List<int>
//{
//    0,
//    4,
//    1,
//    2,
//    4,
//};

//Console.WriteLine(string.Join(", ", list));

//if (true)
//{
//    list.Add(1337);
//}

//list.Remove(4);

//Console.WriteLine(string.Join(", ", list));

//var students = new List<Student>()
//{
//    new Student()
//    {
//        Id = 16,
//        Name = "Azim",
//    },
//    new Student()
//    {
//        Id = 10,
//        Name = "Beksultan",
//    },
//    new Student()
//    {
//        Id = 10,
//        Name = "Beksultan",
//    },
//};

//var Azim = students.Find(FindAzim);

//Console.WriteLine(Azim.Name);

//bool FindAzim(Student student)
//{
//    return student.Name == "Azim";
//}

Student student1 = new Student() { Id = 1, Name = "Dima" };
Student student2 = new Student() { Id = 2, Name = "Batya" };

List<Student> students = new List<Student>() { student1, student2 };

student1.Name = "Mark";

Console.WriteLine("READ WRITE:");
foreach (Student student in students)
{
    Console.WriteLine($"Id: {student.Id} Name: {student.Name}");
}

IReadOnlyList<Student> readonlyStudents = students.AsReadOnly();

student1.Name = "Dima";

Console.WriteLine("\nREADONLY:");
foreach (Student student in readonlyStudents)
{
    Console.WriteLine($"Id: {student.Id} Name: {student.Name}");
}



_ = """
    Создать класс Book с Id, Title и Price.
    В Program создать лист книг с двумя книгами.
    Через foreach вывести все заголовки (Title) книг.
    """;