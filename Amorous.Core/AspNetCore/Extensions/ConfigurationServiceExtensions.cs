using System.IO;
using Amorous.Core.DataAccess;
using Amorous.Core.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace Amorous.Core.AspNetCore.Extensions
{
    public static class ConfigurationServiceExtensions
    {
        /// <summary>
        /// Value of absolution directory containing the project's solution file "Amorous.sln"
        /// </summary>
        /// <example>
        /// <c>
        /// ConfigurationServiceExtensions.SolutionRoot //  /Users/JeffTheUser/RiderProjects/Amorous/
        /// JeffTheUser$ ls
        /// ...
        /// Amorous.sln
        /// Amorous.Core/
        /// Amorous.App/
        /// Amorous.Angular/
        /// ...
        /// </c>
        /// </example>
        public readonly static string SolutionRoot = Path.GetFullPath("./../");

        /// <summary>
        /// Path used by <see cref="AddAmourousConfiguration"/> SpaStaticFiles as wwwroot
        /// </summary>
        /// <summary>
        /// Contents of this directory Should be included within
        /// the build of the using web application
        /// </summary>
        public readonly static string AssetsPath = Path.Combine(SolutionRoot, "Amorous.Core", "wwwroot");

        public static IServiceCollection AddAmourousConfiguration<D, U>(this IServiceCollection serviceCollection)
            where D : AbstractApplicationContext<U>
            where U : ApplicationUser
        {
            serviceCollection.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_2);
            serviceCollection.AddOptions();
            serviceCollection.AddSpaStaticFiles(options =>
            {
                options.RootPath = AssetsPath;
            });
            serviceCollection.AddDbContext<D>();
            return serviceCollection;
        }
    }
}
