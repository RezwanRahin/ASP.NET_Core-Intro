using Microsoft.AspNetCore.Mvc;

namespace Asp.netCoreMVCIntro.Controllers;

public class TutorialController : Controller
{
    // GET
    public IActionResult Index()
    {
        return View();
    }
}