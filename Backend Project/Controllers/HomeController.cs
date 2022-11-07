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
      
            HomeVM home = new HomeVM
            {
                Sliders = slider,
            };
            return View(home);
        }

   
    }
}
