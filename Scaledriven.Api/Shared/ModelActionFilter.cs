using Microsoft.AspNetCore.Mvc.Filters;
using Scaledriven.Api.Database;

namespace Scaledriven.Api.Shared
{
    public class ModelActionFilter : IActionFilter
    {

        public readonly ApplicationDbContext ApplicationDbContext;

        public ModelActionFilter(ApplicationDbContext applicationDbContext)
        {
            ApplicationDbContext = applicationDbContext;
        }

        public void OnActionExecuting(ActionExecutingContext context)
        {
            ApplicationDbContext.SaveChanges();
        }

        public void OnActionExecuted(ActionExecutedContext context)
        {

        }
    }
}
