using Microsoft.Extensions.Configuration;

namespace Amorous.Core.Services
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
