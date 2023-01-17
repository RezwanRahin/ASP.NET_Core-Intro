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

    [HttpGet]
    public IActionResult CreateTutorial()
    {
        return View();
    }

    [HttpPost]
    public IActionResult CreateTutorial(Tutorial tutorial)
    {
        Tutorial newTutorial = _tourRepository.Add(tutorial);
        return RedirectToAction("Index");
    }

    [HttpGet]
    public IActionResult EditTutorial(int id)
    {
        Tutorial tutorial = _tourRepository.GetTutorial(id);
        return View(tutorial);
    }

    [HttpPost]
    public IActionResult EditTutorial(Tutorial modifiedData)
    {
        Tutorial tutorial = _tourRepository.GetTutorial(modifiedData.Id);
        tutorial.Name = modifiedData.Name;
        tutorial.Description = modifiedData.Description;
        Tutorial updatedTutorial = _tourRepository.Update(tutorial);
        return RedirectToAction("Index");
    }

    public IActionResult DeleteTutorial(int id)
    {
        _tourRepository.Delete(id);
        return RedirectToAction("Index");
    }
}
