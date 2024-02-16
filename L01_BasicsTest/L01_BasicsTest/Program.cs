using _20231218_CSharpBasicsTest;

string hello;

hello = "hello";

// Классический пример
string world = hello;

const string kek = "lol";

string input = Console.ReadLine();

Console.WriteLine(input);

string reference = "ref type";

int? value = null;

value = int.Parse(Console.ReadLine());

if (false) { }
else if (true) { }
else { }

switch (input)
{
    case "hello":
        break;
    case "world":
        break;
    default: break;
}

if (input == "string" ? true : false) { }

while (true) { break; }

for (int i = 0; i < 10; i++)
{
    Console.WriteLine("test");
}

for (int i = 0; i < 100; i++)
{
    Console.WriteLine(i);
}

do
{
    Console.WriteLine("hello");
}
while (false);

int[] array = new int[] { 1, 2, 3, 4, 5 };

foreach (int i in array)
{
    Console.WriteLine(i);
}

Console.WriteLine(array.Length);

DateTime date = DateTime.Now;

date.AddYears(1);

string concat = input + date;

string name = $"today is {date}";

try
{
    throw new Exception();
}
catch { }
finally { }

// я молодец

PublicClass publicClass = new PublicClass();

publicClass.Extension();

List<PublicStruct> list = new();