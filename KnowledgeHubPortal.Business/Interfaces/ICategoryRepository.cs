using KnowledgeHubPortal.Business.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace KnowledgeHubPortal.Business.Interfaces
{
    public interface ICategoryRepository
    {
        void CreateCategory(Category category);
        List<Category> GetCategories();
    }
}
