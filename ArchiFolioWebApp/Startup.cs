using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ArchiFolioWebApp.Startup))]
namespace ArchiFolioWebApp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
