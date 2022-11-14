
using System.ComponentModel.DataAnnotations;

namespace Backend_Project.ViewModels.AccountVM
{
    public class ForgetPasswordVM
    {
        [Required]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
    }
}
