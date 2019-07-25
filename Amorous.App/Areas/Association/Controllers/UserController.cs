using Microsoft.AspNetCore.Mvc;
using Scaledriven.Areas.Association.Models;

namespace Scaledriven.Areas.Association.Controllers
{
    [Area("Association")]
    public class UserController : Controller
    {
        public IActionResult Info()
        {
            return View(new User());
        }
    }
}
