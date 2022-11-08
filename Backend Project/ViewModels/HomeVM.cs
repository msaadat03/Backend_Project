using Backend_Project.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Backend_Project.ViewModels
{
    public class HomeVM
    {
            public List<Slider> Sliders { get; set; }
            public List<Service> Services { get; set; }
        public List<SameBannerArea> SameBannerAreas { get; set; }


    }
}
