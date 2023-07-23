using Asp.netCoreMVCIntro.Models;
using Asp.netCoreMVCIntro.Repository;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Asp.netCoreMVCIntro.Controllers;

public class ArticleController : Controller
{
    private readonly IArticleRepository _articleRepository;

    public ArticleController(IArticleRepository articleRepository)
    {
        _articleRepository = articleRepository;
    }

    public async Task<IActionResult> Index()
    {
        IEnumerable<Article> articles = await _articleRepository.GetAllArticle();
        return View(articles);
    }

    [HttpGet]
    public async Task<IActionResult> AddNewArticle()
    {
        var tutorials = await _articleRepository.GetAllTutorials();
        ViewBag.Tutorials = new SelectList(tutorials, "Id", "Name");
        return View();
    }

    public async Task<IActionResult> DisplayArticles(int id)
    {
        IEnumerable<Article> articles = await _articleRepository.GetAllArticlesByTutorialId(id);
        return View(articles);
    }
}