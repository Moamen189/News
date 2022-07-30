using Microsoft.AspNetCore.Mvc;
using News.Models;
using NToastNotify;
using System.Linq;

namespace News.Areas.Admin.Controllers
{
    [Area("Admin")]

    public class CategoriesController : Controller
    {
        private readonly ApplicationDbContext _db;
        private readonly IToastNotification _toastNotification;

        public CategoriesController(ApplicationDbContext Db , IToastNotification ToastNotification)
        {
            _db = Db;
            _toastNotification = ToastNotification;
        }
        public IActionResult Index()
        {
            return View(_db.Catogeries.ToList());
        }

        [HttpGet]

        public IActionResult Create()
        {
            return View();
        }


        [HttpPost]
        [ValidateAntiForgeryToken]

        public IActionResult Create(Catogery catogery)
        {
            _db.Catogeries.Add(catogery);
            _toastNotification.AddSuccessToastMessage("Data Created Succeflly");

            _db.SaveChanges();
            return RedirectToAction("Index");
            //return View();
        }

        [HttpGet]

        public IActionResult Edit(int? id)
        {
            if(id == null)
            {
                return NotFound();
            }
            var Category = _db.Catogeries.Find(id);
            //_db.SaveChanges();
            //return RedirectToAction("Index");
            return View(Category);
        }


        [HttpPost]
        [ValidateAntiForgeryToken]

        public IActionResult Edit(Catogery catogery)
        {
            if (ModelState.IsValid)
            {
                _db.Catogeries.Update(catogery);
                 _db.SaveChanges();
                _toastNotification.AddSuccessToastMessage("Data Submitted Succeflly");

                //return View();
            }
            return RedirectToAction("Index");
        }


        [HttpGet]

        public IActionResult Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var Category = _db.Catogeries.Find(id);

            //_toastNotification.AddSuccessToastMessage("Data Submitted Succeflly");
            //_db.SaveChanges();
            //return RedirectToAction("Index");
            return View(Category);
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Delete(int id, Catogery catogery)
        {
            if (ModelState.IsValid)
            {
                var Category = _db.Catogeries.Find(id);
                _db.Catogeries.Remove(catogery);

                //_toastNotification.AddSuccessToastMessage("Data Submitted Succeflly");
                _db.SaveChanges();
                _toastNotification.AddSuccessToastMessage("Data Deleted Succeflly");

                //return View(Category);

            }
            return RedirectToAction("Index");

        }
    }
}
