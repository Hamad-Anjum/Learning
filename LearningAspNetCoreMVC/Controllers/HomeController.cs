using LearningAspNetCoreMVC.Models;
using Microsoft.AspNetCore.Mvc;

namespace LearningAspNetCoreMVC.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            Product myProduct = new Product
            {
                ProductID = 1,
                Name = "Kayak",
                Description = "A boat for one person",
                Category = "Watersports",
                Price = 275M
            };

            return View(myProduct);
        }
    }
}