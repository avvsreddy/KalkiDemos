using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace KnowledgeHubPortal.Business.Entities
{
    public class Category
    {
        public int CategoryID { get; set; }
        [Required]
        [MaxLength(100)]
        [MinLength(3)]
        public string Name { get; set; }
        [Required]
        [MinLength(5)]
        [MaxLength(500)]
        public string Description { get; set; }
    }
}
