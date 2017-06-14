using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AzureAppCI.Startup))]
namespace AzureAppCI
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
