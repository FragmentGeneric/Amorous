using System;
using Amorous.Core.DataAccess;
using Amorous.Core.Models;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.EntityFrameworkCore;

namespace Amorous.Core.AspNetCore.Application.Filers
{
    /// <summary>
    /// Saves the state of the right after dbcontext during action execution
    /// </summary>
    /// <example>
    /// public static IServiceCollection AddAmourousConfiguration(this IServiceCollection serviceCollection)
    /// {
    ///    serviceCollection.AddTransient<SaveChangesResultFilter<ApplicationUser, ApplicationDbContext<ApplicationUser>>>();
    ///    return serviceCollection;
    /// }
    /// </example>
    public class SaveChangesResultFilter<U, C> : IResultFilter
    where U : ApplicationUser
    where C : ApplicationDbContext<U>
    {
        private readonly ApplicationDbContext<U> _dbContext;

        public SaveChangesResultFilter(C dbContext)
        {
            _dbContext = dbContext;
        }

        public void OnResultExecuting(ResultExecutingContext context)
        {

        }

        public void OnResultExecuted(ResultExecutedContext context)
        {
            _dbContext.SaveChanges();
        }
    }
}
