using Asp.netCoreMVCIntro.Models;
using Asp.netCoreMVCIntro.Models.ViewModels;

namespace Asp.netCoreMVCIntro.Repository
{
    public class ArticleRepository : IArticleRepository
    {
        public void AddArticle(ArticleViewModel article)
        {
            throw new NotImplementedException();
        }

        public void DeleteArticle(int Id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Article> GetAllArticle()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Article> GetAllArticlesByTutorialId(int tutorialId)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Tutorial> GetAllTutorials()
        {
            throw new NotImplementedException();
        }

        public Article GetArticleById(int Id)
        {
            throw new NotImplementedException();
        }

        public Article UpdateArticle(Article updatedArticle)
        {
            throw new NotImplementedException();
        }
    }
}