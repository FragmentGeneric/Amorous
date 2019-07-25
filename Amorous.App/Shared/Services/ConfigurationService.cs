using Microsoft.Extensions.Configuration;

namespace Scaledriven.Shared.Services
{
    public class ConfigurationService
    {
        public readonly IConfiguration Configuration;

        public string Message { get; } = "The Configuration of Docs";

        public ConfigurationService(IConfiguration configuration)
        {
            Configuration = configuration;
        }


    }
}
