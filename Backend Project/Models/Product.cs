using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Backend_Project.Models
{
    public class Product : BaseEntity
    { 
        public string Title { get; set; }

        [Column(TypeName = "decimal(18,4)")]
        public decimal Price { get; set; }

        [Column(TypeName = "decimal(18,4)")]
        public decimal DiscountPrice { get; set; }

        public string Description { get; set; }
        public int SellerCount { get; set; }
        public int CategoriesId { get; set; }
        public Categories Categories { get; set; }
        public ICollection<ProductImage> ProductImages { get; set; }
    }
}
