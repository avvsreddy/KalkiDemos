using KnowledgeHubPortal.Business.Entities;
using KnowledgeHubPortal.Business.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace KnowledgeHubPortal.Data
{
    public class CategoryRepository : ICategoryRepository
    {
        private KnowledgeHubPortalDbContext db = new KnowledgeHubPortalDbContext(); // Use DIP
        public void CreateCategory(Category category)
        {
           db.Categories.Add(category);
           db.SaveChanges();
        }

        public List<Category> GetCategories()
        {
            return db.Categories.ToList();
        }
    }
}
