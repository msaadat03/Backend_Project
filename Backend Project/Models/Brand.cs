using System.ComponentModel.DataAnnotations;


namespace Backend_Project.Models
{
    public class Brand : BaseEntity
    {
        [Required]
        public string Image { get; set; }
    }
}
