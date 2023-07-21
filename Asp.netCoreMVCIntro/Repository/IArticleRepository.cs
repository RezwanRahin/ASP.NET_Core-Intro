using Asp.netCoreMVCIntro.Models;
using Asp.netCoreMVCIntro.Models.ViewModels;

namespace Asp.netCoreMVCIntro.Repository
{
    public interface IArticleRepository
    {
        void AddArticle(ArticleViewModel article);
        Article UpdateArticle(Article updatedArticle);
        void DeleteArticle(int Id);
        Task<Article> GetArticleById(int Id);
        Task<IEnumerable<Article>> GetAllArticle();
        Task<IEnumerable<Article>> GetAllArticlesByTutorialId(int tutorialId);
        Task<IEnumerable<Tutorial>> GetAllTutorials();
    }
}