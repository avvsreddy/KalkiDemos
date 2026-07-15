using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace ProductsManagementConsoleApp.Entities
{
    [Table("tbl_suppliers")]
    public class Supplier
    {
        //[Key]
        public int SupplierId { get; set; }
        [Required]
        [MinLength(5)]
        [MaxLength(100)]
        public string Name { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        [NotMapped]
        public int ProfitMargin { get; set; }

        public List<Product> Products { get; set; }

    }
}
