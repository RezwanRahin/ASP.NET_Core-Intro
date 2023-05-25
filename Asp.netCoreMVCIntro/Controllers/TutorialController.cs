using Asp.netCoreMVCIntro.Models;
using Asp.netCoreMVCIntro.Repository;
using Microsoft.AspNetCore.Mvc;

namespace Asp.netCoreMVCIntro.Controllers;

// [Route("Tutorial")]
public class TutorialController : Controller
{
    private readonly ITutorialRepository _tourRepository;
    
    public TutorialController(ITutorialRepository tutorialRepository)
    {
        _tourRepository = tutorialRepository;
    }    

    // GET
    public async Task<IActionResult> Index()
    {
        var tutorials = await _tourRepository.GetAllTutorial();
        return View(tutorials);
    }

    // [Route("AddTutorial")]
    // [Route("Tutorial/AddTutorial")]
    [HttpGet]
    public IActionResult CreateTutorial()
    {
        return View();
    }

    [HttpPost]
    public IActionResult CreateTutorial(Tutorial tutorial)
    {
        if (!ModelState.IsValid)
        {
            return View(tutorial);
        }

        Tutorial newTutorial = _tourRepository.Add(tutorial);
        return RedirectToAction("Index");
    }

    [HttpGet]
    public IActionResult EditTutorial(int id, string querystringData)
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
