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

        public async Task<IEnumerable<Article>> GetAllArticlesByTutorialId(int tutorialId)
        {
            return await _context.Articles.Where(a => a.TutorialId == tutorialId).ToListAsync();
        }

        public async Task<IEnumerable<Tutorial>> GetAllTutorials()
        {
            return await _context.Tutorials.ToListAsync();
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