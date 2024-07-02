using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using BookApp.Models;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace BookApp.Controllers;

public class HomeController : Controller
{

    public HomeController()
    {
    }

    [HttpGet]
    public IActionResult Index(string searchString, string category)
    {
        var books = Repository.Books;

        if(!String.IsNullOrEmpty(searchString)){
            ViewBag.SearchString = searchString;
            books = books.Where(p=>p.Title.ToLower().Contains(searchString)).ToList();
        }

        if(!String.IsNullOrEmpty(category) && category != "0"){
            books = books.Where(p=>p.CategoryId == int.Parse(category)).ToList();
        }

        var model = new ProductViewModel{
            Books = books,
            Categories = Repository.Categories,
            SelectedCategory = category
        };
        return View(model);
    }

    [HttpGet]
    public IActionResult Create()
    {
        ViewBag.Categories = new SelectList(Repository.Categories, "CategoryId","Name");
        return View();
    }

    [HttpPost]
    public async Task<IActionResult> Create(Book model, IFormFile imageFile)
    {
        var allowenExtensions = new[] {".jpg",".png",".jpeg"};
        var extension = Path.GetExtension(imageFile.FileName);
        var randomfileName = string.Format($"{Guid.NewGuid().ToString()}{extension}");
        var path = Path.Combine(Directory.GetCurrentDirectory(),"wwwroot/img",randomfileName);

        if(imageFile != null){
            if(!allowenExtensions.Contains(extension)){
                ModelState.AddModelError("","Geçerli bir resim seçiniz.");
            }
        }

        if(ModelState.IsValid){
        
        using(var stream = new FileStream(path,FileMode.Create)){
            await imageFile.CopyToAsync(stream);
        }
        model.Image = randomfileName;
        model.BookId = Repository.Books.Count + 1;
        Repository.CreateProduct(model);
        return RedirectToAction("Index");
        }
        ViewBag.Categories = new SelectList(Repository.Categories, "CategoryId","Name");
        return View(model);    
    }

}
