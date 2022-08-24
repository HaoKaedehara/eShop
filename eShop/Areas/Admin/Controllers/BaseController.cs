using Microsoft.AspNetCore.Mvc;
using eShop.Database;

namespace eShop.Areas.Admin.Controllers
{
    public class BaseController : Controller
    {
        protected readonly AppDbContext _db;

        public BaseController(AppDbContext db)
        {
            _db = db;
        }

    }
}
