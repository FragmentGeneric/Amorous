using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Scaledriven.Areas.Association.Views.Shared.Components.User
{
    public class UserViewComponent : ViewComponent
    {
        [TempData] public string Name { get; set; } = "Main";

        public async Task<IViewComponentResult> InvokeAsync()
        {
            return View("Default",new Models.User());
        }
    }
}
