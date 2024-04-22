using Microsoft.AspNetCore.Mvc;
using WebApplication3.Models;

namespace WebApplication3.Controllers
{
    public class BlogController : Controller
    {

        public IActionResult Index()
        {
            var db = new BlogContext();

            return View(db.Blogs.ToList());
        }
    }
}
