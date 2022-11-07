using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Backend_Project.Models
{
    public class Slider : BaseEntity
    {
        [Required]
        public string Image { get; set; }

        [Required]
        public string Subtitle { get; set; }

        [Required]
        public string Title { get; set; }

        [Required]
        public string Desc { get; set; }


    }
}
