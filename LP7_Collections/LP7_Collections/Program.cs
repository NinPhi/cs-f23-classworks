
using LP7_Collections;

int number = 10;
int[] numbers = new int[] { 1, 2, 3, 4, 5 };

foreach (var n in numbers)
{
    Console.WriteLine(n);
}

IEnumerable<string> students = new Students();

foreach (var name in students)
{
    Console.WriteLine(name);
}

var infiniteOnes = new InfiniteOnes();

foreach (var item in infiniteOnes)
{
    Console.WriteLine(item);
}