using Asp.netCoreMVCIntro.Repository;
using Microsoft.AspNetCore.Mvc;

namespace Asp.netCoreMVCIntro.Controllers;

public class ArticleController : Controller
{
    private readonly IArticleRepository _articleRepository;

    public ArticleController(IArticleRepository articleRepository)
    {
        _articleRepository = articleRepository;
    }
}