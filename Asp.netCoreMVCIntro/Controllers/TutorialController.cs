using Asp.netCoreMVCIntro.Models;
using Asp.netCoreMVCIntro.Repository;
using Microsoft.AspNetCore.Mvc;

namespace Asp.netCoreMVCIntro.Controllers;

public class TutorialController : Controller
{
    private readonly ITutorialRepository _tourRepository;
    
    public TutorialController(ITutorialRepository tutorialRepository)
    {
        _tourRepository = tutorialRepository;
    }    

    // GET
    public IActionResult Index()
    {
        var tutorials = _tourRepository.GetAllTutorial();
        return View(tutorials);
    }
}
