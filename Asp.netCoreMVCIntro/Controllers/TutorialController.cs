using Asp.netCoreMVCIntro.Models;
using Asp.netCoreMVCIntro.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace Asp.netCoreMVCIntro.Controllers;

public class TutorialController : Controller
{
    [ViewData] public string title { get; set; }

    // GET
    public IActionResult Index()
    {
        // var tutorials = new List<Tutorial>
        // {
        //     new Tutorial { Id = 1, Name = "C#", Description = "C# tutorial" },
        //     new Tutorial { Id = 2, Name = "Asp.net core", Description = "Asp.net core tutorial" }
        // };

        // // ViewData["title"] = "Tutorial Details";
        // title = "Tutorial Details";

        // // ViewData["tutorials"] = tutorials;
        // ViewBag.Tutorials = tutorials;
        // ViewData["name"] = "All about .net...";
        // return View();

        // var newModel = new Tutorial { Id = 1, Name = ".net", Description = ".net tutorial" };
        // return View(newModel);

        var newModel = new TutorialViewModel()
        {
            tutorial = new Tutorial { Id = 1, Name = ".net", Description = ".net tutorial" },
            title = "New Title"
        };
        return View(newModel);
    }
}
