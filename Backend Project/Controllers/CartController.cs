using Microsoft.AspNetCore.Mvc;


namespace Backend_Project.Controllers
{
    public class CartController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
