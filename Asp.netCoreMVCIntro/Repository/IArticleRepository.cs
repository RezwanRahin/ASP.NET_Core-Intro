using Asp.netCoreMVCIntro.Models;
using Asp.netCoreMVCIntro.Models.ViewModels;

namespace Asp.netCoreMVCIntro.Repository
{
    public interface IArticleRepository
    {
        void AddArticle(ArticleViewModel article);
        Article UpdateArticle(Article updatedArticle);
        void DeleteArticle(int Id);
        Article GetArticleById(int Id);
        IEnumerable<Article> GetAllArticle();
        IEnumerable<Article> GetAllArticlesByTutorialId(int tutorialId);
        IEnumerable<Tutorial> GetAllTutorials();
    }
}