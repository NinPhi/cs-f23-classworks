namespace LP9_Lambdas_ExtensionMethods;

public class Movie
{
    public string Title { get; set; } = "";

    public int GetRandomRating()
    {
        var random = new Random();

        return random.Next(1, 11); // 1 - 10
    }
}
