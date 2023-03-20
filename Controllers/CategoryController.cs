using Microsoft.AspNetCore.Mvc;
using MoBooksWeb.Data;
using MoBooksWeb.Models;

namespace MoBooksWeb.Controllers
{
    public class CategoryController : Controller
    {

        private readonly ApplicationDBContect _db;

        public CategoryController(ApplicationDBContect db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            IEnumerable<Category> objCategoryList = _db.categories.ToList();
            return View(objCategoryList);
        }
        //GET
        public IActionResult Create()
        {
            return View();  
        }
    }
}
