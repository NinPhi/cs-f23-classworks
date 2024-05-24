using L55_FirstMVC.Models;
using Microsoft.AspNetCore.Mvc;

namespace L55_FirstMVC.Controllers;

public class TodoController : Controller
{
    public IActionResult List()
    {
        var todo = new TodoModel
        {
            Id = 1,
            Complete = false,
            Title = "Запилить дверь."
        };

        return View(todo);
    }
}
