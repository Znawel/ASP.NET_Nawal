using Microsoft.AspNetCore.Mvc;
using WebApplication4.Models;

namespace WebApplication4.Controllers
{
    public class BookController : Controller
    {
        public IActionResult Index()
        {
            var listeDesLivres = new List<Book>
            {
                new Book { Id = 1, Title = "L'Éducation sentimentale", Author = "Gustave Flaubert", Year = 1869 },
                new Book { Id = 2, Title = "Une chambre à soi", Author = "Virginia Woolf", Year = 1929 },
                new Book { Id = 3, Title = "Lolita", Author = "Vladimir Nabokov", Year = 1955 }
            };

            return View(listeDesLivres);
        }
        public IActionResult Details(int id)
        {
            var listeDesLivres = new List<Book>
            {
                new Book { Id = 1, Title = "L'Éducation sentimentale", Author = "Gustave Flaubert", Year = 1869 },
                new Book { Id = 2, Title = "Une chambre à soi", Author = "Virginia Woolf", Year = 1929 },
                new Book { Id = 3, Title = "Lolita", Author = "Vladimir Nabokov", Year = 1955 }
            };
            
            var livre = listeDesLivres.FirstOrDefault(b => b.Id == id);

            if (livre == null)
            {
                return NotFound(); 
            }

            return View(livre); 
        }

    }
}
