using Backend_Project.Data;
using Backend_Project.Models;
using Backend_Project.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Backend_Project.Controllers
{
    public class BlogController : Controller
    {
        private readonly AppDbContext _context;
        public BlogController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            List<Blog> blog = _context.Blogs.ToList();




            HomeVM home = new HomeVM
            {
                Blogs = blog

            };
            return View(home);

            
        }


    }
}
