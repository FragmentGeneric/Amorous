using System;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Scaledriven.Pages
{
    public class Index : PageModel
    {
        public IActionResult OnGet()
        {
            return StatusCode(303);
        }


        public override void OnPageHandlerExecuting(PageHandlerExecutingContext context)
        {
            base.OnPageHandlerExecuting(context);
            Console.WriteLine($@"

            {nameof(Index)} : PageModel
");
        }
    }
}
