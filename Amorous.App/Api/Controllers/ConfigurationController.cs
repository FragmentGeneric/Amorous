using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using Swashbuckle.AspNetCore.Swagger;

namespace Scaledriven.Api.Controllers
{

    [Route("api/[controller]")]
    public class ConfigurationController : ControllerBase
    {
        private readonly Info ApiDocumentInfo;

        public ConfigurationController(IOptions<Info> apiDocumentInfo)
        {
            ApiDocumentInfo = apiDocumentInfo.Value;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return Ok(ApiDocumentInfo);
        }
    }
}
