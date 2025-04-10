using Microsoft.AspNetCore.Mvc;
using WebApplication4.Data;
using WebApplication4.Models;

namespace WebApplication4.Controllers
{ 
    public class BookController : Controller
    {
        private readonly AppDbContext _Context;
        public BookController(AppDbContext context)
        {
            _Context = context;
        }
        public IActionResult Index()
        {
            var books = _Context.Books.ToList();
            return View(books);
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Book book)
        {
            if (ModelState.IsValid)
            {
                _Context.Books.Add(book);
                _Context.SaveChanges();

                return RedirectToAction("Index");
            }

            return View(book);
        }
    }
} 