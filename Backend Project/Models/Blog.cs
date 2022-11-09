using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Backend_Project.Models
{
    public class Blog : BaseEntity
    {
        public string Images { get; set; }
        public string Title { get; set; }
        public string By { get; set; }
        public DateTime Date { get; set; }



    }
}
