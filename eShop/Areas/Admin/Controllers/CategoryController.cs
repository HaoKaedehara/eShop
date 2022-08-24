using Microsoft.AspNetCore.Mvc;
using eShop.Database;

namespace eShop.Areas.Admin.Controllers
{
    public class CategoryController : BaseController
    {


        public CategoryController(AppDbContext db) : base(db)
        {
        }

        public IActionResult Index()
        {
            var data = _db.ProductCategories.OrderByDescending(c=>c.Id).ToList();
            return View(data);
        }
        public IActionResult Create()
        {
            return View();
        }
    }
}
