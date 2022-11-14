using Backend_Project.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Backend_Project.Models
{
    public class OurProduct : BaseEntity
    {
        public string Title { get; set; }
        public string Description { get; set; }
    }
}
