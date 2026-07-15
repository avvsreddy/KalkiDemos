using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace KnowledgeHubPortal.Business.Entities
{
    public class Article
    {
        public int ArticleID { get; set; }
        [Required]
        public string Title { get; set; }
        [Required]
        public string ArticleUrl { get; set; }
        public string? Description { get; set; }
        public Category Category { get; set; }
        //[ForeignKey("Category")]
        public int CategoryId { get; set; }
        public bool IsApproved { get; set; }
        public string PostedBy { get; set; }
        public DateTime DateCreated { get; set; }
        public bool IsDeleted { get; set; }
    }
}
