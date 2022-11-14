using Backend_Project.Data;
using Backend_Project.Models;
using Backend_Project.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Backend_Project.Controllers
{
    public class ProductDetailController : Controller
    {
        private readonly AppDbContext _context;
        public ProductDetailController(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index(int? id)
        {
            Product products = await _context.Products
                   .Where(m => !m.IsDeleted && m.Id == id)
                   .Include(m => m.ProductImages)
                   .FirstOrDefaultAsync();

            ProductDetailVM productDetailVM = new ProductDetailVM
            {
                Products = products,

            };


            return View(productDetailVM);
        }
    }
}
