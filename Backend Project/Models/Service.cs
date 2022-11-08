using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Backend_Project.Models
{
    public class Service : BaseEntity
    {
        public string Icon { get; set; }
        public string Title { get; set; }
        public string Desc { get; set; }
        public string Color { get; set; }

    }
}
