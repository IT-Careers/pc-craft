using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
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
