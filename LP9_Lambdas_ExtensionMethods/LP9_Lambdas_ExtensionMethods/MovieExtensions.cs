namespace LP9_Lambdas_ExtensionMethods;

public static class MovieExtensions
{
    private static Dictionary<string, int> movieRatings =
        new()
        {
            { "Spider-Man (2002)", 10 },
            { "Morbius (2022)", 1 },
        };

    public static int FindRating(this Movie movie)
    {
        if (movieRatings.ContainsKey(movie.Title))
            return movieRatings[movie.Title];

        return 0;
    }
}
