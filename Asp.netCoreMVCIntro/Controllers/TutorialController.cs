using Asp.netCoreMVCIntro.Models;
using Microsoft.AspNetCore.Mvc;

namespace Asp.netCoreMVCIntro.Controllers;

public class TutorialController : Controller
{
    [ViewData] public string title { get; set; }

    // GET
    public IActionResult Index()
    {
        var tutorials = new List<Tutorial>
        {
            new Tutorial { Id = 1, Name = "C#", Description = "C# tutorial" },
            new Tutorial { Id = 2, Name = "Asp.net core", Description = "Asp.net core tutorial" }
        };

        // ViewData["title"] = "Tutorial Details";
        title = "Tutorial Details";

        // ViewData["tutorials"] = tutorials;
        ViewBag.Tutorials = tutorials;
        ViewData["name"] = "All about .net...";

        return View();
    }
}
