using RescueRegister.Models;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace RescueRegister.Controllers
{
    public class MountaineerController : Controller
    {
        private readonly RescueRegisterDbContext context;

        public MountaineerController(RescueRegisterDbContext context)
        {
            this.context = context;
        }

        public IActionResult Index()
        {
            using (var db = new RescueRegisterDbContext())
            {
                var alltasks = db.Mountaineers.ToList();
                return View(alltasks);
            }
        }

        [HttpGet]
        public IActionResult Create()
        {
            return this.View();
        }

        [HttpPost]
        public IActionResult Create(Mountaineer mountaineer)
        {
            if (mountaineer==null)
            {
                return RedirectToAction("Index");
            }
            using (var db = new RescueRegisterDbContext())
            {
                db.Mountaineers.Add(mountaineer);
                db.SaveChanges();
            }
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            using (var db = new RescueRegisterDbContext())
            {
                var mountaineerToEdit = db.Mountaineers.FirstOrDefault(m => m.Id == id);
                if (mountaineerToEdit == null)
                {
                    return RedirectToAction("Index");
                }
                return this.View(mountaineerToEdit);
            }
        }

        [HttpPost]
        public IActionResult Edit(Mountaineer mountaineer)
        {
            if (!ModelState.IsValid)
            {
                return RedirectToAction("Index");
            }
            using (var db = new RescueRegisterDbContext())
            {
                var mountaineerToEdit = db.Mountaineers.FirstOrDefault(m => m.Id == mountaineer.Id);
                mountaineerToEdit.Name = mountaineer.Name;
                mountaineerToEdit.Age = mountaineer.Age;
                mountaineerToEdit.Gender = mountaineer.Gender;
                mountaineerToEdit.LastSeenDate = mountaineer.LastSeenDate;
                db.SaveChanges();
            }
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Delete(int id)
        {
            using (var db = new RescueRegisterDbContext())
            {
                var mountaineerDetails = db.Mountaineers.FirstOrDefault(t => t.Id == id);
                if (mountaineerDetails == null)
                {
                    return RedirectToAction("Index");
                }
                return this.View(mountaineerDetails);
            }
        }

        [HttpPost]
        public IActionResult Delete(Mountaineer mountaineer)
        {
            using (var db = new RescueRegisterDbContext())
            {
                var mountaineerToDelete = db.Mountaineers.FirstOrDefault(t => t.Id == mountaineer.Id);
                if (mountaineerToDelete == null)
                {
                    return RedirectToAction("Index");
                }
                db.Mountaineers.Remove(mountaineerToDelete);
                db.SaveChanges();
            }
            return RedirectToAction("Index");
        }
    }
}