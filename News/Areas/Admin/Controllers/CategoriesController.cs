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

        public IActionResult Create(Catogery catogery)
        {
            _db.Catogeries.Add(catogery);
            _db.SaveChanges();
            return RedirectToAction("Index");
            //return View();
        }

        [HttpGet]

        public IActionResult Edit(int id)
        {
            var Category = _db.Catogeries.Find(id);
            _toastNotification.AddSuccessToastMessage("Data Submitted Succeflly");
            //_db.SaveChanges();
            //return RedirectToAction("Index");
            return View(Category);
        }


        [HttpPost]

        public IActionResult Edit(Catogery catogery)
        {
            _db.Catogeries.Update(catogery);
            _db.SaveChanges();
            return RedirectToAction("Index");
            //return View();
        }
    }
}
