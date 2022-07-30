using Microsoft.AspNetCore.Mvc;
using News.Models;
using System.Linq;

namespace News.Areas.Admin.Controllers
{
    public class CategoriesController : Controller
    {
        private readonly ApplicationDbContext _db;

        public CategoriesController(ApplicationDbContext Db)
        {
            _db = Db;
        }
        [Area("Admin")]
        public IActionResult Index()
        {
            return View(_db.Catogeries.ToList());
        }
    }
}
