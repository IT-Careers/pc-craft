using Microsoft.AspNetCore.Mvc;

namespace PCC.Web.Controllers
{
    public class CraftController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
