using Microsoft.AspNetCore.Mvc;

namespace Bulkey_Web.Controllers
{
    public class CategoryController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
