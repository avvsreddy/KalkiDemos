using KnowledgeHubPortal.Business.Entities;
using KnowledgeHubPortal.Business.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace KnowledgeHubPortal.Data
{
    
    public class ArticlesRepository : IArticlesRepository
    {
        private KnowledgeHubPortalDbContext db = new KnowledgeHubPortalDbContext(); // Use DIP
        public void ApproveArticle(List<int> articlesIds)
        {
            foreach (int articleId in articlesIds)
            {
                var article = db.Articles.Find(articleId);
                if (article != null)
                {
                    article.IsApproved = true;
                   
                }
            }
            db.SaveChanges();
        }

        public List<Article> BrowseArticles(int categoryId)
        {
            var articles = from a in db.Articles
                           where a.CategoryId == categoryId && a.IsApproved == true && a.IsDeleted == false
                           select a;
            return articles.ToList();
        }

        public List<Article> GetArticlesForReview()
        {
            var articles = from a in db.Articles
                           where a.IsApproved == false && a.IsDeleted == false
                           select a;
            return articles.ToList();
        }

        public void RejectArticle(List<int> articlesIds)
        {
            foreach (int articleId in articlesIds)
            {
                var article = db.Articles.Find(articleId);
                if (article != null)
                {
                    article.IsApproved = false;
                    article.IsDeleted = true;
                }
            }
            db.SaveChanges();
        }

        public void SubmitArticle(Article article)
        {
            db.Articles.Add(article);
            db.SaveChanges();
        }
    }
}
