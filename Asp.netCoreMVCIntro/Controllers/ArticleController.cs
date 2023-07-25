using Asp.netCoreMVCIntro.Models;
using Asp.netCoreMVCIntro.Models.ViewModels;
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

    public async Task<IActionResult> GetArticleByArticleId(int id)
    {
        Article article = await _articleRepository.GetArticleById(id);
        return View(article);
    }

    public async Task<IActionResult> DisplayArticlesByTutorialId(int id)
    {
        IEnumerable<Article> articles = await _articleRepository.GetAllArticlesByTutorialId(id);
        return View(articles);
    }

    [HttpGet]
    public async Task<IActionResult> AddNewArticle()
    {
        var tutorials = await _articleRepository.GetAllTutorials();
        ViewBag.Tutorials = new SelectList(tutorials, "Id", "Name");
        return View();
    }

    [HttpPost]
    public async Task<IActionResult> AddNewArticle(ArticleViewModel article)
    {
        if (!ModelState.IsValid)
        {
            var tutorials = await _articleRepository.GetAllTutorials();
            ViewBag.Tutorials = new SelectList(tutorials, "Id", "Name");
            return View(article);
        }

        _articleRepository.AddArticle(article);
        return RedirectToAction("Index");
    }
}