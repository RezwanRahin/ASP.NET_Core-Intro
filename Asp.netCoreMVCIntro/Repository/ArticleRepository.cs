using Asp.netCoreMVCIntro.Context;
using Asp.netCoreMVCIntro.Models;
using Asp.netCoreMVCIntro.Models.ViewModels;
using Microsoft.EntityFrameworkCore;

namespace Asp.netCoreMVCIntro.Repository
{
    public class ArticleRepository : IArticleRepository
    {
        private readonly TutorialDbContext _context;

        public ArticleRepository(TutorialDbContext context)
        {
            _context = context;
        }

        public void AddArticle(ArticleViewModel article)
        {
            var newArticle = new Article()
            {
                ArticleTitle = article.ArticleTitle,
                ArticleContent = article.ArticleContent,
                TutorialId = article.TutorialId
            };

            _context.Articles.AddAsync(newArticle);
            _context.SaveChangesAsync();
        }

        public void DeleteArticle(int Id)
        {
            Article article = _context.Articles.Find(Id);
            if (article != null)
            {
                _context.Articles.Remove(article);
                _context.SaveChanges();
            }
        }

        public async Task<IEnumerable<Article>> GetAllArticle()
        {
            return await _context.Articles.ToListAsync();
        }

        public IEnumerable<Article> GetAllArticlesByTutorialId(int tutorialId)
        {
            return _context.Articles.Where(a => a.TutorialId == tutorialId).ToList();
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