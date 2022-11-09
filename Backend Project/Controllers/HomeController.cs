using Backend_Project.Data;
using Backend_Project.Models;
using Backend_Project.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace Backend_Project.Controllers
{
    public class HomeController : Controller
    {
        private readonly AppDbContext _context;
        public HomeController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            List<Slider> slider = _context.Sliders.ToList();
            List<Service> service = _context.Services.ToList();
            List<SameBannerArea> sameBannerArea = _context.SameBannerAreas.ToList();
            List<Blog> blog = _context.Blogs.Take(5).ToList();
            List<Brand> brand = _context.Brands.ToList();




            HomeVM home = new HomeVM
            {
                Sliders = slider,
                Services = service,
                SameBannerAreas = sameBannerArea,
                Blogs = blog,
                Brands = brand,

            };
            return View(home);
        }

   
    }
}
