using Microsoft.AspNetCore.Mvc;

namespace WA.Areas.Manage.Controllers
{
    [Area("manage")]
    public class IndexController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
