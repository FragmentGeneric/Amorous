using Amorous.App.Database;
using Microsoft.AspNetCore.Mvc;

namespace Amorous.App.Controllers
{
    [Route("api/[controller]")]
    public class DatabaseController : ControllerBase
    {
        private readonly ApplicationDbContext _dbContext;

        public DatabaseController(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return Ok(_dbContext.Database.EnsureCreatedAsync().Result);
        }
    }
}
