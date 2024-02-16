namespace L9_Delegates_Lambdas_ExtensionMethods;

internal static class MovieHelper
{
    public static Movie? FindMovie(
        this List<Movie> movies,
        Func<Movie, bool> predicate)
    {
        foreach (Movie movie in movies)
        {
            if (predicate(movie))
            {
                return movie;
            }
        }

        return null;
    }
}
