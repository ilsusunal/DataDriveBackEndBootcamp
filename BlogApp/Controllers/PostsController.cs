using Microsoft.AspNetCore.Mvc;
using BlogApp.Data.Concrete.EfCore;

namespace BlogApp.Controllers
{
    public class PostsController : Controller
    {
        private readonly BlogContext _context;
        public PostsController(BlogContext context){
            _context = context;
        }
        public IActionResult Index(){
            return View(_context.Posts.ToList());
        }
    }
}