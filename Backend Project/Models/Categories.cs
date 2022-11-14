using System.Collections.Generic;

namespace Backend_Project.Models
{
    public class Categories : BaseEntity
    {
        public string Name { get; set; }
        public ICollection<Product> Products { get; set; }
    }
}
