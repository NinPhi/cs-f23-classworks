if (args == null || args.Length < 1)
{
    Console.WriteLine("Required arguments missing.");
    Environment.Exit(0);
}

var arg1 = args[0];

Console.WriteLine("Hello! Enter your name:");
var name = "Azim";

if (name == "Azim")
    Console.WriteLine("Welcome back!");
else
{
    Console.WriteLine($"Sorry, {name}... I don't talk to strangers.");
    Environment.Exit(0);
}

Console.WriteLine("Here is your argument:");
Console.WriteLine(arg1);

while (true)
{
    Console.WriteLine("Hmmm...");
    Thread.Sleep(500);
}