using Library.Data;
using Library.Models;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using System.Threading.Tasks;

namespace Library.Controllers
{
    public class LibraryController : Controller
    {
        public IActionResult Index()
        {
            //TO DO
            using (var db = new LibraryDbContext())
            {
                var allbooks = db.Books.ToList();
                return View(allbooks);
            }
        }

        [HttpGet]
        public IActionResult Create()
        {
            return this.View();
        }

        [HttpPost]
        public IActionResult Create(Book book)
        {
            if (string.IsNullOrEmpty(book.Title) || string.IsNullOrEmpty(book.Author)
                || book.Price == null || book.Price < 1)
            {
                return RedirectToAction("Index");
            }
            Book newbook = new Book
            {
                Title = book.Title,
                Author = book.Author,
                Price = book.Price
            };
            using (var db = new LibraryDbContext())
            {
                db.Books.Add(newbook);
                db.SaveChanges();
            }
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            using (var db = new LibraryDbContext())
            {
                var bookToEdit = db.Books.FirstOrDefault(t => t.Id == id);
                if (bookToEdit == null)
                {
                    return RedirectToAction("Index");
                }
                return this.View(bookToEdit);
            }
        }

        [HttpPost]
        public IActionResult Edit(Book book)
        {
            if (!ModelState.IsValid)
            {
                return RedirectToAction("Index");
            }
            using (var db = new LibraryDbContext())
            {
                var bookToEdit = db.Books.FirstOrDefault(b => b.Id == book.Id);
                bookToEdit.Title = book.Title;
                bookToEdit.Author = book.Author;
                bookToEdit.Price = book.Price;
                db.SaveChanges();
            }
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Delete(int id)
        {
            using (var db = new LibraryDbContext())
            {
                var bookDetails = db.Books.FirstOrDefault(t => t.Id == id);
                if (bookDetails == null)
                {
                    return RedirectToAction("Index");
                }
                return this.View(bookDetails);
            }
        }

        [HttpPost]
        public IActionResult Delete(Book book)
        {
            using (var db = new LibraryDbContext())
            {
                var bookToDelete = db.Books.FirstOrDefault(t => t.Id == book.Id);
                if (bookToDelete == null)
                {
                    return RedirectToAction("Index");
                }
                db.Books.Remove(bookToDelete);
                db.SaveChanges();
            }
            return RedirectToAction("Index");
        }
    }
}