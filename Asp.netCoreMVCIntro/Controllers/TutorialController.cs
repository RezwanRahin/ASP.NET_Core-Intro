using Asp.netCoreMVCIntro.Models;
using Asp.netCoreMVCIntro.Repository;
using Microsoft.AspNetCore.Mvc;

namespace Asp.netCoreMVCIntro.Controllers;

public class TutorialController : Controller
{
    // GET
    public IActionResult Index()
    {
        var tutorials = new TutorialRepository().GetAllTutorial();
        return View(tutorials);
    }
}
