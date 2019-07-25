using Amorous.App.Models;
using Amorous.Core.DataAccess;
using Microsoft.EntityFrameworkCore;

namespace Amorous.App.Database
{
    public class ApplicationDbContext : AbstractApplicationContext<User>
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {
        }
    }
}
