
using LP9_Lambdas_ExtensionMethods;

internal class Program
{
    private static void Main(string[] args)
    {
        Movie movie1 = new Movie() { Title = "Spider-Man (2002)" };
        Movie movie2 = new Movie() { Title = "Morbius (2022)" };

        //int rating1 = movie1.GetRandomRating();
        //int rating2 = movie2.GetRandomRating();
        int rating1 = movie1.FindRating();
        int rating2 = movie2.FindRating();

        Console.WriteLine($"Movie: {movie1.Title}, Rating: {rating1}");
        Console.WriteLine($"Movie: {movie2.Title}, Rating: {rating2}");

        var x = X;
        var y = () => { };

        x.Call();
        y.Call();
    }

    // любой подходящий по сигнатуре метод
    private static void X() { }
}