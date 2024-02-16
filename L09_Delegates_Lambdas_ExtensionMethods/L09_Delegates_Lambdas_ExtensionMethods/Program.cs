
using L9_Delegates_Lambdas_ExtensionMethods;

internal class Program
{
    private static void Main(string[] args)
    {
        var movies = new List<Movie>()
        {
            new Movie() { Title = "Morbius (2022)", Rating = 1 },
            new Movie() { Title = "Spider-Man (2002)", Rating = 8 },
        };

        Movie? movie = MovieHelper.FindMovie(movies, Predicate);
        Movie? movie1 = MovieHelper.FindMovie(movies, m => m.Title.Length < 15);
        Movie? movie2 = movies.FindMovie(m => m.Title.Length < 15);

        Console.WriteLine($"Title: {movie?.Title}, Rating: {movie?.Rating}");

        //int x = 10;

        //int y = IntExtensions.TimesTwo(x);
        //int w = x.TimesTwo();
    }

    private static bool Predicate(Movie movie)
    {
        return movie.Title.Length < 15;
    }
}