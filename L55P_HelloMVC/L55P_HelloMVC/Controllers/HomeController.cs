using L55P_HelloMVC.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace L55P_HelloMVC.Controllers;

public class HomeController(
    ILogger<HomeController> logger)
    : Controller
{
    private static readonly List<BookViewModel> _books =
    [
        new()
        {
            Id = 1,
            Title = "Best of Hans Zimmer",
            Author = "Hans Zimmer",
            AvailableCount = 3,
            Price = 2300 // T.T
        },
        new()
        {
            Id = 2,
            Title = "Metro 2033",
            Author = "Alexey Glohovskoy",
            AvailableCount = 90,
            Price = 1500 // TvT
        },
        new()
        {
            Id = 3,
            Title = "Mystery Island",
            Author = "Joules Vern",
            AvailableCount = 33,
            Price = 900 // TwT
        },
    ];

    private readonly ILogger<HomeController> _logger = logger;

    public IActionResult Index()
    {
        return View();
    }

    public IActionResult Books()
    {
        return View(_books);
    }

    public IActionResult CreateEditBook(int id)
    {
        var book = _books.FirstOrDefault(b => b.Id == id);
        return View(book);
    }

    public IActionResult CreateEditBookForm(BookViewModel book)
    {
        _books.Add(book);

        return RedirectToAction("Books");
    }

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
